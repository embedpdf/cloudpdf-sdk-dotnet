using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(RichTextDocumentParagraphsItemDir.RichTextDocumentParagraphsItemDirSerializer)
)]
[Serializable]
public readonly record struct RichTextDocumentParagraphsItemDir : IStringEnum
{
    public static readonly RichTextDocumentParagraphsItemDir Ltr = new(Values.Ltr);

    public static readonly RichTextDocumentParagraphsItemDir Rtl = new(Values.Rtl);

    public RichTextDocumentParagraphsItemDir(string value)
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
    public static RichTextDocumentParagraphsItemDir FromCustom(string value)
    {
        return new RichTextDocumentParagraphsItemDir(value);
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

    public static bool operator ==(RichTextDocumentParagraphsItemDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RichTextDocumentParagraphsItemDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RichTextDocumentParagraphsItemDir value) => value.Value;

    public static explicit operator RichTextDocumentParagraphsItemDir(string value) => new(value);

    internal class RichTextDocumentParagraphsItemDirSerializer
        : JsonConverter<RichTextDocumentParagraphsItemDir>
    {
        public override RichTextDocumentParagraphsItemDir Read(
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
            return new RichTextDocumentParagraphsItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RichTextDocumentParagraphsItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RichTextDocumentParagraphsItemDir ReadAsPropertyName(
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
            return new RichTextDocumentParagraphsItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RichTextDocumentParagraphsItemDir value,
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
