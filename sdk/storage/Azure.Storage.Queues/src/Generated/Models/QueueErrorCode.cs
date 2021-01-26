// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Storage.Queues.Models
{
    /// <summary> Error codes returned by the service. </summary>
    public readonly partial struct QueueErrorCode : IEquatable<QueueErrorCode>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="QueueErrorCode"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public QueueErrorCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AccountAlreadyExistsValue = "AccountAlreadyExists";
        private const string AccountBeingCreatedValue = "AccountBeingCreated";
        private const string AccountIsDisabledValue = "AccountIsDisabled";
        private const string AuthenticationFailedValue = "AuthenticationFailed";
        private const string AuthorizationFailureValue = "AuthorizationFailure";
        private const string ConditionHeadersNotSupportedValue = "ConditionHeadersNotSupported";
        private const string ConditionNotMetValue = "ConditionNotMet";
        private const string EmptyMetadataKeyValue = "EmptyMetadataKey";
        private const string InsufficientAccountPermissionsValue = "InsufficientAccountPermissions";
        private const string InternalErrorValue = "InternalError";
        private const string InvalidAuthenticationInfoValue = "InvalidAuthenticationInfo";
        private const string InvalidHeaderValueValue = "InvalidHeaderValue";
        private const string InvalidHttpVerbValue = "InvalidHttpVerb";
        private const string InvalidInputValue = "InvalidInput";
        private const string InvalidMd5Value = "InvalidMd5";
        private const string InvalidMetadataValue = "InvalidMetadata";
        private const string InvalidQueryParameterValueValue = "InvalidQueryParameterValue";
        private const string InvalidRangeValue = "InvalidRange";
        private const string InvalidResourceNameValue = "InvalidResourceName";
        private const string InvalidUriValue = "InvalidUri";
        private const string InvalidXmlDocumentValue = "InvalidXmlDocument";
        private const string InvalidXmlNodeValueValue = "InvalidXmlNodeValue";
        private const string Md5MismatchValue = "Md5Mismatch";
        private const string MetadataTooLargeValue = "MetadataTooLarge";
        private const string MissingContentLengthHeaderValue = "MissingContentLengthHeader";
        private const string MissingRequiredQueryParameterValue = "MissingRequiredQueryParameter";
        private const string MissingRequiredHeaderValue = "MissingRequiredHeader";
        private const string MissingRequiredXmlNodeValue = "MissingRequiredXmlNode";
        private const string MultipleConditionHeadersNotSupportedValue = "MultipleConditionHeadersNotSupported";
        private const string OperationTimedOutValue = "OperationTimedOut";
        private const string OutOfRangeInputValue = "OutOfRangeInput";
        private const string OutOfRangeQueryParameterValueValue = "OutOfRangeQueryParameterValue";
        private const string RequestBodyTooLargeValue = "RequestBodyTooLarge";
        private const string ResourceTypeMismatchValue = "ResourceTypeMismatch";
        private const string RequestUrlFailedToParseValue = "RequestUrlFailedToParse";
        private const string ResourceAlreadyExistsValue = "ResourceAlreadyExists";
        private const string ResourceNotFoundValue = "ResourceNotFound";
        private const string ServerBusyValue = "ServerBusy";
        private const string UnsupportedHeaderValue = "UnsupportedHeader";
        private const string UnsupportedXmlNodeValue = "UnsupportedXmlNode";
        private const string UnsupportedQueryParameterValue = "UnsupportedQueryParameter";
        private const string UnsupportedHttpVerbValue = "UnsupportedHttpVerb";
        private const string InvalidMarkerValue = "InvalidMarker";
        private const string MessageNotFoundValue = "MessageNotFound";
        private const string MessageTooLargeValue = "MessageTooLarge";
        private const string PopReceiptMismatchValue = "PopReceiptMismatch";
        private const string QueueAlreadyExistsValue = "QueueAlreadyExists";
        private const string QueueBeingDeletedValue = "QueueBeingDeleted";
        private const string QueueDisabledValue = "QueueDisabled";
        private const string QueueNotEmptyValue = "QueueNotEmpty";
        private const string QueueNotFoundValue = "QueueNotFound";
        private const string AuthorizationSourceIPMismatchValue = "AuthorizationSourceIPMismatch";
        private const string AuthorizationProtocolMismatchValue = "AuthorizationProtocolMismatch";
        private const string AuthorizationPermissionMismatchValue = "AuthorizationPermissionMismatch";
        private const string AuthorizationServiceMismatchValue = "AuthorizationServiceMismatch";
        private const string AuthorizationResourceTypeMismatchValue = "AuthorizationResourceTypeMismatch";
        private const string FeatureVersionMismatchValue = "FeatureVersionMismatch";

        /// <summary> AccountAlreadyExists. </summary>
        public static QueueErrorCode AccountAlreadyExists { get; } = new QueueErrorCode(AccountAlreadyExistsValue);
        /// <summary> AccountBeingCreated. </summary>
        public static QueueErrorCode AccountBeingCreated { get; } = new QueueErrorCode(AccountBeingCreatedValue);
        /// <summary> AccountIsDisabled. </summary>
        public static QueueErrorCode AccountIsDisabled { get; } = new QueueErrorCode(AccountIsDisabledValue);
        /// <summary> AuthenticationFailed. </summary>
        public static QueueErrorCode AuthenticationFailed { get; } = new QueueErrorCode(AuthenticationFailedValue);
        /// <summary> AuthorizationFailure. </summary>
        public static QueueErrorCode AuthorizationFailure { get; } = new QueueErrorCode(AuthorizationFailureValue);
        /// <summary> ConditionHeadersNotSupported. </summary>
        public static QueueErrorCode ConditionHeadersNotSupported { get; } = new QueueErrorCode(ConditionHeadersNotSupportedValue);
        /// <summary> ConditionNotMet. </summary>
        public static QueueErrorCode ConditionNotMet { get; } = new QueueErrorCode(ConditionNotMetValue);
        /// <summary> EmptyMetadataKey. </summary>
        public static QueueErrorCode EmptyMetadataKey { get; } = new QueueErrorCode(EmptyMetadataKeyValue);
        /// <summary> InsufficientAccountPermissions. </summary>
        public static QueueErrorCode InsufficientAccountPermissions { get; } = new QueueErrorCode(InsufficientAccountPermissionsValue);
        /// <summary> InternalError. </summary>
        public static QueueErrorCode InternalError { get; } = new QueueErrorCode(InternalErrorValue);
        /// <summary> InvalidAuthenticationInfo. </summary>
        public static QueueErrorCode InvalidAuthenticationInfo { get; } = new QueueErrorCode(InvalidAuthenticationInfoValue);
        /// <summary> InvalidHeaderValue. </summary>
        public static QueueErrorCode InvalidHeaderValue { get; } = new QueueErrorCode(InvalidHeaderValueValue);
        /// <summary> InvalidHttpVerb. </summary>
        public static QueueErrorCode InvalidHttpVerb { get; } = new QueueErrorCode(InvalidHttpVerbValue);
        /// <summary> InvalidInput. </summary>
        public static QueueErrorCode InvalidInput { get; } = new QueueErrorCode(InvalidInputValue);
        /// <summary> InvalidMd5. </summary>
        public static QueueErrorCode InvalidMd5 { get; } = new QueueErrorCode(InvalidMd5Value);
        /// <summary> InvalidMetadata. </summary>
        public static QueueErrorCode InvalidMetadata { get; } = new QueueErrorCode(InvalidMetadataValue);
        /// <summary> InvalidQueryParameterValue. </summary>
        public static QueueErrorCode InvalidQueryParameterValue { get; } = new QueueErrorCode(InvalidQueryParameterValueValue);
        /// <summary> InvalidRange. </summary>
        public static QueueErrorCode InvalidRange { get; } = new QueueErrorCode(InvalidRangeValue);
        /// <summary> InvalidResourceName. </summary>
        public static QueueErrorCode InvalidResourceName { get; } = new QueueErrorCode(InvalidResourceNameValue);
        /// <summary> InvalidUri. </summary>
        public static QueueErrorCode InvalidUri { get; } = new QueueErrorCode(InvalidUriValue);
        /// <summary> InvalidXmlDocument. </summary>
        public static QueueErrorCode InvalidXmlDocument { get; } = new QueueErrorCode(InvalidXmlDocumentValue);
        /// <summary> InvalidXmlNodeValue. </summary>
        public static QueueErrorCode InvalidXmlNodeValue { get; } = new QueueErrorCode(InvalidXmlNodeValueValue);
        /// <summary> Md5Mismatch. </summary>
        public static QueueErrorCode Md5Mismatch { get; } = new QueueErrorCode(Md5MismatchValue);
        /// <summary> MetadataTooLarge. </summary>
        public static QueueErrorCode MetadataTooLarge { get; } = new QueueErrorCode(MetadataTooLargeValue);
        /// <summary> MissingContentLengthHeader. </summary>
        public static QueueErrorCode MissingContentLengthHeader { get; } = new QueueErrorCode(MissingContentLengthHeaderValue);
        /// <summary> MissingRequiredQueryParameter. </summary>
        public static QueueErrorCode MissingRequiredQueryParameter { get; } = new QueueErrorCode(MissingRequiredQueryParameterValue);
        /// <summary> MissingRequiredHeader. </summary>
        public static QueueErrorCode MissingRequiredHeader { get; } = new QueueErrorCode(MissingRequiredHeaderValue);
        /// <summary> MissingRequiredXmlNode. </summary>
        public static QueueErrorCode MissingRequiredXmlNode { get; } = new QueueErrorCode(MissingRequiredXmlNodeValue);
        /// <summary> MultipleConditionHeadersNotSupported. </summary>
        public static QueueErrorCode MultipleConditionHeadersNotSupported { get; } = new QueueErrorCode(MultipleConditionHeadersNotSupportedValue);
        /// <summary> OperationTimedOut. </summary>
        public static QueueErrorCode OperationTimedOut { get; } = new QueueErrorCode(OperationTimedOutValue);
        /// <summary> OutOfRangeInput. </summary>
        public static QueueErrorCode OutOfRangeInput { get; } = new QueueErrorCode(OutOfRangeInputValue);
        /// <summary> OutOfRangeQueryParameterValue. </summary>
        public static QueueErrorCode OutOfRangeQueryParameterValue { get; } = new QueueErrorCode(OutOfRangeQueryParameterValueValue);
        /// <summary> RequestBodyTooLarge. </summary>
        public static QueueErrorCode RequestBodyTooLarge { get; } = new QueueErrorCode(RequestBodyTooLargeValue);
        /// <summary> ResourceTypeMismatch. </summary>
        public static QueueErrorCode ResourceTypeMismatch { get; } = new QueueErrorCode(ResourceTypeMismatchValue);
        /// <summary> RequestUrlFailedToParse. </summary>
        public static QueueErrorCode RequestUrlFailedToParse { get; } = new QueueErrorCode(RequestUrlFailedToParseValue);
        /// <summary> ResourceAlreadyExists. </summary>
        public static QueueErrorCode ResourceAlreadyExists { get; } = new QueueErrorCode(ResourceAlreadyExistsValue);
        /// <summary> ResourceNotFound. </summary>
        public static QueueErrorCode ResourceNotFound { get; } = new QueueErrorCode(ResourceNotFoundValue);
        /// <summary> ServerBusy. </summary>
        public static QueueErrorCode ServerBusy { get; } = new QueueErrorCode(ServerBusyValue);
        /// <summary> UnsupportedHeader. </summary>
        public static QueueErrorCode UnsupportedHeader { get; } = new QueueErrorCode(UnsupportedHeaderValue);
        /// <summary> UnsupportedXmlNode. </summary>
        public static QueueErrorCode UnsupportedXmlNode { get; } = new QueueErrorCode(UnsupportedXmlNodeValue);
        /// <summary> UnsupportedQueryParameter. </summary>
        public static QueueErrorCode UnsupportedQueryParameter { get; } = new QueueErrorCode(UnsupportedQueryParameterValue);
        /// <summary> UnsupportedHttpVerb. </summary>
        public static QueueErrorCode UnsupportedHttpVerb { get; } = new QueueErrorCode(UnsupportedHttpVerbValue);
        /// <summary> InvalidMarker. </summary>
        public static QueueErrorCode InvalidMarker { get; } = new QueueErrorCode(InvalidMarkerValue);
        /// <summary> MessageNotFound. </summary>
        public static QueueErrorCode MessageNotFound { get; } = new QueueErrorCode(MessageNotFoundValue);
        /// <summary> MessageTooLarge. </summary>
        public static QueueErrorCode MessageTooLarge { get; } = new QueueErrorCode(MessageTooLargeValue);
        /// <summary> PopReceiptMismatch. </summary>
        public static QueueErrorCode PopReceiptMismatch { get; } = new QueueErrorCode(PopReceiptMismatchValue);
        /// <summary> QueueAlreadyExists. </summary>
        public static QueueErrorCode QueueAlreadyExists { get; } = new QueueErrorCode(QueueAlreadyExistsValue);
        /// <summary> QueueBeingDeleted. </summary>
        public static QueueErrorCode QueueBeingDeleted { get; } = new QueueErrorCode(QueueBeingDeletedValue);
        /// <summary> QueueDisabled. </summary>
        public static QueueErrorCode QueueDisabled { get; } = new QueueErrorCode(QueueDisabledValue);
        /// <summary> QueueNotEmpty. </summary>
        public static QueueErrorCode QueueNotEmpty { get; } = new QueueErrorCode(QueueNotEmptyValue);
        /// <summary> QueueNotFound. </summary>
        public static QueueErrorCode QueueNotFound { get; } = new QueueErrorCode(QueueNotFoundValue);
        /// <summary> AuthorizationSourceIPMismatch. </summary>
        public static QueueErrorCode AuthorizationSourceIPMismatch { get; } = new QueueErrorCode(AuthorizationSourceIPMismatchValue);
        /// <summary> AuthorizationProtocolMismatch. </summary>
        public static QueueErrorCode AuthorizationProtocolMismatch { get; } = new QueueErrorCode(AuthorizationProtocolMismatchValue);
        /// <summary> AuthorizationPermissionMismatch. </summary>
        public static QueueErrorCode AuthorizationPermissionMismatch { get; } = new QueueErrorCode(AuthorizationPermissionMismatchValue);
        /// <summary> AuthorizationServiceMismatch. </summary>
        public static QueueErrorCode AuthorizationServiceMismatch { get; } = new QueueErrorCode(AuthorizationServiceMismatchValue);
        /// <summary> AuthorizationResourceTypeMismatch. </summary>
        public static QueueErrorCode AuthorizationResourceTypeMismatch { get; } = new QueueErrorCode(AuthorizationResourceTypeMismatchValue);
        /// <summary> FeatureVersionMismatch. </summary>
        public static QueueErrorCode FeatureVersionMismatch { get; } = new QueueErrorCode(FeatureVersionMismatchValue);
        /// <summary> Determines if two <see cref="QueueErrorCode"/> values are the same. </summary>
        public static bool operator ==(QueueErrorCode left, QueueErrorCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="QueueErrorCode"/> values are not the same. </summary>
        public static bool operator !=(QueueErrorCode left, QueueErrorCode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="QueueErrorCode"/>. </summary>
        public static implicit operator QueueErrorCode(string value) => new QueueErrorCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is QueueErrorCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(QueueErrorCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}