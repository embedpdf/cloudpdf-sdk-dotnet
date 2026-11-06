using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsCreateResponseGrantLayerMode.GrantsCreateResponseGrantLayerModeSerializer)
)]
[Serializable]
public readonly record struct GrantsCreateResponseGrantLayerMode : IStringEnum
{
    public static readonly GrantsCreateResponseGrantLayerMode Shared = new(Values.Shared);

    public static readonly GrantsCreateResponseGrantLayerMode PerVisitor = new(Values.PerVisitor);

    public GrantsCreateResponseGrantLayerMode(string value)
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
    public static GrantsCreateResponseGrantLayerMode FromCustom(string value)
    {
        return new GrantsCreateResponseGrantLayerMode(value);
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

    public static bool operator ==(GrantsCreateResponseGrantLayerMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GrantsCreateResponseGrantLayerMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GrantsCreateResponseGrantLayerMode value) => value.Value;

    public static explicit operator GrantsCreateResponseGrantLayerMode(string value) => new(value);

    internal class GrantsCreateResponseGrantLayerModeSerializer
        : JsonConverter<GrantsCreateResponseGrantLayerMode>
    {
        public override GrantsCreateResponseGrantLayerMode Read(
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
            return new GrantsCreateResponseGrantLayerMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsCreateResponseGrantLayerMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsCreateResponseGrantLayerMode ReadAsPropertyName(
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
            return new GrantsCreateResponseGrantLayerMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsCreateResponseGrantLayerMode value,
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
