using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesComplete200ResponseSignatureCoverage.DocSignaturesComplete200ResponseSignatureCoverageSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesComplete200ResponseSignatureCoverage : IStringEnum
{
    public static readonly DocSignaturesComplete200ResponseSignatureCoverage WholeRevision = new(
        Values.WholeRevision
    );

    public static readonly DocSignaturesComplete200ResponseSignatureCoverage Partial = new(
        Values.Partial
    );

    public static readonly DocSignaturesComplete200ResponseSignatureCoverage Malformed = new(
        Values.Malformed
    );

    public DocSignaturesComplete200ResponseSignatureCoverage(string value)
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
    public static DocSignaturesComplete200ResponseSignatureCoverage FromCustom(string value)
    {
        return new DocSignaturesComplete200ResponseSignatureCoverage(value);
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
        DocSignaturesComplete200ResponseSignatureCoverage value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocSignaturesComplete200ResponseSignatureCoverage value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocSignaturesComplete200ResponseSignatureCoverage value
    ) => value.Value;

    public static explicit operator DocSignaturesComplete200ResponseSignatureCoverage(
        string value
    ) => new(value);

    internal class DocSignaturesComplete200ResponseSignatureCoverageSerializer
        : JsonConverter<DocSignaturesComplete200ResponseSignatureCoverage>
    {
        public override DocSignaturesComplete200ResponseSignatureCoverage Read(
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
            return new DocSignaturesComplete200ResponseSignatureCoverage(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesComplete200ResponseSignatureCoverage value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesComplete200ResponseSignatureCoverage ReadAsPropertyName(
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
            return new DocSignaturesComplete200ResponseSignatureCoverage(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesComplete200ResponseSignatureCoverage value,
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
