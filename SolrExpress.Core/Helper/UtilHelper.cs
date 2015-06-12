﻿using SolrExpress.Core.Attribute;
using SolrExpress.Core.Enumerator;
using SolrExpress.Core.Query;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace SolrExpress.Core.Helper
{
    /// <summary>
    /// Helper class use in the SOLR Query core
    /// </summary>
    internal static class UtilHelper
    {
        /// <summary>
        /// Returns the SolrFieldAttribute associated with the informed property
        /// </summary>
        /// <param name="propertyInfo">Property information to find the attribute</param>
        /// <returns>SolrFieldAttribute associated4 with the informed property, otherwise null</returns>
        private static SolrFieldAttribute GetSolrFieldAttributeFrompropertyInfo(PropertyInfo propertyInfo)
        {
            var attrs = propertyInfo.GetCustomAttributes(true);
            return (SolrFieldAttribute)attrs.FirstOrDefault(q => q is SolrFieldAttribute);
        }

        /// <summary>
        /// Returns the property name of the indicated expression
        /// </summary>
        /// <typeparam name="T">Type of the document used in the query</typeparam>
        /// <param name="expression">Expression used to find the property name</param>
        /// <returns>Property name indicated in the expression</returns>
        internal static string GetPropertyNameFromExpression<T>(Expression<Func<T, object>> expression)
            where T : IDocument
        {
            var lambda = (LambdaExpression)expression;

            PropertyInfo propertyInfo;
            MemberExpression memberExpression;
            SolrFieldAttribute solrFieldAttribute;

            switch (lambda.Body.NodeType)
            {
                case ExpressionType.Convert:
                    var unaryExpression = (UnaryExpression)lambda.Body;

                    memberExpression = (MemberExpression)unaryExpression.Operand;

                    propertyInfo = memberExpression.Member as PropertyInfo;
                    if (propertyInfo == null)
                    {
                        throw new InvalidOperationException("Expression must be a property reference.");
                    }

                    solrFieldAttribute = UtilHelper.GetSolrFieldAttributeFrompropertyInfo(propertyInfo);

                    return solrFieldAttribute == null ? propertyInfo.Name : solrFieldAttribute.Label;
                case ExpressionType.MemberAccess:
                    memberExpression = (MemberExpression)lambda.Body;

                    propertyInfo = memberExpression.Member as PropertyInfo;
                    if (propertyInfo == null)
                    {
                        throw new InvalidOperationException("Expression must be a property reference.");
                    }

                    solrFieldAttribute = UtilHelper.GetSolrFieldAttributeFrompropertyInfo(propertyInfo);

                    return solrFieldAttribute == null ? propertyInfo.Name : solrFieldAttribute.Label;
            }

            throw new InvalidOperationException("Unknown to resolve the expression");
        }

        /// <summary>
        /// Get the sort type and direction
        /// </summary>
        /// <param name="solrFacetSortType">Type used in match</param>
        /// <param name="typeName">Type name</param>
        /// <param name="sortName">Sort direction</param>
        internal static void GetSolrFacetSort(SolrFacetSortType solrFacetSortType, out string typeName, out string sortName)
        {
            switch (solrFacetSortType)
            {
                case SolrFacetSortType.IndexAsc:
                    typeName = "index";
                    sortName = "asc";
                    break;
                case SolrFacetSortType.IndexDesc:
                    typeName = "index";
                    sortName = "desc";
                    break;
                case SolrFacetSortType.QuantityAsc:
                    typeName = "count";
                    sortName = "asc";
                    break;
                case SolrFacetSortType.QuantityDesc:
                    typeName = "count";
                    sortName = "desc";
                    break;
                default:
                    throw new ArgumentException("sortType");
                    break;
            }
        }
    }
}
