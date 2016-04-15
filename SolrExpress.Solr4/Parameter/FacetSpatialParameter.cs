﻿using SolrExpress.Core;
using SolrExpress.Core.Extension.Internal;
using SolrExpress.Core.Parameter;
using SolrExpress.Core.ParameterValue;
using SolrExpress.Core.Query;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SolrExpress.Solr4.Parameter
{
    public sealed class FacetSpatialParameter<TDocument> : IFacetSpatialParameter<TDocument>, IParameter<List<string>>, IValidation
        where TDocument : IDocument
    {
        private string _aliasName { get; set; }
        private SolrSpatialFunctionType _functionType { get; set; }
        private Expression<Func<TDocument, object>> _expression { get; set; }
        private GeoCoordinate _centerPoint { get; set; }
        private decimal _distance { get; set; }
        private SolrFacetSortType? _sortType { get; set; }
        private string[] _excludes { get; set; }

        /// <summary>
        /// True to indicate multiple instances of the parameter, otherwise false
        /// </summary>
        public bool AllowMultipleInstances { get; } = true;

        /// <summary>
        /// Execute the creation of the parameter "sort"
        /// </summary>
        /// <param name="container">Container to parameters to request to SOLR</param>
        public void Execute(List<string> container)
        {
            Checker.IsNullOrWhiteSpace(this._aliasName);
            Checker.IsNull(this._expression);

            if (!container.Contains("facet=true"))
            {
                container.Add("facet=true");
            }

            var fieldName = this._expression.GetFieldNameFromExpression();

            //TODO
            //var formule = UtilHelper.GetSolrSpatialFormule(
            //    this.FunctionType,
            //    fieldName,
            //    this.CenterPoint,
            //    this.Distance);

            //container.Add($"facet.query={UtilHelper.GetSolrFacetWithExcludesSolr4(this.AliasName, formule, this.Excludes)}");

            if (this._sortType.HasValue)
            {
                string typeName;
                string dummy;

                Checker.IsTrue<UnsupportedSortTypeException>(this._sortType.Value == SolrFacetSortType.CountDesc || this._sortType.Value == SolrFacetSortType.IndexDesc);

                //TODO
                //UtilHelper.GetSolrFacetSort(this.SortType.Value, out typeName, out dummy);

                //container.Add($"f.{this.AliasName}.facet.sort={typeName}");
            }

            container.Add($"f.{this._aliasName}.facet.mincount=1");
        }

        /// <summary>
        /// Check for the parameter validation
        /// </summary>
        /// <param name="isValid">True if is valid, otherwise false</param>
        /// <param name="errorMessage">The error message, if applicable</param>
        public void Validate(out bool isValid, out string errorMessage)
        {
            Checker.IsNullOrWhiteSpace(this._aliasName);
            Checker.IsNull(this._expression);

            isValid = true;
            errorMessage = string.Empty;

            var solrFieldAttribute = this._expression.GetSolrFieldAttributeFromPropertyInfo();

            if (solrFieldAttribute != null && !solrFieldAttribute.Indexed)
            {
                isValid = false;
                errorMessage = Resource.FieldMustBeIndexedTrueToBeUsedInAFacetException;
            }
        }

        /// <summary>
        /// Configure current instance
        /// </summary>
        /// <param name="aliasName">Name of the alias added in the query</param>
        /// <param name="functionType">Function used in the spatial filter</param>
        /// <param name="expression">Expression used to find the property name</param>
        /// <param name="centerPoint">Center point to spatial filter</param>
        /// <param name="distance">Distance from the center point</param>
        /// <param name="sortType">Sort type of the result of the facet</param>
        /// <param name="excludes">List of tags to exclude in facet calculation</param>
        public IFacetSpatialParameter<TDocument> Configure(string aliasName, SolrSpatialFunctionType functionType, Expression<Func<TDocument, object>> expression, GeoCoordinate centerPoint, decimal distance, SolrFacetSortType? sortType = null, params string[] excludes)
        {
            this._aliasName = aliasName;
            this._functionType = functionType;
            this._expression = expression;
            this._centerPoint = centerPoint;
            this._distance = distance;
            this._sortType = sortType;
            this._excludes = excludes;

            return this;
        }
    }
}
