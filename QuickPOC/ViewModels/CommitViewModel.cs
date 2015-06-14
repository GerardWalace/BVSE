using LibGit2Sharp;
using QuickPOC.IModels;
using QuickPOC.IViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPOC.ViewModels
{
    class CommitViewModel : ICommitViewModel
    {
        private ICommitModel commitModel;
        private ISignatureViewModel author;

        public CommitViewModel(string commitSha)
        {
            // Lancement de la commande git
            using (var repo = new Repository(Program.PATH_REPO))
            {
                var commit = repo.Lookup<Commit>(commitSha);
                if (commit != null)
                {
                    this.commitModel = new CommitModel()
                    {
                        Sha = commit.Sha,
                        Message = commit.Message,
                        Author = new SignatureModel()
                        {
                            Email = commit.Author.Email,
                            Name = commit.Author.Name,
                            When = commit.Author.When,
                        },
                    };
                }
                // TODO : else Log, mem si ce n'est pas sensé arriver
            }

            // Maintenant que le Commit est bien chargé, on peut créer le viewModel Signature associé
            this.Author = new SignatureViewModel(this.commitModel.Author);
        }

        public string Sha
        {
            get
            {
                return this.commitModel.Sha;
            }
        }

        public string Message
        {
            get
            {
                return this.commitModel.Message;
            }
        }

        public ISignatureViewModel Author
        {
            get
            {
                return this.author;
            }
            protected set
            {
                if (this.author != value)
                {
                    this.author = value;
                    // TODO : Notify Property Change
                }
            }
        }
    }
}
