using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocVersionsAnalysis200ResponseMode.DocVersionsAnalysis200ResponseModeSerializer)
)]
[Serializable]
public readonly record struct DocVersionsAnalysis200ResponseMode : IStringEnum
{
    public static readonly DocVersionsAnalysis200ResponseMode Authoritative = new(
        Values.Authoritative
    );

    public static readonly DocVersionsAnalysis200ResponseMode Exploratory = new(Values.Exploratory);

    public DocVersionsAnalysis200ResponseMode(string value)
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
    public static DocVersionsAnalysis200ResponseMode FromCustom(string value)
    {
        return new DocVersionsAnalysis200ResponseMode(value);
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

    public static bool operator ==(DocVersionsAnalysis200ResponseMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocVersionsAnalysis200ResponseMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocVersionsAnalysis200ResponseMode value) => value.Value;

    public static explicit operator DocVersionsAnalysis200ResponseMode(string value) => new(value);

    internal class DocVersionsAnalysis200ResponseModeSerializer
        : JsonConverter<DocVersionsAnalysis200ResponseMode>
    {
        public override DocVersionsAnalysis200ResponseMode Read(
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
            return new DocVersionsAnalysis200ResponseMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsAnalysis200ResponseMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsAnalysis200ResponseMode ReadAsPropertyName(
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
            return new DocVersionsAnalysis200ResponseMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsAnalysis200ResponseMode value,
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
