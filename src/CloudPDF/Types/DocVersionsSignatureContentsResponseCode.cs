using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocVersionsSignatureContentsResponseCode.DocVersionsSignatureContentsResponseCodeSerializer)
)]
[Serializable]
public readonly record struct DocVersionsSignatureContentsResponseCode : IStringEnum
{
    public static readonly DocVersionsSignatureContentsResponseCode Unknown = new(Values.Unknown);

    public static readonly DocVersionsSignatureContentsResponseCode InvalidArg = new(
        Values.InvalidArg
    );

    public static readonly DocVersionsSignatureContentsResponseCode DocNotOpen = new(
        Values.DocNotOpen
    );

    public static readonly DocVersionsSignatureContentsResponseCode DocOpenFailed = new(
        Values.DocOpenFailed
    );

    public static readonly DocVersionsSignatureContentsResponseCode DocPasswordRequired = new(
        Values.DocPasswordRequired
    );

    public static readonly DocVersionsSignatureContentsResponseCode DocPasswordIncorrect = new(
        Values.DocPasswordIncorrect
    );

    public static readonly DocVersionsSignatureContentsResponseCode SharePasswordRequired = new(
        Values.SharePasswordRequired
    );

    public static readonly DocVersionsSignatureContentsResponseCode Aborted = new(Values.Aborted);

    public static readonly DocVersionsSignatureContentsResponseCode Network = new(Values.Network);

    public static readonly DocVersionsSignatureContentsResponseCode Unauthenticated = new(
        Values.Unauthenticated
    );

    public static readonly DocVersionsSignatureContentsResponseCode Forbidden = new(
        Values.Forbidden
    );

    public static readonly DocVersionsSignatureContentsResponseCode NotFound = new(Values.NotFound);

    public static readonly DocVersionsSignatureContentsResponseCode WireFormat = new(
        Values.WireFormat
    );

    public static readonly DocVersionsSignatureContentsResponseCode RuntimeUnavailable = new(
        Values.RuntimeUnavailable
    );

    public static readonly DocVersionsSignatureContentsResponseCode InvalidReference = new(
        Values.InvalidReference
    );

    public static readonly DocVersionsSignatureContentsResponseCode WeakAnnotationSessionConflict =
        new(Values.WeakAnnotationSessionConflict);

    public static readonly DocVersionsSignatureContentsResponseCode LayerVersionConflict = new(
        Values.LayerVersionConflict
    );

    public static readonly DocVersionsSignatureContentsResponseCode NotImplemented = new(
        Values.NotImplemented
    );

    public static readonly DocVersionsSignatureContentsResponseCode MalformedPdf = new(
        Values.MalformedPdf
    );

    public static readonly DocVersionsSignatureContentsResponseCode SigningPending = new(
        Values.SigningPending
    );

    public static readonly DocVersionsSignatureContentsResponseCode SigningExpired = new(
        Values.SigningExpired
    );

    public static readonly DocVersionsSignatureContentsResponseCode SigningVersionMismatch = new(
        Values.SigningVersionMismatch
    );

    public static readonly DocVersionsSignatureContentsResponseCode SignatureRefused = new(
        Values.SignatureRefused
    );

    public static readonly DocVersionsSignatureContentsResponseCode ProtectedDocument = new(
        Values.ProtectedDocument
    );

    public static readonly DocVersionsSignatureContentsResponseCode StaleBase = new(
        Values.StaleBase
    );

    public DocVersionsSignatureContentsResponseCode(string value)
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
    public static DocVersionsSignatureContentsResponseCode FromCustom(string value)
    {
        return new DocVersionsSignatureContentsResponseCode(value);
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

    public static bool operator ==(
        DocVersionsSignatureContentsResponseCode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocVersionsSignatureContentsResponseCode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocVersionsSignatureContentsResponseCode value) =>
        value.Value;

    public static explicit operator DocVersionsSignatureContentsResponseCode(string value) =>
        new(value);

    internal class DocVersionsSignatureContentsResponseCodeSerializer
        : JsonConverter<DocVersionsSignatureContentsResponseCode>
    {
        public override DocVersionsSignatureContentsResponseCode Read(
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
            return new DocVersionsSignatureContentsResponseCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsSignatureContentsResponseCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsSignatureContentsResponseCode ReadAsPropertyName(
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
            return new DocVersionsSignatureContentsResponseCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsSignatureContentsResponseCode value,
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
