using PCLStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Data
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PCLStorage : ContentPage
    {
        public PCLStorage()
        {
            InitializeComponent();

            ReadFile();
            WriteFile();
        }

        private async Task<bool> ReadFile()
        {
            IFolder root = FileSystem.Current.LocalStorage;

            if ((await root.CheckExistsAsync("MySubFolder")) == ExistenceCheckResult.FolderExists)
            {
                var folder = await root.GetFolderAsync("MySubFolder");
                var file = await folder.GetFileAsync("answer.txt");
                var fileContent = await file.ReadAllTextAsync();


                content.Text = fileContent;

                return true;
            }
            return false;
        }

        private async void WriteFile()
        {
            IFolder rootFolder = FileSystem.Current.LocalStorage;
            IFolder folder = await rootFolder.CreateFolderAsync("MySubFolder", CreationCollisionOption.OpenIfExists);
            IFile file = await folder.CreateFileAsync("answer.txt", CreationCollisionOption.ReplaceExisting);
            await file.WriteAllTextAsync("42");
        }
    }
}