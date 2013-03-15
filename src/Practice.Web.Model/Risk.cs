using System.ComponentModel.DataAnnotations;

namespace Practice.Web.Model
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
