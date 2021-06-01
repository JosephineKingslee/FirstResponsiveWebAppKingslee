using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppKingslee.Models
{
    public class FirstResponsiveWebApp
    {
        [Required(ErrorMessage = "Please enter User's name.")]
        //[RegularExpression("[a-zA-Z]+")]
        public string Name { get; set; }
        public DateTime BirthYear { get; set; }
        public DateTime BirthYearEnd = Convert.ToDateTime("12/31/2021");
        public DateTime todayDate = DateTime.Today;
        public int AgeThisYear()
        {
            int age = todayDate.Year - BirthYear.Year;

            if (BirthYear > todayDate.AddYears(-age))
            {
                age--;
            }
            return age;
        }
        public int AgeThisYearEnd()
        {
            int ageEnd = BirthYearEnd.Year - BirthYear.Year;
            if (BirthYear > BirthYearEnd.AddYears(-ageEnd))
            {
                ageEnd--;
            }
            return ageEnd;
        }
    }
}
