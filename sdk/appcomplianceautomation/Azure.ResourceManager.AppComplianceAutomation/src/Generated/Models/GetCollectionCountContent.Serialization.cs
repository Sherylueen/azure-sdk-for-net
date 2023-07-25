// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class GetCollectionCountContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(GetCollectionCountRequestType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(GetCollectionCountRequestType);
            }
            writer.WriteEndObject();
        }
    }
}
