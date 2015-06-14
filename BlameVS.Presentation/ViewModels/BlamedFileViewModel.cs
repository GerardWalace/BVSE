using BlameVS.Presentation.IViewModels;
using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlameVS.Presentation.ViewModels
{
    public class BlamedFileViewModel : IBlamedFileViewModel
    {
        public BlamedFileViewModel(IRepository repository, string filePath)
            : this(repository, filePath, "HEAD") 
        {

        }

        public BlamedFileViewModel(IRepository repository, string filePath, string startingCommitSha)
        {
            var blameOptions = new BlameOptions()
            {
                Strategy = BlameStrategy.Default, // Classical Blame (the only one usable in libgit2 for the moment)
                StartingAt = startingCommitSha, // Latest commit to take into account
                StoppingAt = null, // First Commit
                MinLine = 0, // First Line of the file
                MaxLine = 0 // Last line of the file
            };

            // On effectue le Blame
            var blameHunkCollection = repository.Blame(filePath, blameOptions); // TODO : Alerte Optimisation 

            // Le Blame venant sans le texte, on recupère le text du dernier commit
            var logEntries = repository.Commits.QueryBy(filePath);

            LogEntry logEntry = null;
            if (startingCommitSha != "HEAD")
                logEntry = logEntries.First(l => l.Commit.Id.Sha == startingCommitSha);
            else
                logEntry = logEntries.First();

            var blob = logEntry.Commit.Tree[logEntry.Path].Target as Blob;
            var text = blob.GetContentText();

            // On crée ensuite les BlamedLineViewModel
            var linesViewModel = new List<IBlamedLineViewModel>();
            using (var stringReader = new StringReader(text))
            {
                foreach (var blameHunk in blameHunkCollection)
                {
                    for (int i = 0; i < blameHunk.LineCount; i++)
                    {
                        var textLine = stringReader.ReadLine();
                        linesViewModel.Add(new BlamedLineViewModel(repository, textLine, blameHunk.FinalStartLineNumber + i, blameHunk.FinalCommit.Id.Sha));
                    }
                }
            }

            // TODO : Optimiser le code ci-dessous (et donc en amont aussi)
            // On met à jour nos trois propriétés
            this.Lines = linesViewModel;
            this.CommitShown = new CommitViewModel(repository, startingCommitSha);
            this.CommitsHistory = logEntries.Select(l => new CommitViewModel(repository, l.Commit.Sha)).ToList<ICommitViewModel>(); // TODO : Alerte Optimisation
        }

        public IList<IBlamedLineViewModel> Lines { get; protected set; }

        public ICommitViewModel CommitShown { get; protected set; }

        public IList<ICommitViewModel> CommitsHistory { get; protected set; }
    }
}
