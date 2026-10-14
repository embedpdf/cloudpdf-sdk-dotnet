using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchFreeTextRichTextParagraphsItemAlign.AnnotationPatchFreeTextRichTextParagraphsItemAlignSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchFreeTextRichTextParagraphsItemAlign : IStringEnum
{
    public static readonly AnnotationPatchFreeTextRichTextParagraphsItemAlign Left = new(
        Values.Left
    );

    public static readonly AnnotationPatchFreeTextRichTextParagraphsItemAlign Center = new(
        Values.Center
    );

    public static readonly AnnotationPatchFreeTextRichTextParagraphsItemAlign Right = new(
        Values.Right
    );

    public static readonly AnnotationPatchFreeTextRichTextParagraphsItemAlign Justify = new(
        Values.Justify
    );

    public AnnotationPatchFreeTextRichTextParagraphsItemAlign(string value)
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
    public static AnnotationPatchFreeTextRichTextParagraphsItemAlign FromCustom(string value)
    {
        return new AnnotationPatchFreeTextRichTextParagraphsItemAlign(value);
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
        AnnotationPatchFreeTextRichTextParagraphsItemAlign value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationPatchFreeTextRichTextParagraphsItemAlign value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AnnotationPatchFreeTextRichTextParagraphsItemAlign value
    ) => value.Value;

    public static explicit operator AnnotationPatchFreeTextRichTextParagraphsItemAlign(
        string value
    ) => new(value);

    internal class AnnotationPatchFreeTextRichTextParagraphsItemAlignSerializer
        : JsonConverter<AnnotationPatchFreeTextRichTextParagraphsItemAlign>
    {
        public override AnnotationPatchFreeTextRichTextParagraphsItemAlign Read(
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
            return new AnnotationPatchFreeTextRichTextParagraphsItemAlign(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchFreeTextRichTextParagraphsItemAlign value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchFreeTextRichTextParagraphsItemAlign ReadAsPropertyName(
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
            return new AnnotationPatchFreeTextRichTextParagraphsItemAlign(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchFreeTextRichTextParagraphsItemAlign value,
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
