using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocVersionsAnalysisResponseCurrentPrimaryVerdict.DocVersionsAnalysisResponseCurrentPrimaryVerdictSerializer)
)]
[Serializable]
public readonly record struct DocVersionsAnalysisResponseCurrentPrimaryVerdict : IStringEnum
{
    public static readonly DocVersionsAnalysisResponseCurrentPrimaryVerdict Permitted = new(
        Values.Permitted
    );

    public static readonly DocVersionsAnalysisResponseCurrentPrimaryVerdict Forbidden = new(
        Values.Forbidden
    );

    public static readonly DocVersionsAnalysisResponseCurrentPrimaryVerdict Incomplete = new(
        Values.Incomplete
    );

    public DocVersionsAnalysisResponseCurrentPrimaryVerdict(string value)
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
    public static DocVersionsAnalysisResponseCurrentPrimaryVerdict FromCustom(string value)
    {
        return new DocVersionsAnalysisResponseCurrentPrimaryVerdict(value);
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
        DocVersionsAnalysisResponseCurrentPrimaryVerdict value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocVersionsAnalysisResponseCurrentPrimaryVerdict value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocVersionsAnalysisResponseCurrentPrimaryVerdict value
    ) => value.Value;

    public static explicit operator DocVersionsAnalysisResponseCurrentPrimaryVerdict(
        string value
    ) => new(value);

    internal class DocVersionsAnalysisResponseCurrentPrimaryVerdictSerializer
        : JsonConverter<DocVersionsAnalysisResponseCurrentPrimaryVerdict>
    {
        public override DocVersionsAnalysisResponseCurrentPrimaryVerdict Read(
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
            return new DocVersionsAnalysisResponseCurrentPrimaryVerdict(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsAnalysisResponseCurrentPrimaryVerdict value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsAnalysisResponseCurrentPrimaryVerdict ReadAsPropertyName(
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
            return new DocVersionsAnalysisResponseCurrentPrimaryVerdict(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsAnalysisResponseCurrentPrimaryVerdict value,
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
