using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesAnalysisResponseCurrentPrimaryVerdict.DocSignaturesAnalysisResponseCurrentPrimaryVerdictSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesAnalysisResponseCurrentPrimaryVerdict : IStringEnum
{
    public static readonly DocSignaturesAnalysisResponseCurrentPrimaryVerdict Permitted = new(
        Values.Permitted
    );

    public static readonly DocSignaturesAnalysisResponseCurrentPrimaryVerdict Forbidden = new(
        Values.Forbidden
    );

    public static readonly DocSignaturesAnalysisResponseCurrentPrimaryVerdict Incomplete = new(
        Values.Incomplete
    );

    public DocSignaturesAnalysisResponseCurrentPrimaryVerdict(string value)
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
    public static DocSignaturesAnalysisResponseCurrentPrimaryVerdict FromCustom(string value)
    {
        return new DocSignaturesAnalysisResponseCurrentPrimaryVerdict(value);
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
        DocSignaturesAnalysisResponseCurrentPrimaryVerdict value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocSignaturesAnalysisResponseCurrentPrimaryVerdict value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocSignaturesAnalysisResponseCurrentPrimaryVerdict value
    ) => value.Value;

    public static explicit operator DocSignaturesAnalysisResponseCurrentPrimaryVerdict(
        string value
    ) => new(value);

    internal class DocSignaturesAnalysisResponseCurrentPrimaryVerdictSerializer
        : JsonConverter<DocSignaturesAnalysisResponseCurrentPrimaryVerdict>
    {
        public override DocSignaturesAnalysisResponseCurrentPrimaryVerdict Read(
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
            return new DocSignaturesAnalysisResponseCurrentPrimaryVerdict(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesAnalysisResponseCurrentPrimaryVerdict value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesAnalysisResponseCurrentPrimaryVerdict ReadAsPropertyName(
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
            return new DocSignaturesAnalysisResponseCurrentPrimaryVerdict(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesAnalysisResponseCurrentPrimaryVerdict value,
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
        public const string Permitted = "permitted";

        public const string Forbidden = "forbidden";

        public const string Incomplete = "incomplete";
    }
}
