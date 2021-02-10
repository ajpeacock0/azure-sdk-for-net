// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Purview.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Soft Deleted Account resource
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DeletedAccount : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the DeletedAccount class.
        /// </summary>
        public DeletedAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeletedAccount class.
        /// </summary>
        /// <param name="id">Gets or sets the identifier.</param>
        /// <param name="name">Gets or sets the name.</param>
        /// <param name="type">Gets or sets the type.</param>
        /// <param name="accountId">Gets the account identifier associated with
        /// resource.</param>
        /// <param name="deletedBy">Gets the user identifier that deleted
        /// resource.</param>
        /// <param name="deletionDate">Gets the time at which the resource was
        /// soft deleted.</param>
        /// <param name="location">Gets the resource location.</param>
        /// <param name="scheduledPurgeDate">Gets the scheduled purge
        /// datetime.</param>
        /// <param name="tags">Gets the account tags.</param>
        public DeletedAccount(string id = default(string), string name = default(string), string type = default(string), string accountId = default(string), string deletedBy = default(string), System.DateTime? deletionDate = default(System.DateTime?), string location = default(string), System.DateTime? scheduledPurgeDate = default(System.DateTime?), IDictionary<string, string> tags = default(IDictionary<string, string>))
            : base(id, name, type)
        {
            AccountId = accountId;
            DeletedBy = deletedBy;
            DeletionDate = deletionDate;
            Location = location;
            ScheduledPurgeDate = scheduledPurgeDate;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the account identifier associated with resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.accountId")]
        public string AccountId { get; private set; }

        /// <summary>
        /// Gets the user identifier that deleted resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deletedBy")]
        public string DeletedBy { get; private set; }

        /// <summary>
        /// Gets the time at which the resource was soft deleted.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deletionDate")]
        public System.DateTime? DeletionDate { get; private set; }

        /// <summary>
        /// Gets the resource location.
        /// </summary>
        [JsonProperty(PropertyName = "properties.location")]
        public string Location { get; private set; }

        /// <summary>
        /// Gets the scheduled purge datetime.
        /// </summary>
        [JsonProperty(PropertyName = "properties.scheduledPurgeDate")]
        public System.DateTime? ScheduledPurgeDate { get; private set; }

        /// <summary>
        /// Gets the account tags.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tags")]
        public IDictionary<string, string> Tags { get; private set; }

    }
}