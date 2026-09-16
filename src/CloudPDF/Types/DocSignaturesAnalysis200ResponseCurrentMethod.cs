using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesAnalysis200ResponseCurrentMethod.DocSignaturesAnalysis200ResponseCurrentMethodSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesAnalysis200ResponseCurrentMethod : IStringEnum
{
    public static readonly DocSignaturesAnalysis200ResponseCurrentMethod NetState = new(
        Values.NetState
    );

    public static readonly DocSignaturesAnalysis200ResponseCurrentMethod NetStateReplay = new(
        Values.NetStateReplay
    );

    public DocSignaturesAnalysis200ResponseCurrentMethod(string value)
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
    public static DocSignaturesAnalysis200ResponseCurrentMethod FromCustom(string value)
    {
        return new DocSignaturesAnalysis200ResponseCurrentMethod(value);
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
        DocSignaturesAnalysis200ResponseCurrentMethod value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocSignaturesAnalysis200ResponseCurrentMethod value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesAnalysis200ResponseCurrentMethod value) =>
        value.Value;

    public static explicit operator DocSignaturesAnalysis200ResponseCurrentMethod(string value) =>
        new(value);

    internal class DocSignaturesAnalysis200ResponseCurrentMethodSerializer
        : JsonConverter<DocSignaturesAnalysis200ResponseCurrentMethod>
    {
        public override DocSignaturesAnalysis200ResponseCurrentMethod Read(
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
            return new DocSignaturesAnalysis200ResponseCurrentMethod(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesAnalysis200ResponseCurrentMethod value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesAnalysis200ResponseCurrentMethod ReadAsPropertyName(
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
            return new DocSignaturesAnalysis200ResponseCurrentMethod(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesAnalysis200ResponseCurrentMethod value,
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
