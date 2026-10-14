using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocManifest200ResponseProtectionJudged.DocManifest200ResponseProtectionJudgedSerializer)
)]
[Serializable]
public readonly record struct DocManifest200ResponseProtectionJudged : IStringEnum
{
    public static readonly DocManifest200ResponseProtectionJudged None = new(Values.None);

    public static readonly DocManifest200ResponseProtectionJudged Lta = new(Values.Lta);

    public static readonly DocManifest200ResponseProtectionJudged Fill = new(Values.Fill);

    public static readonly DocManifest200ResponseProtectionJudged Annotate = new(Values.Annotate);

    public DocManifest200ResponseProtectionJudged(string value)
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
    public static DocManifest200ResponseProtectionJudged FromCustom(string value)
    {
        return new DocManifest200ResponseProtectionJudged(value);
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

    public static bool operator ==(DocManifest200ResponseProtectionJudged value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocManifest200ResponseProtectionJudged value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocManifest200ResponseProtectionJudged value) =>
        value.Value;

    public static explicit operator DocManifest200ResponseProtectionJudged(string value) =>
        new(value);

    internal class DocManifest200ResponseProtectionJudgedSerializer
        : JsonConverter<DocManifest200ResponseProtectionJudged>
    {
        public override DocManifest200ResponseProtectionJudged Read(
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
            return new DocManifest200ResponseProtectionJudged(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocManifest200ResponseProtectionJudged value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocManifest200ResponseProtectionJudged ReadAsPropertyName(
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
            return new DocManifest200ResponseProtectionJudged(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocManifest200ResponseProtectionJudged value,
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
