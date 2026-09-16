using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocVersionsDownloadResponseName.DocVersionsDownloadResponseNameSerializer))]
[Serializable]
public readonly record struct DocVersionsDownloadResponseName : IStringEnum
{
    public static readonly DocVersionsDownloadResponseName EngineError = new(Values.EngineError);

    public DocVersionsDownloadResponseName(string value)
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
    public static DocVersionsDownloadResponseName FromCustom(string value)
    {
        return new DocVersionsDownloadResponseName(value);
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

    public static bool operator ==(DocVersionsDownloadResponseName value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocVersionsDownloadResponseName value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocVersionsDownloadResponseName value) => value.Value;

    public static explicit operator DocVersionsDownloadResponseName(string value) => new(value);

    internal class DocVersionsDownloadResponseNameSerializer
        : JsonConverter<DocVersionsDownloadResponseName>
    {
        public override DocVersionsDownloadResponseName Read(
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
            return new DocVersionsDownloadResponseName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsDownloadResponseName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsDownloadResponseName ReadAsPropertyName(
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
            return new DocVersionsDownloadResponseName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsDownloadResponseName value,
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
