using System;
using SAO;
using SAO.Attributes.Property.Default;
using SAO.Attributes.Property.Validation;

namespace TestSAO.SampleModels
{
    public class Customer : SAObject
    {
        [DefaultEmptyGuidToNewGuid]
        public Guid ID { get; set; }

        [DefaultNullOrEmptyStringTo("Test User")]
        public string Name { get; set; }

        [Required("Address is required")]
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

        [CannotBeEmptyString("Password must have a value")]
        public string Password { get; set; }

        [CannotBeEmptyString("Confirmation password must have a value")]
        [MustHaveSameValueAs("Password", "Confirmation password must match Password")]
        public string ConfirmPassword { get; set; }

        public decimal Value1 { get; set; }

        [MustBeGreaterThanOrEqualTo("Value1", "Value2 must be greater than or equal to Value 1")]
        public decimal Value2 { get; set; }
    }
}