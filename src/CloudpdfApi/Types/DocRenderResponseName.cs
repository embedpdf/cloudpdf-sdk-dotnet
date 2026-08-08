using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(typeof(DocRenderResponseName.DocRenderResponseNameSerializer))]
[Serializable]
public readonly record struct DocRenderResponseName : IStringEnum
{
    public static readonly DocRenderResponseName EngineError = new(Values.EngineError);

    public DocRenderResponseName(string value)
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
    public static DocRenderResponseName FromCustom(string value)
    {
        return new DocRenderResponseName(value);
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

    public static bool operator ==(DocRenderResponseName value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocRenderResponseName value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocRenderResponseName value) => value.Value;

    public static explicit operator DocRenderResponseName(string value) => new(value);

    internal class DocRenderResponseNameSerializer : JsonConverter<DocRenderResponseName>
    {
        public override DocRenderResponseName Read(
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
            return new DocRenderResponseName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocRenderResponseName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocRenderResponseName ReadAsPropertyName(
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
            return new DocRenderResponseName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocRenderResponseName value,
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
