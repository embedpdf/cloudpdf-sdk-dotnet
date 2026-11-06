using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(PdfActionNodeSubmitFormPayloadFormat.PdfActionNodeSubmitFormPayloadFormatSerializer)
)]
[Serializable]
public readonly record struct PdfActionNodeSubmitFormPayloadFormat : IStringEnum
{
    public static readonly PdfActionNodeSubmitFormPayloadFormat Fdf = new(Values.Fdf);

    public static readonly PdfActionNodeSubmitFormPayloadFormat Html = new(Values.Html);

    public static readonly PdfActionNodeSubmitFormPayloadFormat Xfdf = new(Values.Xfdf);

    public static readonly PdfActionNodeSubmitFormPayloadFormat Pdf = new(Values.Pdf);

    public PdfActionNodeSubmitFormPayloadFormat(string value)
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
    public static PdfActionNodeSubmitFormPayloadFormat FromCustom(string value)
    {
        return new PdfActionNodeSubmitFormPayloadFormat(value);
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

    public static bool operator ==(PdfActionNodeSubmitFormPayloadFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PdfActionNodeSubmitFormPayloadFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PdfActionNodeSubmitFormPayloadFormat value) =>
        value.Value;

    public static explicit operator PdfActionNodeSubmitFormPayloadFormat(string value) =>
        new(value);

    internal class PdfActionNodeSubmitFormPayloadFormatSerializer
        : JsonConverter<PdfActionNodeSubmitFormPayloadFormat>
    {
        public override PdfActionNodeSubmitFormPayloadFormat Read(
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
            return new PdfActionNodeSubmitFormPayloadFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfActionNodeSubmitFormPayloadFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PdfActionNodeSubmitFormPayloadFormat ReadAsPropertyName(
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
            return new PdfActionNodeSubmitFormPayloadFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfActionNodeSubmitFormPayloadFormat value,
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
        public const string Fdf = "fdf";

        public const string Html = "html";

        public const string Xfdf = "xfdf";

        public const string Pdf = "pdf";
    }
}
