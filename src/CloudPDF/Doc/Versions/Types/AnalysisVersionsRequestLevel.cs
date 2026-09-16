using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF.Doc;

[JsonConverter(typeof(AnalysisVersionsRequestLevel.AnalysisVersionsRequestLevelSerializer))]
[Serializable]
public readonly record struct AnalysisVersionsRequestLevel : IStringEnum
{
    public static readonly AnalysisVersionsRequestLevel None = new(Values.None);

    public static readonly AnalysisVersionsRequestLevel Lta = new(Values.Lta);

    public static readonly AnalysisVersionsRequestLevel Fill = new(Values.Fill);

    public static readonly AnalysisVersionsRequestLevel Annotate = new(Values.Annotate);

    public AnalysisVersionsRequestLevel(string value)
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
    public static AnalysisVersionsRequestLevel FromCustom(string value)
    {
        return new AnalysisVersionsRequestLevel(value);
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

    public static bool operator ==(AnalysisVersionsRequestLevel value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnalysisVersionsRequestLevel value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnalysisVersionsRequestLevel value) => value.Value;

    public static explicit operator AnalysisVersionsRequestLevel(string value) => new(value);

    internal class AnalysisVersionsRequestLevelSerializer
        : JsonConverter<AnalysisVersionsRequestLevel>
    {
        public override AnalysisVersionsRequestLevel Read(
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
            return new AnalysisVersionsRequestLevel(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnalysisVersionsRequestLevel value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnalysisVersionsRequestLevel ReadAsPropertyName(
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
            return new AnalysisVersionsRequestLevel(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnalysisVersionsRequestLevel value,
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
        public const string None = "none";

        public const string Lta = "lta";

        public const string Fill = "fill";

        public const string Annotate = "annotate";
    }
}
