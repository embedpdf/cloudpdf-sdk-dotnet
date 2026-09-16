using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesList200ResponseSignaturesItemCoverage.DocSignaturesList200ResponseSignaturesItemCoverageSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesList200ResponseSignaturesItemCoverage : IStringEnum
{
    public static readonly DocSignaturesList200ResponseSignaturesItemCoverage WholeRevision = new(
        Values.WholeRevision
    );

    public static readonly DocSignaturesList200ResponseSignaturesItemCoverage Partial = new(
        Values.Partial
    );

    public static readonly DocSignaturesList200ResponseSignaturesItemCoverage Malformed = new(
        Values.Malformed
    );

    public DocSignaturesList200ResponseSignaturesItemCoverage(string value)
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
    public static DocSignaturesList200ResponseSignaturesItemCoverage FromCustom(string value)
    {
        return new DocSignaturesList200ResponseSignaturesItemCoverage(value);
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
        DocSignaturesList200ResponseSignaturesItemCoverage value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocSignaturesList200ResponseSignaturesItemCoverage value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocSignaturesList200ResponseSignaturesItemCoverage value
    ) => value.Value;

    public static explicit operator DocSignaturesList200ResponseSignaturesItemCoverage(
        string value
    ) => new(value);

    internal class DocSignaturesList200ResponseSignaturesItemCoverageSerializer
        : JsonConverter<DocSignaturesList200ResponseSignaturesItemCoverage>
    {
        public override DocSignaturesList200ResponseSignaturesItemCoverage Read(
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
            return new DocSignaturesList200ResponseSignaturesItemCoverage(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesList200ResponseSignaturesItemCoverage value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesList200ResponseSignaturesItemCoverage ReadAsPropertyName(
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
            return new DocSignaturesList200ResponseSignaturesItemCoverage(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesList200ResponseSignaturesItemCoverage value,
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
        public const string WholeRevision = "whole-revision";

        public const string Partial = "partial";

        public const string Malformed = "malformed";
    }
}
