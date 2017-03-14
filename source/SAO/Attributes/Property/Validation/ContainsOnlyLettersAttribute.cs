using System;
using System.Linq;

using SAO.Attributes.Base;

namespace SAO.Attributes.Property.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class ContainsOnlyLettersAttribute : SAOBasePropertyValidationAttribute
    {
        public ContainsOnlyLettersAttribute(string errorMessage) : base(errorMessage)
        {
        }

        public override void Validate(SAObject obj, object property)
        {
            if(property is string)
            {
                if(!property.ToString().All(char.IsLetter))
                {
                    obj.Invalidate(ErrorMessage);
                }
            }
        }
    }
}
