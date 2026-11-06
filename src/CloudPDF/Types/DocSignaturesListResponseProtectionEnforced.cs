using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesListResponseProtectionEnforced.DocSignaturesListResponseProtectionEnforcedSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesListResponseProtectionEnforced : IStringEnum
{
    public static readonly DocSignaturesListResponseProtectionEnforced None = new(Values.None);

    public static readonly DocSignaturesListResponseProtectionEnforced Lta = new(Values.Lta);

    public static readonly DocSignaturesListResponseProtectionEnforced Fill = new(Values.Fill);

    public static readonly DocSignaturesListResponseProtectionEnforced Annotate = new(
        Values.Annotate
    );

    public DocSignaturesListResponseProtectionEnforced(string value)
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
    public static DocSignaturesListResponseProtectionEnforced FromCustom(string value)
    {
        return new DocSignaturesListResponseProtectionEnforced(value);
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
        DocSignaturesListResponseProtectionEnforced value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocSignaturesListResponseProtectionEnforced value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesListResponseProtectionEnforced value) =>
        value.Value;

    public static explicit operator DocSignaturesListResponseProtectionEnforced(string value) =>
        new(value);

    internal class DocSignaturesListResponseProtectionEnforcedSerializer
        : JsonConverter<DocSignaturesListResponseProtectionEnforced>
    {
        public override DocSignaturesListResponseProtectionEnforced Read(
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
            return new DocSignaturesListResponseProtectionEnforced(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesListResponseProtectionEnforced value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesListResponseProtectionEnforced ReadAsPropertyName(
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
            return new DocSignaturesListResponseProtectionEnforced(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesListResponseProtectionEnforced value,
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
