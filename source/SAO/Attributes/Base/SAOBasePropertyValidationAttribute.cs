using System;
using SAO.Attributes.Interfaces;

namespace SAO.Attributes.Base
{
    public abstract class SAOBasePropertyValidationAttribute : Attribute, ISAOPropertyValidator
    {
        protected string ErrorMessage { get; }

        protected SAOBasePropertyValidationAttribute(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        public abstract void Validate(SAObject obj, object property);
    }
}