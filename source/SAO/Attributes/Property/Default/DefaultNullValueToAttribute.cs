using System;

using SAO.Attributes.Interfaces;

namespace SAO.Attributes.Property.Default
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DefaultNullValueToAttribute : Attribute, ISAOPropertyDefaultApplicator
    {
        public object DefaultValue { get; }

        public DefaultNullValueToAttribute(object defaultValue)
        {
            DefaultValue = defaultValue;
        }

        public bool NeedsDefaultApplied(object property)
        {
            return property == null;
        }
    }
}
