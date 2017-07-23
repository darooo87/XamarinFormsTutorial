using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Models
{
    public class ContactGroup : List<Contact>
    {
        public string Title { get; set; }

        public string ShortTitle { get; set; }

        public ContactGroup(string title, string shortTitle, List<Contact> contacts)
        {
            Title = title;
            ShortTitle = ShortTitle;
            base.AddRange(contacts);
        }
    }
}
