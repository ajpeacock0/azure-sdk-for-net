// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.PhoneNumbers.Models
{
    /// <summary> Represents a wrapper around a list of location options. </summary>
    public partial class LocationOptionsResponse
    {
        /// <summary> Initializes a new instance of LocationOptionsResponse. </summary>
        internal LocationOptionsResponse()
        {
        }

        /// <summary> Initializes a new instance of LocationOptionsResponse. </summary>
        /// <param name="locationOptions"> Represents a location options. </param>
        internal LocationOptionsResponse(LocationOptions locationOptions)
        {
            LocationOptions = locationOptions;
        }

        /// <summary> Represents a location options. </summary>
        public LocationOptions LocationOptions { get; }
    }
}