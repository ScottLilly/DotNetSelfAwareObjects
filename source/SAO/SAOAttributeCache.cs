using System;
using System.Collections.Generic;
using System.Reflection;
using SAO.Attributes;
using SAO.Attributes.Interfaces;

namespace SAO
{
    internal static class SAOAttributeCache
    {
        private static readonly List<Type> _cachedSAOClasseTypes = new List<Type>();

        internal static readonly List<SAODefaultAttributeInfo> DefaultAttributes = 
            new List<SAODefaultAttributeInfo>();

        internal static readonly List<SAOValidationAttributeInfo> ValidationAttributes =
            new List<SAOValidationAttributeInfo>();

        internal static void CacheSAOAttributesForClass(SAObject obj)
        {
            Type classType = obj.GetType();

            if(!_cachedSAOClasseTypes.Contains(classType))
            {
                PopulateSAODefaultAttributesForClassType(classType);
                PopulateSAOValidationAttributesForClassType(classType);

                _cachedSAOClasseTypes.Add(classType);
            }
        }

        private static void PopulateSAODefaultAttributesForClassType(Type classType)
        {
            foreach(PropertyInfo property in classType.GetProperties())
            {
                foreach(ISAOPropertyDefaultApplicator attribute in
                    property.GetCustomAttributes(typeof(ISAOPropertyDefaultApplicator), true))
                {
                    if(!DefaultAttributes.Exists(x => x.ClassType == classType &&
                                                      x.PropertyName == property.Name &&
                                                      x.DefaultAttribute == attribute))
                    {
                        SAODefaultAttributeInfo rule = new SAODefaultAttributeInfo
                                                       {
                                                           ClassType = classType,
                                                           PropertyName = property.Name,
                                                           DefaultAttribute = attribute
                                                       };

                        DefaultAttributes.Add(rule);
                    }
                }
            }
        }

        private static void PopulateSAOValidationAttributesForClassType(Type classType)
        {
            foreach(PropertyInfo property in classType.GetProperties())
            {
                foreach(ISAOPropertyValidator attribute in
                    property.GetCustomAttributes(typeof(ISAOPropertyValidator), true))
                {
                    if(!ValidationAttributes.Exists(x => x.ClassType == classType &&
                                                         x.PropertyName == property.Name &&
                                                         x.ValidationAttribute == attribute))
                    {
                        SAOValidationAttributeInfo rule = new SAOValidationAttributeInfo
                                                          {
                                                              ClassType = classType,
                                                              PropertyName = property.Name,
                                                              ValidationAttribute = attribute
                                                          };

                        ValidationAttributes.Add(rule);
                    }
                }
            }
        }
    }
}