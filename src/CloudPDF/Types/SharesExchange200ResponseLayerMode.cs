using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesExchange200ResponseLayerMode.SharesExchange200ResponseLayerModeSerializer)
)]
[Serializable]
public readonly record struct SharesExchange200ResponseLayerMode : IStringEnum
{
    public static readonly SharesExchange200ResponseLayerMode Shared = new(Values.Shared);

    public static readonly SharesExchange200ResponseLayerMode PerVisitor = new(Values.PerVisitor);

    public SharesExchange200ResponseLayerMode(string value)
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
    public static SharesExchange200ResponseLayerMode FromCustom(string value)
    {
        return new SharesExchange200ResponseLayerMode(value);
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

    public static bool operator ==(SharesExchange200ResponseLayerMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SharesExchange200ResponseLayerMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SharesExchange200ResponseLayerMode value) => value.Value;

    public static explicit operator SharesExchange200ResponseLayerMode(string value) => new(value);

    internal class SharesExchange200ResponseLayerModeSerializer
        : JsonConverter<SharesExchange200ResponseLayerMode>
    {
        public override SharesExchange200ResponseLayerMode Read(
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
            return new SharesExchange200ResponseLayerMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesExchange200ResponseLayerMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesExchange200ResponseLayerMode ReadAsPropertyName(
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
            return new SharesExchange200ResponseLayerMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesExchange200ResponseLayerMode value,
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
