using System;

using SAO.Attributes.Base;

namespace SAO.Attributes.Property.Validation
{
    public class MaximumValueAttribute : SAOBasePropertyValidationAttribute
    {
        private object MaximumValue { get; set; }

        public MaximumValueAttribute(object maximumValue, string errorMessage) : base(errorMessage)
        {
            if(maximumValue.IsNumericType())
            {
                MaximumValue = maximumValue;
            }
        }

        public override void Validate(SAObject obj, object property)
        {
            if(property.IsNumericType())
            {
                if(Convert.ToDouble(property) > Convert.ToDouble(MaximumValue))
                {
                    obj.Invalidate(ErrorMessage);
                }
            }
        }
    }
}
