using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocVersionsAnalysisResponseBasisSource.DocVersionsAnalysisResponseBasisSourceSerializer)
)]
[Serializable]
public readonly record struct DocVersionsAnalysisResponseBasisSource : IStringEnum
{
    public static readonly DocVersionsAnalysisResponseBasisSource Persisted = new(Values.Persisted);

    public static readonly DocVersionsAnalysisResponseBasisSource WorkingCopy = new(
        Values.WorkingCopy
    );

    public DocVersionsAnalysisResponseBasisSource(string value)
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
    public static DocVersionsAnalysisResponseBasisSource FromCustom(string value)
    {
        return new DocVersionsAnalysisResponseBasisSource(value);
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

    public static bool operator ==(DocVersionsAnalysisResponseBasisSource value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocVersionsAnalysisResponseBasisSource value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocVersionsAnalysisResponseBasisSource value) =>
        value.Value;

    public static explicit operator DocVersionsAnalysisResponseBasisSource(string value) =>
        new(value);

    internal class DocVersionsAnalysisResponseBasisSourceSerializer
        : JsonConverter<DocVersionsAnalysisResponseBasisSource>
    {
        public override DocVersionsAnalysisResponseBasisSource Read(
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
            return new DocVersionsAnalysisResponseBasisSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsAnalysisResponseBasisSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsAnalysisResponseBasisSource ReadAsPropertyName(
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
            return new DocVersionsAnalysisResponseBasisSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsAnalysisResponseBasisSource value,
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
        public const string Persisted = "persisted";

        public const string WorkingCopy = "working-copy";
    }
}
