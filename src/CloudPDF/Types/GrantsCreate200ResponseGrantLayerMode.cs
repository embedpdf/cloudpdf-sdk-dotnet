using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsCreate200ResponseGrantLayerMode.GrantsCreate200ResponseGrantLayerModeSerializer)
)]
[Serializable]
public readonly record struct GrantsCreate200ResponseGrantLayerMode : IStringEnum
{
    public static readonly GrantsCreate200ResponseGrantLayerMode Shared = new(Values.Shared);

    public static readonly GrantsCreate200ResponseGrantLayerMode PerVisitor = new(
        Values.PerVisitor
    );

    public GrantsCreate200ResponseGrantLayerMode(string value)
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
    public static GrantsCreate200ResponseGrantLayerMode FromCustom(string value)
    {
        return new GrantsCreate200ResponseGrantLayerMode(value);
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

    public static bool operator ==(GrantsCreate200ResponseGrantLayerMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GrantsCreate200ResponseGrantLayerMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GrantsCreate200ResponseGrantLayerMode value) =>
        value.Value;

    public static explicit operator GrantsCreate200ResponseGrantLayerMode(string value) =>
        new(value);

    internal class GrantsCreate200ResponseGrantLayerModeSerializer
        : JsonConverter<GrantsCreate200ResponseGrantLayerMode>
    {
        public override GrantsCreate200ResponseGrantLayerMode Read(
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
            return new GrantsCreate200ResponseGrantLayerMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsCreate200ResponseGrantLayerMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsCreate200ResponseGrantLayerMode ReadAsPropertyName(
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
            return new GrantsCreate200ResponseGrantLayerMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsCreate200ResponseGrantLayerMode value,
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
