using QuickPOC.ILoader;
using QuickPOC.IModels;
using QuickPOC.IViewModels;
using QuickPOC.Loader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickPOC.ViewModels
{
    class CommitViewModel : ICommitViewModel
    {
        private Loader<ICommitModel> commitLoader;
        private ISignatureViewModel author;
        private string commitSha;

        public CommitViewModel(string commitSha)
        {
            this.commitSha = commitSha;
            this.commitLoader = new Loader<ICommitModel>();
            this.commitLoader.LoadingStatus = EnumLoadingStatus.Loading;
            // TODO : On s'abonne au changement de LoadingStatus pour les différentes propriétés

            // TODO : Await le lancement de la commande git
            // TODO : On met à jour le commitLoader
            // TODO : On met à jour le LoadingStatus

            // Maintenant que le Commit est bien chargé, on peut créer le viewModel Signature associé
            this.Author = new SignatureViewModel(this.commitLoader.Item.Author);
        }

        public bool IsLoading
        {
            get
            {
                return this.commitLoader.LoadingStatus == EnumLoadingStatus.Loading;
            }
        }

        public bool IsError
        {
            get
            {
                return this.commitLoader.LoadingStatus == EnumLoadingStatus.Error;
            }
        }

        public bool IsLoaded
        {
            get
            {
                return this.commitLoader.LoadingStatus == EnumLoadingStatus.Loaded;
            }
        }

        public string Sha
        {
            get
            {
                if (this.IsLoaded)
                    return this.commitLoader.Item.Sha;
                else
                    return this.commitSha;
            }
        }

        public string Message
        {
            get
            {
                if (this.IsLoaded)
                    return this.commitLoader.Item.Message;
                else
                    return null;
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
