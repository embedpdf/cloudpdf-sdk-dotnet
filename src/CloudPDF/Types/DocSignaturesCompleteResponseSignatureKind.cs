using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesCompleteResponseSignatureKind.DocSignaturesCompleteResponseSignatureKindSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesCompleteResponseSignatureKind : IStringEnum
{
    public static readonly DocSignaturesCompleteResponseSignatureKind Signature = new(
        Values.Signature
    );

    public static readonly DocSignaturesCompleteResponseSignatureKind Timestamp = new(
        Values.Timestamp
    );

    public DocSignaturesCompleteResponseSignatureKind(string value)
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
    public static DocSignaturesCompleteResponseSignatureKind FromCustom(string value)
    {
        return new DocSignaturesCompleteResponseSignatureKind(value);
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
        DocSignaturesCompleteResponseSignatureKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocSignaturesCompleteResponseSignatureKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesCompleteResponseSignatureKind value) =>
        value.Value;

    public static explicit operator DocSignaturesCompleteResponseSignatureKind(string value) =>
        new(value);

    internal class DocSignaturesCompleteResponseSignatureKindSerializer
        : JsonConverter<DocSignaturesCompleteResponseSignatureKind>
    {
        public override DocSignaturesCompleteResponseSignatureKind Read(
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
            return new DocSignaturesCompleteResponseSignatureKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesCompleteResponseSignatureKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesCompleteResponseSignatureKind ReadAsPropertyName(
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
            return new DocSignaturesCompleteResponseSignatureKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesCompleteResponseSignatureKind value,
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
        public const string Signature = "signature";

        public const string Timestamp = "timestamp";
    }
}
