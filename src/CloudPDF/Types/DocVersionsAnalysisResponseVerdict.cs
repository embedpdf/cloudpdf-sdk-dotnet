using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocVersionsAnalysisResponseVerdict.DocVersionsAnalysisResponseVerdictSerializer)
)]
[Serializable]
public readonly record struct DocVersionsAnalysisResponseVerdict : IStringEnum
{
    public static readonly DocVersionsAnalysisResponseVerdict Unchanged = new(Values.Unchanged);

    public static readonly DocVersionsAnalysisResponseVerdict Permitted = new(Values.Permitted);

    public static readonly DocVersionsAnalysisResponseVerdict Forbidden = new(Values.Forbidden);

    public static readonly DocVersionsAnalysisResponseVerdict Indeterminate = new(
        Values.Indeterminate
    );

    public DocVersionsAnalysisResponseVerdict(string value)
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
    public static DocVersionsAnalysisResponseVerdict FromCustom(string value)
    {
        return new DocVersionsAnalysisResponseVerdict(value);
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

    public static bool operator ==(DocVersionsAnalysisResponseVerdict value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocVersionsAnalysisResponseVerdict value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocVersionsAnalysisResponseVerdict value) => value.Value;

    public static explicit operator DocVersionsAnalysisResponseVerdict(string value) => new(value);

    internal class DocVersionsAnalysisResponseVerdictSerializer
        : JsonConverter<DocVersionsAnalysisResponseVerdict>
    {
        public override DocVersionsAnalysisResponseVerdict Read(
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
            return new DocVersionsAnalysisResponseVerdict(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsAnalysisResponseVerdict value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsAnalysisResponseVerdict ReadAsPropertyName(
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
            return new DocVersionsAnalysisResponseVerdict(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsAnalysisResponseVerdict value,
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
        public const string Unchanged = "unchanged";

        public const string Permitted = "permitted";

        public const string Forbidden = "forbidden";

        public const string Indeterminate = "indeterminate";
    }
}
