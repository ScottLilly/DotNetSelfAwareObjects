using System;
using SAO.Attributes.Base;

namespace SAO.Attributes.Property.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class MustBeValidDate : SAOBasePropertyValidationAttribute
    {
        public MustBeValidDate(string errorMessage) : base(errorMessage)
        {
        }

        public override void Validate(SAObject obj, object property)
        {
            if(!(property is DateTime))
            {
                obj.Invalidate(ErrorMessage);
            }
        }
    }
}