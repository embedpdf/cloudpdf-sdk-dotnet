using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocVersionsSignatureDigestResponseName.DocVersionsSignatureDigestResponseNameSerializer)
)]
[Serializable]
public readonly record struct DocVersionsSignatureDigestResponseName : IStringEnum
{
    public static readonly DocVersionsSignatureDigestResponseName EngineError = new(
        Values.EngineError
    );

    public DocVersionsSignatureDigestResponseName(string value)
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
    public static DocVersionsSignatureDigestResponseName FromCustom(string value)
    {
        return new DocVersionsSignatureDigestResponseName(value);
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

    public static bool operator ==(DocVersionsSignatureDigestResponseName value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocVersionsSignatureDigestResponseName value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocVersionsSignatureDigestResponseName value) =>
        value.Value;

    public static explicit operator DocVersionsSignatureDigestResponseName(string value) =>
        new(value);

    internal class DocVersionsSignatureDigestResponseNameSerializer
        : JsonConverter<DocVersionsSignatureDigestResponseName>
    {
        public override DocVersionsSignatureDigestResponseName Read(
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
            return new DocVersionsSignatureDigestResponseName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsSignatureDigestResponseName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsSignatureDigestResponseName ReadAsPropertyName(
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
            return new DocVersionsSignatureDigestResponseName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsSignatureDigestResponseName value,
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
