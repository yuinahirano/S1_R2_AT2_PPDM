using S1_R2_AT2_PPDM.src.MVVM.Models;
using S1_R2_AT2_PPDM.src.MVVM.ViewModels;
using System.Threading.Tasks;

namespace S1_R2_AT2_PPDM;

public partial class Produtos : ContentPage
{
	public Produtos()
	{
		InitializeComponent();
		//vinculação view com viewmodel
		BindingContext = new ProdutoViewModel();
	}

    
    private async void AdicionarCarrinho(object sender, EventArgs e)
    {
        var botao = (Button)sender;
        var produto = (Produto)botao.CommandParameter;

        if (produto.Quantidade > 0)
        {
            await DisplayAlertAsync("Sucesso", $"{produto.Quantidade}x {produto.Nome} adicionado ao carrinho!", "OK");
        }
        else
        {
            await DisplayAlertAsync("Atenção", "Selecione uma quantidade antes de adicionar!", "OK");
        }
    }

    private void DiminuirQtd(object sender, EventArgs e)
    {
        var botao = (Button)sender;
        var produto = (Produto)botao.CommandParameter;

        if (produto.Quantidade > 0)
            produto.Quantidade--;
    }

    private void AdicionarQtd(object sender, EventArgs e)
    {
        var botao = (Button)sender;
        var produto = (Produto)botao.CommandParameter;

        produto.Quantidade++;
    }
}