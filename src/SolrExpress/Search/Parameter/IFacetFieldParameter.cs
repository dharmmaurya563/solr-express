﻿using System;
using System.Linq.Expressions;

namespace SolrExpress.Search.Parameter
{
    /// <summary>
    /// Signatures to use facet field parameter
    /// </summary>
    public interface IFacetFieldParameter<TDocument> : ISearchParameter
        where TDocument : IDocument
    {
        /// <summary>
        /// Expression used to find field name
        /// </summary>
        Expression<Func<TDocument, object>> FieldExpression { get; set; }

        /// <summary>
        /// Sort type of result of facet
        /// </summary>
        FacetSortType SortType { get; set; }

        /// <summary>
        /// Minimum count of itens in facet's result
        /// </summary>
        int Minimum { get; set; }

        /// <summary>
        /// Limit of itens in facet's result
        /// </summary>
        int Limit { get; set; }

        /// <summary>
        /// List of tags to exclude in facet calculation
        /// </summary>
        string[] Excludes { get; set; }
    }
}
