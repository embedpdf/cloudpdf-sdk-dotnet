using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesPrepare200ResponseAlgorithm.DocSignaturesPrepare200ResponseAlgorithmSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesPrepare200ResponseAlgorithm : IStringEnum
{
    public static readonly DocSignaturesPrepare200ResponseAlgorithm Sha256 = new(Values.Sha256);

    public static readonly DocSignaturesPrepare200ResponseAlgorithm Sha384 = new(Values.Sha384);

    public static readonly DocSignaturesPrepare200ResponseAlgorithm Sha512 = new(Values.Sha512);

    public DocSignaturesPrepare200ResponseAlgorithm(string value)
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
    public static DocSignaturesPrepare200ResponseAlgorithm FromCustom(string value)
    {
        return new DocSignaturesPrepare200ResponseAlgorithm(value);
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

    public static bool operator ==(
        DocSignaturesPrepare200ResponseAlgorithm value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocSignaturesPrepare200ResponseAlgorithm value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesPrepare200ResponseAlgorithm value) =>
        value.Value;

    public static explicit operator DocSignaturesPrepare200ResponseAlgorithm(string value) =>
        new(value);

    internal class DocSignaturesPrepare200ResponseAlgorithmSerializer
        : JsonConverter<DocSignaturesPrepare200ResponseAlgorithm>
    {
        public override DocSignaturesPrepare200ResponseAlgorithm Read(
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
            return new DocSignaturesPrepare200ResponseAlgorithm(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesPrepare200ResponseAlgorithm value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesPrepare200ResponseAlgorithm ReadAsPropertyName(
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
            return new DocSignaturesPrepare200ResponseAlgorithm(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesPrepare200ResponseAlgorithm value,
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
        public const string Sha256 = "sha256";

        public const string Sha384 = "sha384";

        public const string Sha512 = "sha512";
    }
}
