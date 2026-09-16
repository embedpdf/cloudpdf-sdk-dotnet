using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocVersionsRevisionResponseCode.DocVersionsRevisionResponseCodeSerializer))]
[Serializable]
public readonly record struct DocVersionsRevisionResponseCode : IStringEnum
{
    public static readonly DocVersionsRevisionResponseCode Unknown = new(Values.Unknown);

    public static readonly DocVersionsRevisionResponseCode InvalidArg = new(Values.InvalidArg);

    public static readonly DocVersionsRevisionResponseCode DocNotOpen = new(Values.DocNotOpen);

    public static readonly DocVersionsRevisionResponseCode DocOpenFailed = new(
        Values.DocOpenFailed
    );

    public static readonly DocVersionsRevisionResponseCode DocPasswordRequired = new(
        Values.DocPasswordRequired
    );

    public static readonly DocVersionsRevisionResponseCode DocPasswordIncorrect = new(
        Values.DocPasswordIncorrect
    );

    public static readonly DocVersionsRevisionResponseCode SharePasswordRequired = new(
        Values.SharePasswordRequired
    );

    public static readonly DocVersionsRevisionResponseCode Aborted = new(Values.Aborted);

    public static readonly DocVersionsRevisionResponseCode Network = new(Values.Network);

    public static readonly DocVersionsRevisionResponseCode Unauthenticated = new(
        Values.Unauthenticated
    );

    public static readonly DocVersionsRevisionResponseCode Forbidden = new(Values.Forbidden);

    public static readonly DocVersionsRevisionResponseCode NotFound = new(Values.NotFound);

    public static readonly DocVersionsRevisionResponseCode WireFormat = new(Values.WireFormat);

    public static readonly DocVersionsRevisionResponseCode RuntimeUnavailable = new(
        Values.RuntimeUnavailable
    );

    public static readonly DocVersionsRevisionResponseCode InvalidReference = new(
        Values.InvalidReference
    );

    public static readonly DocVersionsRevisionResponseCode WeakAnnotationSessionConflict = new(
        Values.WeakAnnotationSessionConflict
    );

    public static readonly DocVersionsRevisionResponseCode LayerVersionConflict = new(
        Values.LayerVersionConflict
    );

    public static readonly DocVersionsRevisionResponseCode NotImplemented = new(
        Values.NotImplemented
    );

    public static readonly DocVersionsRevisionResponseCode MalformedPdf = new(Values.MalformedPdf);

    public static readonly DocVersionsRevisionResponseCode SigningPending = new(
        Values.SigningPending
    );

    public static readonly DocVersionsRevisionResponseCode SigningExpired = new(
        Values.SigningExpired
    );

    public static readonly DocVersionsRevisionResponseCode SigningVersionMismatch = new(
        Values.SigningVersionMismatch
    );

    public static readonly DocVersionsRevisionResponseCode SignatureRefused = new(
        Values.SignatureRefused
    );

    public static readonly DocVersionsRevisionResponseCode ProtectedDocument = new(
        Values.ProtectedDocument
    );

    public static readonly DocVersionsRevisionResponseCode StaleBase = new(Values.StaleBase);

    public DocVersionsRevisionResponseCode(string value)
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
    public static DocVersionsRevisionResponseCode FromCustom(string value)
    {
        return new DocVersionsRevisionResponseCode(value);
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

    public static bool operator ==(DocVersionsRevisionResponseCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocVersionsRevisionResponseCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocVersionsRevisionResponseCode value) => value.Value;

    public static explicit operator DocVersionsRevisionResponseCode(string value) => new(value);

    internal class DocVersionsRevisionResponseCodeSerializer
        : JsonConverter<DocVersionsRevisionResponseCode>
    {
        public override DocVersionsRevisionResponseCode Read(
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
            return new DocVersionsRevisionResponseCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsRevisionResponseCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsRevisionResponseCode ReadAsPropertyName(
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
            return new DocVersionsRevisionResponseCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsRevisionResponseCode value,
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
