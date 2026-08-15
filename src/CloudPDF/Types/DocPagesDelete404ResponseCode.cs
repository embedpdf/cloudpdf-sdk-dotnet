using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocPagesDelete404ResponseCode.DocPagesDelete404ResponseCodeSerializer))]
[Serializable]
public readonly record struct DocPagesDelete404ResponseCode : IStringEnum
{
    public static readonly DocPagesDelete404ResponseCode Unknown = new(Values.Unknown);

    public static readonly DocPagesDelete404ResponseCode InvalidArg = new(Values.InvalidArg);

    public static readonly DocPagesDelete404ResponseCode DocNotOpen = new(Values.DocNotOpen);

    public static readonly DocPagesDelete404ResponseCode DocOpenFailed = new(Values.DocOpenFailed);

    public static readonly DocPagesDelete404ResponseCode DocPasswordRequired = new(
        Values.DocPasswordRequired
    );

    public static readonly DocPagesDelete404ResponseCode DocPasswordIncorrect = new(
        Values.DocPasswordIncorrect
    );

    public static readonly DocPagesDelete404ResponseCode SharePasswordRequired = new(
        Values.SharePasswordRequired
    );

    public static readonly DocPagesDelete404ResponseCode Aborted = new(Values.Aborted);

    public static readonly DocPagesDelete404ResponseCode Network = new(Values.Network);

    public static readonly DocPagesDelete404ResponseCode Unauthenticated = new(
        Values.Unauthenticated
    );

    public static readonly DocPagesDelete404ResponseCode Forbidden = new(Values.Forbidden);

    public static readonly DocPagesDelete404ResponseCode NotFound = new(Values.NotFound);

    public static readonly DocPagesDelete404ResponseCode WireFormat = new(Values.WireFormat);

    public static readonly DocPagesDelete404ResponseCode RuntimeUnavailable = new(
        Values.RuntimeUnavailable
    );

    public static readonly DocPagesDelete404ResponseCode InvalidReference = new(
        Values.InvalidReference
    );

    public static readonly DocPagesDelete404ResponseCode WeakAnnotationSessionConflict = new(
        Values.WeakAnnotationSessionConflict
    );

    public static readonly DocPagesDelete404ResponseCode LayerVersionConflict = new(
        Values.LayerVersionConflict
    );

    public static readonly DocPagesDelete404ResponseCode NotImplemented = new(
        Values.NotImplemented
    );

    public static readonly DocPagesDelete404ResponseCode MalformedPdf = new(Values.MalformedPdf);

    public DocPagesDelete404ResponseCode(string value)
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
    public static DocPagesDelete404ResponseCode FromCustom(string value)
    {
        return new DocPagesDelete404ResponseCode(value);
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

    public static bool operator ==(DocPagesDelete404ResponseCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocPagesDelete404ResponseCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocPagesDelete404ResponseCode value) => value.Value;

    public static explicit operator DocPagesDelete404ResponseCode(string value) => new(value);

    internal class DocPagesDelete404ResponseCodeSerializer
        : JsonConverter<DocPagesDelete404ResponseCode>
    {
        public override DocPagesDelete404ResponseCode Read(
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
            return new DocPagesDelete404ResponseCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesDelete404ResponseCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesDelete404ResponseCode ReadAsPropertyName(
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
            return new DocPagesDelete404ResponseCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesDelete404ResponseCode value,
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
