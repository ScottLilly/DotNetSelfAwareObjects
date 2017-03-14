using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

namespace SAO
{
    public abstract class SAObject : INotifyPropertyChanged
    {
        [XmlIgnore]
        public bool IsValid { get; private set; }

        [XmlIgnore]
        public List<string> ErrorMessages { get; }

        protected SAObject()
        {
            ErrorMessages = new List<string>();

            SAOInitializer.Initialize(this);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Validate()
        {
            IsValid = true;
            ErrorMessages.Clear();

            SAOValidator.Validate(this);
        }

        internal void Invalidate(string errorMessage)
        {
            IsValid = false;
            ErrorMessages.Add(errorMessage);
        }
    }
}