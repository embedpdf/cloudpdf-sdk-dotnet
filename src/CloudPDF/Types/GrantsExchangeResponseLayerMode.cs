using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(GrantsExchangeResponseLayerMode.GrantsExchangeResponseLayerModeSerializer))]
[Serializable]
public readonly record struct GrantsExchangeResponseLayerMode : IStringEnum
{
    public static readonly GrantsExchangeResponseLayerMode Shared = new(Values.Shared);

    public static readonly GrantsExchangeResponseLayerMode PerVisitor = new(Values.PerVisitor);

    public GrantsExchangeResponseLayerMode(string value)
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
    public static GrantsExchangeResponseLayerMode FromCustom(string value)
    {
        return new GrantsExchangeResponseLayerMode(value);
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

    public static bool operator ==(GrantsExchangeResponseLayerMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GrantsExchangeResponseLayerMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GrantsExchangeResponseLayerMode value) => value.Value;

    public static explicit operator GrantsExchangeResponseLayerMode(string value) => new(value);

    internal class GrantsExchangeResponseLayerModeSerializer
        : JsonConverter<GrantsExchangeResponseLayerMode>
    {
        public override GrantsExchangeResponseLayerMode Read(
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
            return new GrantsExchangeResponseLayerMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsExchangeResponseLayerMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsExchangeResponseLayerMode ReadAsPropertyName(
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
            return new GrantsExchangeResponseLayerMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsExchangeResponseLayerMode value,
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
