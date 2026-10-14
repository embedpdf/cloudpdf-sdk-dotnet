using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationDraftFreeTextRichTextBodyScript.AnnotationDraftFreeTextRichTextBodyScriptSerializer)
)]
[Serializable]
public readonly record struct AnnotationDraftFreeTextRichTextBodyScript : IStringEnum
{
    public static readonly AnnotationDraftFreeTextRichTextBodyScript Normal = new(Values.Normal);

    public static readonly AnnotationDraftFreeTextRichTextBodyScript Sub = new(Values.Sub);

    public static readonly AnnotationDraftFreeTextRichTextBodyScript Super = new(Values.Super);

    public AnnotationDraftFreeTextRichTextBodyScript(string value)
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
    public static AnnotationDraftFreeTextRichTextBodyScript FromCustom(string value)
    {
        return new AnnotationDraftFreeTextRichTextBodyScript(value);
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
        AnnotationDraftFreeTextRichTextBodyScript value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationDraftFreeTextRichTextBodyScript value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftFreeTextRichTextBodyScript value) =>
        value.Value;

    public static explicit operator AnnotationDraftFreeTextRichTextBodyScript(string value) =>
        new(value);

    internal class AnnotationDraftFreeTextRichTextBodyScriptSerializer
        : JsonConverter<AnnotationDraftFreeTextRichTextBodyScript>
    {
        public override AnnotationDraftFreeTextRichTextBodyScript Read(
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
            return new AnnotationDraftFreeTextRichTextBodyScript(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftFreeTextRichTextBodyScript value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftFreeTextRichTextBodyScript ReadAsPropertyName(
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
            return new AnnotationDraftFreeTextRichTextBodyScript(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftFreeTextRichTextBodyScript value,
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
