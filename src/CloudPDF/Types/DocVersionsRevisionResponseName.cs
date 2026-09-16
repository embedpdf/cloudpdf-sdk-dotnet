using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocVersionsRevisionResponseName.DocVersionsRevisionResponseNameSerializer))]
[Serializable]
public readonly record struct DocVersionsRevisionResponseName : IStringEnum
{
    public static readonly DocVersionsRevisionResponseName EngineError = new(Values.EngineError);

    public DocVersionsRevisionResponseName(string value)
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
    public static DocVersionsRevisionResponseName FromCustom(string value)
    {
        return new DocVersionsRevisionResponseName(value);
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

    public static bool operator ==(DocVersionsRevisionResponseName value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocVersionsRevisionResponseName value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocVersionsRevisionResponseName value) => value.Value;

    public static explicit operator DocVersionsRevisionResponseName(string value) => new(value);

    internal class DocVersionsRevisionResponseNameSerializer
        : JsonConverter<DocVersionsRevisionResponseName>
    {
        public override DocVersionsRevisionResponseName Read(
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
            return new DocVersionsRevisionResponseName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsRevisionResponseName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsRevisionResponseName ReadAsPropertyName(
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
            return new DocVersionsRevisionResponseName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsRevisionResponseName value,
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
