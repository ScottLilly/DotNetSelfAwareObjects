using System;

using SAO.Attributes.Base;

namespace SAO.Attributes.Property.Validation
{
    public class MinimumValueAttribute : SAOBasePropertyValidationAttribute
    {
        private object MinimumValue { get; set; }

        public MinimumValueAttribute(object minimumValue, string errorMessage) : base(errorMessage)
        {
            if(minimumValue.IsNumericType())
            {
                MinimumValue = minimumValue;
            }
        }

        public override void Validate(SAObject obj, object property)
        {
            if(property.IsNumericType())
            {
                if(Convert.ToDouble(property) < Convert.ToDouble(MinimumValue))
                {
                    obj.Invalidate(ErrorMessage);
                }
            }
        }
    }
}
