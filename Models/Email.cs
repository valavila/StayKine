using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MillionMealsGoldLeaf.Models
{
    public class Email
    {
        [Key]
        public int id { get; set; }
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        public bool isSubscribed { get; set; }
    }
}
