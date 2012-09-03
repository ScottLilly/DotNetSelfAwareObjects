using System;

using SAO.Attributes.Interfaces;

namespace SAO.Attributes.Property.Default
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class DefaultEmptyGuidToNewGuidAttribute : Attribute, ISAOPropertyDefaultApplicator
    {
        public object DefaultValue { get { return Guid.NewGuid(); } }

        public bool NeedsDefaultApplied(object property)
        {
            if(property is Guid)
            {
                return ((Guid)property == Guid.Empty);
            }

            return false;
        }
    }
}
