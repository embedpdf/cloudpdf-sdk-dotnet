using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesGet200ResponseShareLayerMode.SharesGet200ResponseShareLayerModeSerializer)
)]
[Serializable]
public readonly record struct SharesGet200ResponseShareLayerMode : IStringEnum
{
    public static readonly SharesGet200ResponseShareLayerMode Shared = new(Values.Shared);

    public static readonly SharesGet200ResponseShareLayerMode PerVisitor = new(Values.PerVisitor);

    public SharesGet200ResponseShareLayerMode(string value)
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
    public static SharesGet200ResponseShareLayerMode FromCustom(string value)
    {
        return new SharesGet200ResponseShareLayerMode(value);
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

    public static bool operator ==(SharesGet200ResponseShareLayerMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SharesGet200ResponseShareLayerMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SharesGet200ResponseShareLayerMode value) => value.Value;

    public static explicit operator SharesGet200ResponseShareLayerMode(string value) => new(value);

    internal class SharesGet200ResponseShareLayerModeSerializer
        : JsonConverter<SharesGet200ResponseShareLayerMode>
    {
        public override SharesGet200ResponseShareLayerMode Read(
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
            return new SharesGet200ResponseShareLayerMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesGet200ResponseShareLayerMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesGet200ResponseShareLayerMode ReadAsPropertyName(
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
            return new SharesGet200ResponseShareLayerMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesGet200ResponseShareLayerMode value,
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
