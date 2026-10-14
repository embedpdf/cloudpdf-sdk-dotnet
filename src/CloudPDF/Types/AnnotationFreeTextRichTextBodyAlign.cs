using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationFreeTextRichTextBodyAlign.AnnotationFreeTextRichTextBodyAlignSerializer)
)]
[Serializable]
public readonly record struct AnnotationFreeTextRichTextBodyAlign : IStringEnum
{
    public static readonly AnnotationFreeTextRichTextBodyAlign Left = new(Values.Left);

    public static readonly AnnotationFreeTextRichTextBodyAlign Center = new(Values.Center);

    public static readonly AnnotationFreeTextRichTextBodyAlign Right = new(Values.Right);

    public static readonly AnnotationFreeTextRichTextBodyAlign Justify = new(Values.Justify);

    public AnnotationFreeTextRichTextBodyAlign(string value)
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
    public static AnnotationFreeTextRichTextBodyAlign FromCustom(string value)
    {
        return new AnnotationFreeTextRichTextBodyAlign(value);
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

    public static bool operator ==(AnnotationFreeTextRichTextBodyAlign value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationFreeTextRichTextBodyAlign value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationFreeTextRichTextBodyAlign value) =>
        value.Value;

    public static explicit operator AnnotationFreeTextRichTextBodyAlign(string value) => new(value);

    internal class AnnotationFreeTextRichTextBodyAlignSerializer
        : JsonConverter<AnnotationFreeTextRichTextBodyAlign>
    {
        public override AnnotationFreeTextRichTextBodyAlign Read(
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
            return new AnnotationFreeTextRichTextBodyAlign(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationFreeTextRichTextBodyAlign value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationFreeTextRichTextBodyAlign ReadAsPropertyName(
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
            return new AnnotationFreeTextRichTextBodyAlign(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationFreeTextRichTextBodyAlign value,
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
