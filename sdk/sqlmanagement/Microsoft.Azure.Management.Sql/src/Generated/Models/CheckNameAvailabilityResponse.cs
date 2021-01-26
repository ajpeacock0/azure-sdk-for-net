// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The result of a name availability check.
    /// </summary>
    public partial class CheckNameAvailabilityResponse
    {
        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityResponse
        /// class.
        /// </summary>
        public CheckNameAvailabilityResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CheckNameAvailabilityResponse
        /// class.
        /// </summary>
        /// <param name="name">The name whose availability was checked.</param>
        /// <param name="available">True if the name is available, otherwise
        /// false.</param>
        /// <param name="reason">The reason code explaining why the name is
        /// unavailable. Will be undefined if the name is available. Possible
        /// values include: 'Invalid', 'AlreadyExists'</param>
        /// <param name="message">A message explaining why the name is
        /// unavailable. Will be undefined if the name is available.</param>
        public CheckNameAvailabilityResponse(string name = default(string), bool? available = default(bool?), CheckNameAvailabilityReason? reason = default(CheckNameAvailabilityReason?), string message = default(string))
        {
            Name = name;
            Available = available;
            Reason = reason;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the name whose availability was checked.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets true if the name is available, otherwise false.
        /// </summary>
        [JsonProperty(PropertyName = "available")]
        public bool? Available { get; private set; }

        /// <summary>
        /// Gets the reason code explaining why the name is unavailable. Will
        /// be undefined if the name is available. Possible values include:
        /// 'Invalid', 'AlreadyExists'
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public CheckNameAvailabilityReason? Reason { get; private set; }

        /// <summary>
        /// Gets a message explaining why the name is unavailable. Will be
        /// undefined if the name is available.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

    }
}