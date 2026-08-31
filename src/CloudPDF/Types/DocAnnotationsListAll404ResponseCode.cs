using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsListAll404ResponseCode.DocAnnotationsListAll404ResponseCodeSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsListAll404ResponseCode : IStringEnum
{
    public static readonly DocAnnotationsListAll404ResponseCode Unknown = new(Values.Unknown);

    public static readonly DocAnnotationsListAll404ResponseCode InvalidArg = new(Values.InvalidArg);

    public static readonly DocAnnotationsListAll404ResponseCode DocNotOpen = new(Values.DocNotOpen);

    public static readonly DocAnnotationsListAll404ResponseCode DocOpenFailed = new(
        Values.DocOpenFailed
    );

    public static readonly DocAnnotationsListAll404ResponseCode DocPasswordRequired = new(
        Values.DocPasswordRequired
    );

    public static readonly DocAnnotationsListAll404ResponseCode DocPasswordIncorrect = new(
        Values.DocPasswordIncorrect
    );

    public static readonly DocAnnotationsListAll404ResponseCode SharePasswordRequired = new(
        Values.SharePasswordRequired
    );

    public static readonly DocAnnotationsListAll404ResponseCode Aborted = new(Values.Aborted);

    public static readonly DocAnnotationsListAll404ResponseCode Network = new(Values.Network);

    public static readonly DocAnnotationsListAll404ResponseCode Unauthenticated = new(
        Values.Unauthenticated
    );

    public static readonly DocAnnotationsListAll404ResponseCode Forbidden = new(Values.Forbidden);

    public static readonly DocAnnotationsListAll404ResponseCode NotFound = new(Values.NotFound);

    public static readonly DocAnnotationsListAll404ResponseCode WireFormat = new(Values.WireFormat);

    public static readonly DocAnnotationsListAll404ResponseCode RuntimeUnavailable = new(
        Values.RuntimeUnavailable
    );

    public static readonly DocAnnotationsListAll404ResponseCode InvalidReference = new(
        Values.InvalidReference
    );

    public static readonly DocAnnotationsListAll404ResponseCode WeakAnnotationSessionConflict = new(
        Values.WeakAnnotationSessionConflict
    );

    public static readonly DocAnnotationsListAll404ResponseCode LayerVersionConflict = new(
        Values.LayerVersionConflict
    );

    public static readonly DocAnnotationsListAll404ResponseCode NotImplemented = new(
        Values.NotImplemented
    );

    public static readonly DocAnnotationsListAll404ResponseCode MalformedPdf = new(
        Values.MalformedPdf
    );

    public DocAnnotationsListAll404ResponseCode(string value)
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
    public static DocAnnotationsListAll404ResponseCode FromCustom(string value)
    {
        return new DocAnnotationsListAll404ResponseCode(value);
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

    public static bool operator ==(DocAnnotationsListAll404ResponseCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocAnnotationsListAll404ResponseCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocAnnotationsListAll404ResponseCode value) =>
        value.Value;

    public static explicit operator DocAnnotationsListAll404ResponseCode(string value) =>
        new(value);

    internal class DocAnnotationsListAll404ResponseCodeSerializer
        : JsonConverter<DocAnnotationsListAll404ResponseCode>
    {
        public override DocAnnotationsListAll404ResponseCode Read(
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
            return new DocAnnotationsListAll404ResponseCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll404ResponseCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsListAll404ResponseCode ReadAsPropertyName(
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
            return new DocAnnotationsListAll404ResponseCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll404ResponseCode value,
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
    }
}
