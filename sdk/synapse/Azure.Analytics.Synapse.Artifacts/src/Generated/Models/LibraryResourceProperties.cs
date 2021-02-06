// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Library/package properties. </summary>
    public partial class LibraryResourceProperties
    {
        /// <summary> Initializes a new instance of LibraryResourceProperties. </summary>
        public LibraryResourceProperties()
        {
        }

        /// <summary> Initializes a new instance of LibraryResourceProperties. </summary>
        /// <param name="name"> Name of the library/package. </param>
        /// <param name="path"> Location of library/package in storage account. </param>
        /// <param name="containerName"> Container name of the library/package. </param>
        /// <param name="uploadedTimestamp"> The last update time of the library/package. </param>
        /// <param name="type"> Type of the library/package. </param>
        /// <param name="provisioningStatus"> Provisioning status of the library/package. </param>
        /// <param name="creatorId"> Creator Id of the library/package. </param>
        internal LibraryResourceProperties(string name, string path, string containerName, string uploadedTimestamp, string type, string provisioningStatus, string creatorId)
        {
            Name = name;
            Path = path;
            ContainerName = containerName;
            UploadedTimestamp = uploadedTimestamp;
            Type = type;
            ProvisioningStatus = provisioningStatus;
            CreatorId = creatorId;
        }

        /// <summary> Name of the library/package. </summary>
        public string Name { get; }
        /// <summary> Location of library/package in storage account. </summary>
        public string Path { get; }
        /// <summary> Container name of the library/package. </summary>
        public string ContainerName { get; }
        /// <summary> The last update time of the library/package. </summary>
        public string UploadedTimestamp { get; }
        /// <summary> Type of the library/package. </summary>
        public string Type { get; }
        /// <summary> Provisioning status of the library/package. </summary>
        public string ProvisioningStatus { get; }
        /// <summary> Creator Id of the library/package. </summary>
        public string CreatorId { get; }
    }
}