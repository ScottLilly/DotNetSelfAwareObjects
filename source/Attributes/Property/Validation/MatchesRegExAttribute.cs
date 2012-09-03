using System;
using System.Text.RegularExpressions;

using SAO.Attributes.Base;

namespace SAO.Attributes.Property.Validation
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = true)]
    public class MatchesRegExAttribute : SAOBasePropertyValidationAttribute
    {
        private string RegEx { get; set; }

        public MatchesRegExAttribute(string regEx, string errorMessage) : base(errorMessage)
        {
            RegEx = regEx;
        }

        public override void Validate(SAObject obj, object property)
        {
            if((property == null) || (!new Regex(RegEx).IsMatch(property.ToString())))
            {
                obj.Invalidate(ErrorMessage);
            }
        }
    }
}
