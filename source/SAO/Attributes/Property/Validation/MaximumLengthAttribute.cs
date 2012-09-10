using System;

using SAO.Attributes.Base;

namespace SAO.Attributes.Property.Validation
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = true)]
    public class MaximumLengthAttribute : SAOBasePropertyValidationAttribute
    {
        private int MaximumLength { get; set; }

        public MaximumLengthAttribute(int maximumLength, string errorMessage) : base(errorMessage)
        {
            MaximumLength = maximumLength;
        }

        public override void Validate(SAObject obj, object property)
        {
            if(property is String)
            {
                if(property.ToString().Length > MaximumLength)
                {
                    obj.Invalidate(ErrorMessage);
                }
            }
        }
    }
}
