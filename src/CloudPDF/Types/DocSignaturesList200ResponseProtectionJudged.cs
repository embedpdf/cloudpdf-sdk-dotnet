using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesList200ResponseProtectionJudged.DocSignaturesList200ResponseProtectionJudgedSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesList200ResponseProtectionJudged : IStringEnum
{
    public static readonly DocSignaturesList200ResponseProtectionJudged None = new(Values.None);

    public static readonly DocSignaturesList200ResponseProtectionJudged Lta = new(Values.Lta);

    public static readonly DocSignaturesList200ResponseProtectionJudged Fill = new(Values.Fill);

    public static readonly DocSignaturesList200ResponseProtectionJudged Annotate = new(
        Values.Annotate
    );

    public DocSignaturesList200ResponseProtectionJudged(string value)
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
    public static DocSignaturesList200ResponseProtectionJudged FromCustom(string value)
    {
        return new DocSignaturesList200ResponseProtectionJudged(value);
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
        DocSignaturesList200ResponseProtectionJudged value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocSignaturesList200ResponseProtectionJudged value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesList200ResponseProtectionJudged value) =>
        value.Value;

    public static explicit operator DocSignaturesList200ResponseProtectionJudged(string value) =>
        new(value);

    internal class DocSignaturesList200ResponseProtectionJudgedSerializer
        : JsonConverter<DocSignaturesList200ResponseProtectionJudged>
    {
        public override DocSignaturesList200ResponseProtectionJudged Read(
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
            return new DocSignaturesList200ResponseProtectionJudged(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesList200ResponseProtectionJudged value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesList200ResponseProtectionJudged ReadAsPropertyName(
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
            return new DocSignaturesList200ResponseProtectionJudged(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesList200ResponseProtectionJudged value,
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
