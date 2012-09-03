using System.Linq;

using SAO.Attributes;

namespace SAO
{
    internal static class SAOInitializer
    {
        internal static void Initialize(SAObject obj)
        {
            // Load the default attributes for this class into the cache, if needed.
            SAOAttributeCache.CacheSAOAttributesForClass(obj);

            foreach(SAODefaultAttributeInfo attribute in SAOAttributeCache.DefaultAttributes.Where(x => (x.ClassType == obj.GetType())))
            {
                if(attribute.DefaultAttribute.NeedsDefaultApplied(obj.GetType().GetProperty(attribute.PropertyName).GetValue(obj, null)))
                {
                    obj.GetType().GetProperty(attribute.PropertyName).SetValue(obj, attribute.DefaultAttribute.DefaultValue, null);
                }
            }
        }
    }
}
