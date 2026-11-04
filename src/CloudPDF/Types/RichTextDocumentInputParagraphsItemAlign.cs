using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(RichTextDocumentInputParagraphsItemAlign.RichTextDocumentInputParagraphsItemAlignSerializer)
)]
[Serializable]
public readonly record struct RichTextDocumentInputParagraphsItemAlign : IStringEnum
{
    public static readonly RichTextDocumentInputParagraphsItemAlign Left = new(Values.Left);

    public static readonly RichTextDocumentInputParagraphsItemAlign Center = new(Values.Center);

    public static readonly RichTextDocumentInputParagraphsItemAlign Right = new(Values.Right);

    public static readonly RichTextDocumentInputParagraphsItemAlign Justify = new(Values.Justify);

    public RichTextDocumentInputParagraphsItemAlign(string value)
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
    public static RichTextDocumentInputParagraphsItemAlign FromCustom(string value)
    {
        return new RichTextDocumentInputParagraphsItemAlign(value);
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
        RichTextDocumentInputParagraphsItemAlign value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RichTextDocumentInputParagraphsItemAlign value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RichTextDocumentInputParagraphsItemAlign value) =>
        value.Value;

    public static explicit operator RichTextDocumentInputParagraphsItemAlign(string value) =>
        new(value);

    internal class RichTextDocumentInputParagraphsItemAlignSerializer
        : JsonConverter<RichTextDocumentInputParagraphsItemAlign>
    {
        public override RichTextDocumentInputParagraphsItemAlign Read(
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
            return new RichTextDocumentInputParagraphsItemAlign(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RichTextDocumentInputParagraphsItemAlign value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RichTextDocumentInputParagraphsItemAlign ReadAsPropertyName(
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
            return new RichTextDocumentInputParagraphsItemAlign(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RichTextDocumentInputParagraphsItemAlign value,
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
        public const string Left = "left";

        public const string Center = "center";

        public const string Right = "right";

        public const string Justify = "justify";
    }
}
