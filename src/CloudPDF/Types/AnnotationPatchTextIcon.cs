using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPatchTextIcon.AnnotationPatchTextIconSerializer))]
[Serializable]
public readonly record struct AnnotationPatchTextIcon : IStringEnum
{
    public static readonly AnnotationPatchTextIcon Comment = new(Values.Comment);

    public static readonly AnnotationPatchTextIcon Key = new(Values.Key);

    public static readonly AnnotationPatchTextIcon Note = new(Values.Note);

    public static readonly AnnotationPatchTextIcon Help = new(Values.Help);

    public static readonly AnnotationPatchTextIcon NewParagraph = new(Values.NewParagraph);

    public static readonly AnnotationPatchTextIcon Paragraph = new(Values.Paragraph);

    public static readonly AnnotationPatchTextIcon Insert = new(Values.Insert);

    public AnnotationPatchTextIcon(string value)
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
    public static AnnotationPatchTextIcon FromCustom(string value)
    {
        return new AnnotationPatchTextIcon(value);
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

    public static bool operator ==(AnnotationPatchTextIcon value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchTextIcon value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchTextIcon value) => value.Value;

    public static explicit operator AnnotationPatchTextIcon(string value) => new(value);

    internal class AnnotationPatchTextIconSerializer : JsonConverter<AnnotationPatchTextIcon>
    {
        public override AnnotationPatchTextIcon Read(
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
            return new AnnotationPatchTextIcon(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchTextIcon value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchTextIcon ReadAsPropertyName(
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
            return new AnnotationPatchTextIcon(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchTextIcon value,
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
        public const string Comment = "comment";

        public const string Key = "key";

        public const string Note = "note";

        public const string Help = "help";

        public const string NewParagraph = "new-paragraph";

        public const string Paragraph = "paragraph";

        public const string Insert = "insert";
    }
}
