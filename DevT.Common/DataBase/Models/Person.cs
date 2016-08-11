using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DataBase.Models
{
   public class Person
    {
        public Person( string name ):this() {
            Name = name;
        }
        public Person()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsArchived { get; set; }
        public string CountryOfBirth { get; set; }
        public int Age { get; set; }

        public DateTime? DateOfBirth { get; set; }
        [Index(IsUnique = true)]
        [StringLength(255)]
        public string UserName { get; set; }

        public byte[] Password { get; set; }
        public DateTime UpdatedAt { get; set; }

         
    }
}
