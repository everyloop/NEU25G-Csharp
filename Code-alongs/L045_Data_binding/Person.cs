using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace L045_Data_binding
{
    public class Person : INotifyPropertyChanged
    {
        private string _firstName;
        public string FirstName 
        { 
            get => _firstName; 
            set
            {
                _firstName = value;
                RaisePropertyChanged();
            }
        }

        private string _lastName;
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                RaisePropertyChanged();
            }
        }
        public int Age { get; set; }

        public ObservableCollection<Person> Children { get; set; } = new ObservableCollection<Person>();

        public event PropertyChangedEventHandler? PropertyChanged;

        private void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
