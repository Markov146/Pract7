using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using WpfApp12.Model;

namespace WpfApp12.ViewModel
{
    internal class CarViewModel
    {
        private Car car;

        public CarViewModel(Car p)
        {
            car = p;
        }

        public string Title
        {
            get { return car.Model; }
            set
            {
                car.Model = value;
                OnPropertyChanged("Title");
            }
        }
        public string Company
        {
            get { return car.Company; }
            set
            {
                car.Company = value;
                OnPropertyChanged("Company");
            }
        }
        public int Price
        {
            get { return car.Price; }
            set
            {
                car.Price = value;
                OnPropertyChanged("Price");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
