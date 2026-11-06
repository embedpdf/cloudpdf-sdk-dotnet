using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesListResponseSignaturesItemCoverage.DocSignaturesListResponseSignaturesItemCoverageSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesListResponseSignaturesItemCoverage : IStringEnum
{
    public static readonly DocSignaturesListResponseSignaturesItemCoverage WholeRevision = new(
        Values.WholeRevision
    );

    public static readonly DocSignaturesListResponseSignaturesItemCoverage Partial = new(
        Values.Partial
    );

    public static readonly DocSignaturesListResponseSignaturesItemCoverage Malformed = new(
        Values.Malformed
    );

    public DocSignaturesListResponseSignaturesItemCoverage(string value)
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
    public static DocSignaturesListResponseSignaturesItemCoverage FromCustom(string value)
    {
        return new DocSignaturesListResponseSignaturesItemCoverage(value);
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
        DocSignaturesListResponseSignaturesItemCoverage value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocSignaturesListResponseSignaturesItemCoverage value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesListResponseSignaturesItemCoverage value) =>
        value.Value;

    public static explicit operator DocSignaturesListResponseSignaturesItemCoverage(string value) =>
        new(value);

    internal class DocSignaturesListResponseSignaturesItemCoverageSerializer
        : JsonConverter<DocSignaturesListResponseSignaturesItemCoverage>
    {
        public override DocSignaturesListResponseSignaturesItemCoverage Read(
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
            return new DocSignaturesListResponseSignaturesItemCoverage(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesListResponseSignaturesItemCoverage value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesListResponseSignaturesItemCoverage ReadAsPropertyName(
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
            return new DocSignaturesListResponseSignaturesItemCoverage(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesListResponseSignaturesItemCoverage value,
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
