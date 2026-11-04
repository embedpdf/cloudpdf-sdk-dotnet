using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(RichTextDocumentInputParagraphsItemRunsItemStyleScript.RichTextDocumentInputParagraphsItemRunsItemStyleScriptSerializer)
)]
[Serializable]
public readonly record struct RichTextDocumentInputParagraphsItemRunsItemStyleScript : IStringEnum
{
    public static readonly RichTextDocumentInputParagraphsItemRunsItemStyleScript Normal = new(
        Values.Normal
    );

    public static readonly RichTextDocumentInputParagraphsItemRunsItemStyleScript Sub = new(
        Values.Sub
    );

    public static readonly RichTextDocumentInputParagraphsItemRunsItemStyleScript Super = new(
        Values.Super
    );

    public RichTextDocumentInputParagraphsItemRunsItemStyleScript(string value)
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
    public static RichTextDocumentInputParagraphsItemRunsItemStyleScript FromCustom(string value)
    {
        return new RichTextDocumentInputParagraphsItemRunsItemStyleScript(value);
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
        RichTextDocumentInputParagraphsItemRunsItemStyleScript value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RichTextDocumentInputParagraphsItemRunsItemStyleScript value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        RichTextDocumentInputParagraphsItemRunsItemStyleScript value
    ) => value.Value;

    public static explicit operator RichTextDocumentInputParagraphsItemRunsItemStyleScript(
        string value
    ) => new(value);

    internal class RichTextDocumentInputParagraphsItemRunsItemStyleScriptSerializer
        : JsonConverter<RichTextDocumentInputParagraphsItemRunsItemStyleScript>
    {
        public override RichTextDocumentInputParagraphsItemRunsItemStyleScript Read(
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
            return new RichTextDocumentInputParagraphsItemRunsItemStyleScript(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RichTextDocumentInputParagraphsItemRunsItemStyleScript value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RichTextDocumentInputParagraphsItemRunsItemStyleScript ReadAsPropertyName(
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
            return new RichTextDocumentInputParagraphsItemRunsItemStyleScript(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RichTextDocumentInputParagraphsItemRunsItemStyleScript value,
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
