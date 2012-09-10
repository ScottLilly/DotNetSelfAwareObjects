using System;

namespace SAO.Attributes.Base
{
    public abstract class SAOBaseAttributeInfo
    {
        public Type ClassType { get; set; }
        public string PropertyName { get; set; }
    }
}
