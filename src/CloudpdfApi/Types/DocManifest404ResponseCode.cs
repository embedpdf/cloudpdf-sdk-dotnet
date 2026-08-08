using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(typeof(DocManifest404ResponseCode.DocManifest404ResponseCodeSerializer))]
[Serializable]
public readonly record struct DocManifest404ResponseCode : IStringEnum
{
    public static readonly DocManifest404ResponseCode Unknown = new(Values.Unknown);

    public static readonly DocManifest404ResponseCode InvalidArg = new(Values.InvalidArg);

    public static readonly DocManifest404ResponseCode DocNotOpen = new(Values.DocNotOpen);

    public static readonly DocManifest404ResponseCode DocOpenFailed = new(Values.DocOpenFailed);

    public static readonly DocManifest404ResponseCode DocPasswordRequired = new(
        Values.DocPasswordRequired
    );

    public static readonly DocManifest404ResponseCode DocPasswordIncorrect = new(
        Values.DocPasswordIncorrect
    );

    public static readonly DocManifest404ResponseCode Aborted = new(Values.Aborted);

    public static readonly DocManifest404ResponseCode Network = new(Values.Network);

    public static readonly DocManifest404ResponseCode Unauthenticated = new(Values.Unauthenticated);

    public static readonly DocManifest404ResponseCode Forbidden = new(Values.Forbidden);

    public static readonly DocManifest404ResponseCode NotFound = new(Values.NotFound);

    public static readonly DocManifest404ResponseCode WireFormat = new(Values.WireFormat);

    public static readonly DocManifest404ResponseCode RuntimeUnavailable = new(
        Values.RuntimeUnavailable
    );

    public static readonly DocManifest404ResponseCode InvalidReference = new(
        Values.InvalidReference
    );

    public static readonly DocManifest404ResponseCode WeakAnnotationSessionConflict = new(
        Values.WeakAnnotationSessionConflict
    );

    public static readonly DocManifest404ResponseCode LayerVersionConflict = new(
        Values.LayerVersionConflict
    );

    public static readonly DocManifest404ResponseCode NotImplemented = new(Values.NotImplemented);

    public static readonly DocManifest404ResponseCode MalformedPdf = new(Values.MalformedPdf);

    public DocManifest404ResponseCode(string value)
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
    public static DocManifest404ResponseCode FromCustom(string value)
    {
        return new DocManifest404ResponseCode(value);
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

    public static bool operator ==(DocManifest404ResponseCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocManifest404ResponseCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocManifest404ResponseCode value) => value.Value;

    public static explicit operator DocManifest404ResponseCode(string value) => new(value);

    internal class DocManifest404ResponseCodeSerializer : JsonConverter<DocManifest404ResponseCode>
    {
        public override DocManifest404ResponseCode Read(
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
            return new DocManifest404ResponseCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocManifest404ResponseCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocManifest404ResponseCode ReadAsPropertyName(
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
            return new DocManifest404ResponseCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocManifest404ResponseCode value,
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
