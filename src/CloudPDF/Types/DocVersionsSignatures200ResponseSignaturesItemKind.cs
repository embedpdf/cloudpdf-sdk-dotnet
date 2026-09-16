using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocVersionsSignatures200ResponseSignaturesItemKind.DocVersionsSignatures200ResponseSignaturesItemKindSerializer)
)]
[Serializable]
public readonly record struct DocVersionsSignatures200ResponseSignaturesItemKind : IStringEnum
{
    public static readonly DocVersionsSignatures200ResponseSignaturesItemKind Signature = new(
        Values.Signature
    );

    public static readonly DocVersionsSignatures200ResponseSignaturesItemKind Timestamp = new(
        Values.Timestamp
    );

    public DocVersionsSignatures200ResponseSignaturesItemKind(string value)
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
    public static DocVersionsSignatures200ResponseSignaturesItemKind FromCustom(string value)
    {
        return new DocVersionsSignatures200ResponseSignaturesItemKind(value);
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
        DocVersionsSignatures200ResponseSignaturesItemKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocVersionsSignatures200ResponseSignaturesItemKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocVersionsSignatures200ResponseSignaturesItemKind value
    ) => value.Value;

    public static explicit operator DocVersionsSignatures200ResponseSignaturesItemKind(
        string value
    ) => new(value);

    internal class DocVersionsSignatures200ResponseSignaturesItemKindSerializer
        : JsonConverter<DocVersionsSignatures200ResponseSignaturesItemKind>
    {
        public override DocVersionsSignatures200ResponseSignaturesItemKind Read(
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
            return new DocVersionsSignatures200ResponseSignaturesItemKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsSignatures200ResponseSignaturesItemKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsSignatures200ResponseSignaturesItemKind ReadAsPropertyName(
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
            return new DocVersionsSignatures200ResponseSignaturesItemKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsSignatures200ResponseSignaturesItemKind value,
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
