using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemTextIcon.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemTextIconSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsListAll200ResponsePagesItemAnnotationsItemTextIcon
    : IStringEnum
{
    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemTextIcon Comment =
        new(Values.Comment);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemTextIcon Key =
        new(Values.Key);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemTextIcon Note =
        new(Values.Note);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemTextIcon Help =
        new(Values.Help);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemTextIcon NewParagraph =
        new(Values.NewParagraph);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemTextIcon Paragraph =
        new(Values.Paragraph);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemTextIcon Insert =
        new(Values.Insert);

    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemTextIcon(string value)
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
    public static DocAnnotationsListAll200ResponsePagesItemAnnotationsItemTextIcon FromCustom(
        string value
    )
    {
        return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemTextIcon(value);
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
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemTextIcon value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemTextIcon value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemTextIcon value
    ) => value.Value;

    public static explicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemTextIcon(
        string value
    ) => new(value);

    internal class DocAnnotationsListAll200ResponsePagesItemAnnotationsItemTextIconSerializer
        : JsonConverter<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemTextIcon>
    {
        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemTextIcon Read(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemTextIcon(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemTextIcon value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemTextIcon ReadAsPropertyName(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemTextIcon(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemTextIcon value,
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
