using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesAnalysisResponseMode.DocSignaturesAnalysisResponseModeSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesAnalysisResponseMode : IStringEnum
{
    public static readonly DocSignaturesAnalysisResponseMode Authoritative = new(
        Values.Authoritative
    );

    public static readonly DocSignaturesAnalysisResponseMode Exploratory = new(Values.Exploratory);

    public DocSignaturesAnalysisResponseMode(string value)
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
    public static DocSignaturesAnalysisResponseMode FromCustom(string value)
    {
        return new DocSignaturesAnalysisResponseMode(value);
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

    public static bool operator ==(DocSignaturesAnalysisResponseMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocSignaturesAnalysisResponseMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesAnalysisResponseMode value) => value.Value;

    public static explicit operator DocSignaturesAnalysisResponseMode(string value) => new(value);

    internal class DocSignaturesAnalysisResponseModeSerializer
        : JsonConverter<DocSignaturesAnalysisResponseMode>
    {
        public override DocSignaturesAnalysisResponseMode Read(
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
            return new DocSignaturesAnalysisResponseMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesAnalysisResponseMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesAnalysisResponseMode ReadAsPropertyName(
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
            return new DocSignaturesAnalysisResponseMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesAnalysisResponseMode value,
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
        public const string Authoritative = "authoritative";

        public const string Exploratory = "exploratory";
    }
}
