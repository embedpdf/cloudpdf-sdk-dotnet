using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocVersionsAnalysis200ResponseCurrentMethod.DocVersionsAnalysis200ResponseCurrentMethodSerializer)
)]
[Serializable]
public readonly record struct DocVersionsAnalysis200ResponseCurrentMethod : IStringEnum
{
    public static readonly DocVersionsAnalysis200ResponseCurrentMethod NetState = new(
        Values.NetState
    );

    public static readonly DocVersionsAnalysis200ResponseCurrentMethod NetStateReplay = new(
        Values.NetStateReplay
    );

    public DocVersionsAnalysis200ResponseCurrentMethod(string value)
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
    public static DocVersionsAnalysis200ResponseCurrentMethod FromCustom(string value)
    {
        return new DocVersionsAnalysis200ResponseCurrentMethod(value);
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
        DocVersionsAnalysis200ResponseCurrentMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocVersionsAnalysis200ResponseCurrentMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocVersionsAnalysis200ResponseCurrentMethod value) =>
        value.Value;

    public static explicit operator DocVersionsAnalysis200ResponseCurrentMethod(string value) =>
        new(value);

    internal class DocVersionsAnalysis200ResponseCurrentMethodSerializer
        : JsonConverter<DocVersionsAnalysis200ResponseCurrentMethod>
    {
        public override DocVersionsAnalysis200ResponseCurrentMethod Read(
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
            return new DocVersionsAnalysis200ResponseCurrentMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsAnalysis200ResponseCurrentMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsAnalysis200ResponseCurrentMethod ReadAsPropertyName(
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
            return new DocVersionsAnalysis200ResponseCurrentMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsAnalysis200ResponseCurrentMethod value,
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
