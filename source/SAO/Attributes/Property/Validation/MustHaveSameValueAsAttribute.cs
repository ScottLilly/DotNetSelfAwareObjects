using System;
using SAO.Attributes.Base;

namespace SAO.Attributes.Property.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public class MustHaveSameValueAsAttribute : SAOBasePropertyValidationAttribute
    {
        private readonly string _propertyName;

        public MustHaveSameValueAsAttribute(string propertyName, string errorMessage) : base(errorMessage)
        {
            _propertyName = propertyName;
        }

        public override void Validate(SAObject obj, object property)
        {
            object otherProperty = obj.GetType().GetProperty(_propertyName).GetValue(obj, null);

            if(property == null)
            {
                obj.Invalidate(ErrorMessage);
            }
            else if(property.ToString() != otherProperty.ToString())
            {
                obj.Invalidate(ErrorMessage);
            }
        }
    }
}