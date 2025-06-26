
namespace ExamenMvvm
{
    public partial class App : Application
    {
        [Obsolete]
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Views.MainPage());
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}