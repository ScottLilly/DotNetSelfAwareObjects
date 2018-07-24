using System;
using SAO.Attributes.Base;

namespace SAO.Attributes.Property.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public class RequiredWhenOtherPropertyIsTrue : SAOBasePropertyValidationAttribute
    {
        private readonly string _propertyName;

        public RequiredWhenOtherPropertyIsTrue(string propertyName, string errorMessage) : base(errorMessage)
        {
            _propertyName = propertyName;
        }

        public override void Validate(SAObject obj, object property)
        {
            object otherProperty = obj.GetType().GetProperty(_propertyName)?.GetValue(obj, null);

            if(otherProperty is bool b)
            {
                if(b)
                {
                    if(property == null || string.IsNullOrWhiteSpace(property.ToString()))
                    {
                        obj.Invalidate(ErrorMessage);
                    }
                }
            }
        }
    }
}