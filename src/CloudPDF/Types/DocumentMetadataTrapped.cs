using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocumentMetadataTrapped.DocumentMetadataTrappedSerializer))]
[Serializable]
public readonly record struct DocumentMetadataTrapped : IStringEnum
{
    public static readonly DocumentMetadataTrapped True = new(Values.True);

    public static readonly DocumentMetadataTrapped False = new(Values.False);

    public static readonly DocumentMetadataTrapped Unknown = new(Values.Unknown);

    public DocumentMetadataTrapped(string value)
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
    public static DocumentMetadataTrapped FromCustom(string value)
    {
        return new DocumentMetadataTrapped(value);
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

    public static bool operator ==(DocumentMetadataTrapped value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocumentMetadataTrapped value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocumentMetadataTrapped value) => value.Value;

    public static explicit operator DocumentMetadataTrapped(string value) => new(value);

    internal class DocumentMetadataTrappedSerializer : JsonConverter<DocumentMetadataTrapped>
    {
        public override DocumentMetadataTrapped Read(
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
            return new DocumentMetadataTrapped(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentMetadataTrapped value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentMetadataTrapped ReadAsPropertyName(
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
            return new DocumentMetadataTrapped(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentMetadataTrapped value,
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
        public const string True = "true";

        public const string False = "false";

        public const string Unknown = "unknown";
    }
}
