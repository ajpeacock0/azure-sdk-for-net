// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Resource Access Rule.
    /// </summary>
    public partial class ResourceAccessRule
    {
        /// <summary>
        /// Initializes a new instance of the ResourceAccessRule class.
        /// </summary>
        public ResourceAccessRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceAccessRule class.
        /// </summary>
        /// <param name="tenantId">Tenant Id</param>
        /// <param name="resourceId">Resource Id</param>
        public ResourceAccessRule(string tenantId = default(string), string resourceId = default(string))
        {
            TenantId = tenantId;
            ResourceId = resourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets tenant Id
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; set; }

        /// <summary>
        /// Gets or sets resource Id
        /// </summary>
        [JsonProperty(PropertyName = "resourceId")]
        public string ResourceId { get; set; }

    }
}