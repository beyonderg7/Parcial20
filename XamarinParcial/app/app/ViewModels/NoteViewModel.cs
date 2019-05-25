using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace app.ViewModels
{
    public class NoteViewModel:BaseViewModel
    {

        #region variables
        string nota;

        #endregion



        #region propiedades

        public string Nota
        {

            get
            {

                return this.nota;

            }
            set
            {

                SetValue(ref this.nota, value);
            }
        }


        #endregion


        #region comandos
        public ICommand NotaCommand
        {

            get
            {

                return new RelayCommand(Notas);
            }

        }

        private async void Notas()

        {
            if (String.IsNullOrEmpty(Nota))
            {

                await App.Current.MainPage.DisplayAlert("Email empty", "Ponga email", "Accept");

                return;

            }
            throw new NotImplementedException();
        }

        #endregion
    }


}
