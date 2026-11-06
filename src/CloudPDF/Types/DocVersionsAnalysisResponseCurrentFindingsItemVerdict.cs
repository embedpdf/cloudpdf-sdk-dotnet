using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocVersionsAnalysisResponseCurrentFindingsItemVerdict.DocVersionsAnalysisResponseCurrentFindingsItemVerdictSerializer)
)]
[Serializable]
public readonly record struct DocVersionsAnalysisResponseCurrentFindingsItemVerdict : IStringEnum
{
    public static readonly DocVersionsAnalysisResponseCurrentFindingsItemVerdict Permitted = new(
        Values.Permitted
    );

    public static readonly DocVersionsAnalysisResponseCurrentFindingsItemVerdict Forbidden = new(
        Values.Forbidden
    );

    public static readonly DocVersionsAnalysisResponseCurrentFindingsItemVerdict Incomplete = new(
        Values.Incomplete
    );

    public DocVersionsAnalysisResponseCurrentFindingsItemVerdict(string value)
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
    public static DocVersionsAnalysisResponseCurrentFindingsItemVerdict FromCustom(string value)
    {
        return new DocVersionsAnalysisResponseCurrentFindingsItemVerdict(value);
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
        DocVersionsAnalysisResponseCurrentFindingsItemVerdict value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocVersionsAnalysisResponseCurrentFindingsItemVerdict value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocVersionsAnalysisResponseCurrentFindingsItemVerdict value
    ) => value.Value;

    public static explicit operator DocVersionsAnalysisResponseCurrentFindingsItemVerdict(
        string value
    ) => new(value);

    internal class DocVersionsAnalysisResponseCurrentFindingsItemVerdictSerializer
        : JsonConverter<DocVersionsAnalysisResponseCurrentFindingsItemVerdict>
    {
        public override DocVersionsAnalysisResponseCurrentFindingsItemVerdict Read(
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
            return new DocVersionsAnalysisResponseCurrentFindingsItemVerdict(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsAnalysisResponseCurrentFindingsItemVerdict value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsAnalysisResponseCurrentFindingsItemVerdict ReadAsPropertyName(
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
            return new DocVersionsAnalysisResponseCurrentFindingsItemVerdict(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsAnalysisResponseCurrentFindingsItemVerdict value,
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
