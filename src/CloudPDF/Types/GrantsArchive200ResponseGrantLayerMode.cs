using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsArchive200ResponseGrantLayerMode.GrantsArchive200ResponseGrantLayerModeSerializer)
)]
[Serializable]
public readonly record struct GrantsArchive200ResponseGrantLayerMode : IStringEnum
{
    public static readonly GrantsArchive200ResponseGrantLayerMode Shared = new(Values.Shared);

    public static readonly GrantsArchive200ResponseGrantLayerMode PerVisitor = new(
        Values.PerVisitor
    );

    public GrantsArchive200ResponseGrantLayerMode(string value)
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
    public static GrantsArchive200ResponseGrantLayerMode FromCustom(string value)
    {
        return new GrantsArchive200ResponseGrantLayerMode(value);
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

    public static bool operator ==(GrantsArchive200ResponseGrantLayerMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GrantsArchive200ResponseGrantLayerMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GrantsArchive200ResponseGrantLayerMode value) =>
        value.Value;

    public static explicit operator GrantsArchive200ResponseGrantLayerMode(string value) =>
        new(value);

    internal class GrantsArchive200ResponseGrantLayerModeSerializer
        : JsonConverter<GrantsArchive200ResponseGrantLayerMode>
    {
        public override GrantsArchive200ResponseGrantLayerMode Read(
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
            return new GrantsArchive200ResponseGrantLayerMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsArchive200ResponseGrantLayerMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsArchive200ResponseGrantLayerMode ReadAsPropertyName(
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
            return new GrantsArchive200ResponseGrantLayerMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsArchive200ResponseGrantLayerMode value,
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
