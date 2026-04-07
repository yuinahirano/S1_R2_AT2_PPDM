using S1_R2_AT2_PPDM.src;

namespace S1_R2_AT2_PPDM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Produtos(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Produtos());
        }

        private async void Button_Contatos(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Contato());
        }
    }
}
