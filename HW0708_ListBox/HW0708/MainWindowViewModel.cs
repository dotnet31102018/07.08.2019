using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace HW0708
{
    public class MainWindowViewModel 
    {
        public ICommand AddPersonCommand { get; set; }
        public ObservableCollection<Person> People { get; set; }
        public Person NewPerson { get; set; }
        public MainWindowViewModel()
        {
            NewPerson = new Person();
            People = new ObservableCollection<Person>()
            {
                new Person { Age = 12, Name = "Danny", Smoker = false},
                new Person { Age = 28, Name = "Moshe", Smoker = true},
                new Person { Age = 25, Name = "Suzi", Smoker = false},
                new Person { Age = 50, Name = "Safta", Smoker = true}
            };
            AddPersonCommand = new DelegateCommand(
                () => {
                    People.Add(NewPerson);
                }
                );
        }

    }
}
