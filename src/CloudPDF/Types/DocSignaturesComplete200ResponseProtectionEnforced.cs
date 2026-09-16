using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesComplete200ResponseProtectionEnforced.DocSignaturesComplete200ResponseProtectionEnforcedSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesComplete200ResponseProtectionEnforced : IStringEnum
{
    public static readonly DocSignaturesComplete200ResponseProtectionEnforced None = new(
        Values.None
    );

    public static readonly DocSignaturesComplete200ResponseProtectionEnforced Lta = new(Values.Lta);

    public static readonly DocSignaturesComplete200ResponseProtectionEnforced Fill = new(
        Values.Fill
    );

    public static readonly DocSignaturesComplete200ResponseProtectionEnforced Annotate = new(
        Values.Annotate
    );

    public DocSignaturesComplete200ResponseProtectionEnforced(string value)
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
    public static DocSignaturesComplete200ResponseProtectionEnforced FromCustom(string value)
    {
        return new DocSignaturesComplete200ResponseProtectionEnforced(value);
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
        DocSignaturesComplete200ResponseProtectionEnforced value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocSignaturesComplete200ResponseProtectionEnforced value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocSignaturesComplete200ResponseProtectionEnforced value
    ) => value.Value;

    public static explicit operator DocSignaturesComplete200ResponseProtectionEnforced(
        string value
    ) => new(value);

    internal class DocSignaturesComplete200ResponseProtectionEnforcedSerializer
        : JsonConverter<DocSignaturesComplete200ResponseProtectionEnforced>
    {
        public override DocSignaturesComplete200ResponseProtectionEnforced Read(
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
            return new DocSignaturesComplete200ResponseProtectionEnforced(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesComplete200ResponseProtectionEnforced value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesComplete200ResponseProtectionEnforced ReadAsPropertyName(
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
            return new DocSignaturesComplete200ResponseProtectionEnforced(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesComplete200ResponseProtectionEnforced value,
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
