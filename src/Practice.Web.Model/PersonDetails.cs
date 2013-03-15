using System;
using System.ComponentModel.DataAnnotations;

namespace Practice.Web.Model
{
    [Serializable]
    public class PersonDetails
    {
        public const string FirstNameRegex = @"^([a-z A-Z]|-|\u0027){2,15}$";
        public const string LastNameRegex = @"^([a-z A-Z]|-|\u0027){2,20}$";


        [Required]
        [RegularExpression(Constants.ReferenceDataCodeFormat)]
        public string TitleCode { get; set; }
        
        [Required]
        [RegularExpression(FirstNameRegex)]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string DateOfBirth { get; set; }  

    }
}
