using System;

using SAO.Attributes.Interfaces;

namespace SAO.Attributes.Property.Default
{
    [AttributeUsage(AttributeTargets.Property, Inherited = true, AllowMultiple = false)]
    public class DefaultNullOrEmptyStringTo : Attribute, ISAOPropertyDefaultApplicator
    {
        public object DefaultValue { get; private set; }

        public DefaultNullOrEmptyStringTo(string defaultValue)
        {
            DefaultValue = defaultValue;
        }

        public bool NeedsDefaultApplied(object property)
        {
            return (String.IsNullOrEmpty(property as string));
        }
    }
}
