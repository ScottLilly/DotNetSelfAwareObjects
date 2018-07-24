using System;
using SAO.Attributes.Base;

namespace SAO.Attributes.Property.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public class IntMustBeGreaterThanZero : SAOBasePropertyValidationAttribute
    {
        public IntMustBeGreaterThanZero(string errorMessage) : base(errorMessage)
        {
        }

        public override void Validate(SAObject obj, object property)
        {
            if(!(property is int val) || val <= 0)
            {
                obj.Invalidate(ErrorMessage);
            }
        }
    }
}