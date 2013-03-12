using System.ComponentModel.DataAnnotations;

namespace PracticeJ.Web.Model
{
    public class Risk
    {
        public Risk()
        {            
        }
        [Required, ValidateObject]
        public PersonDetails PersonDetails { get; set; }

    }
}
