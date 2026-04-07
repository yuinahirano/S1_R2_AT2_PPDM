//using Android.Service.Voice;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using S1_R2_AT2_PPDM.src.MVVM.Models;

namespace S1_R2_AT2_PPDM.src.MVVM.ViewModels
{
    public class ProdutoViewModel
    {
        //propriedade publica para fazer a vinculação com a view
        //permite criar as alterações na coleção e sejam automaticamente comunicadas a interface grafica, atualizando a exibição dos elementos na tela
        public ObservableCollection<Produto> Produtos { get; set; }
        public ProdutoViewModel()
        {
            CriarProdutos();
        }

        //gerar os produtos que vou mostrar na collectview
        private void CriarProdutos()
        {
            Produtos = new ObservableCollection<Produto>
            {
                new Produto
                {
                    Nome = "Garrafa Térmica Inox Stamina 1L - Matte Black",
                    Preco = 149.90m,
                    PrecoPix = 134.91m,
                    Imagem = "garrafa.png"
                },
                new Produto
                {
                    Nome = "Camiseta Stamina Pro Compression Underlayer",
                    Preco = 119.00m,
                    PrecoPix = 107.10m,
                    Imagem = "camisa.png"
                },
                new Produto
                {
                    Nome = "Jaqueta Corta-Vento Stamina Endurance Impermeável",
                    Preco = 249.90m,
                    PrecoPix = 224.91m,
                    Imagem = "cortavento.png"
                },
                new Produto
                {
                    Nome = "Luvas de Musculação Stamina Grip Neoprene",
                    Preco = 59.90m,
                    PrecoPix = 53.91m,
                    Imagem = "luva.png"
                },
                new Produto
                {
                    Nome = "Bolsa Esportiva Stamina Tactical Duffle Bag",
                    Preco = 199.90m,
                    PrecoPix = 179.91m,
                    Imagem = "bolsa.png"
                },
            };
        }
    }
}
