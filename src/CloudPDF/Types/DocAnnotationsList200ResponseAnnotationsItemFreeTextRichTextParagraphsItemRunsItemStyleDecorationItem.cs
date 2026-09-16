using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem.DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemRunsItemStyleDecorationItemSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem Underline =
        new(Values.Underline);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem LineThrough =
        new(Values.LineThrough);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem Word =
        new(Values.Word);

    public DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem(
        string value
    )
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
    public static DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem(
            value
        );
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
        DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemRunsItemStyleDecorationItemSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemRunsItemStyleDecorationItem value,
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
