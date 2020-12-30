// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.MixedReality.Authentication
{
    internal partial class StsTokenResponseMessage
    {
        internal static StsTokenResponseMessage DeserializeStsTokenResponseMessage(JsonElement element)
        {
            string accessToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("AccessToken"))
                {
                    accessToken = property.Value.GetString();
                    continue;
                }
            }
            return new StsTokenResponseMessage(accessToken);
        }
    }
}