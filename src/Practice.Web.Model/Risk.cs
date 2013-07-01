using System;
using System.ComponentModel.DataAnnotations;

namespace Practice.Web.Model
{
    public class Risk
    {
        public Risk()
        {            
        }

        public Risk(PersonDetails personDetails)
        {
            PersonDetails = personDetails;
            
        }

        [Required, ValidateObject]
        public PersonDetails PersonDetails { get; set; }
        [Required, ValidateObject]
        public PolicyDetails PolicyDetails { get; set; } 
    }
}
