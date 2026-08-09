using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocDownloadResponseName.DocDownloadResponseNameSerializer))]
[Serializable]
public readonly record struct DocDownloadResponseName : IStringEnum
{
    public static readonly DocDownloadResponseName EngineError = new(Values.EngineError);

    public DocDownloadResponseName(string value)
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
    public static DocDownloadResponseName FromCustom(string value)
    {
        return new DocDownloadResponseName(value);
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

    public static bool operator ==(DocDownloadResponseName value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocDownloadResponseName value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocDownloadResponseName value) => value.Value;

    public static explicit operator DocDownloadResponseName(string value) => new(value);

    internal class DocDownloadResponseNameSerializer : JsonConverter<DocDownloadResponseName>
    {
        public override DocDownloadResponseName Read(
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
            return new DocDownloadResponseName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocDownloadResponseName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocDownloadResponseName ReadAsPropertyName(
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
            return new DocDownloadResponseName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocDownloadResponseName value,
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
        public const string EngineError = "EngineError";
    }
}
