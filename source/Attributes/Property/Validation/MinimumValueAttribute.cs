using SAO.Attributes.Base;

namespace SAO.Attributes.Property.Validation
{
    public class MinimumValueAttribute : SAOBasePropertyValidationAttribute
    {
        public int MinimumValue { get; set; }

        public MinimumValueAttribute(int minimumValue, string errorMessage) : base(errorMessage)
        {
            MinimumValue = minimumValue;
        }

        public override void Validate(SAObject obj, object property)
        {
        }
    }
}
