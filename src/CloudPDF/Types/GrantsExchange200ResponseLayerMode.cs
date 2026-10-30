using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsExchange200ResponseLayerMode.GrantsExchange200ResponseLayerModeSerializer)
)]
[Serializable]
public readonly record struct GrantsExchange200ResponseLayerMode : IStringEnum
{
    public static readonly GrantsExchange200ResponseLayerMode Shared = new(Values.Shared);

    public static readonly GrantsExchange200ResponseLayerMode PerVisitor = new(Values.PerVisitor);

    public GrantsExchange200ResponseLayerMode(string value)
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
    public static GrantsExchange200ResponseLayerMode FromCustom(string value)
    {
        return new GrantsExchange200ResponseLayerMode(value);
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

    public static bool operator ==(GrantsExchange200ResponseLayerMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GrantsExchange200ResponseLayerMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GrantsExchange200ResponseLayerMode value) => value.Value;

    public static explicit operator GrantsExchange200ResponseLayerMode(string value) => new(value);

    internal class GrantsExchange200ResponseLayerModeSerializer
        : JsonConverter<GrantsExchange200ResponseLayerMode>
    {
        public override GrantsExchange200ResponseLayerMode Read(
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
            return new GrantsExchange200ResponseLayerMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsExchange200ResponseLayerMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsExchange200ResponseLayerMode ReadAsPropertyName(
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
            return new GrantsExchange200ResponseLayerMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsExchange200ResponseLayerMode value,
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
        public const string Shared = "shared";

        public const string PerVisitor = "per-visitor";
    }
}
