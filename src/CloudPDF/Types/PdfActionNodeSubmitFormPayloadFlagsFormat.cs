using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(PdfActionNodeSubmitFormPayloadFlagsFormat.PdfActionNodeSubmitFormPayloadFlagsFormatSerializer)
)]
[Serializable]
public readonly record struct PdfActionNodeSubmitFormPayloadFlagsFormat : IStringEnum
{
    public static readonly PdfActionNodeSubmitFormPayloadFlagsFormat Fdf = new(Values.Fdf);

    public static readonly PdfActionNodeSubmitFormPayloadFlagsFormat Html = new(Values.Html);

    public static readonly PdfActionNodeSubmitFormPayloadFlagsFormat Xfdf = new(Values.Xfdf);

    public static readonly PdfActionNodeSubmitFormPayloadFlagsFormat Pdf = new(Values.Pdf);

    public PdfActionNodeSubmitFormPayloadFlagsFormat(string value)
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
    public static PdfActionNodeSubmitFormPayloadFlagsFormat FromCustom(string value)
    {
        return new PdfActionNodeSubmitFormPayloadFlagsFormat(value);
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

    public static bool operator ==(
        PdfActionNodeSubmitFormPayloadFlagsFormat value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PdfActionNodeSubmitFormPayloadFlagsFormat value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PdfActionNodeSubmitFormPayloadFlagsFormat value) =>
        value.Value;

    public static explicit operator PdfActionNodeSubmitFormPayloadFlagsFormat(string value) =>
        new(value);

    internal class PdfActionNodeSubmitFormPayloadFlagsFormatSerializer
        : JsonConverter<PdfActionNodeSubmitFormPayloadFlagsFormat>
    {
        public override PdfActionNodeSubmitFormPayloadFlagsFormat Read(
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
            return new PdfActionNodeSubmitFormPayloadFlagsFormat(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            PdfActionNodeSubmitFormPayloadFlagsFormat value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override PdfActionNodeSubmitFormPayloadFlagsFormat ReadAsPropertyName(
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
            return new PdfActionNodeSubmitFormPayloadFlagsFormat(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            PdfActionNodeSubmitFormPayloadFlagsFormat value,
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
