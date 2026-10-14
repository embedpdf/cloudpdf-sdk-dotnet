using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationTextIcon.AnnotationTextIconSerializer))]
[Serializable]
public readonly record struct AnnotationTextIcon : IStringEnum
{
    public static readonly AnnotationTextIcon Comment = new(Values.Comment);

    public static readonly AnnotationTextIcon Key = new(Values.Key);

    public static readonly AnnotationTextIcon Note = new(Values.Note);

    public static readonly AnnotationTextIcon Help = new(Values.Help);

    public static readonly AnnotationTextIcon NewParagraph = new(Values.NewParagraph);

    public static readonly AnnotationTextIcon Paragraph = new(Values.Paragraph);

    public static readonly AnnotationTextIcon Insert = new(Values.Insert);

    public AnnotationTextIcon(string value)
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
    public static AnnotationTextIcon FromCustom(string value)
    {
        return new AnnotationTextIcon(value);
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

    public static bool operator ==(AnnotationTextIcon value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationTextIcon value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationTextIcon value) => value.Value;

    public static explicit operator AnnotationTextIcon(string value) => new(value);

    internal class AnnotationTextIconSerializer : JsonConverter<AnnotationTextIcon>
    {
        public override AnnotationTextIcon Read(
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
            return new AnnotationTextIcon(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationTextIcon value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationTextIcon ReadAsPropertyName(
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
            return new AnnotationTextIcon(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationTextIcon value,
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
