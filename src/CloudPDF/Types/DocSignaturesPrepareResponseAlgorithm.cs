using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesPrepareResponseAlgorithm.DocSignaturesPrepareResponseAlgorithmSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesPrepareResponseAlgorithm : IStringEnum
{
    public static readonly DocSignaturesPrepareResponseAlgorithm Sha256 = new(Values.Sha256);

    public static readonly DocSignaturesPrepareResponseAlgorithm Sha384 = new(Values.Sha384);

    public static readonly DocSignaturesPrepareResponseAlgorithm Sha512 = new(Values.Sha512);

    public DocSignaturesPrepareResponseAlgorithm(string value)
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
    public static DocSignaturesPrepareResponseAlgorithm FromCustom(string value)
    {
        return new DocSignaturesPrepareResponseAlgorithm(value);
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

    public static bool operator ==(DocSignaturesPrepareResponseAlgorithm value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocSignaturesPrepareResponseAlgorithm value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesPrepareResponseAlgorithm value) =>
        value.Value;

    public static explicit operator DocSignaturesPrepareResponseAlgorithm(string value) =>
        new(value);

    internal class DocSignaturesPrepareResponseAlgorithmSerializer
        : JsonConverter<DocSignaturesPrepareResponseAlgorithm>
    {
        public override DocSignaturesPrepareResponseAlgorithm Read(
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
            return new DocSignaturesPrepareResponseAlgorithm(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesPrepareResponseAlgorithm value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesPrepareResponseAlgorithm ReadAsPropertyName(
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
            return new DocSignaturesPrepareResponseAlgorithm(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesPrepareResponseAlgorithm value,
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
