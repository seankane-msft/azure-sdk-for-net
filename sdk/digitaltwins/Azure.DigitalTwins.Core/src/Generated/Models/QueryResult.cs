// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.DigitalTwins.Core.Models
{
    /// <summary> The results of a query operation and an optional continuation token. </summary>
    internal partial class QueryResult
    {
        /// <summary> Initializes a new instance of QueryResult. </summary>
        internal QueryResult()
        {
        }

        /// <summary> Initializes a new instance of QueryResult. </summary>
        /// <param name="items"> The query results. </param>
        /// <param name="continuationToken"> A token which can be used to construct a new QuerySpecification to retrieve the next set of results. </param>
        internal QueryResult(IReadOnlyList<string> items, string continuationToken)
        {
            Items = items;
            ContinuationToken = continuationToken;
        }
        /// <summary> A token which can be used to construct a new QuerySpecification to retrieve the next set of results. </summary>
        public string ContinuationToken { get; }
    }
}
