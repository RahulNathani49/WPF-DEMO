using PassportWPF.Models;
using PassportWPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.ViewModels;

namespace PassportWPF.ViewModels
{
    internal class PassportsViewModel
    {
        public ObservableCollection<Passport> Passports{ get; }
        public DelegateCommand AddCommand { get; }
        public PassportsViewModel() 
        {
            Passports = new ObservableCollection<Passport>();

            Passports.Add(new Passport("Rahul", "Nathani", new DateTime(1999, 06, 21), "Canada"));
            Passports.Add(new Passport("Het", "Patel", new DateTime(2001,07, 11), "Brazil"));
            Passports.Add(new Passport("Jonathan", "Scott", new DateTime(2002, 2, 23), "USA"));
            AddCommand = new DelegateCommand(Add);
        }

   

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Country { get; set; }



        private void Add(Object parameter)
        {
            Trace.WriteLine("hello");

        }


    }

 
}
