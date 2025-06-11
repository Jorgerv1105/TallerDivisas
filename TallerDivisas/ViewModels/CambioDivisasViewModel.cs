using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TallerDivisas.ViewModels
{
    class CambioDivisasViewModel : INotifyPropertyChage
    {
        private string _valorUSD;
        private string _valorEUR;

        public string ValorUSD 
        { get => _valorUSD;
            set
            {
                if (_valorUSD != value)
                {
                    _valorUSD = value;
                    OnPropertyChanged();
                }
            } 
        }
        public void CambiarDeDolaresAEuros()
        {
            double euros =Double.Parse(ValorUSD) * 0.85;
            _valorEUR=euros.ToString();
        }
        public void CambiarDeEurosADolares()
        {
            double euros = Double.Parse(ValorUSD) * 1.15;
            _valorEUR = euros.ToString();
        }
        public string ValorEUR
        {
            get => _valorEUR;
            set
            {
                if (_valorUSD != value)
                {
                    _valorUSD = value;
                    OnPropertyChanged();
                    CambiarDeDolaresAEuros();
                }
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
