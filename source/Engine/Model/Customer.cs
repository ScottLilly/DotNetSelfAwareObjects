using System;

using SAO;
using SAO.Attributes.Property.Default;
using SAO.Attributes.Property.Validation;

namespace Engine.Model
{
    public class Customer : SAObject
    {
        private string _name;

        [DefaultEmptyGuidToNewGuid]
        public Guid ID { get; set; }

        [DefaultNullOrEmptyStringTo("Test User")]
        public string Name 
        { 
            get { return _name; }
            set
            {
                if(_name != value)
                {
                    _name = value;
                    OnPropertyChanged("Name");  // SAObject method to alert any event handlers watching this property
                }
            }
        }

        [MinimumLength(5, "Address cannot be less than 5 characters long")]
        [MaximumLength(100, "Address cannot be more than 100 characters long")]
        public string Address { get; set; }

        [MinimumLength(2, "City cannot be less than 2 characters long")]
        [MaximumLength(100, "City cannot be more than 100 characters long")]
        public string City { get; set; }

        [ExactLengthString(2, "State must be two characters")]
        [ContainsOnlyLetters("State can only contain letters")]
        public string StateCode { get; set; }

        [MatchesRegEx(RegExConstants.CountrySpecific.US.ZIP_CODE, "ZIP Code must be formatted like '99999' or '99999-9999'")]
        public string ZIPCode { get; set; }

        //[MinimumValue(1, "Age must be less than 1")]
        //[MaximumValue(150, "Age cannot be larger than 150")]
        [WithinRange(1, 150, "Age must be between 1 and 150")]
        public int Age { get; set; }
    }
}
