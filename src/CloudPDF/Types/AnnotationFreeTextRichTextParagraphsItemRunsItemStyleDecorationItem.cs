using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem.AnnotationFreeTextRichTextParagraphsItemRunsItemStyleDecorationItemSerializer)
)]
[Serializable]
public readonly record struct AnnotationFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem
    : IStringEnum
{
    public static readonly AnnotationFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem Underline =
        new(Values.Underline);

    public static readonly AnnotationFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem LineThrough =
        new(Values.LineThrough);

    public static readonly AnnotationFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem Word =
        new(Values.Word);

    public AnnotationFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem(string value)
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
    public static AnnotationFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem FromCustom(
        string value
    )
    {
        return new AnnotationFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem(value);
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
        AnnotationFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem value
    ) => value.Value;

    public static explicit operator AnnotationFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem(
        string value
    ) => new(value);

    internal class AnnotationFreeTextRichTextParagraphsItemRunsItemStyleDecorationItemSerializer
        : JsonConverter<AnnotationFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem>
    {
        public override AnnotationFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem Read(
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
            return new AnnotationFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem ReadAsPropertyName(
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
            return new AnnotationFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem value,
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
        public const string Underline = "underline";

        public const string LineThrough = "line-through";

        public const string Word = "word";
    }
}
