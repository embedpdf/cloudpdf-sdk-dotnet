using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesAnalysis200ResponseBasisSource.DocSignaturesAnalysis200ResponseBasisSourceSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesAnalysis200ResponseBasisSource : IStringEnum
{
    public static readonly DocSignaturesAnalysis200ResponseBasisSource Persisted = new(
        Values.Persisted
    );

    public static readonly DocSignaturesAnalysis200ResponseBasisSource WorkingCopy = new(
        Values.WorkingCopy
    );

    public DocSignaturesAnalysis200ResponseBasisSource(string value)
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
    public static DocSignaturesAnalysis200ResponseBasisSource FromCustom(string value)
    {
        return new DocSignaturesAnalysis200ResponseBasisSource(value);
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
        DocSignaturesAnalysis200ResponseBasisSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocSignaturesAnalysis200ResponseBasisSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesAnalysis200ResponseBasisSource value) =>
        value.Value;

    public static explicit operator DocSignaturesAnalysis200ResponseBasisSource(string value) =>
        new(value);

    internal class DocSignaturesAnalysis200ResponseBasisSourceSerializer
        : JsonConverter<DocSignaturesAnalysis200ResponseBasisSource>
    {
        public override DocSignaturesAnalysis200ResponseBasisSource Read(
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
            return new DocSignaturesAnalysis200ResponseBasisSource(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesAnalysis200ResponseBasisSource value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesAnalysis200ResponseBasisSource ReadAsPropertyName(
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
            return new DocSignaturesAnalysis200ResponseBasisSource(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesAnalysis200ResponseBasisSource value,
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
