using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocumentsImportFromRequestMode.DocumentsImportFromRequestModeSerializer))]
[Serializable]
public readonly record struct DocumentsImportFromRequestMode : IStringEnum
{
    public static readonly DocumentsImportFromRequestMode Sync = new(Values.Sync);

    public static readonly DocumentsImportFromRequestMode Async = new(Values.Async);

    public DocumentsImportFromRequestMode(string value)
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
    public static DocumentsImportFromRequestMode FromCustom(string value)
    {
        return new DocumentsImportFromRequestMode(value);
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

    public static bool operator ==(DocumentsImportFromRequestMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocumentsImportFromRequestMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocumentsImportFromRequestMode value) => value.Value;

    public static explicit operator DocumentsImportFromRequestMode(string value) => new(value);

    internal class DocumentsImportFromRequestModeSerializer
        : JsonConverter<DocumentsImportFromRequestMode>
    {
        public override DocumentsImportFromRequestMode Read(
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
            return new DocumentsImportFromRequestMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsImportFromRequestMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsImportFromRequestMode ReadAsPropertyName(
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
            return new DocumentsImportFromRequestMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsImportFromRequestMode value,
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
        public const string Sync = "sync";

        public const string Async = "async";
    }
}
