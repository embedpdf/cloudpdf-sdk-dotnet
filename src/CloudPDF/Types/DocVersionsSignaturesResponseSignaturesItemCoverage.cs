using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocVersionsSignaturesResponseSignaturesItemCoverage.DocVersionsSignaturesResponseSignaturesItemCoverageSerializer)
)]
[Serializable]
public readonly record struct DocVersionsSignaturesResponseSignaturesItemCoverage : IStringEnum
{
    public static readonly DocVersionsSignaturesResponseSignaturesItemCoverage WholeRevision = new(
        Values.WholeRevision
    );

    public static readonly DocVersionsSignaturesResponseSignaturesItemCoverage Partial = new(
        Values.Partial
    );

    public static readonly DocVersionsSignaturesResponseSignaturesItemCoverage Malformed = new(
        Values.Malformed
    );

    public DocVersionsSignaturesResponseSignaturesItemCoverage(string value)
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
    public static DocVersionsSignaturesResponseSignaturesItemCoverage FromCustom(string value)
    {
        return new DocVersionsSignaturesResponseSignaturesItemCoverage(value);
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
        DocVersionsSignaturesResponseSignaturesItemCoverage value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocVersionsSignaturesResponseSignaturesItemCoverage value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocVersionsSignaturesResponseSignaturesItemCoverage value
    ) => value.Value;

    public static explicit operator DocVersionsSignaturesResponseSignaturesItemCoverage(
        string value
    ) => new(value);

    internal class DocVersionsSignaturesResponseSignaturesItemCoverageSerializer
        : JsonConverter<DocVersionsSignaturesResponseSignaturesItemCoverage>
    {
        public override DocVersionsSignaturesResponseSignaturesItemCoverage Read(
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
            return new DocVersionsSignaturesResponseSignaturesItemCoverage(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsSignaturesResponseSignaturesItemCoverage value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsSignaturesResponseSignaturesItemCoverage ReadAsPropertyName(
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
            return new DocVersionsSignaturesResponseSignaturesItemCoverage(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsSignaturesResponseSignaturesItemCoverage value,
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
