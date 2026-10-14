using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationDraftFreeTextRichTextBodyDecorationItem.AnnotationDraftFreeTextRichTextBodyDecorationItemSerializer)
)]
[Serializable]
public readonly record struct AnnotationDraftFreeTextRichTextBodyDecorationItem : IStringEnum
{
    public static readonly AnnotationDraftFreeTextRichTextBodyDecorationItem Underline = new(
        Values.Underline
    );

    public static readonly AnnotationDraftFreeTextRichTextBodyDecorationItem LineThrough = new(
        Values.LineThrough
    );

    public static readonly AnnotationDraftFreeTextRichTextBodyDecorationItem Word = new(
        Values.Word
    );

    public AnnotationDraftFreeTextRichTextBodyDecorationItem(string value)
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
    public static AnnotationDraftFreeTextRichTextBodyDecorationItem FromCustom(string value)
    {
        return new AnnotationDraftFreeTextRichTextBodyDecorationItem(value);
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
        AnnotationDraftFreeTextRichTextBodyDecorationItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationDraftFreeTextRichTextBodyDecorationItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationDraftFreeTextRichTextBodyDecorationItem value
    ) => value.Value;

    public static explicit operator AnnotationDraftFreeTextRichTextBodyDecorationItem(
        string value
    ) => new(value);

    internal class AnnotationDraftFreeTextRichTextBodyDecorationItemSerializer
        : JsonConverter<AnnotationDraftFreeTextRichTextBodyDecorationItem>
    {
        public override AnnotationDraftFreeTextRichTextBodyDecorationItem Read(
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
            return new AnnotationDraftFreeTextRichTextBodyDecorationItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftFreeTextRichTextBodyDecorationItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftFreeTextRichTextBodyDecorationItem ReadAsPropertyName(
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
            return new AnnotationDraftFreeTextRichTextBodyDecorationItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftFreeTextRichTextBodyDecorationItem value,
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
