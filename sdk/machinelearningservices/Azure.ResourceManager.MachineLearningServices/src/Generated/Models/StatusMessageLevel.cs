// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> Severity level of message. </summary>
    public readonly partial struct StatusMessageLevel : IEquatable<StatusMessageLevel>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="StatusMessageLevel"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StatusMessageLevel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ErrorValue = "Error";
        private const string InformationValue = "Information";
        private const string WarningValue = "Warning";

        /// <summary> Error. </summary>
        public static StatusMessageLevel Error { get; } = new StatusMessageLevel(ErrorValue);
        /// <summary> Information. </summary>
        public static StatusMessageLevel Information { get; } = new StatusMessageLevel(InformationValue);
        /// <summary> Warning. </summary>
        public static StatusMessageLevel Warning { get; } = new StatusMessageLevel(WarningValue);
        /// <summary> Determines if two <see cref="StatusMessageLevel"/> values are the same. </summary>
        public static bool operator ==(StatusMessageLevel left, StatusMessageLevel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StatusMessageLevel"/> values are not the same. </summary>
        public static bool operator !=(StatusMessageLevel left, StatusMessageLevel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StatusMessageLevel"/>. </summary>
        public static implicit operator StatusMessageLevel(string value) => new StatusMessageLevel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StatusMessageLevel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StatusMessageLevel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}