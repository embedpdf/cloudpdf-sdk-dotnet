using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocPagesSetName400ResponseCode.DocPagesSetName400ResponseCodeSerializer))]
[Serializable]
public readonly record struct DocPagesSetName400ResponseCode : IStringEnum
{
    public static readonly DocPagesSetName400ResponseCode Unknown = new(Values.Unknown);

    public static readonly DocPagesSetName400ResponseCode InvalidArg = new(Values.InvalidArg);

    public static readonly DocPagesSetName400ResponseCode DocNotOpen = new(Values.DocNotOpen);

    public static readonly DocPagesSetName400ResponseCode DocOpenFailed = new(Values.DocOpenFailed);

    public static readonly DocPagesSetName400ResponseCode DocPasswordRequired = new(
        Values.DocPasswordRequired
    );

    public static readonly DocPagesSetName400ResponseCode DocPasswordIncorrect = new(
        Values.DocPasswordIncorrect
    );

    public static readonly DocPagesSetName400ResponseCode SharePasswordRequired = new(
        Values.SharePasswordRequired
    );

    public static readonly DocPagesSetName400ResponseCode Aborted = new(Values.Aborted);

    public static readonly DocPagesSetName400ResponseCode Network = new(Values.Network);

    public static readonly DocPagesSetName400ResponseCode Unauthenticated = new(
        Values.Unauthenticated
    );

    public static readonly DocPagesSetName400ResponseCode Forbidden = new(Values.Forbidden);

    public static readonly DocPagesSetName400ResponseCode NotFound = new(Values.NotFound);

    public static readonly DocPagesSetName400ResponseCode WireFormat = new(Values.WireFormat);

    public static readonly DocPagesSetName400ResponseCode RuntimeUnavailable = new(
        Values.RuntimeUnavailable
    );

    public static readonly DocPagesSetName400ResponseCode InvalidReference = new(
        Values.InvalidReference
    );

    public static readonly DocPagesSetName400ResponseCode WeakAnnotationSessionConflict = new(
        Values.WeakAnnotationSessionConflict
    );

    public static readonly DocPagesSetName400ResponseCode LayerVersionConflict = new(
        Values.LayerVersionConflict
    );

    public static readonly DocPagesSetName400ResponseCode NotImplemented = new(
        Values.NotImplemented
    );

    public static readonly DocPagesSetName400ResponseCode MalformedPdf = new(Values.MalformedPdf);

    public DocPagesSetName400ResponseCode(string value)
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
    public static DocPagesSetName400ResponseCode FromCustom(string value)
    {
        return new DocPagesSetName400ResponseCode(value);
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

    public static bool operator ==(DocPagesSetName400ResponseCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocPagesSetName400ResponseCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocPagesSetName400ResponseCode value) => value.Value;

    public static explicit operator DocPagesSetName400ResponseCode(string value) => new(value);

    internal class DocPagesSetName400ResponseCodeSerializer
        : JsonConverter<DocPagesSetName400ResponseCode>
    {
        public override DocPagesSetName400ResponseCode Read(
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
            return new DocPagesSetName400ResponseCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesSetName400ResponseCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesSetName400ResponseCode ReadAsPropertyName(
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
            return new DocPagesSetName400ResponseCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesSetName400ResponseCode value,
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
