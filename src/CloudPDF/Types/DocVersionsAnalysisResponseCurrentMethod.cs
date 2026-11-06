using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocVersionsAnalysisResponseCurrentMethod.DocVersionsAnalysisResponseCurrentMethodSerializer)
)]
[Serializable]
public readonly record struct DocVersionsAnalysisResponseCurrentMethod : IStringEnum
{
    public static readonly DocVersionsAnalysisResponseCurrentMethod NetState = new(Values.NetState);

    public static readonly DocVersionsAnalysisResponseCurrentMethod NetStateReplay = new(
        Values.NetStateReplay
    );

    public DocVersionsAnalysisResponseCurrentMethod(string value)
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
    public static DocVersionsAnalysisResponseCurrentMethod FromCustom(string value)
    {
        return new DocVersionsAnalysisResponseCurrentMethod(value);
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
        DocVersionsAnalysisResponseCurrentMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocVersionsAnalysisResponseCurrentMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocVersionsAnalysisResponseCurrentMethod value) =>
        value.Value;

    public static explicit operator DocVersionsAnalysisResponseCurrentMethod(string value) =>
        new(value);

    internal class DocVersionsAnalysisResponseCurrentMethodSerializer
        : JsonConverter<DocVersionsAnalysisResponseCurrentMethod>
    {
        public override DocVersionsAnalysisResponseCurrentMethod Read(
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
            return new DocVersionsAnalysisResponseCurrentMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsAnalysisResponseCurrentMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsAnalysisResponseCurrentMethod ReadAsPropertyName(
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
            return new DocVersionsAnalysisResponseCurrentMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsAnalysisResponseCurrentMethod value,
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
