using System.Collections.Generic;
using System.Xml.Serialization;

namespace SAO
{
    public abstract class SAObject
    {
        [XmlIgnore]
        public bool IsValid { get; private set; }

        [XmlIgnore]
        public List<string> ValidationErrors { get; }

        protected SAObject()
        {
            ValidationErrors = new List<string>();

            SAOInitializer.Initialize(this);
        }

        public void Validate()
        {
            IsValid = true;
            ValidationErrors.Clear();

            SAOValidator.Validate(this);
        }

        internal void Invalidate(string errorMessage)
        {
            IsValid = false;
            ValidationErrors.Add(errorMessage);
        }
    }
}