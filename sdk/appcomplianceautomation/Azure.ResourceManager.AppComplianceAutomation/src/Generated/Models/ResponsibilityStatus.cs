// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> Indicates the customer responsibility status. </summary>
    public readonly partial struct ResponsibilityStatus : IEquatable<ResponsibilityStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResponsibilityStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResponsibilityStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PassedValue = "Passed";
        private const string FailedValue = "Failed";
        private const string NotApplicableValue = "NotApplicable";
        private const string PendingApprovalValue = "PendingApproval";

        /// <summary> Passed. </summary>
        public static ResponsibilityStatus Passed { get; } = new ResponsibilityStatus(PassedValue);
        /// <summary> Failed. </summary>
        public static ResponsibilityStatus Failed { get; } = new ResponsibilityStatus(FailedValue);
        /// <summary> NotApplicable. </summary>
        public static ResponsibilityStatus NotApplicable { get; } = new ResponsibilityStatus(NotApplicableValue);
        /// <summary> PendingApproval. </summary>
        public static ResponsibilityStatus PendingApproval { get; } = new ResponsibilityStatus(PendingApprovalValue);
        /// <summary> Determines if two <see cref="ResponsibilityStatus"/> values are the same. </summary>
        public static bool operator ==(ResponsibilityStatus left, ResponsibilityStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResponsibilityStatus"/> values are not the same. </summary>
        public static bool operator !=(ResponsibilityStatus left, ResponsibilityStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ResponsibilityStatus"/>. </summary>
        public static implicit operator ResponsibilityStatus(string value) => new ResponsibilityStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResponsibilityStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResponsibilityStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
