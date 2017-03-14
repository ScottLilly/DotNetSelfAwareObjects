using System;
using SAO.Attributes.Base;

namespace SAO.Attributes.Property.Validation
{
    public class WithinRangeAttribute : SAOBasePropertyValidationAttribute
    {
        private object MinimumValue { get; }
        private object MaximumValue { get; }

        public WithinRangeAttribute(object minimumValue, object maximumValue, string errorMessage) : base(errorMessage)
        {
            if(minimumValue.IsNumericType())
            {
                MinimumValue = minimumValue;
            }

            if(maximumValue.IsNumericType())
            {
                MaximumValue = maximumValue;
            }
        }

        public override void Validate(SAObject obj, object property)
        {
            if(property.IsNumericType())
            {
                if((Convert.ToDouble(property) < Convert.ToDouble(MinimumValue)) ||
                   (Convert.ToDouble(property) > Convert.ToDouble(MaximumValue)))
                {
                    obj.Invalidate(ErrorMessage);
                }
            }
        }
    }
}