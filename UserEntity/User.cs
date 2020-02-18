using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserEntity
{
    public enum CountryEnum
    {
        India = 1,
        US,
        Australia,
    }
    public class User
    {
        [Required(ErrorMessage ="Please eneter the name")]
        public string name { get; set; }
        [Required(ErrorMessage = "Please enetr the username")]
        public string userName { get; set; }
        [Required(ErrorMessage = "Please enetr the email")]
        public string email { get; set; }
        [Required(ErrorMessage ="Please Enter the Country")]
        public int countryID { get; set; }
        public CountryEnum country { get; set; }
       
    }
}

