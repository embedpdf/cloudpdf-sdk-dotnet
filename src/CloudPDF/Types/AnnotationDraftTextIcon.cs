using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftTextIcon.AnnotationDraftTextIconSerializer))]
[Serializable]
public readonly record struct AnnotationDraftTextIcon : IStringEnum
{
    public static readonly AnnotationDraftTextIcon Comment = new(Values.Comment);

    public static readonly AnnotationDraftTextIcon Key = new(Values.Key);

    public static readonly AnnotationDraftTextIcon Note = new(Values.Note);

    public static readonly AnnotationDraftTextIcon Help = new(Values.Help);

    public static readonly AnnotationDraftTextIcon NewParagraph = new(Values.NewParagraph);

    public static readonly AnnotationDraftTextIcon Paragraph = new(Values.Paragraph);

    public static readonly AnnotationDraftTextIcon Insert = new(Values.Insert);

    public AnnotationDraftTextIcon(string value)
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
    public static AnnotationDraftTextIcon FromCustom(string value)
    {
        return new AnnotationDraftTextIcon(value);
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

    public static bool operator ==(AnnotationDraftTextIcon value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftTextIcon value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftTextIcon value) => value.Value;

    public static explicit operator AnnotationDraftTextIcon(string value) => new(value);

    internal class AnnotationDraftTextIconSerializer : JsonConverter<AnnotationDraftTextIcon>
    {
        public override AnnotationDraftTextIcon Read(
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
            return new AnnotationDraftTextIcon(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftTextIcon value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftTextIcon ReadAsPropertyName(
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
            return new AnnotationDraftTextIcon(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftTextIcon value,
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
