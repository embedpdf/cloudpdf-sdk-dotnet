using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesComplete200ResponseSignatureKind.DocSignaturesComplete200ResponseSignatureKindSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesComplete200ResponseSignatureKind : IStringEnum
{
    public static readonly DocSignaturesComplete200ResponseSignatureKind Signature = new(
        Values.Signature
    );

    public static readonly DocSignaturesComplete200ResponseSignatureKind Timestamp = new(
        Values.Timestamp
    );

    public DocSignaturesComplete200ResponseSignatureKind(string value)
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
    public static DocSignaturesComplete200ResponseSignatureKind FromCustom(string value)
    {
        return new DocSignaturesComplete200ResponseSignatureKind(value);
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
        DocSignaturesComplete200ResponseSignatureKind value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocSignaturesComplete200ResponseSignatureKind value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesComplete200ResponseSignatureKind value) =>
        value.Value;

    public static explicit operator DocSignaturesComplete200ResponseSignatureKind(string value) =>
        new(value);

    internal class DocSignaturesComplete200ResponseSignatureKindSerializer
        : JsonConverter<DocSignaturesComplete200ResponseSignatureKind>
    {
        public override DocSignaturesComplete200ResponseSignatureKind Read(
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
            return new DocSignaturesComplete200ResponseSignatureKind(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesComplete200ResponseSignatureKind value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesComplete200ResponseSignatureKind ReadAsPropertyName(
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
            return new DocSignaturesComplete200ResponseSignatureKind(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesComplete200ResponseSignatureKind value,
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
