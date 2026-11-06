using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(PdfActionWriteSubmitFormFormat.PdfActionWriteSubmitFormFormatSerializer))]
[Serializable]
public readonly record struct PdfActionWriteSubmitFormFormat : IStringEnum
{
    public static readonly PdfActionWriteSubmitFormFormat Fdf = new(Values.Fdf);

    public static readonly PdfActionWriteSubmitFormFormat Html = new(Values.Html);

    public static readonly PdfActionWriteSubmitFormFormat Xfdf = new(Values.Xfdf);

    public static readonly PdfActionWriteSubmitFormFormat Pdf = new(Values.Pdf);

    public PdfActionWriteSubmitFormFormat(string value)
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
    public static PdfActionWriteSubmitFormFormat FromCustom(string value)
    {
        return new PdfActionWriteSubmitFormFormat(value);
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

    public static bool operator ==(PdfActionWriteSubmitFormFormat value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PdfActionWriteSubmitFormFormat value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PdfActionWriteSubmitFormFormat value) => value.Value;

    public static explicit operator PdfActionWriteSubmitFormFormat(string value) => new(value);

    internal class PdfActionWriteSubmitFormFormatSerializer
        : JsonConverter<PdfActionWriteSubmitFormFormat>
    {
        public override PdfActionWriteSubmitFormFormat Read(
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
            return new PdfActionWriteSubmitFormFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfActionWriteSubmitFormFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PdfActionWriteSubmitFormFormat ReadAsPropertyName(
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
            return new PdfActionWriteSubmitFormFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfActionWriteSubmitFormFormat value,
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
