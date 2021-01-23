using System;
using System.Text.RegularExpressions;

namespace HyHeroesWebAPI.Presentation.Utils
{
    public class FormatterUtil
    {
        public string StripHTMLTags(string input) =>
            string.IsNullOrEmpty(input) ? string.Empty : Regex.Replace(input, "<.*?>", String.Empty);
    }
}
