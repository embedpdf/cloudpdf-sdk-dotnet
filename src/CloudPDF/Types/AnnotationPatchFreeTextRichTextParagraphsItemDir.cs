using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchFreeTextRichTextParagraphsItemDir.AnnotationPatchFreeTextRichTextParagraphsItemDirSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchFreeTextRichTextParagraphsItemDir : IStringEnum
{
    public static readonly AnnotationPatchFreeTextRichTextParagraphsItemDir Ltr = new(Values.Ltr);

    public static readonly AnnotationPatchFreeTextRichTextParagraphsItemDir Rtl = new(Values.Rtl);

    public AnnotationPatchFreeTextRichTextParagraphsItemDir(string value)
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
    public static AnnotationPatchFreeTextRichTextParagraphsItemDir FromCustom(string value)
    {
        return new AnnotationPatchFreeTextRichTextParagraphsItemDir(value);
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
        AnnotationPatchFreeTextRichTextParagraphsItemDir value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationPatchFreeTextRichTextParagraphsItemDir value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationPatchFreeTextRichTextParagraphsItemDir value
    ) => value.Value;

    public static explicit operator AnnotationPatchFreeTextRichTextParagraphsItemDir(
        string value
    ) => new(value);

    internal class AnnotationPatchFreeTextRichTextParagraphsItemDirSerializer
        : JsonConverter<AnnotationPatchFreeTextRichTextParagraphsItemDir>
    {
        public override AnnotationPatchFreeTextRichTextParagraphsItemDir Read(
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
            return new AnnotationPatchFreeTextRichTextParagraphsItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchFreeTextRichTextParagraphsItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchFreeTextRichTextParagraphsItemDir ReadAsPropertyName(
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
            return new AnnotationPatchFreeTextRichTextParagraphsItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchFreeTextRichTextParagraphsItemDir value,
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
