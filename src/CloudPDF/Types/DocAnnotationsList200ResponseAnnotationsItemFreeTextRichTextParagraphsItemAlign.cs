using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemAlign.DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemAlignSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemAlign
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemAlign Left =
        new(Values.Left);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemAlign Center =
        new(Values.Center);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemAlign Right =
        new(Values.Right);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemAlign Justify =
        new(Values.Justify);

    public DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemAlign(
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
    public static DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemAlign FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemAlign(
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
        DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemAlign value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemAlign value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemAlign value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemAlign(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemAlignSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemAlign>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemAlign Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemAlign(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemAlign value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemAlign ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemAlign(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextParagraphsItemAlign value,
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
        public const string Left = "left";

        public const string Center = "center";

        public const string Right = "right";

        public const string Justify = "justify";
    }
}
