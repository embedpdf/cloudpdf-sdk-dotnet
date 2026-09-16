using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF.Doc;

[JsonConverter(typeof(AnalysisSignaturesRequestLevel.AnalysisSignaturesRequestLevelSerializer))]
[Serializable]
public readonly record struct AnalysisSignaturesRequestLevel : IStringEnum
{
    public static readonly AnalysisSignaturesRequestLevel None = new(Values.None);

    public static readonly AnalysisSignaturesRequestLevel Lta = new(Values.Lta);

    public static readonly AnalysisSignaturesRequestLevel Fill = new(Values.Fill);

    public static readonly AnalysisSignaturesRequestLevel Annotate = new(Values.Annotate);

    public AnalysisSignaturesRequestLevel(string value)
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
    public static AnalysisSignaturesRequestLevel FromCustom(string value)
    {
        return new AnalysisSignaturesRequestLevel(value);
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

    public static bool operator ==(AnalysisSignaturesRequestLevel value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnalysisSignaturesRequestLevel value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnalysisSignaturesRequestLevel value) => value.Value;

    public static explicit operator AnalysisSignaturesRequestLevel(string value) => new(value);

    internal class AnalysisSignaturesRequestLevelSerializer
        : JsonConverter<AnalysisSignaturesRequestLevel>
    {
        public override AnalysisSignaturesRequestLevel Read(
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
            return new AnalysisSignaturesRequestLevel(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnalysisSignaturesRequestLevel value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnalysisSignaturesRequestLevel ReadAsPropertyName(
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
            return new AnalysisSignaturesRequestLevel(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnalysisSignaturesRequestLevel value,
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
