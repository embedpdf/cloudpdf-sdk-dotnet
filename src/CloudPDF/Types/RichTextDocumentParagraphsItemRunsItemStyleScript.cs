using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(RichTextDocumentParagraphsItemRunsItemStyleScript.RichTextDocumentParagraphsItemRunsItemStyleScriptSerializer)
)]
[Serializable]
public readonly record struct RichTextDocumentParagraphsItemRunsItemStyleScript : IStringEnum
{
    public static readonly RichTextDocumentParagraphsItemRunsItemStyleScript Normal = new(
        Values.Normal
    );

    public static readonly RichTextDocumentParagraphsItemRunsItemStyleScript Sub = new(Values.Sub);

    public static readonly RichTextDocumentParagraphsItemRunsItemStyleScript Super = new(
        Values.Super
    );

    public RichTextDocumentParagraphsItemRunsItemStyleScript(string value)
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
    public static RichTextDocumentParagraphsItemRunsItemStyleScript FromCustom(string value)
    {
        return new RichTextDocumentParagraphsItemRunsItemStyleScript(value);
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
        RichTextDocumentParagraphsItemRunsItemStyleScript value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RichTextDocumentParagraphsItemRunsItemStyleScript value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        RichTextDocumentParagraphsItemRunsItemStyleScript value
    ) => value.Value;

    public static explicit operator RichTextDocumentParagraphsItemRunsItemStyleScript(
        string value
    ) => new(value);

    internal class RichTextDocumentParagraphsItemRunsItemStyleScriptSerializer
        : JsonConverter<RichTextDocumentParagraphsItemRunsItemStyleScript>
    {
        public override RichTextDocumentParagraphsItemRunsItemStyleScript Read(
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
            return new RichTextDocumentParagraphsItemRunsItemStyleScript(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RichTextDocumentParagraphsItemRunsItemStyleScript value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RichTextDocumentParagraphsItemRunsItemStyleScript ReadAsPropertyName(
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
            return new RichTextDocumentParagraphsItemRunsItemStyleScript(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RichTextDocumentParagraphsItemRunsItemStyleScript value,
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
        public const string Normal = "normal";

        public const string Sub = "sub";

        public const string Super = "super";
    }
}
