using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocAnnotationsUpdate404ResponseName.DocAnnotationsUpdate404ResponseNameSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsUpdate404ResponseName : IStringEnum
{
    public static readonly DocAnnotationsUpdate404ResponseName EngineError = new(
        Values.EngineError
    );

    public DocAnnotationsUpdate404ResponseName(string value)
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
    public static DocAnnotationsUpdate404ResponseName FromCustom(string value)
    {
        return new DocAnnotationsUpdate404ResponseName(value);
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

    public static bool operator ==(DocAnnotationsUpdate404ResponseName value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocAnnotationsUpdate404ResponseName value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocAnnotationsUpdate404ResponseName value) =>
        value.Value;

    public static explicit operator DocAnnotationsUpdate404ResponseName(string value) => new(value);

    internal class DocAnnotationsUpdate404ResponseNameSerializer
        : JsonConverter<DocAnnotationsUpdate404ResponseName>
    {
        public override DocAnnotationsUpdate404ResponseName Read(
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
            return new DocAnnotationsUpdate404ResponseName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsUpdate404ResponseName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsUpdate404ResponseName ReadAsPropertyName(
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
            return new DocAnnotationsUpdate404ResponseName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsUpdate404ResponseName value,
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
