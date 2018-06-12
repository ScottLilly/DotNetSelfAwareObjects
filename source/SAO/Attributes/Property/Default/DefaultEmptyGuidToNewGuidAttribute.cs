using System;
using SAO.Attributes.Interfaces;

namespace SAO.Attributes.Property.Default
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DefaultEmptyGuidToNewGuidAttribute : Attribute, ISAOPropertyDefaultApplicator
    {
        public object DefaultValue => Guid.NewGuid();

        public bool NeedsDefaultApplied(object property)
        {
            if(property is Guid guid)
            {
                return guid == Guid.Empty;
            }

            return false;
        }
    }
}