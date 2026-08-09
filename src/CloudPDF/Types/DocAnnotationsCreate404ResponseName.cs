using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsCreate404ResponseName.DocAnnotationsCreate404ResponseNameSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsCreate404ResponseName : IStringEnum
{
    public static readonly DocAnnotationsCreate404ResponseName EngineError = new(
        Values.EngineError
    );

    public DocAnnotationsCreate404ResponseName(string value)
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
    public static DocAnnotationsCreate404ResponseName FromCustom(string value)
    {
        return new DocAnnotationsCreate404ResponseName(value);
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

    public static bool operator ==(DocAnnotationsCreate404ResponseName value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocAnnotationsCreate404ResponseName value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocAnnotationsCreate404ResponseName value) =>
        value.Value;

    public static explicit operator DocAnnotationsCreate404ResponseName(string value) => new(value);

    internal class DocAnnotationsCreate404ResponseNameSerializer
        : JsonConverter<DocAnnotationsCreate404ResponseName>
    {
        public override DocAnnotationsCreate404ResponseName Read(
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
            return new DocAnnotationsCreate404ResponseName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsCreate404ResponseName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsCreate404ResponseName ReadAsPropertyName(
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
            return new DocAnnotationsCreate404ResponseName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsCreate404ResponseName value,
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
