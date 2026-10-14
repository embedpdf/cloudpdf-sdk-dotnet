using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationDraftFreeTextRichTextBodyDir.AnnotationDraftFreeTextRichTextBodyDirSerializer)
)]
[Serializable]
public readonly record struct AnnotationDraftFreeTextRichTextBodyDir : IStringEnum
{
    public static readonly AnnotationDraftFreeTextRichTextBodyDir Ltr = new(Values.Ltr);

    public static readonly AnnotationDraftFreeTextRichTextBodyDir Rtl = new(Values.Rtl);

    public AnnotationDraftFreeTextRichTextBodyDir(string value)
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
    public static AnnotationDraftFreeTextRichTextBodyDir FromCustom(string value)
    {
        return new AnnotationDraftFreeTextRichTextBodyDir(value);
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

    public static bool operator ==(AnnotationDraftFreeTextRichTextBodyDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftFreeTextRichTextBodyDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftFreeTextRichTextBodyDir value) =>
        value.Value;

    public static explicit operator AnnotationDraftFreeTextRichTextBodyDir(string value) =>
        new(value);

    internal class AnnotationDraftFreeTextRichTextBodyDirSerializer
        : JsonConverter<AnnotationDraftFreeTextRichTextBodyDir>
    {
        public override AnnotationDraftFreeTextRichTextBodyDir Read(
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
            return new AnnotationDraftFreeTextRichTextBodyDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftFreeTextRichTextBodyDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftFreeTextRichTextBodyDir ReadAsPropertyName(
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
            return new AnnotationDraftFreeTextRichTextBodyDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftFreeTextRichTextBodyDir value,
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
        public const string Ltr = "ltr";

        public const string Rtl = "rtl";
    }
}
