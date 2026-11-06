using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocSignaturesCompleteResponseProtectionEnforced.DocSignaturesCompleteResponseProtectionEnforcedSerializer)
)]
[Serializable]
public readonly record struct DocSignaturesCompleteResponseProtectionEnforced : IStringEnum
{
    public static readonly DocSignaturesCompleteResponseProtectionEnforced None = new(Values.None);

    public static readonly DocSignaturesCompleteResponseProtectionEnforced Lta = new(Values.Lta);

    public static readonly DocSignaturesCompleteResponseProtectionEnforced Fill = new(Values.Fill);

    public static readonly DocSignaturesCompleteResponseProtectionEnforced Annotate = new(
        Values.Annotate
    );

    public DocSignaturesCompleteResponseProtectionEnforced(string value)
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
    public static DocSignaturesCompleteResponseProtectionEnforced FromCustom(string value)
    {
        return new DocSignaturesCompleteResponseProtectionEnforced(value);
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
        DocSignaturesCompleteResponseProtectionEnforced value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocSignaturesCompleteResponseProtectionEnforced value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocSignaturesCompleteResponseProtectionEnforced value) =>
        value.Value;

    public static explicit operator DocSignaturesCompleteResponseProtectionEnforced(string value) =>
        new(value);

    internal class DocSignaturesCompleteResponseProtectionEnforcedSerializer
        : JsonConverter<DocSignaturesCompleteResponseProtectionEnforced>
    {
        public override DocSignaturesCompleteResponseProtectionEnforced Read(
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
            return new DocSignaturesCompleteResponseProtectionEnforced(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocSignaturesCompleteResponseProtectionEnforced value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocSignaturesCompleteResponseProtectionEnforced ReadAsPropertyName(
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
            return new DocSignaturesCompleteResponseProtectionEnforced(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocSignaturesCompleteResponseProtectionEnforced value,
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
