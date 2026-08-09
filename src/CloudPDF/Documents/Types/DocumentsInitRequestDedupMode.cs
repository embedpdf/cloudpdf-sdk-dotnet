using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocumentsInitRequestDedupMode.DocumentsInitRequestDedupModeSerializer))]
[Serializable]
public readonly record struct DocumentsInitRequestDedupMode : IStringEnum
{
    public static readonly DocumentsInitRequestDedupMode AlwaysCreate = new(Values.AlwaysCreate);

    public static readonly DocumentsInitRequestDedupMode ReuseExisting = new(Values.ReuseExisting);

    public DocumentsInitRequestDedupMode(string value)
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
    public static DocumentsInitRequestDedupMode FromCustom(string value)
    {
        return new DocumentsInitRequestDedupMode(value);
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

    public static bool operator ==(DocumentsInitRequestDedupMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocumentsInitRequestDedupMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocumentsInitRequestDedupMode value) => value.Value;

    public static explicit operator DocumentsInitRequestDedupMode(string value) => new(value);

    internal class DocumentsInitRequestDedupModeSerializer
        : JsonConverter<DocumentsInitRequestDedupMode>
    {
        public override DocumentsInitRequestDedupMode Read(
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
            return new DocumentsInitRequestDedupMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsInitRequestDedupMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsInitRequestDedupMode ReadAsPropertyName(
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
            return new DocumentsInitRequestDedupMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsInitRequestDedupMode value,
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
        public const string AlwaysCreate = "always-create";

        public const string ReuseExisting = "reuse-existing";
    }
}
