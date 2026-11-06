using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocVersionsAnalysisResponseCurrentVerdict.DocVersionsAnalysisResponseCurrentVerdictSerializer)
)]
[Serializable]
public readonly record struct DocVersionsAnalysisResponseCurrentVerdict : IStringEnum
{
    public static readonly DocVersionsAnalysisResponseCurrentVerdict Unchanged = new(
        Values.Unchanged
    );

    public static readonly DocVersionsAnalysisResponseCurrentVerdict Permitted = new(
        Values.Permitted
    );

    public static readonly DocVersionsAnalysisResponseCurrentVerdict Forbidden = new(
        Values.Forbidden
    );

    public static readonly DocVersionsAnalysisResponseCurrentVerdict Indeterminate = new(
        Values.Indeterminate
    );

    public DocVersionsAnalysisResponseCurrentVerdict(string value)
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
    public static DocVersionsAnalysisResponseCurrentVerdict FromCustom(string value)
    {
        return new DocVersionsAnalysisResponseCurrentVerdict(value);
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
        DocVersionsAnalysisResponseCurrentVerdict value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocVersionsAnalysisResponseCurrentVerdict value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocVersionsAnalysisResponseCurrentVerdict value) =>
        value.Value;

    public static explicit operator DocVersionsAnalysisResponseCurrentVerdict(string value) =>
        new(value);

    internal class DocVersionsAnalysisResponseCurrentVerdictSerializer
        : JsonConverter<DocVersionsAnalysisResponseCurrentVerdict>
    {
        public override DocVersionsAnalysisResponseCurrentVerdict Read(
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
            return new DocVersionsAnalysisResponseCurrentVerdict(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsAnalysisResponseCurrentVerdict value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsAnalysisResponseCurrentVerdict ReadAsPropertyName(
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
            return new DocVersionsAnalysisResponseCurrentVerdict(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsAnalysisResponseCurrentVerdict value,
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
