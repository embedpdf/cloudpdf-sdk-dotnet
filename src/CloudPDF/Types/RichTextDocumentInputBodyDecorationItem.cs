using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(RichTextDocumentInputBodyDecorationItem.RichTextDocumentInputBodyDecorationItemSerializer)
)]
[Serializable]
public readonly record struct RichTextDocumentInputBodyDecorationItem : IStringEnum
{
    public static readonly RichTextDocumentInputBodyDecorationItem Underline = new(
        Values.Underline
    );

    public static readonly RichTextDocumentInputBodyDecorationItem LineThrough = new(
        Values.LineThrough
    );

    public static readonly RichTextDocumentInputBodyDecorationItem Word = new(Values.Word);

    public RichTextDocumentInputBodyDecorationItem(string value)
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
    public static RichTextDocumentInputBodyDecorationItem FromCustom(string value)
    {
        return new RichTextDocumentInputBodyDecorationItem(value);
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

    public static bool operator ==(RichTextDocumentInputBodyDecorationItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RichTextDocumentInputBodyDecorationItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RichTextDocumentInputBodyDecorationItem value) =>
        value.Value;

    public static explicit operator RichTextDocumentInputBodyDecorationItem(string value) =>
        new(value);

    internal class RichTextDocumentInputBodyDecorationItemSerializer
        : JsonConverter<RichTextDocumentInputBodyDecorationItem>
    {
        public override RichTextDocumentInputBodyDecorationItem Read(
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
            return new RichTextDocumentInputBodyDecorationItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RichTextDocumentInputBodyDecorationItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RichTextDocumentInputBodyDecorationItem ReadAsPropertyName(
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
            return new RichTextDocumentInputBodyDecorationItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RichTextDocumentInputBodyDecorationItem value,
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
