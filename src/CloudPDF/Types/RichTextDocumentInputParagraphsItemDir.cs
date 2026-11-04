using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(RichTextDocumentInputParagraphsItemDir.RichTextDocumentInputParagraphsItemDirSerializer)
)]
[Serializable]
public readonly record struct RichTextDocumentInputParagraphsItemDir : IStringEnum
{
    public static readonly RichTextDocumentInputParagraphsItemDir Ltr = new(Values.Ltr);

    public static readonly RichTextDocumentInputParagraphsItemDir Rtl = new(Values.Rtl);

    public RichTextDocumentInputParagraphsItemDir(string value)
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
    public static RichTextDocumentInputParagraphsItemDir FromCustom(string value)
    {
        return new RichTextDocumentInputParagraphsItemDir(value);
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

    public static bool operator ==(RichTextDocumentInputParagraphsItemDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RichTextDocumentInputParagraphsItemDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RichTextDocumentInputParagraphsItemDir value) =>
        value.Value;

    public static explicit operator RichTextDocumentInputParagraphsItemDir(string value) =>
        new(value);

    internal class RichTextDocumentInputParagraphsItemDirSerializer
        : JsonConverter<RichTextDocumentInputParagraphsItemDir>
    {
        public override RichTextDocumentInputParagraphsItemDir Read(
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
            return new RichTextDocumentInputParagraphsItemDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RichTextDocumentInputParagraphsItemDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RichTextDocumentInputParagraphsItemDir ReadAsPropertyName(
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
            return new RichTextDocumentInputParagraphsItemDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RichTextDocumentInputParagraphsItemDir value,
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
