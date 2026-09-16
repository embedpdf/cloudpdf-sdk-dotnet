using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocVersionsAnalysis200ResponseCurrentFindingsItemVerdict.DocVersionsAnalysis200ResponseCurrentFindingsItemVerdictSerializer)
)]
[Serializable]
public readonly record struct DocVersionsAnalysis200ResponseCurrentFindingsItemVerdict : IStringEnum
{
    public static readonly DocVersionsAnalysis200ResponseCurrentFindingsItemVerdict Permitted = new(
        Values.Permitted
    );

    public static readonly DocVersionsAnalysis200ResponseCurrentFindingsItemVerdict Forbidden = new(
        Values.Forbidden
    );

    public static readonly DocVersionsAnalysis200ResponseCurrentFindingsItemVerdict Incomplete =
        new(Values.Incomplete);

    public DocVersionsAnalysis200ResponseCurrentFindingsItemVerdict(string value)
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
    public static DocVersionsAnalysis200ResponseCurrentFindingsItemVerdict FromCustom(string value)
    {
        return new DocVersionsAnalysis200ResponseCurrentFindingsItemVerdict(value);
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
        DocVersionsAnalysis200ResponseCurrentFindingsItemVerdict value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocVersionsAnalysis200ResponseCurrentFindingsItemVerdict value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocVersionsAnalysis200ResponseCurrentFindingsItemVerdict value
    ) => value.Value;

    public static explicit operator DocVersionsAnalysis200ResponseCurrentFindingsItemVerdict(
        string value
    ) => new(value);

    internal class DocVersionsAnalysis200ResponseCurrentFindingsItemVerdictSerializer
        : JsonConverter<DocVersionsAnalysis200ResponseCurrentFindingsItemVerdict>
    {
        public override DocVersionsAnalysis200ResponseCurrentFindingsItemVerdict Read(
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
            return new DocVersionsAnalysis200ResponseCurrentFindingsItemVerdict(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsAnalysis200ResponseCurrentFindingsItemVerdict value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsAnalysis200ResponseCurrentFindingsItemVerdict ReadAsPropertyName(
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
            return new DocVersionsAnalysis200ResponseCurrentFindingsItemVerdict(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsAnalysis200ResponseCurrentFindingsItemVerdict value,
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
