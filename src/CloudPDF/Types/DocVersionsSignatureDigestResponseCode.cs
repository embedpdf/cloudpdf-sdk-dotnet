using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocVersionsSignatureDigestResponseCode.DocVersionsSignatureDigestResponseCodeSerializer)
)]
[Serializable]
public readonly record struct DocVersionsSignatureDigestResponseCode : IStringEnum
{
    public static readonly DocVersionsSignatureDigestResponseCode Unknown = new(Values.Unknown);

    public static readonly DocVersionsSignatureDigestResponseCode InvalidArg = new(
        Values.InvalidArg
    );

    public static readonly DocVersionsSignatureDigestResponseCode DocNotOpen = new(
        Values.DocNotOpen
    );

    public static readonly DocVersionsSignatureDigestResponseCode DocOpenFailed = new(
        Values.DocOpenFailed
    );

    public static readonly DocVersionsSignatureDigestResponseCode DocPasswordRequired = new(
        Values.DocPasswordRequired
    );

    public static readonly DocVersionsSignatureDigestResponseCode DocPasswordIncorrect = new(
        Values.DocPasswordIncorrect
    );

    public static readonly DocVersionsSignatureDigestResponseCode SharePasswordRequired = new(
        Values.SharePasswordRequired
    );

    public static readonly DocVersionsSignatureDigestResponseCode Aborted = new(Values.Aborted);

    public static readonly DocVersionsSignatureDigestResponseCode Network = new(Values.Network);

    public static readonly DocVersionsSignatureDigestResponseCode Unauthenticated = new(
        Values.Unauthenticated
    );

    public static readonly DocVersionsSignatureDigestResponseCode Forbidden = new(Values.Forbidden);

    public static readonly DocVersionsSignatureDigestResponseCode NotFound = new(Values.NotFound);

    public static readonly DocVersionsSignatureDigestResponseCode WireFormat = new(
        Values.WireFormat
    );

    public static readonly DocVersionsSignatureDigestResponseCode RuntimeUnavailable = new(
        Values.RuntimeUnavailable
    );

    public static readonly DocVersionsSignatureDigestResponseCode InvalidReference = new(
        Values.InvalidReference
    );

    public static readonly DocVersionsSignatureDigestResponseCode WeakAnnotationSessionConflict =
        new(Values.WeakAnnotationSessionConflict);

    public static readonly DocVersionsSignatureDigestResponseCode LayerVersionConflict = new(
        Values.LayerVersionConflict
    );

    public static readonly DocVersionsSignatureDigestResponseCode NotImplemented = new(
        Values.NotImplemented
    );

    public static readonly DocVersionsSignatureDigestResponseCode MalformedPdf = new(
        Values.MalformedPdf
    );

    public static readonly DocVersionsSignatureDigestResponseCode SigningPending = new(
        Values.SigningPending
    );

    public static readonly DocVersionsSignatureDigestResponseCode SigningExpired = new(
        Values.SigningExpired
    );

    public static readonly DocVersionsSignatureDigestResponseCode SigningVersionMismatch = new(
        Values.SigningVersionMismatch
    );

    public static readonly DocVersionsSignatureDigestResponseCode SignatureRefused = new(
        Values.SignatureRefused
    );

    public static readonly DocVersionsSignatureDigestResponseCode ProtectedDocument = new(
        Values.ProtectedDocument
    );

    public static readonly DocVersionsSignatureDigestResponseCode StaleBase = new(Values.StaleBase);

    public DocVersionsSignatureDigestResponseCode(string value)
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
    public static DocVersionsSignatureDigestResponseCode FromCustom(string value)
    {
        return new DocVersionsSignatureDigestResponseCode(value);
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

    public static bool operator ==(DocVersionsSignatureDigestResponseCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocVersionsSignatureDigestResponseCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocVersionsSignatureDigestResponseCode value) =>
        value.Value;

    public static explicit operator DocVersionsSignatureDigestResponseCode(string value) =>
        new(value);

    internal class DocVersionsSignatureDigestResponseCodeSerializer
        : JsonConverter<DocVersionsSignatureDigestResponseCode>
    {
        public override DocVersionsSignatureDigestResponseCode Read(
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
            return new DocVersionsSignatureDigestResponseCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsSignatureDigestResponseCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsSignatureDigestResponseCode ReadAsPropertyName(
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
            return new DocVersionsSignatureDigestResponseCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsSignatureDigestResponseCode value,
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

        public const string SharePasswordRequired = "SharePasswordRequired";

        public const string Aborted = "Aborted";

        public const string Network = "Network";

        public const string Unauthenticated = "Unauthenticated";

        public const string Forbidden = "Forbidden";

        public const string NotFound = "NotFound";

        public const string WireFormat = "WireFormat";

        public const string RuntimeUnavailable = "RuntimeUnavailable";

        public const string InvalidReference = "InvalidReference";

        public const string WeakAnnotationSessionConflict = "WeakAnnotationSessionConflict";

        public const string LayerVersionConflict = "LayerVersionConflict";

        public const string NotImplemented = "NotImplemented";

        public const string MalformedPdf = "MalformedPdf";

        public const string SigningPending = "SigningPending";

        public const string SigningExpired = "SigningExpired";

        public const string SigningVersionMismatch = "SigningVersionMismatch";

        public const string SignatureRefused = "SignatureRefused";

        public const string ProtectedDocument = "ProtectedDocument";

        public const string StaleBase = "StaleBase";
    }
}
