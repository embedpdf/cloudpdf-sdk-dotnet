using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesComplete400ResponseName.DocSignaturesComplete400ResponseNameSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesComplete400ResponseName : IStringEnum
{
    public static readonly DocSignaturesComplete400ResponseName EngineError = new(
        Values.EngineError
    );

    public DocSignaturesComplete400ResponseName(string value)
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
    public static DocSignaturesComplete400ResponseName FromCustom(string value)
    {
        return new DocSignaturesComplete400ResponseName(value);
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

    public static bool operator ==(DocSignaturesComplete400ResponseName value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocSignaturesComplete400ResponseName value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesComplete400ResponseName value) =>
        value.Value;

    public static explicit operator DocSignaturesComplete400ResponseName(string value) =>
        new(value);

    internal class DocSignaturesComplete400ResponseNameSerializer
        : JsonConverter<DocSignaturesComplete400ResponseName>
    {
        public override DocSignaturesComplete400ResponseName Read(
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
            return new DocSignaturesComplete400ResponseName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesComplete400ResponseName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesComplete400ResponseName ReadAsPropertyName(
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
            return new DocSignaturesComplete400ResponseName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesComplete400ResponseName value,
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
