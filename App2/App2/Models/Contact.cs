using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App2.Models
{
    public class Contact
    {

        public string Name { get; set; }

        public string Status { get; set; }

        public string ImageUrl { get; set; }


        public static ObservableCollection<Contact> Contacts
        {
            get
            {
                return new ObservableCollection<Models.Contact>
                {
                    new Models.Contact{ Name = "Darek", ImageUrl = "http://lorempixel.com/100/100/people/1", Status = "test1"},
                    new Models.Contact{ Name = "Dan", ImageUrl = "http://lorempixel.com/100/100/people/3", Status = "test5"},
                    new Models.Contact{ Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "test2"},
                    new Models.Contact{ Name = "Jack", ImageUrl = "http://lorempixel.com/100/100/people/4", Status = "test6"},
                    new Models.Contact{ Name = "Jeremy", ImageUrl = "http://lorempixel.com/100/100/people/4", Status = "test6"}
                };
            }
        }
    }
}
