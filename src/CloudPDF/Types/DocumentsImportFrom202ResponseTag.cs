using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocumentsImportFrom202ResponseTag.DocumentsImportFrom202ResponseTagSerializer)
)]
[Serializable]
public readonly record struct DocumentsImportFrom202ResponseTag : IStringEnum
{
    public static readonly DocumentsImportFrom202ResponseTag Imported = new(Values.Imported);

    public static readonly DocumentsImportFrom202ResponseTag Deduped = new(Values.Deduped);

    public static readonly DocumentsImportFrom202ResponseTag Accepted = new(Values.Accepted);

    public DocumentsImportFrom202ResponseTag(string value)
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
    public static DocumentsImportFrom202ResponseTag FromCustom(string value)
    {
        return new DocumentsImportFrom202ResponseTag(value);
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

    public static bool operator ==(DocumentsImportFrom202ResponseTag value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocumentsImportFrom202ResponseTag value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocumentsImportFrom202ResponseTag value) => value.Value;

    public static explicit operator DocumentsImportFrom202ResponseTag(string value) => new(value);

    internal class DocumentsImportFrom202ResponseTagSerializer
        : JsonConverter<DocumentsImportFrom202ResponseTag>
    {
        public override DocumentsImportFrom202ResponseTag Read(
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
            return new DocumentsImportFrom202ResponseTag(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsImportFrom202ResponseTag value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsImportFrom202ResponseTag ReadAsPropertyName(
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
            return new DocumentsImportFrom202ResponseTag(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsImportFrom202ResponseTag value,
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
        public const string Imported = "imported";

        public const string Deduped = "deduped";

        public const string Accepted = "accepted";
    }
}
