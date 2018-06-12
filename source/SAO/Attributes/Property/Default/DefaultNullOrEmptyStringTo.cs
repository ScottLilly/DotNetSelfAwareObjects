using System;
using SAO.Attributes.Interfaces;

namespace SAO.Attributes.Property.Default
{
    [AttributeUsage(AttributeTargets.Property)]
    public class DefaultNullOrEmptyStringTo : Attribute, ISAOPropertyDefaultApplicator
    {
        public object DefaultValue { get; }

        public DefaultNullOrEmptyStringTo(string defaultValue)
        {
            DefaultValue = defaultValue;
        }

        public bool NeedsDefaultApplied(object property)
        {
            return string.IsNullOrEmpty(property as string);
        }
    }
}