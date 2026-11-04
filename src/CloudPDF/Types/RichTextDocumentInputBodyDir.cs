using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(RichTextDocumentInputBodyDir.RichTextDocumentInputBodyDirSerializer))]
[Serializable]
public readonly record struct RichTextDocumentInputBodyDir : IStringEnum
{
    public static readonly RichTextDocumentInputBodyDir Ltr = new(Values.Ltr);

    public static readonly RichTextDocumentInputBodyDir Rtl = new(Values.Rtl);

    public RichTextDocumentInputBodyDir(string value)
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
    public static RichTextDocumentInputBodyDir FromCustom(string value)
    {
        return new RichTextDocumentInputBodyDir(value);
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

    public static bool operator ==(RichTextDocumentInputBodyDir value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(RichTextDocumentInputBodyDir value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(RichTextDocumentInputBodyDir value) => value.Value;

    public static explicit operator RichTextDocumentInputBodyDir(string value) => new(value);

    internal class RichTextDocumentInputBodyDirSerializer
        : JsonConverter<RichTextDocumentInputBodyDir>
    {
        public override RichTextDocumentInputBodyDir Read(
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
            return new RichTextDocumentInputBodyDir(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            RichTextDocumentInputBodyDir value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override RichTextDocumentInputBodyDir ReadAsPropertyName(
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
            return new RichTextDocumentInputBodyDir(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            RichTextDocumentInputBodyDir value,
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
