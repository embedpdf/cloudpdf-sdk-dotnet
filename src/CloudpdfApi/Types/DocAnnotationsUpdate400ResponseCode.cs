using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocAnnotationsUpdate400ResponseCode.DocAnnotationsUpdate400ResponseCodeSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsUpdate400ResponseCode : IStringEnum
{
    public static readonly DocAnnotationsUpdate400ResponseCode Unknown = new(Values.Unknown);

    public static readonly DocAnnotationsUpdate400ResponseCode InvalidArg = new(Values.InvalidArg);

    public static readonly DocAnnotationsUpdate400ResponseCode DocNotOpen = new(Values.DocNotOpen);

    public static readonly DocAnnotationsUpdate400ResponseCode DocOpenFailed = new(
        Values.DocOpenFailed
    );

    public static readonly DocAnnotationsUpdate400ResponseCode DocPasswordRequired = new(
        Values.DocPasswordRequired
    );

    public static readonly DocAnnotationsUpdate400ResponseCode DocPasswordIncorrect = new(
        Values.DocPasswordIncorrect
    );

    public static readonly DocAnnotationsUpdate400ResponseCode Aborted = new(Values.Aborted);

    public static readonly DocAnnotationsUpdate400ResponseCode Network = new(Values.Network);

    public static readonly DocAnnotationsUpdate400ResponseCode Unauthenticated = new(
        Values.Unauthenticated
    );

    public static readonly DocAnnotationsUpdate400ResponseCode Forbidden = new(Values.Forbidden);

    public static readonly DocAnnotationsUpdate400ResponseCode NotFound = new(Values.NotFound);

    public static readonly DocAnnotationsUpdate400ResponseCode WireFormat = new(Values.WireFormat);

    public static readonly DocAnnotationsUpdate400ResponseCode RuntimeUnavailable = new(
        Values.RuntimeUnavailable
    );

    public static readonly DocAnnotationsUpdate400ResponseCode InvalidReference = new(
        Values.InvalidReference
    );

    public static readonly DocAnnotationsUpdate400ResponseCode WeakAnnotationSessionConflict = new(
        Values.WeakAnnotationSessionConflict
    );

    public static readonly DocAnnotationsUpdate400ResponseCode LayerVersionConflict = new(
        Values.LayerVersionConflict
    );

    public static readonly DocAnnotationsUpdate400ResponseCode NotImplemented = new(
        Values.NotImplemented
    );

    public static readonly DocAnnotationsUpdate400ResponseCode MalformedPdf = new(
        Values.MalformedPdf
    );

    public DocAnnotationsUpdate400ResponseCode(string value)
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
    public static DocAnnotationsUpdate400ResponseCode FromCustom(string value)
    {
        return new DocAnnotationsUpdate400ResponseCode(value);
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

    public static bool operator ==(DocAnnotationsUpdate400ResponseCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocAnnotationsUpdate400ResponseCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocAnnotationsUpdate400ResponseCode value) =>
        value.Value;

    public static explicit operator DocAnnotationsUpdate400ResponseCode(string value) => new(value);

    internal class DocAnnotationsUpdate400ResponseCodeSerializer
        : JsonConverter<DocAnnotationsUpdate400ResponseCode>
    {
        public override DocAnnotationsUpdate400ResponseCode Read(
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
            return new DocAnnotationsUpdate400ResponseCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsUpdate400ResponseCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsUpdate400ResponseCode ReadAsPropertyName(
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
            return new DocAnnotationsUpdate400ResponseCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsUpdate400ResponseCode value,
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
