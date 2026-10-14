using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationFreeTextRichTextBodyScript.AnnotationFreeTextRichTextBodyScriptSerializer)
)]
[Serializable]
public readonly record struct AnnotationFreeTextRichTextBodyScript : IStringEnum
{
    public static readonly AnnotationFreeTextRichTextBodyScript Normal = new(Values.Normal);

    public static readonly AnnotationFreeTextRichTextBodyScript Sub = new(Values.Sub);

    public static readonly AnnotationFreeTextRichTextBodyScript Super = new(Values.Super);

    public AnnotationFreeTextRichTextBodyScript(string value)
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
    public static AnnotationFreeTextRichTextBodyScript FromCustom(string value)
    {
        return new AnnotationFreeTextRichTextBodyScript(value);
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

    public static bool operator ==(AnnotationFreeTextRichTextBodyScript value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationFreeTextRichTextBodyScript value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationFreeTextRichTextBodyScript value) =>
        value.Value;

    public static explicit operator AnnotationFreeTextRichTextBodyScript(string value) =>
        new(value);

    internal class AnnotationFreeTextRichTextBodyScriptSerializer
        : JsonConverter<AnnotationFreeTextRichTextBodyScript>
    {
        public override AnnotationFreeTextRichTextBodyScript Read(
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
            return new AnnotationFreeTextRichTextBodyScript(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationFreeTextRichTextBodyScript value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationFreeTextRichTextBodyScript ReadAsPropertyName(
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
            return new AnnotationFreeTextRichTextBodyScript(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationFreeTextRichTextBodyScript value,
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
        public const string Normal = "normal";

        public const string Sub = "sub";

        public const string Super = "super";
    }
}
