using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(MetadataPatchTrapped.MetadataPatchTrappedSerializer))]
[Serializable]
public readonly record struct MetadataPatchTrapped : IStringEnum
{
    public static readonly MetadataPatchTrapped True = new(Values.True);

    public static readonly MetadataPatchTrapped False = new(Values.False);

    public static readonly MetadataPatchTrapped Unknown = new(Values.Unknown);

    public MetadataPatchTrapped(string value)
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
    public static MetadataPatchTrapped FromCustom(string value)
    {
        return new MetadataPatchTrapped(value);
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

    public static bool operator ==(MetadataPatchTrapped value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(MetadataPatchTrapped value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(MetadataPatchTrapped value) => value.Value;

    public static explicit operator MetadataPatchTrapped(string value) => new(value);

    internal class MetadataPatchTrappedSerializer : JsonConverter<MetadataPatchTrapped>
    {
        public override MetadataPatchTrapped Read(
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
            return new MetadataPatchTrapped(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            MetadataPatchTrapped value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override MetadataPatchTrapped ReadAsPropertyName(
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
            return new MetadataPatchTrapped(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            MetadataPatchTrapped value,
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
        public const string True = "true";

        public const string False = "false";

        public const string Unknown = "unknown";
    }
}
