using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocSignaturesList404ResponseName.DocSignaturesList404ResponseNameSerializer))]
[Serializable]
public readonly record struct DocSignaturesList404ResponseName : IStringEnum
{
    public static readonly DocSignaturesList404ResponseName EngineError = new(Values.EngineError);

    public DocSignaturesList404ResponseName(string value)
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
    public static DocSignaturesList404ResponseName FromCustom(string value)
    {
        return new DocSignaturesList404ResponseName(value);
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

    public static bool operator ==(DocSignaturesList404ResponseName value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocSignaturesList404ResponseName value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesList404ResponseName value) => value.Value;

    public static explicit operator DocSignaturesList404ResponseName(string value) => new(value);

    internal class DocSignaturesList404ResponseNameSerializer
        : JsonConverter<DocSignaturesList404ResponseName>
    {
        public override DocSignaturesList404ResponseName Read(
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
            return new DocSignaturesList404ResponseName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesList404ResponseName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesList404ResponseName ReadAsPropertyName(
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
            return new DocSignaturesList404ResponseName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesList404ResponseName value,
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
