using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(RichTextDocumentInputParagraphsItemRunsItemStyleDecorationItem.RichTextDocumentInputParagraphsItemRunsItemStyleDecorationItemSerializer)
)]
[Serializable]
public readonly record struct RichTextDocumentInputParagraphsItemRunsItemStyleDecorationItem
    : IStringEnum
{
    public static readonly RichTextDocumentInputParagraphsItemRunsItemStyleDecorationItem Underline =
        new(Values.Underline);

    public static readonly RichTextDocumentInputParagraphsItemRunsItemStyleDecorationItem LineThrough =
        new(Values.LineThrough);

    public static readonly RichTextDocumentInputParagraphsItemRunsItemStyleDecorationItem Word =
        new(Values.Word);

    public RichTextDocumentInputParagraphsItemRunsItemStyleDecorationItem(string value)
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
    public static RichTextDocumentInputParagraphsItemRunsItemStyleDecorationItem FromCustom(
        string value
    )
    {
        return new RichTextDocumentInputParagraphsItemRunsItemStyleDecorationItem(value);
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
        RichTextDocumentInputParagraphsItemRunsItemStyleDecorationItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RichTextDocumentInputParagraphsItemRunsItemStyleDecorationItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        RichTextDocumentInputParagraphsItemRunsItemStyleDecorationItem value
    ) => value.Value;

    public static explicit operator RichTextDocumentInputParagraphsItemRunsItemStyleDecorationItem(
        string value
    ) => new(value);

    internal class RichTextDocumentInputParagraphsItemRunsItemStyleDecorationItemSerializer
        : JsonConverter<RichTextDocumentInputParagraphsItemRunsItemStyleDecorationItem>
    {
        public override RichTextDocumentInputParagraphsItemRunsItemStyleDecorationItem Read(
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
            return new RichTextDocumentInputParagraphsItemRunsItemStyleDecorationItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RichTextDocumentInputParagraphsItemRunsItemStyleDecorationItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RichTextDocumentInputParagraphsItemRunsItemStyleDecorationItem ReadAsPropertyName(
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
            return new RichTextDocumentInputParagraphsItemRunsItemStyleDecorationItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RichTextDocumentInputParagraphsItemRunsItemStyleDecorationItem value,
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
        public const string Underline = "underline";

        public const string LineThrough = "line-through";

        public const string Word = "word";
    }
}
