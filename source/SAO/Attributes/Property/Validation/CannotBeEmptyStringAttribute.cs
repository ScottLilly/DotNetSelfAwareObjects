using System;

using SAO.Attributes.Base;

namespace SAO.Attributes.Property.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CannotBeEmptyStringAttribute : SAOBasePropertyValidationAttribute
    {
        public CannotBeEmptyStringAttribute(string errorMessage) : base(errorMessage)
        {
        }

        public override void Validate(SAObject obj, object property)
        {
            if(string.IsNullOrWhiteSpace(property as string))
            {
                obj.Invalidate(ErrorMessage);
            }
        }
    }
}
