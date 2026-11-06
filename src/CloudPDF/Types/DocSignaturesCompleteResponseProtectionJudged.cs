using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesCompleteResponseProtectionJudged.DocSignaturesCompleteResponseProtectionJudgedSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesCompleteResponseProtectionJudged : IStringEnum
{
    public static readonly DocSignaturesCompleteResponseProtectionJudged None = new(Values.None);

    public static readonly DocSignaturesCompleteResponseProtectionJudged Lta = new(Values.Lta);

    public static readonly DocSignaturesCompleteResponseProtectionJudged Fill = new(Values.Fill);

    public static readonly DocSignaturesCompleteResponseProtectionJudged Annotate = new(
        Values.Annotate
    );

    public DocSignaturesCompleteResponseProtectionJudged(string value)
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
    public static DocSignaturesCompleteResponseProtectionJudged FromCustom(string value)
    {
        return new DocSignaturesCompleteResponseProtectionJudged(value);
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
        DocSignaturesCompleteResponseProtectionJudged value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocSignaturesCompleteResponseProtectionJudged value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesCompleteResponseProtectionJudged value) =>
        value.Value;

    public static explicit operator DocSignaturesCompleteResponseProtectionJudged(string value) =>
        new(value);

    internal class DocSignaturesCompleteResponseProtectionJudgedSerializer
        : JsonConverter<DocSignaturesCompleteResponseProtectionJudged>
    {
        public override DocSignaturesCompleteResponseProtectionJudged Read(
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
            return new DocSignaturesCompleteResponseProtectionJudged(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesCompleteResponseProtectionJudged value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesCompleteResponseProtectionJudged ReadAsPropertyName(
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
            return new DocSignaturesCompleteResponseProtectionJudged(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesCompleteResponseProtectionJudged value,
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
