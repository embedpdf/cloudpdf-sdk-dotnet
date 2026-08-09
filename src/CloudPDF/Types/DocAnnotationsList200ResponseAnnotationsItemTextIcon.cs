using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemTextIcon.DocAnnotationsList200ResponseAnnotationsItemTextIconSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemTextIcon : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemTextIcon Comment = new(
        Values.Comment
    );

    public static readonly DocAnnotationsList200ResponseAnnotationsItemTextIcon Key = new(
        Values.Key
    );

    public static readonly DocAnnotationsList200ResponseAnnotationsItemTextIcon Note = new(
        Values.Note
    );

    public static readonly DocAnnotationsList200ResponseAnnotationsItemTextIcon Help = new(
        Values.Help
    );

    public static readonly DocAnnotationsList200ResponseAnnotationsItemTextIcon NewParagraph = new(
        Values.NewParagraph
    );

    public static readonly DocAnnotationsList200ResponseAnnotationsItemTextIcon Paragraph = new(
        Values.Paragraph
    );

    public static readonly DocAnnotationsList200ResponseAnnotationsItemTextIcon Insert = new(
        Values.Insert
    );

    public DocAnnotationsList200ResponseAnnotationsItemTextIcon(string value)
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
    public static DocAnnotationsList200ResponseAnnotationsItemTextIcon FromCustom(string value)
    {
        return new DocAnnotationsList200ResponseAnnotationsItemTextIcon(value);
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
        DocAnnotationsList200ResponseAnnotationsItemTextIcon value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemTextIcon value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemTextIcon value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemTextIcon(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemTextIconSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemTextIcon>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemTextIcon Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemTextIcon(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemTextIcon value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemTextIcon ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemTextIcon(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemTextIcon value,
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
