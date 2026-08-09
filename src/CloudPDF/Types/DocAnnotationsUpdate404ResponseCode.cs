using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsUpdate404ResponseCode.DocAnnotationsUpdate404ResponseCodeSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsUpdate404ResponseCode : IStringEnum
{
    public static readonly DocAnnotationsUpdate404ResponseCode Unknown = new(Values.Unknown);

    public static readonly DocAnnotationsUpdate404ResponseCode InvalidArg = new(Values.InvalidArg);

    public static readonly DocAnnotationsUpdate404ResponseCode DocNotOpen = new(Values.DocNotOpen);

    public static readonly DocAnnotationsUpdate404ResponseCode DocOpenFailed = new(
        Values.DocOpenFailed
    );

    public static readonly DocAnnotationsUpdate404ResponseCode DocPasswordRequired = new(
        Values.DocPasswordRequired
    );

    public static readonly DocAnnotationsUpdate404ResponseCode DocPasswordIncorrect = new(
        Values.DocPasswordIncorrect
    );

    public static readonly DocAnnotationsUpdate404ResponseCode Aborted = new(Values.Aborted);

    public static readonly DocAnnotationsUpdate404ResponseCode Network = new(Values.Network);

    public static readonly DocAnnotationsUpdate404ResponseCode Unauthenticated = new(
        Values.Unauthenticated
    );

    public static readonly DocAnnotationsUpdate404ResponseCode Forbidden = new(Values.Forbidden);

    public static readonly DocAnnotationsUpdate404ResponseCode NotFound = new(Values.NotFound);

    public static readonly DocAnnotationsUpdate404ResponseCode WireFormat = new(Values.WireFormat);

    public static readonly DocAnnotationsUpdate404ResponseCode RuntimeUnavailable = new(
        Values.RuntimeUnavailable
    );

    public static readonly DocAnnotationsUpdate404ResponseCode InvalidReference = new(
        Values.InvalidReference
    );

    public static readonly DocAnnotationsUpdate404ResponseCode WeakAnnotationSessionConflict = new(
        Values.WeakAnnotationSessionConflict
    );

    public static readonly DocAnnotationsUpdate404ResponseCode LayerVersionConflict = new(
        Values.LayerVersionConflict
    );

    public static readonly DocAnnotationsUpdate404ResponseCode NotImplemented = new(
        Values.NotImplemented
    );

    public static readonly DocAnnotationsUpdate404ResponseCode MalformedPdf = new(
        Values.MalformedPdf
    );

    public DocAnnotationsUpdate404ResponseCode(string value)
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
    public static DocAnnotationsUpdate404ResponseCode FromCustom(string value)
    {
        return new DocAnnotationsUpdate404ResponseCode(value);
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

    public static bool operator ==(DocAnnotationsUpdate404ResponseCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocAnnotationsUpdate404ResponseCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocAnnotationsUpdate404ResponseCode value) =>
        value.Value;

    public static explicit operator DocAnnotationsUpdate404ResponseCode(string value) => new(value);

    internal class DocAnnotationsUpdate404ResponseCodeSerializer
        : JsonConverter<DocAnnotationsUpdate404ResponseCode>
    {
        public override DocAnnotationsUpdate404ResponseCode Read(
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
            return new DocAnnotationsUpdate404ResponseCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsUpdate404ResponseCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsUpdate404ResponseCode ReadAsPropertyName(
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
            return new DocAnnotationsUpdate404ResponseCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsUpdate404ResponseCode value,
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
