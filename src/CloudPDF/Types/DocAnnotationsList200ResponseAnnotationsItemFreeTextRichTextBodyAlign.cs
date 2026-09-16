using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextBodyAlign.DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextBodyAlignSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextBodyAlign
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextBodyAlign Left =
        new(Values.Left);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextBodyAlign Center =
        new(Values.Center);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextBodyAlign Right =
        new(Values.Right);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextBodyAlign Justify =
        new(Values.Justify);

    public DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextBodyAlign(string value)
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
    public static DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextBodyAlign FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextBodyAlign(value);
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
        DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextBodyAlign value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextBodyAlign value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextBodyAlign value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextBodyAlign(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextBodyAlignSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextBodyAlign>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextBodyAlign Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextBodyAlign(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextBodyAlign value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextBodyAlign ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextBodyAlign(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemFreeTextRichTextBodyAlign value,
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
