using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW0708
{
    public class Person : INotifyPropertyChanged
    {
        private string name;
        private int age;
        private bool smoker;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
                OnPropertyChanged("Name");
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
                OnPropertyChanged("Age");
            }
        }
        public bool Smoker
        {
            get
            {
                return this.smoker;
            }
            set
            {
                this.smoker = value;
                OnPropertyChanged("Smoker");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public override string ToString()
        {
            return $"Person {Name} {Age} Smoking? (bad for you) {Smoker}";
        }
    }


}
