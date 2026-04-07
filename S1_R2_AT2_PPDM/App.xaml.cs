using Microsoft.Extensions.DependencyInjection;

namespace S1_R2_AT2_PPDM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage = new NavigationPage(new MainPage());
            //navPage.BarBackground = Colors.Yellow;

            MainPage = navPage;
        }
    }
}