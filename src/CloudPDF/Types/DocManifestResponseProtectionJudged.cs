using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocManifestResponseProtectionJudged.DocManifestResponseProtectionJudgedSerializer)
)]
[Serializable]
public readonly record struct DocManifestResponseProtectionJudged : IStringEnum
{
    public static readonly DocManifestResponseProtectionJudged None = new(Values.None);

    public static readonly DocManifestResponseProtectionJudged Lta = new(Values.Lta);

    public static readonly DocManifestResponseProtectionJudged Fill = new(Values.Fill);

    public static readonly DocManifestResponseProtectionJudged Annotate = new(Values.Annotate);

    public DocManifestResponseProtectionJudged(string value)
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
    public static DocManifestResponseProtectionJudged FromCustom(string value)
    {
        return new DocManifestResponseProtectionJudged(value);
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

    public static bool operator ==(DocManifestResponseProtectionJudged value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocManifestResponseProtectionJudged value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocManifestResponseProtectionJudged value) =>
        value.Value;

    public static explicit operator DocManifestResponseProtectionJudged(string value) => new(value);

    internal class DocManifestResponseProtectionJudgedSerializer
        : JsonConverter<DocManifestResponseProtectionJudged>
    {
        public override DocManifestResponseProtectionJudged Read(
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
            return new DocManifestResponseProtectionJudged(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocManifestResponseProtectionJudged value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocManifestResponseProtectionJudged ReadAsPropertyName(
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
            return new DocManifestResponseProtectionJudged(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocManifestResponseProtectionJudged value,
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
