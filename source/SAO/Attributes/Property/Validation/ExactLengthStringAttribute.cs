﻿using System;
using SAO.Attributes.Base;

namespace SAO.Attributes.Property.Validation
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public class ExactLengthStringAttribute : SAOBasePropertyValidationAttribute
    {
        private int Length { get; }

        public ExactLengthStringAttribute(int length, string errorMessage) : base(errorMessage)
        {
            Length = length;
        }

        public override void Validate(SAObject obj, object property)
        {
            if(property == null && Length > 0 || (property?.ToString().Length != Length))
            {
                obj.Invalidate(ErrorMessage);
            }
        }
    }
}