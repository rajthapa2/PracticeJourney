using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Web.Model
{
    public class MaritalStatusGroup
    {
        public const  string SingleMaritalStatus = "Single";
        public const string MarriedMaritalStatus = "Married";
        public const string DivorcedMaritalStatus = "Divorced";

        public static readonly Dictionary<string,string> MaritalStatusMap= new Dictionary<string,string>{
        {"M",SingleMaritalStatus},
        {"S",MarriedMaritalStatus},
        {"D",DivorcedMaritalStatus}};

        public static Dictionary<string,string > GetDisplayMaritalTypes()
        {
            return MaritalStatusMap.ToDictionary(item => item.Key,item=> item.Value);
        }

        public static List<ReferenceDataItem> GetMaritalTypes()
        {
            return MaritalStatusMap.Select(x => new ReferenceDataItem(x.Key, x.Value)).ToList();
        }
    }
}
