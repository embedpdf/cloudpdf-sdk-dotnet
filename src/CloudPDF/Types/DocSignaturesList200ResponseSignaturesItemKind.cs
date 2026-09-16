using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesList200ResponseSignaturesItemKind.DocSignaturesList200ResponseSignaturesItemKindSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesList200ResponseSignaturesItemKind : IStringEnum
{
    public static readonly DocSignaturesList200ResponseSignaturesItemKind Signature = new(
        Values.Signature
    );

    public static readonly DocSignaturesList200ResponseSignaturesItemKind Timestamp = new(
        Values.Timestamp
    );

    public DocSignaturesList200ResponseSignaturesItemKind(string value)
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
    public static DocSignaturesList200ResponseSignaturesItemKind FromCustom(string value)
    {
        return new DocSignaturesList200ResponseSignaturesItemKind(value);
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
        DocSignaturesList200ResponseSignaturesItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocSignaturesList200ResponseSignaturesItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesList200ResponseSignaturesItemKind value) =>
        value.Value;

    public static explicit operator DocSignaturesList200ResponseSignaturesItemKind(string value) =>
        new(value);

    internal class DocSignaturesList200ResponseSignaturesItemKindSerializer
        : JsonConverter<DocSignaturesList200ResponseSignaturesItemKind>
    {
        public override DocSignaturesList200ResponseSignaturesItemKind Read(
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
            return new DocSignaturesList200ResponseSignaturesItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesList200ResponseSignaturesItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesList200ResponseSignaturesItemKind ReadAsPropertyName(
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
            return new DocSignaturesList200ResponseSignaturesItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesList200ResponseSignaturesItemKind value,
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
