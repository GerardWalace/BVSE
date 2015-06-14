using LibGit2Sharp;
using QuickPOC.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPOC
{
    class Program
    {
        public const string PATH_REPO = @"C:\Users\Administrator\Desktop\Bootstrap";

        static void Main(string[] args)
        {            
            // Test du ViewModel
            var viewModel = new BlamedFileViewModel(@"docs\assets\js\customize.min.js");

            foreach (var line in viewModel.Lines)
                Console.WriteLine("{0} | {1} | {2} : {3}"
                    , line.Commit.Author.When
                    , line.Commit.Sha
                    , line.LineNumber
                    , line.Text);
        }
    }
}
