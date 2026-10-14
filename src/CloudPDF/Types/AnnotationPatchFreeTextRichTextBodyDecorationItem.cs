using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchFreeTextRichTextBodyDecorationItem.AnnotationPatchFreeTextRichTextBodyDecorationItemSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchFreeTextRichTextBodyDecorationItem : IStringEnum
{
    public static readonly AnnotationPatchFreeTextRichTextBodyDecorationItem Underline = new(
        Values.Underline
    );

    public static readonly AnnotationPatchFreeTextRichTextBodyDecorationItem LineThrough = new(
        Values.LineThrough
    );

    public static readonly AnnotationPatchFreeTextRichTextBodyDecorationItem Word = new(
        Values.Word
    );

    public AnnotationPatchFreeTextRichTextBodyDecorationItem(string value)
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
    public static AnnotationPatchFreeTextRichTextBodyDecorationItem FromCustom(string value)
    {
        return new AnnotationPatchFreeTextRichTextBodyDecorationItem(value);
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
        AnnotationPatchFreeTextRichTextBodyDecorationItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationPatchFreeTextRichTextBodyDecorationItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationPatchFreeTextRichTextBodyDecorationItem value
    ) => value.Value;

    public static explicit operator AnnotationPatchFreeTextRichTextBodyDecorationItem(
        string value
    ) => new(value);

    internal class AnnotationPatchFreeTextRichTextBodyDecorationItemSerializer
        : JsonConverter<AnnotationPatchFreeTextRichTextBodyDecorationItem>
    {
        public override AnnotationPatchFreeTextRichTextBodyDecorationItem Read(
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
            return new AnnotationPatchFreeTextRichTextBodyDecorationItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchFreeTextRichTextBodyDecorationItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchFreeTextRichTextBodyDecorationItem ReadAsPropertyName(
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
            return new AnnotationPatchFreeTextRichTextBodyDecorationItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchFreeTextRichTextBodyDecorationItem value,
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
