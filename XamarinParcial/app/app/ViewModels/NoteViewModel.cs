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
        bool isrunning;

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

        public bool IsRunning
        {

            get { return this.isrunning; }
            set { SetValue(ref this.isrunning, value); }
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

                await App.Current.MainPage.DisplayAlert("Nota vacia", "Escriba una nota", "Aceptar");

                return;

            }
            throw new NotImplementedException();
        }

        #endregion
    }


}
