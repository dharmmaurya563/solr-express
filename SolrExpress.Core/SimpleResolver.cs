﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SolrExpress.Core
{
    /// <summary>
    /// Simple dependency injection resolver
    /// </summary>
    public class SimpleResolver : IResolver
    {
        private Dictionary<Type, Type> mappings = new Dictionary<Type, Type>();

        /// <summary>
        /// Resolve target type based in informed source type
        /// </summary>
        /// <param name="source">Source type used to resolve target type</param>
        /// <returns>Target type or null</returns>
        private Type ResolveType(Type source)
        {
            var item = mappings.Keys.FirstOrDefault(q => $"{q.Namespace}.{q.Name}".Equals($"{source.Namespace}.{source.Name}"));

            if (item != null)
            {
                var target = mappings[item];

                if (target.ContainsGenericParameters)
                {
                    target = target.MakeGenericType(source.GenericTypeArguments);
                }

                return target;
            }

            return null;
        }

        /// <summary>
        /// Get concrete class that implements informed interface
        /// </summary>
        /// <returns>Concrete class</returns>
        public T GetInstance<T>()
        {
            var target = this.ResolveType(typeof(T));

            if (target == null)
            {
                throw new UnexpectedDependencyInjectionMappingException(typeof(T).FullName);
            }

            var constructor = target.GetConstructors()[0];
            return (T)constructor.Invoke(new object[] { });
        }
    }
}
