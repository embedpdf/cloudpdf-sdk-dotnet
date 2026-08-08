using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(typeof(DocDownloadResponseCode.DocDownloadResponseCodeSerializer))]
[Serializable]
public readonly record struct DocDownloadResponseCode : IStringEnum
{
    public static readonly DocDownloadResponseCode Unknown = new(Values.Unknown);

    public static readonly DocDownloadResponseCode InvalidArg = new(Values.InvalidArg);

    public static readonly DocDownloadResponseCode DocNotOpen = new(Values.DocNotOpen);

    public static readonly DocDownloadResponseCode DocOpenFailed = new(Values.DocOpenFailed);

    public static readonly DocDownloadResponseCode DocPasswordRequired = new(
        Values.DocPasswordRequired
    );

    public static readonly DocDownloadResponseCode DocPasswordIncorrect = new(
        Values.DocPasswordIncorrect
    );

    public static readonly DocDownloadResponseCode Aborted = new(Values.Aborted);

    public static readonly DocDownloadResponseCode Network = new(Values.Network);

    public static readonly DocDownloadResponseCode Unauthenticated = new(Values.Unauthenticated);

    public static readonly DocDownloadResponseCode Forbidden = new(Values.Forbidden);

    public static readonly DocDownloadResponseCode NotFound = new(Values.NotFound);

    public static readonly DocDownloadResponseCode WireFormat = new(Values.WireFormat);

    public static readonly DocDownloadResponseCode RuntimeUnavailable = new(
        Values.RuntimeUnavailable
    );

    public static readonly DocDownloadResponseCode InvalidReference = new(Values.InvalidReference);

    public static readonly DocDownloadResponseCode WeakAnnotationSessionConflict = new(
        Values.WeakAnnotationSessionConflict
    );

    public static readonly DocDownloadResponseCode LayerVersionConflict = new(
        Values.LayerVersionConflict
    );

    public static readonly DocDownloadResponseCode NotImplemented = new(Values.NotImplemented);

    public static readonly DocDownloadResponseCode MalformedPdf = new(Values.MalformedPdf);

    public DocDownloadResponseCode(string value)
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
    public static DocDownloadResponseCode FromCustom(string value)
    {
        return new DocDownloadResponseCode(value);
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

    public static bool operator ==(DocDownloadResponseCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocDownloadResponseCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocDownloadResponseCode value) => value.Value;

    public static explicit operator DocDownloadResponseCode(string value) => new(value);

    internal class DocDownloadResponseCodeSerializer : JsonConverter<DocDownloadResponseCode>
    {
        public override DocDownloadResponseCode Read(
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
            return new DocDownloadResponseCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocDownloadResponseCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocDownloadResponseCode ReadAsPropertyName(
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
            return new DocDownloadResponseCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocDownloadResponseCode value,
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
    }
}
