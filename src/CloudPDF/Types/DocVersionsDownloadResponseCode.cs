using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocVersionsDownloadResponseCode.DocVersionsDownloadResponseCodeSerializer))]
[Serializable]
public readonly record struct DocVersionsDownloadResponseCode : IStringEnum
{
    public static readonly DocVersionsDownloadResponseCode Unknown = new(Values.Unknown);

    public static readonly DocVersionsDownloadResponseCode InvalidArg = new(Values.InvalidArg);

    public static readonly DocVersionsDownloadResponseCode DocNotOpen = new(Values.DocNotOpen);

    public static readonly DocVersionsDownloadResponseCode DocOpenFailed = new(
        Values.DocOpenFailed
    );

    public static readonly DocVersionsDownloadResponseCode DocPasswordRequired = new(
        Values.DocPasswordRequired
    );

    public static readonly DocVersionsDownloadResponseCode DocPasswordIncorrect = new(
        Values.DocPasswordIncorrect
    );

    public static readonly DocVersionsDownloadResponseCode SharePasswordRequired = new(
        Values.SharePasswordRequired
    );

    public static readonly DocVersionsDownloadResponseCode Aborted = new(Values.Aborted);

    public static readonly DocVersionsDownloadResponseCode Network = new(Values.Network);

    public static readonly DocVersionsDownloadResponseCode Unauthenticated = new(
        Values.Unauthenticated
    );

    public static readonly DocVersionsDownloadResponseCode Forbidden = new(Values.Forbidden);

    public static readonly DocVersionsDownloadResponseCode NotFound = new(Values.NotFound);

    public static readonly DocVersionsDownloadResponseCode WireFormat = new(Values.WireFormat);

    public static readonly DocVersionsDownloadResponseCode RuntimeUnavailable = new(
        Values.RuntimeUnavailable
    );

    public static readonly DocVersionsDownloadResponseCode InvalidReference = new(
        Values.InvalidReference
    );

    public static readonly DocVersionsDownloadResponseCode WeakAnnotationSessionConflict = new(
        Values.WeakAnnotationSessionConflict
    );

    public static readonly DocVersionsDownloadResponseCode LayerVersionConflict = new(
        Values.LayerVersionConflict
    );

    public static readonly DocVersionsDownloadResponseCode NotImplemented = new(
        Values.NotImplemented
    );

    public static readonly DocVersionsDownloadResponseCode MalformedPdf = new(Values.MalformedPdf);

    public static readonly DocVersionsDownloadResponseCode SigningPending = new(
        Values.SigningPending
    );

    public static readonly DocVersionsDownloadResponseCode SigningExpired = new(
        Values.SigningExpired
    );

    public static readonly DocVersionsDownloadResponseCode SigningVersionMismatch = new(
        Values.SigningVersionMismatch
    );

    public static readonly DocVersionsDownloadResponseCode SignatureRefused = new(
        Values.SignatureRefused
    );

    public static readonly DocVersionsDownloadResponseCode ProtectedDocument = new(
        Values.ProtectedDocument
    );

    public static readonly DocVersionsDownloadResponseCode StaleBase = new(Values.StaleBase);

    public DocVersionsDownloadResponseCode(string value)
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
    public static DocVersionsDownloadResponseCode FromCustom(string value)
    {
        return new DocVersionsDownloadResponseCode(value);
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

    public static bool operator ==(DocVersionsDownloadResponseCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocVersionsDownloadResponseCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocVersionsDownloadResponseCode value) => value.Value;

    public static explicit operator DocVersionsDownloadResponseCode(string value) => new(value);

    internal class DocVersionsDownloadResponseCodeSerializer
        : JsonConverter<DocVersionsDownloadResponseCode>
    {
        public override DocVersionsDownloadResponseCode Read(
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
            return new DocVersionsDownloadResponseCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsDownloadResponseCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsDownloadResponseCode ReadAsPropertyName(
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
            return new DocVersionsDownloadResponseCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsDownloadResponseCode value,
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
