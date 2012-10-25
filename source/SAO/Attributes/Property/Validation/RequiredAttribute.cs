using System;

namespace SAO.Attributes.Property.Validation
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = true)]
    public class RequiredAttribute : CannotBeNullAttribute
    {
        public RequiredAttribute(string errorMessage) : base(errorMessage)
        {
        }
    }
}
