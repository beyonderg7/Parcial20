namespace app.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public string Token { get; set; }
        public string TokenType { get; set; }
        #endregion

        #region ViewModels
        public NoteViewModel Login { get; }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            this.Login = new NoteViewModel();
        }
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }
        #endregion

    }
}
