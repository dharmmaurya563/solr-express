﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SolrExpress.Core {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SolrExpress.Core.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter &quot;{0}&quot; is not allowed because another instance of the same type was added.
        /// </summary>
        internal static string AllowMultipleInstanceOfParameterTypeException {
            get {
                return ResourceManager.GetString("AllowMultipleInstanceOfParameterTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expression must be a property reference.
        /// </summary>
        internal static string ExpressionMustBePropertyException {
            get {
                return ResourceManager.GetString("ExpressionMustBePropertyException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A field must be &quot;indexed=true&quot; to be used in a facet.
        /// </summary>
        internal static string FieldMustBeIndexedTrueToBeUsedInAFacetException {
            get {
                return ResourceManager.GetString("FieldMustBeIndexedTrueToBeUsedInAFacetException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A field must be &quot;indexed=true&quot; to be used in a query.
        /// </summary>
        internal static string FieldMustBeIndexedTrueToBeUsedInAQueryException {
            get {
                return ResourceManager.GetString("FieldMustBeIndexedTrueToBeUsedInAQueryException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A field must be numeric or DateTime to be used in a facet range.
        /// </summary>
        internal static string FieldMustBeNumericOrDateTimeToBeUsedInFacetRangeException {
            get {
                return ResourceManager.GetString("FieldMustBeNumericOrDateTimeToBeUsedInFacetRangeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A field must be &quot;stored=true&quot; to be used in field list.
        /// </summary>
        internal static string FieldMustBeStoredTrueToBeUsedInFieldsException {
            get {
                return ResourceManager.GetString("FieldMustBeStoredTrueToBeUsedInFieldsException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Latitude most be inside range from -90.0 to 90.0.
        /// </summary>
        internal static string InvalidLatitudeException {
            get {
                return ResourceManager.GetString("InvalidLatitudeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Longitude most be inside range from -180.0 to 180.0.
        /// </summary>
        internal static string InvalidLongitudeException {
            get {
                return ResourceManager.GetString("InvalidLongitudeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter &quot;{0}&quot; validation message: &quot;{1}&quot;.
        /// </summary>
        internal static string InvalidParameterTypeException {
            get {
                return ResourceManager.GetString("InvalidParameterTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown to resolve type &quot;{0}&quot;. Mapping not found.
        /// </summary>
        internal static string UnexpectedDependencyInjectionMappingException {
            get {
                return ResourceManager.GetString("UnexpectedDependencyInjectionMappingException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter &quot;{0}&quot; was not found in the source json.
        /// </summary>
        internal static string UnexpectedJsonException {
            get {
                return ResourceManager.GetString("UnexpectedJsonException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown to resolve solr query request.
        /// </summary>
        internal static string UnexpectedSolrRequestException {
            get {
                return ResourceManager.GetString("UnexpectedSolrRequestException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown resolve of the result builder type &quot;{0}&quot; because this type doesn&apos;t implement IConvertJsonObject or IConvertJsonPlainText.
        /// </summary>
        internal static string UnknownResolveResultBuilderException {
            get {
                return ResourceManager.GetString("UnknownResolveResultBuilderException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unknown to resolve the expression.
        /// </summary>
        internal static string UnknownToResolveExpressionException {
            get {
                return ResourceManager.GetString("UnknownToResolveExpressionException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Descending sort type is an unsupported feature in Solr 4.
        /// </summary>
        internal static string UnsupportedSortTypeException {
            get {
                return ResourceManager.GetString("UnsupportedSortTypeException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Parameter &quot;{0}&quot; have a specific version.
        /// </summary>
        internal static string UseSpecificParameterRatherThanAnyException {
            get {
                return ResourceManager.GetString("UseSpecificParameterRatherThanAnyException", resourceCulture);
            }
        }
    }
}
