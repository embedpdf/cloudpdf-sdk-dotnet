using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationDraftFreeTextRichTextBodyAlign.AnnotationDraftFreeTextRichTextBodyAlignSerializer)
)]
[Serializable]
public readonly record struct AnnotationDraftFreeTextRichTextBodyAlign : IStringEnum
{
    public static readonly AnnotationDraftFreeTextRichTextBodyAlign Left = new(Values.Left);

    public static readonly AnnotationDraftFreeTextRichTextBodyAlign Center = new(Values.Center);

    public static readonly AnnotationDraftFreeTextRichTextBodyAlign Right = new(Values.Right);

    public static readonly AnnotationDraftFreeTextRichTextBodyAlign Justify = new(Values.Justify);

    public AnnotationDraftFreeTextRichTextBodyAlign(string value)
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
    public static AnnotationDraftFreeTextRichTextBodyAlign FromCustom(string value)
    {
        return new AnnotationDraftFreeTextRichTextBodyAlign(value);
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
        AnnotationDraftFreeTextRichTextBodyAlign value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AnnotationDraftFreeTextRichTextBodyAlign value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftFreeTextRichTextBodyAlign value) =>
        value.Value;

    public static explicit operator AnnotationDraftFreeTextRichTextBodyAlign(string value) =>
        new(value);

    internal class AnnotationDraftFreeTextRichTextBodyAlignSerializer
        : JsonConverter<AnnotationDraftFreeTextRichTextBodyAlign>
    {
        public override AnnotationDraftFreeTextRichTextBodyAlign Read(
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
            return new AnnotationDraftFreeTextRichTextBodyAlign(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftFreeTextRichTextBodyAlign value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftFreeTextRichTextBodyAlign ReadAsPropertyName(
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
            return new AnnotationDraftFreeTextRichTextBodyAlign(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftFreeTextRichTextBodyAlign value,
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
