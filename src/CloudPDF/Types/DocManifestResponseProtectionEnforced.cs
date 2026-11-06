using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocManifestResponseProtectionEnforced.DocManifestResponseProtectionEnforcedSerializer)
)]
[Serializable]
public readonly record struct DocManifestResponseProtectionEnforced : IStringEnum
{
    public static readonly DocManifestResponseProtectionEnforced None = new(Values.None);

    public static readonly DocManifestResponseProtectionEnforced Lta = new(Values.Lta);

    public static readonly DocManifestResponseProtectionEnforced Fill = new(Values.Fill);

    public static readonly DocManifestResponseProtectionEnforced Annotate = new(Values.Annotate);

    public DocManifestResponseProtectionEnforced(string value)
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
    public static DocManifestResponseProtectionEnforced FromCustom(string value)
    {
        return new DocManifestResponseProtectionEnforced(value);
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

    public static bool operator ==(DocManifestResponseProtectionEnforced value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocManifestResponseProtectionEnforced value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocManifestResponseProtectionEnforced value) =>
        value.Value;

    public static explicit operator DocManifestResponseProtectionEnforced(string value) =>
        new(value);

    internal class DocManifestResponseProtectionEnforcedSerializer
        : JsonConverter<DocManifestResponseProtectionEnforced>
    {
        public override DocManifestResponseProtectionEnforced Read(
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
            return new DocManifestResponseProtectionEnforced(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocManifestResponseProtectionEnforced value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocManifestResponseProtectionEnforced ReadAsPropertyName(
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
            return new DocManifestResponseProtectionEnforced(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocManifestResponseProtectionEnforced value,
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
