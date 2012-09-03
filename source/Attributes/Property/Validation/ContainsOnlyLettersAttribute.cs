using System;
using System.Linq;

using SAO.Attributes.Base;

namespace SAO.Attributes.Property.Validation
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = true)]
    public class ContainsOnlyLettersAttribute : SAOBasePropertyValidationAttribute
    {
        public ContainsOnlyLettersAttribute(string errorMessage) : base(errorMessage)
        {
        }

        public override void Validate(SAObject obj, object property)
        {
            if(property is String)
            {
                if(!property.ToString().All(Char.IsLetter))
                {
                    obj.Invalidate(ErrorMessage);
                }
            }
        }
    }
}
