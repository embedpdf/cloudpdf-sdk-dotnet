using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationFreeTextRichTextParagraphsItemDir.AnnotationFreeTextRichTextParagraphsItemDirSerializer)
)]
[Serializable]
public readonly record struct AnnotationFreeTextRichTextParagraphsItemDir : IStringEnum
{
    public static readonly AnnotationFreeTextRichTextParagraphsItemDir Ltr = new(Values.Ltr);

    public static readonly AnnotationFreeTextRichTextParagraphsItemDir Rtl = new(Values.Rtl);

    public AnnotationFreeTextRichTextParagraphsItemDir(string value)
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
    public static AnnotationFreeTextRichTextParagraphsItemDir FromCustom(string value)
    {
        return new AnnotationFreeTextRichTextParagraphsItemDir(value);
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
        AnnotationFreeTextRichTextParagraphsItemDir value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationFreeTextRichTextParagraphsItemDir value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationFreeTextRichTextParagraphsItemDir value) =>
        value.Value;

    public static explicit operator AnnotationFreeTextRichTextParagraphsItemDir(string value) =>
        new(value);

    internal class AnnotationFreeTextRichTextParagraphsItemDirSerializer
        : JsonConverter<AnnotationFreeTextRichTextParagraphsItemDir>
    {
        public override AnnotationFreeTextRichTextParagraphsItemDir Read(
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
            return new AnnotationFreeTextRichTextParagraphsItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationFreeTextRichTextParagraphsItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationFreeTextRichTextParagraphsItemDir ReadAsPropertyName(
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
            return new AnnotationFreeTextRichTextParagraphsItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationFreeTextRichTextParagraphsItemDir value,
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
        public const string Ltr = "ltr";

        public const string Rtl = "rtl";
    }
}
