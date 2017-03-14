using SAO.Attributes.Base;
using SAO.Attributes.Interfaces;

namespace SAO.Attributes
{
    public class SAODefaultAttributeInfo : SAOBaseAttributeInfo
    {
        public ISAOPropertyDefaultApplicator DefaultAttribute { get; set; }
    }
}