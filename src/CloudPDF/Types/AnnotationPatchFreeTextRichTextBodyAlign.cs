using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchFreeTextRichTextBodyAlign.AnnotationPatchFreeTextRichTextBodyAlignSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchFreeTextRichTextBodyAlign : IStringEnum
{
    public static readonly AnnotationPatchFreeTextRichTextBodyAlign Left = new(Values.Left);

    public static readonly AnnotationPatchFreeTextRichTextBodyAlign Center = new(Values.Center);

    public static readonly AnnotationPatchFreeTextRichTextBodyAlign Right = new(Values.Right);

    public static readonly AnnotationPatchFreeTextRichTextBodyAlign Justify = new(Values.Justify);

    public AnnotationPatchFreeTextRichTextBodyAlign(string value)
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
    public static AnnotationPatchFreeTextRichTextBodyAlign FromCustom(string value)
    {
        return new AnnotationPatchFreeTextRichTextBodyAlign(value);
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
        AnnotationPatchFreeTextRichTextBodyAlign value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationPatchFreeTextRichTextBodyAlign value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchFreeTextRichTextBodyAlign value) =>
        value.Value;

    public static explicit operator AnnotationPatchFreeTextRichTextBodyAlign(string value) =>
        new(value);

    internal class AnnotationPatchFreeTextRichTextBodyAlignSerializer
        : JsonConverter<AnnotationPatchFreeTextRichTextBodyAlign>
    {
        public override AnnotationPatchFreeTextRichTextBodyAlign Read(
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
            return new AnnotationPatchFreeTextRichTextBodyAlign(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchFreeTextRichTextBodyAlign value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchFreeTextRichTextBodyAlign ReadAsPropertyName(
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
            return new AnnotationPatchFreeTextRichTextBodyAlign(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchFreeTextRichTextBodyAlign value,
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
