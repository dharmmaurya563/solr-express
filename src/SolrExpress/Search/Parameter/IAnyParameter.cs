﻿namespace SolrExpress.Search.Parameter
{
    /// <summary>
    /// Signatures to use any parameter
    /// </summary>
    public interface IAnyParameter<TDocument> : ISearchParameter
        where TDocument : IDocument
    {
        /// <summary>
        /// Name of parameter
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Value of parameter
        /// </summary>
        string Value { get; set; }
    }
}
