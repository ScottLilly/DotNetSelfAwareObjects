using System;

using SAO.Attributes.Base;

namespace SAO.Attributes.Property.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class MaximumLengthAttribute : SAOBasePropertyValidationAttribute
    {
        private int MaximumLength { get; }

        public MaximumLengthAttribute(int maximumLength, string errorMessage) : base(errorMessage)
        {
            MaximumLength = maximumLength;
        }

        public override void Validate(SAObject obj, object property)
        {
            if(property is string)
            {
                if(property.ToString().Length > MaximumLength)
                {
                    obj.Invalidate(ErrorMessage);
                }
            }
        }
    }
}
