using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetailSample
{
    class MainViewModel
    {
        public ObservableCollection<Person> Persons
        {
            get;
            set;
        }

        public Person SelectedPerson { get; set; }
    }
}
