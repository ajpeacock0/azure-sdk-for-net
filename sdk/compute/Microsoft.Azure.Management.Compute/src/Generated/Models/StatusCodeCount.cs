// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class StatusCodeCount
    {
        /// <summary>
        /// Initializes a new instance of the StatusCodeCount class.
        /// </summary>
        public StatusCodeCount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StatusCodeCount class.
        /// </summary>
        /// <param name="code">The instance view status code</param>
        /// <param name="count">Number of instances having this status
        /// code</param>
        public StatusCodeCount(string code = default(string), int? count = default(int?))
        {
            Code = code;
            Count = count;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the instance view status code
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets number of instances having this status code
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; private set; }

    }
}