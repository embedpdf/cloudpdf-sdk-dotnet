using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocRenderResponseCode.DocRenderResponseCodeSerializer))]
[Serializable]
public readonly record struct DocRenderResponseCode : IStringEnum
{
    public static readonly DocRenderResponseCode Unknown = new(Values.Unknown);

    public static readonly DocRenderResponseCode InvalidArg = new(Values.InvalidArg);

    public static readonly DocRenderResponseCode DocNotOpen = new(Values.DocNotOpen);

    public static readonly DocRenderResponseCode DocOpenFailed = new(Values.DocOpenFailed);

    public static readonly DocRenderResponseCode DocPasswordRequired = new(
        Values.DocPasswordRequired
    );

    public static readonly DocRenderResponseCode DocPasswordIncorrect = new(
        Values.DocPasswordIncorrect
    );

    public static readonly DocRenderResponseCode SharePasswordRequired = new(
        Values.SharePasswordRequired
    );

    public static readonly DocRenderResponseCode Aborted = new(Values.Aborted);

    public static readonly DocRenderResponseCode Network = new(Values.Network);

    public static readonly DocRenderResponseCode Unauthenticated = new(Values.Unauthenticated);

    public static readonly DocRenderResponseCode Forbidden = new(Values.Forbidden);

    public static readonly DocRenderResponseCode NotFound = new(Values.NotFound);

    public static readonly DocRenderResponseCode WireFormat = new(Values.WireFormat);

    public static readonly DocRenderResponseCode RuntimeUnavailable = new(
        Values.RuntimeUnavailable
    );

    public static readonly DocRenderResponseCode InvalidReference = new(Values.InvalidReference);

    public static readonly DocRenderResponseCode WeakAnnotationSessionConflict = new(
        Values.WeakAnnotationSessionConflict
    );

    public static readonly DocRenderResponseCode LayerVersionConflict = new(
        Values.LayerVersionConflict
    );

    public static readonly DocRenderResponseCode NotImplemented = new(Values.NotImplemented);

    public static readonly DocRenderResponseCode MalformedPdf = new(Values.MalformedPdf);

    public DocRenderResponseCode(string value)
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
    public static DocRenderResponseCode FromCustom(string value)
    {
        return new DocRenderResponseCode(value);
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

    public static bool operator ==(DocRenderResponseCode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocRenderResponseCode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocRenderResponseCode value) => value.Value;

    public static explicit operator DocRenderResponseCode(string value) => new(value);

    internal class DocRenderResponseCodeSerializer : JsonConverter<DocRenderResponseCode>
    {
        public override DocRenderResponseCode Read(
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
            return new DocRenderResponseCode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocRenderResponseCode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocRenderResponseCode ReadAsPropertyName(
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
            return new DocRenderResponseCode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocRenderResponseCode value,
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
