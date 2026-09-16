using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesPrepare400ResponseName.DocSignaturesPrepare400ResponseNameSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesPrepare400ResponseName : IStringEnum
{
    public static readonly DocSignaturesPrepare400ResponseName EngineError = new(
        Values.EngineError
    );

    public DocSignaturesPrepare400ResponseName(string value)
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
    public static DocSignaturesPrepare400ResponseName FromCustom(string value)
    {
        return new DocSignaturesPrepare400ResponseName(value);
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

    public static bool operator ==(DocSignaturesPrepare400ResponseName value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocSignaturesPrepare400ResponseName value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesPrepare400ResponseName value) =>
        value.Value;

    public static explicit operator DocSignaturesPrepare400ResponseName(string value) => new(value);

    internal class DocSignaturesPrepare400ResponseNameSerializer
        : JsonConverter<DocSignaturesPrepare400ResponseName>
    {
        public override DocSignaturesPrepare400ResponseName Read(
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
            return new DocSignaturesPrepare400ResponseName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesPrepare400ResponseName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesPrepare400ResponseName ReadAsPropertyName(
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
            return new DocSignaturesPrepare400ResponseName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesPrepare400ResponseName value,
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
