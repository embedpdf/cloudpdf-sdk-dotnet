using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesAnalysisResponseCurrentMethod.DocSignaturesAnalysisResponseCurrentMethodSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesAnalysisResponseCurrentMethod : IStringEnum
{
    public static readonly DocSignaturesAnalysisResponseCurrentMethod NetState = new(
        Values.NetState
    );

    public static readonly DocSignaturesAnalysisResponseCurrentMethod NetStateReplay = new(
        Values.NetStateReplay
    );

    public DocSignaturesAnalysisResponseCurrentMethod(string value)
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
    public static DocSignaturesAnalysisResponseCurrentMethod FromCustom(string value)
    {
        return new DocSignaturesAnalysisResponseCurrentMethod(value);
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
        DocSignaturesAnalysisResponseCurrentMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocSignaturesAnalysisResponseCurrentMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesAnalysisResponseCurrentMethod value) =>
        value.Value;

    public static explicit operator DocSignaturesAnalysisResponseCurrentMethod(string value) =>
        new(value);

    internal class DocSignaturesAnalysisResponseCurrentMethodSerializer
        : JsonConverter<DocSignaturesAnalysisResponseCurrentMethod>
    {
        public override DocSignaturesAnalysisResponseCurrentMethod Read(
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
            return new DocSignaturesAnalysisResponseCurrentMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesAnalysisResponseCurrentMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesAnalysisResponseCurrentMethod ReadAsPropertyName(
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
            return new DocSignaturesAnalysisResponseCurrentMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesAnalysisResponseCurrentMethod value,
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
        public const string NetState = "net-state";

        public const string NetStateReplay = "net-state+replay";
    }
}
