using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocVersionsAnalysis200ResponseVerdict.DocVersionsAnalysis200ResponseVerdictSerializer)
)]
[Serializable]
public readonly record struct DocVersionsAnalysis200ResponseVerdict : IStringEnum
{
    public static readonly DocVersionsAnalysis200ResponseVerdict Unchanged = new(Values.Unchanged);

    public static readonly DocVersionsAnalysis200ResponseVerdict Permitted = new(Values.Permitted);

    public static readonly DocVersionsAnalysis200ResponseVerdict Forbidden = new(Values.Forbidden);

    public static readonly DocVersionsAnalysis200ResponseVerdict Indeterminate = new(
        Values.Indeterminate
    );

    public DocVersionsAnalysis200ResponseVerdict(string value)
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
    public static DocVersionsAnalysis200ResponseVerdict FromCustom(string value)
    {
        return new DocVersionsAnalysis200ResponseVerdict(value);
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

    public static bool operator ==(DocVersionsAnalysis200ResponseVerdict value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocVersionsAnalysis200ResponseVerdict value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocVersionsAnalysis200ResponseVerdict value) =>
        value.Value;

    public static explicit operator DocVersionsAnalysis200ResponseVerdict(string value) =>
        new(value);

    internal class DocVersionsAnalysis200ResponseVerdictSerializer
        : JsonConverter<DocVersionsAnalysis200ResponseVerdict>
    {
        public override DocVersionsAnalysis200ResponseVerdict Read(
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
            return new DocVersionsAnalysis200ResponseVerdict(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsAnalysis200ResponseVerdict value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsAnalysis200ResponseVerdict ReadAsPropertyName(
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
            return new DocVersionsAnalysis200ResponseVerdict(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsAnalysis200ResponseVerdict value,
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
