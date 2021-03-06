// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Blobs.Models
{
    internal static partial class PublicAccessTypeExtensions
    {
        public static string ToSerialString(this PublicAccessType value) => value switch
        {
            PublicAccessType.BlobContainer => "container",
            PublicAccessType.Blob => "blob",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PublicAccessType value.")
        };

        public static PublicAccessType ToPublicAccessType(this string value)
        {
            if (string.Equals(value, "container", StringComparison.InvariantCultureIgnoreCase)) return PublicAccessType.BlobContainer;
            if (string.Equals(value, "blob", StringComparison.InvariantCultureIgnoreCase)) return PublicAccessType.Blob;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown PublicAccessType value.");
        }
    }
}
