using LibGit2Sharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPOC
{
    class DirtyTest
    {
        public static void Run()
        {
            GetHistory(@"C:\Users\Administrator\Desktop\BVSE_Test", "MonFichier.txt");
            GetBlame(@"C:\Users\Administrator\Desktop\BVSE_Test", "MonFichier.txt");
        }

        static void GetBlame(string pathRepo, string pathFile)
        {
            using (var repo = new Repository(pathRepo))
            {
                var blameOptions = new BlameOptions()
                {
                    Strategy = BlameStrategy.Default, // Classical Blame (the only one usable in libgit2 for the moment)
                    StartingAt = null, // HEAD
                    StoppingAt = null, // Initial Commit
                    MinLine = 0, // First Line of the file
                    MaxLine = 0 // Last line of the file
                };

                var blameHunkCollection = repo.Blame(pathFile);

                Console.WriteLine("Number of blameHunks : " + blameHunkCollection.Count());

                var logEntries = repo.Commits.QueryBy(pathFile);
                var blob = logEntries.First().Commit.Tree[pathFile].Target as Blob;
                var text = blob.GetContentText();

                using (var stringReader = new StringReader(text))
                {
                    foreach (var blameHunk in blameHunkCollection)
                    {

                        for (int i = 0; i < blameHunk.LineCount; i++)
                        {
                            var line = stringReader.ReadLine();
                            Console.WriteLine("Line {0} | Commit {1} : {2} | {3}", blameHunk.FinalStartLineNumber + i, blameHunk.FinalCommit.Id.ToString(4), blameHunk.FinalSignature.When, line);
                        }
                    }
                }
            }
        }

        static void GetHistory(string pathRepo, string pathFile)
        {
            using (var repo = new Repository(pathRepo))
            {
                var logEntries = repo.Commits.QueryBy(pathFile);

                foreach (var log in logEntries)
                {
                    Console.WriteLine("File {0} / Commit {1} : {2}", log.Path, log.Commit.Id.ToString(4), log.Commit.Author.When);
                }
            }
        }
    }
}
