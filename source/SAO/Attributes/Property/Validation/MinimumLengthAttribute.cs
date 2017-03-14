using System;

using SAO.Attributes.Base;

namespace SAO.Attributes.Property.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class MinimumLengthAttribute : SAOBasePropertyValidationAttribute
    {
        private int MinimumLength { get; }

        public MinimumLengthAttribute(int minimumLength, string errorMessage) : base(errorMessage)
        {
            MinimumLength = minimumLength;
        }

        public override void Validate(SAObject obj, object property)
        {
            if(property == null && (MinimumLength > 0) || (property.ToString().Length < MinimumLength))
            {
                obj.Invalidate(ErrorMessage);
            }
        }
    }
}
