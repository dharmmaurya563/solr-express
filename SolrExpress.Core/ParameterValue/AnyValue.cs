﻿using SolrExpress.Core.Helper;
using SolrExpress.Core.Query;
using System;

namespace SolrExpress.Core.ParameterValue
{
    /// <summary>
    /// Free value parameter
    /// </summary>
    public sealed class AnyValue : IQueryParameterValue
    {
        private readonly string _value;

        /// <summary>
        /// Create a free solr parameter value
        /// </summary>
        /// <param name="value">Value of the filter</param>
        public AnyValue(string value)
        {
            ThrowHelper<ArgumentNullException>.If(string.IsNullOrWhiteSpace(value));

            this._value = value;
        }

        /// <summary>
        /// Execute the parameter value generator
        /// </summary>
        /// <returns>Result generated value</returns>
        public string Execute()
        {
            return _value;
        }
    }
}