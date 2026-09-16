using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesPrepare409ResponseName.DocSignaturesPrepare409ResponseNameSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesPrepare409ResponseName : IStringEnum
{
    public static readonly DocSignaturesPrepare409ResponseName EngineError = new(
        Values.EngineError
    );

    public DocSignaturesPrepare409ResponseName(string value)
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
    public static DocSignaturesPrepare409ResponseName FromCustom(string value)
    {
        return new DocSignaturesPrepare409ResponseName(value);
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

    public static bool operator ==(DocSignaturesPrepare409ResponseName value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocSignaturesPrepare409ResponseName value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesPrepare409ResponseName value) =>
        value.Value;

    public static explicit operator DocSignaturesPrepare409ResponseName(string value) => new(value);

    internal class DocSignaturesPrepare409ResponseNameSerializer
        : JsonConverter<DocSignaturesPrepare409ResponseName>
    {
        public override DocSignaturesPrepare409ResponseName Read(
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
            return new DocSignaturesPrepare409ResponseName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesPrepare409ResponseName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesPrepare409ResponseName ReadAsPropertyName(
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
            return new DocSignaturesPrepare409ResponseName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesPrepare409ResponseName value,
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
