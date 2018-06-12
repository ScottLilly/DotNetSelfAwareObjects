using System;
using SAO.Attributes.Base;

namespace SAO.Attributes.Property.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class CannotBeNullAttribute : SAOBasePropertyValidationAttribute
    {
        public CannotBeNullAttribute(string errorMessage) : base(errorMessage)
        {
        }

        public override void Validate(SAObject obj, object property)
        {
            if(property == null)
            {
                obj.Invalidate(ErrorMessage);
            }
        }
    }
}