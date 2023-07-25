// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class CertSyncRecord : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OfferGuid))
            {
                writer.WritePropertyName("offerGuid"u8);
                writer.WriteStringValue(OfferGuid);
            }
            if (Optional.IsDefined(CertificationStatus))
            {
                writer.WritePropertyName("certificationStatus"u8);
                writer.WriteStringValue(CertificationStatus);
            }
            if (Optional.IsDefined(IngestionStatus))
            {
                writer.WritePropertyName("ingestionStatus"u8);
                writer.WriteStringValue(IngestionStatus);
            }
            if (Optional.IsCollectionDefined(Controls))
            {
                writer.WritePropertyName("controls"u8);
                writer.WriteStartArray();
                foreach (var item in Controls)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static CertSyncRecord DeserializeCertSyncRecord(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> offerGuid = default;
            Optional<string> certificationStatus = default;
            Optional<string> ingestionStatus = default;
            Optional<IList<ControlSyncRecord>> controls = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("offerGuid"u8))
                {
                    offerGuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certificationStatus"u8))
                {
                    certificationStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ingestionStatus"u8))
                {
                    ingestionStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ControlSyncRecord> array = new List<ControlSyncRecord>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ControlSyncRecord.DeserializeControlSyncRecord(item));
                    }
                    controls = array;
                    continue;
                }
            }
            return new CertSyncRecord(offerGuid.Value, certificationStatus.Value, ingestionStatus.Value, Optional.ToList(controls));
        }
    }
}
