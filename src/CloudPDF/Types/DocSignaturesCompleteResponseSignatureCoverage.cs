using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesCompleteResponseSignatureCoverage.DocSignaturesCompleteResponseSignatureCoverageSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesCompleteResponseSignatureCoverage : IStringEnum
{
    public static readonly DocSignaturesCompleteResponseSignatureCoverage WholeRevision = new(
        Values.WholeRevision
    );

    public static readonly DocSignaturesCompleteResponseSignatureCoverage Partial = new(
        Values.Partial
    );

    public static readonly DocSignaturesCompleteResponseSignatureCoverage Malformed = new(
        Values.Malformed
    );

    public DocSignaturesCompleteResponseSignatureCoverage(string value)
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
    public static DocSignaturesCompleteResponseSignatureCoverage FromCustom(string value)
    {
        return new DocSignaturesCompleteResponseSignatureCoverage(value);
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
        DocSignaturesCompleteResponseSignatureCoverage value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocSignaturesCompleteResponseSignatureCoverage value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesCompleteResponseSignatureCoverage value) =>
        value.Value;

    public static explicit operator DocSignaturesCompleteResponseSignatureCoverage(string value) =>
        new(value);

    internal class DocSignaturesCompleteResponseSignatureCoverageSerializer
        : JsonConverter<DocSignaturesCompleteResponseSignatureCoverage>
    {
        public override DocSignaturesCompleteResponseSignatureCoverage Read(
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
            return new DocSignaturesCompleteResponseSignatureCoverage(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesCompleteResponseSignatureCoverage value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesCompleteResponseSignatureCoverage ReadAsPropertyName(
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
            return new DocSignaturesCompleteResponseSignatureCoverage(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesCompleteResponseSignatureCoverage value,
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
