using System;
using System.ComponentModel.DataAnnotations;

namespace Practice.Web.Model
{
    public class Risk
    {
        public Guid RiskId { get; set; }
        [Required, ValidateObject]
        public PersonDetails PersonDetails { get; set; }
        [Required, ValidateObject]
        public PolicyDetails PolicyDetails { get; set; } 

        public Risk(Guid riskId)
        {
            RiskId = riskId;
        }
        public Risk(PersonDetails personDetails)
        {
            PersonDetails = personDetails;    
        }
    }
}
