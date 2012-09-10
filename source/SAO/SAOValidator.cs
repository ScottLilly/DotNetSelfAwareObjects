using System.Linq;

using SAO.Attributes;

namespace SAO
{
    internal static class SAOValidator
    {
        internal static void Validate(SAObject obj)
        {
            // Load the validation attributes for this class into the cache, if needed.
            SAOAttributeCache.CacheSAOAttributesForClass(obj);

            foreach(SAOValidationAttributeInfo attribute in SAOAttributeCache.ValidationAttributes.Where(x => (x.ClassType == obj.GetType())))
            {
                attribute.ValidationAttribute.Validate(obj, obj.GetType().GetProperty(attribute.PropertyName).GetValue(obj, null));
            }
        }
    }
}
