using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocVersionsSignaturesResponseProtectionJudged.DocVersionsSignaturesResponseProtectionJudgedSerializer)
)]
[Serializable]
public readonly record struct DocVersionsSignaturesResponseProtectionJudged : IStringEnum
{
    public static readonly DocVersionsSignaturesResponseProtectionJudged None = new(Values.None);

    public static readonly DocVersionsSignaturesResponseProtectionJudged Lta = new(Values.Lta);

    public static readonly DocVersionsSignaturesResponseProtectionJudged Fill = new(Values.Fill);

    public static readonly DocVersionsSignaturesResponseProtectionJudged Annotate = new(
        Values.Annotate
    );

    public DocVersionsSignaturesResponseProtectionJudged(string value)
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
    public static DocVersionsSignaturesResponseProtectionJudged FromCustom(string value)
    {
        return new DocVersionsSignaturesResponseProtectionJudged(value);
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
        DocVersionsSignaturesResponseProtectionJudged value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocVersionsSignaturesResponseProtectionJudged value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocVersionsSignaturesResponseProtectionJudged value) =>
        value.Value;

    public static explicit operator DocVersionsSignaturesResponseProtectionJudged(string value) =>
        new(value);

    internal class DocVersionsSignaturesResponseProtectionJudgedSerializer
        : JsonConverter<DocVersionsSignaturesResponseProtectionJudged>
    {
        public override DocVersionsSignaturesResponseProtectionJudged Read(
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
            return new DocVersionsSignaturesResponseProtectionJudged(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocVersionsSignaturesResponseProtectionJudged value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocVersionsSignaturesResponseProtectionJudged ReadAsPropertyName(
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
            return new DocVersionsSignaturesResponseProtectionJudged(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocVersionsSignaturesResponseProtectionJudged value,
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
