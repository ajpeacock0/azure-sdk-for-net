// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.Chat
{
    /// <summary> The Communication Services error. </summary>
    internal partial class CommunicationErrorResponse
    {
        /// <summary> Initializes a new instance of CommunicationErrorResponse. </summary>
        /// <param name="error"> The Communication Services error. </param>
        internal CommunicationErrorResponse(CommunicationError error)
        {
            Error = error;
        }

        /// <summary> The Communication Services error. </summary>
        public CommunicationError Error { get; }
    }
}