// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.DigitalTwins.Core.Models
{
    /// <summary> Parameter group. </summary>
    public partial class EventRoutesListOptions
    {
        /// <summary> Initializes a new instance of EventRoutesListOptions. </summary>
        public EventRoutesListOptions()
        {
        }

        /// <summary> Initializes a new instance of EventRoutesListOptions. </summary>
        /// <param name="maxItemCount"> The maximum number of items to retrieve per request. The server may choose to return less than the requested max. </param>
        internal EventRoutesListOptions(int? maxItemCount)
        {
            MaxItemCount = maxItemCount;
        }

        /// <summary> The maximum number of items to retrieve per request. The server may choose to return less than the requested max. </summary>
        public int? MaxItemCount { get; set; }
    }
}
