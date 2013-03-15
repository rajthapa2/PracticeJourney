using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Practice.Web.Model
{
    [Serializable]
    public class ReferenceDataItem
    {
        [Required]
        [RegularExpression(Constants.ReferenceDataCodeFormat)]
        public string Code { get; set; }
        public string Description { get; set; }

        public ReferenceDataItem()
        {
            
        }
        public ReferenceDataItem(string code, string description)
        {
            Code = code;
            Description = description;
        }
    }
}
