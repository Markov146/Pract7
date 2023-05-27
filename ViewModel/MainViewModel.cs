using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using WpfApp12.Model;

namespace WpfApp12.ViewModel
{
    internal class MainViewModel
    {
        private Car selected;

        public ObservableCollection<Car> Cars { get; set; }
        public Car Selected
        {
            get { return selected; }
            set
            {
                selected = value;
                OnPropertyChanged("SelectedCar");
            }
        }

        public MainViewModel()
        {
            Cars = new ObservableCollection<Car>
            {
                new Car { Model ="Audi A4", Company="Audi", Price=1600000 },
                new Car { Model="LADA Priora",Company="Lada" , Price=500000 },
                new Car { Model="Porshe 911", Company="Porshe", Price=5600000 },
                new Car { Model="Kia Stinger", Company="Kia", Price=1000000 },
                new Car { Model="BMW x5", Company="BMW", Price=3000000 },
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}




