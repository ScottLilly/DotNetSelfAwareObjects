using SAO.Attributes.Base;
using SAO.Attributes.Interfaces;

namespace SAO.Attributes
{
    internal class SAOValidationAttributeInfo : SAOBaseAttributeInfo
    {
        public ISAOPropertyValidator ValidationAttribute { get; set; }
    }
}