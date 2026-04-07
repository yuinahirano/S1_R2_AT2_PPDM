using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace S1_R2_AT2_PPDM.src.MVVM.Models
{
    public class Produto : INotifyPropertyChanged
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public decimal PrecoPix { get; set; }
        public string Imagem { get; set; }

        private int _quantidade = 0;
        public int Quantidade
        {
            get => _quantidade;
            set
            {
                _quantidade = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Quantidade)));
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
