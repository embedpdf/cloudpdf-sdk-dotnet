using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesAnalysisResponseCurrentFindingsItemVerdict.DocSignaturesAnalysisResponseCurrentFindingsItemVerdictSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesAnalysisResponseCurrentFindingsItemVerdict : IStringEnum
{
    public static readonly DocSignaturesAnalysisResponseCurrentFindingsItemVerdict Permitted = new(
        Values.Permitted
    );

    public static readonly DocSignaturesAnalysisResponseCurrentFindingsItemVerdict Forbidden = new(
        Values.Forbidden
    );

    public static readonly DocSignaturesAnalysisResponseCurrentFindingsItemVerdict Incomplete = new(
        Values.Incomplete
    );

    public DocSignaturesAnalysisResponseCurrentFindingsItemVerdict(string value)
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
    public static DocSignaturesAnalysisResponseCurrentFindingsItemVerdict FromCustom(string value)
    {
        return new DocSignaturesAnalysisResponseCurrentFindingsItemVerdict(value);
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
        DocSignaturesAnalysisResponseCurrentFindingsItemVerdict value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocSignaturesAnalysisResponseCurrentFindingsItemVerdict value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocSignaturesAnalysisResponseCurrentFindingsItemVerdict value
    ) => value.Value;

    public static explicit operator DocSignaturesAnalysisResponseCurrentFindingsItemVerdict(
        string value
    ) => new(value);

    internal class DocSignaturesAnalysisResponseCurrentFindingsItemVerdictSerializer
        : JsonConverter<DocSignaturesAnalysisResponseCurrentFindingsItemVerdict>
    {
        public override DocSignaturesAnalysisResponseCurrentFindingsItemVerdict Read(
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
            return new DocSignaturesAnalysisResponseCurrentFindingsItemVerdict(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesAnalysisResponseCurrentFindingsItemVerdict value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesAnalysisResponseCurrentFindingsItemVerdict ReadAsPropertyName(
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
            return new DocSignaturesAnalysisResponseCurrentFindingsItemVerdict(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesAnalysisResponseCurrentFindingsItemVerdict value,
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
