using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsList200ResponseGrantsItemLayerMode.GrantsList200ResponseGrantsItemLayerModeSerializer)
)]
[Serializable]
public readonly record struct GrantsList200ResponseGrantsItemLayerMode : IStringEnum
{
    public static readonly GrantsList200ResponseGrantsItemLayerMode Shared = new(Values.Shared);

    public static readonly GrantsList200ResponseGrantsItemLayerMode PerVisitor = new(
        Values.PerVisitor
    );

    public GrantsList200ResponseGrantsItemLayerMode(string value)
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
    public static GrantsList200ResponseGrantsItemLayerMode FromCustom(string value)
    {
        return new GrantsList200ResponseGrantsItemLayerMode(value);
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
        GrantsList200ResponseGrantsItemLayerMode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsList200ResponseGrantsItemLayerMode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GrantsList200ResponseGrantsItemLayerMode value) =>
        value.Value;

    public static explicit operator GrantsList200ResponseGrantsItemLayerMode(string value) =>
        new(value);

    internal class GrantsList200ResponseGrantsItemLayerModeSerializer
        : JsonConverter<GrantsList200ResponseGrantsItemLayerMode>
    {
        public override GrantsList200ResponseGrantsItemLayerMode Read(
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
            return new GrantsList200ResponseGrantsItemLayerMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsList200ResponseGrantsItemLayerMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsList200ResponseGrantsItemLayerMode ReadAsPropertyName(
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
            return new GrantsList200ResponseGrantsItemLayerMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsList200ResponseGrantsItemLayerMode value,
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
