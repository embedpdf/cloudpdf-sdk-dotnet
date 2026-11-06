using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesAnalysisResponseVerdict.DocSignaturesAnalysisResponseVerdictSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesAnalysisResponseVerdict : IStringEnum
{
    public static readonly DocSignaturesAnalysisResponseVerdict Unchanged = new(Values.Unchanged);

    public static readonly DocSignaturesAnalysisResponseVerdict Permitted = new(Values.Permitted);

    public static readonly DocSignaturesAnalysisResponseVerdict Forbidden = new(Values.Forbidden);

    public static readonly DocSignaturesAnalysisResponseVerdict Indeterminate = new(
        Values.Indeterminate
    );

    public DocSignaturesAnalysisResponseVerdict(string value)
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
    public static DocSignaturesAnalysisResponseVerdict FromCustom(string value)
    {
        return new DocSignaturesAnalysisResponseVerdict(value);
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

    public static bool operator ==(DocSignaturesAnalysisResponseVerdict value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocSignaturesAnalysisResponseVerdict value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesAnalysisResponseVerdict value) =>
        value.Value;

    public static explicit operator DocSignaturesAnalysisResponseVerdict(string value) =>
        new(value);

    internal class DocSignaturesAnalysisResponseVerdictSerializer
        : JsonConverter<DocSignaturesAnalysisResponseVerdict>
    {
        public override DocSignaturesAnalysisResponseVerdict Read(
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
            return new DocSignaturesAnalysisResponseVerdict(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesAnalysisResponseVerdict value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesAnalysisResponseVerdict ReadAsPropertyName(
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
            return new DocSignaturesAnalysisResponseVerdict(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesAnalysisResponseVerdict value,
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
