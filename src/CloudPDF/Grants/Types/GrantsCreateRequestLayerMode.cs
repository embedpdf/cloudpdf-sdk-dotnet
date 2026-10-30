using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(GrantsCreateRequestLayerMode.GrantsCreateRequestLayerModeSerializer))]
[Serializable]
public readonly record struct GrantsCreateRequestLayerMode : IStringEnum
{
    public static readonly GrantsCreateRequestLayerMode Shared = new(Values.Shared);

    public static readonly GrantsCreateRequestLayerMode PerVisitor = new(Values.PerVisitor);

    public GrantsCreateRequestLayerMode(string value)
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
    public static GrantsCreateRequestLayerMode FromCustom(string value)
    {
        return new GrantsCreateRequestLayerMode(value);
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

    public static bool operator ==(GrantsCreateRequestLayerMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GrantsCreateRequestLayerMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GrantsCreateRequestLayerMode value) => value.Value;

    public static explicit operator GrantsCreateRequestLayerMode(string value) => new(value);

    internal class GrantsCreateRequestLayerModeSerializer
        : JsonConverter<GrantsCreateRequestLayerMode>
    {
        public override GrantsCreateRequestLayerMode Read(
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
            return new GrantsCreateRequestLayerMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsCreateRequestLayerMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsCreateRequestLayerMode ReadAsPropertyName(
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
            return new GrantsCreateRequestLayerMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsCreateRequestLayerMode value,
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
