// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> webhook deliveryStatus. </summary>
    public readonly partial struct WebhookPropertiesDeliveryStatus : IEquatable<WebhookPropertiesDeliveryStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WebhookPropertiesDeliveryStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WebhookPropertiesDeliveryStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string NotStartedValue = "NotStarted";

        /// <summary> Succeeded. </summary>
        public static WebhookPropertiesDeliveryStatus Succeeded { get; } = new WebhookPropertiesDeliveryStatus(SucceededValue);
        /// <summary> Failed. </summary>
        public static WebhookPropertiesDeliveryStatus Failed { get; } = new WebhookPropertiesDeliveryStatus(FailedValue);
        /// <summary> NotStarted. </summary>
        public static WebhookPropertiesDeliveryStatus NotStarted { get; } = new WebhookPropertiesDeliveryStatus(NotStartedValue);
        /// <summary> Determines if two <see cref="WebhookPropertiesDeliveryStatus"/> values are the same. </summary>
        public static bool operator ==(WebhookPropertiesDeliveryStatus left, WebhookPropertiesDeliveryStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WebhookPropertiesDeliveryStatus"/> values are not the same. </summary>
        public static bool operator !=(WebhookPropertiesDeliveryStatus left, WebhookPropertiesDeliveryStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="WebhookPropertiesDeliveryStatus"/>. </summary>
        public static implicit operator WebhookPropertiesDeliveryStatus(string value) => new WebhookPropertiesDeliveryStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WebhookPropertiesDeliveryStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WebhookPropertiesDeliveryStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
