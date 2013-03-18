using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice.Web.Model
{
    public class TitleGender
    {
        public const string MrTitleCode = "MR";
        public const string MrsTitleCode = "MRS";


        public string Gender { get; set; }
        public string Description { get; set; }
        public string DisplayTitle { get; set; }

        private static readonly Dictionary<string, TitleGender> TitleGenderMap = new Dictionary<string, TitleGender>
                                                                                     {
                                                                                         {MrTitleCode, new TitleGender("M", "Mr","Mr")},
                                                                                         {MrsTitleCode, new TitleGender("F","Mrs","Mrs")},
                                                                                         {"MS",new TitleGender("F","Ms","Ms")}
                                                                                    };
        public TitleGender(string gender, string description, string displayTitle)
        {
            Gender = gender;
            Description = description;
            DisplayTitle = displayTitle;
        }

        public static IList<ReferenceDataItem> GetTitleTypes()
        {
            return TitleGenderMap.Select(x => new ReferenceDataItem(x.Key, x.Value.Description)).ToList();
        }

        public static Dictionary<string, string> GetDisplayTitles()
        {
            return TitleGenderMap.ToDictionary(item => item.Key, item => item.Value.DisplayTitle);
        }
    }
}
