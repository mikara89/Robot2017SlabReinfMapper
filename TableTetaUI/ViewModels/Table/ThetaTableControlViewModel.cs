using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TableTetaUI.Models;

namespace TableTetaUI.ViewModels.Table
{
    public class ThetaTableControlViewModel:BindingList<TableTetaModel>
    {
        public ICommand RemoveCommand =>
         new ActionCommand(async p => await RemoveAsync(p));

        private async Task RemoveAsync(object p)
        {
            var storey = this.ToList().Find(x => x.Id == (p as TableTetaModel).Id);
            MessageBoxResult result = MessageBox.Show($"Are you sure that you want to remove {storey.StoreyName}?", "Removing storey", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    this.Remove(storey);
                    break;
                case MessageBoxResult.No:
                    break;
            }

        }
    }
}
