using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Models
{
    [Table("People")]
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int PersonId { get; set; }

        [MaxLength(255)]
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
