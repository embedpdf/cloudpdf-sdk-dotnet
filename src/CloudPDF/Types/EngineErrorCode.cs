using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(EngineErrorCode.EngineErrorCodeSerializer))]
[Serializable]
public readonly record struct EngineErrorCode : IStringEnum
{
    public static readonly EngineErrorCode Unknown = new(Values.Unknown);

    public static readonly EngineErrorCode InvalidArg = new(Values.InvalidArg);

    public static readonly EngineErrorCode DocNotOpen = new(Values.DocNotOpen);

    public static readonly EngineErrorCode DocOpenFailed = new(Values.DocOpenFailed);

    public static readonly EngineErrorCode DocPasswordRequired = new(Values.DocPasswordRequired);

    public static readonly EngineErrorCode DocPasswordIncorrect = new(Values.DocPasswordIncorrect);

    public static readonly EngineErrorCode GrantPassphraseRequired = new(
        Values.GrantPassphraseRequired
    );

    public static readonly EngineErrorCode Aborted = new(Values.Aborted);

    public static readonly EngineErrorCode Network = new(Values.Network);

    public static readonly EngineErrorCode Unauthenticated = new(Values.Unauthenticated);

    public static readonly EngineErrorCode Forbidden = new(Values.Forbidden);

    public static readonly EngineErrorCode NotFound = new(Values.NotFound);

    public static readonly EngineErrorCode WireFormat = new(Values.WireFormat);

    public static readonly EngineErrorCode RuntimeUnavailable = new(Values.RuntimeUnavailable);

    public static readonly EngineErrorCode LayerVersionConflict = new(Values.LayerVersionConflict);

    public static readonly EngineErrorCode NotImplemented = new(Values.NotImplemented);

    public static readonly EngineErrorCode MalformedPdf = new(Values.MalformedPdf);

    public static readonly EngineErrorCode SigningPending = new(Values.SigningPending);

    public static readonly EngineErrorCode SigningExpired = new(Values.SigningExpired);

    public static readonly EngineErrorCode SigningVersionMismatch = new(
        Values.SigningVersionMismatch
    );

    public static readonly EngineErrorCode SignatureRefused = new(Values.SignatureRefused);

    public static readonly EngineErrorCode ProtectedDocument = new(Values.ProtectedDocument);

    public static readonly EngineErrorCode PayloadTooLarge = new(Values.PayloadTooLarge);

    public static readonly EngineErrorCode ObjectNumberUnavailable = new(
        Values.ObjectNumberUnavailable
    );

    public static readonly EngineErrorCode LayerFull = new(Values.LayerFull);

    public static readonly EngineErrorCode ChangeConflict = new(Values.ChangeConflict);

    public static readonly EngineErrorCode UndoUnavailable = new(Values.UndoUnavailable);

    public static readonly EngineErrorCode IdempotencyKeyReused = new(Values.IdempotencyKeyReused);

    public static readonly EngineErrorCode LayerDeleted = new(Values.LayerDeleted);

    public static readonly EngineErrorCode VisitorIdentityRequired = new(
        Values.VisitorIdentityRequired
    );

    public static readonly EngineErrorCode Conflict = new(Values.Conflict);

    public static readonly EngineErrorCode EngineBusy = new(Values.EngineBusy);

    public static readonly EngineErrorCode EngineRestarting = new(Values.EngineRestarting);

    public static readonly EngineErrorCode DocumentQuarantined = new(Values.DocumentQuarantined);

    public static readonly EngineErrorCode ThumbnailNotReady = new(Values.ThumbnailNotReady);

    public static readonly EngineErrorCode TooManyRequests = new(Values.TooManyRequests);

    public static readonly EngineErrorCode GrantExpired = new(Values.GrantExpired);

    public static readonly EngineErrorCode OriginRequired = new(Values.OriginRequired);

    public static readonly EngineErrorCode OriginNotAllowed = new(Values.OriginNotAllowed);

    public static readonly EngineErrorCode FeatureNotEnabled = new(Values.FeatureNotEnabled);

    public static readonly EngineErrorCode FeatureStopped = new(Values.FeatureStopped);

    public static readonly EngineErrorCode LicenseInvalid = new(Values.LicenseInvalid);

    public static readonly EngineErrorCode LicenseUsageLimit = new(Values.LicenseUsageLimit);

    public static readonly EngineErrorCode UpstreamError = new(Values.UpstreamError);

    public EngineErrorCode(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static EngineErrorCode FromCustom(string value)
    {
        return new EngineErrorCode(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(EngineErrorCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EngineErrorCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EngineErrorCode value) => value.Value;

    public static explicit operator EngineErrorCode(string value) => new(value);

    internal class EngineErrorCodeSerializer : JsonConverter<EngineErrorCode>
    {
        public override EngineErrorCode Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON value could not be read as a string."
                );
            return new EngineErrorCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            EngineErrorCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override EngineErrorCode ReadAsPropertyName(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new global::System.Exception(
                    "The JSON property name could not be read as a string."
                );
            return new EngineErrorCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            EngineErrorCode value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Value);
        }
    }

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "Unknown";

        public const string InvalidArg = "InvalidArg";

        public const string DocNotOpen = "DocNotOpen";

        public const string DocOpenFailed = "DocOpenFailed";

        public const string DocPasswordRequired = "DocPasswordRequired";

        public const string DocPasswordIncorrect = "DocPasswordIncorrect";

        public const string GrantPassphraseRequired = "GrantPassphraseRequired";

        public const string Aborted = "Aborted";

        public const string Network = "Network";

        public const string Unauthenticated = "Unauthenticated";

        public const string Forbidden = "Forbidden";

        public const string NotFound = "NotFound";

        public const string WireFormat = "WireFormat";

        public const string RuntimeUnavailable = "RuntimeUnavailable";

        public const string LayerVersionConflict = "LayerVersionConflict";

        public const string NotImplemented = "NotImplemented";

        public const string MalformedPdf = "MalformedPdf";

        public const string SigningPending = "SigningPending";

        public const string SigningExpired = "SigningExpired";

        public const string SigningVersionMismatch = "SigningVersionMismatch";

        public const string SignatureRefused = "SignatureRefused";

        public const string ProtectedDocument = "ProtectedDocument";

        public const string PayloadTooLarge = "PayloadTooLarge";

        public const string ObjectNumberUnavailable = "ObjectNumberUnavailable";

        public const string LayerFull = "LayerFull";

        public const string ChangeConflict = "ChangeConflict";

        public const string UndoUnavailable = "UndoUnavailable";

        public const string IdempotencyKeyReused = "IdempotencyKeyReused";

        public const string LayerDeleted = "LayerDeleted";

        public const string VisitorIdentityRequired = "VisitorIdentityRequired";

        public const string Conflict = "Conflict";

        public const string EngineBusy = "EngineBusy";

        public const string EngineRestarting = "EngineRestarting";

        public const string DocumentQuarantined = "DocumentQuarantined";

        public const string ThumbnailNotReady = "ThumbnailNotReady";

        public const string TooManyRequests = "TooManyRequests";

        public const string GrantExpired = "GrantExpired";

        public const string OriginRequired = "OriginRequired";

        public const string OriginNotAllowed = "OriginNotAllowed";

        public const string FeatureNotEnabled = "FeatureNotEnabled";

        public const string FeatureStopped = "FeatureStopped";

        public const string LicenseInvalid = "LicenseInvalid";

        public const string LicenseUsageLimit = "LicenseUsageLimit";

        public const string UpstreamError = "UpstreamError";
    }
}
