using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocVersionsAnalysis200ResponseBasisSource.DocVersionsAnalysis200ResponseBasisSourceSerializer)
)]
[Serializable]
public readonly record struct DocVersionsAnalysis200ResponseBasisSource : IStringEnum
{
    public static readonly DocVersionsAnalysis200ResponseBasisSource Persisted = new(
        Values.Persisted
    );

    public static readonly DocVersionsAnalysis200ResponseBasisSource WorkingCopy = new(
        Values.WorkingCopy
    );

    public DocVersionsAnalysis200ResponseBasisSource(string value)
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
    public static DocVersionsAnalysis200ResponseBasisSource FromCustom(string value)
    {
        return new DocVersionsAnalysis200ResponseBasisSource(value);
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
        DocVersionsAnalysis200ResponseBasisSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocVersionsAnalysis200ResponseBasisSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocVersionsAnalysis200ResponseBasisSource value) =>
        value.Value;

    public static explicit operator DocVersionsAnalysis200ResponseBasisSource(string value) =>
        new(value);

    internal class DocVersionsAnalysis200ResponseBasisSourceSerializer
        : JsonConverter<DocVersionsAnalysis200ResponseBasisSource>
    {
        public override DocVersionsAnalysis200ResponseBasisSource Read(
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
            return new DocVersionsAnalysis200ResponseBasisSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsAnalysis200ResponseBasisSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsAnalysis200ResponseBasisSource ReadAsPropertyName(
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
            return new DocVersionsAnalysis200ResponseBasisSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsAnalysis200ResponseBasisSource value,
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
