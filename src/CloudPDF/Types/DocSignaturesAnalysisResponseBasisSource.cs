using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesAnalysisResponseBasisSource.DocSignaturesAnalysisResponseBasisSourceSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesAnalysisResponseBasisSource : IStringEnum
{
    public static readonly DocSignaturesAnalysisResponseBasisSource Persisted = new(
        Values.Persisted
    );

    public static readonly DocSignaturesAnalysisResponseBasisSource WorkingCopy = new(
        Values.WorkingCopy
    );

    public DocSignaturesAnalysisResponseBasisSource(string value)
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
    public static DocSignaturesAnalysisResponseBasisSource FromCustom(string value)
    {
        return new DocSignaturesAnalysisResponseBasisSource(value);
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
        DocSignaturesAnalysisResponseBasisSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocSignaturesAnalysisResponseBasisSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesAnalysisResponseBasisSource value) =>
        value.Value;

    public static explicit operator DocSignaturesAnalysisResponseBasisSource(string value) =>
        new(value);

    internal class DocSignaturesAnalysisResponseBasisSourceSerializer
        : JsonConverter<DocSignaturesAnalysisResponseBasisSource>
    {
        public override DocSignaturesAnalysisResponseBasisSource Read(
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
            return new DocSignaturesAnalysisResponseBasisSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesAnalysisResponseBasisSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesAnalysisResponseBasisSource ReadAsPropertyName(
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
            return new DocSignaturesAnalysisResponseBasisSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesAnalysisResponseBasisSource value,
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
