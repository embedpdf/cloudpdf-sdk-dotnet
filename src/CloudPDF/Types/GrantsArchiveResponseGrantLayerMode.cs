using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsArchiveResponseGrantLayerMode.GrantsArchiveResponseGrantLayerModeSerializer)
)]
[Serializable]
public readonly record struct GrantsArchiveResponseGrantLayerMode : IStringEnum
{
    public static readonly GrantsArchiveResponseGrantLayerMode Shared = new(Values.Shared);

    public static readonly GrantsArchiveResponseGrantLayerMode PerVisitor = new(Values.PerVisitor);

    public GrantsArchiveResponseGrantLayerMode(string value)
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
    public static GrantsArchiveResponseGrantLayerMode FromCustom(string value)
    {
        return new GrantsArchiveResponseGrantLayerMode(value);
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

    public static bool operator ==(GrantsArchiveResponseGrantLayerMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GrantsArchiveResponseGrantLayerMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GrantsArchiveResponseGrantLayerMode value) =>
        value.Value;

    public static explicit operator GrantsArchiveResponseGrantLayerMode(string value) => new(value);

    internal class GrantsArchiveResponseGrantLayerModeSerializer
        : JsonConverter<GrantsArchiveResponseGrantLayerMode>
    {
        public override GrantsArchiveResponseGrantLayerMode Read(
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
            return new GrantsArchiveResponseGrantLayerMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsArchiveResponseGrantLayerMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsArchiveResponseGrantLayerMode ReadAsPropertyName(
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
            return new GrantsArchiveResponseGrantLayerMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsArchiveResponseGrantLayerMode value,
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
