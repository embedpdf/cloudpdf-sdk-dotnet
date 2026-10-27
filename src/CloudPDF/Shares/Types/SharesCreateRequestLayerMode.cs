using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(SharesCreateRequestLayerMode.SharesCreateRequestLayerModeSerializer))]
[Serializable]
public readonly record struct SharesCreateRequestLayerMode : IStringEnum
{
    public static readonly SharesCreateRequestLayerMode Shared = new(Values.Shared);

    public static readonly SharesCreateRequestLayerMode PerVisitor = new(Values.PerVisitor);

    public SharesCreateRequestLayerMode(string value)
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
    public static SharesCreateRequestLayerMode FromCustom(string value)
    {
        return new SharesCreateRequestLayerMode(value);
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

    public static bool operator ==(SharesCreateRequestLayerMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SharesCreateRequestLayerMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SharesCreateRequestLayerMode value) => value.Value;

    public static explicit operator SharesCreateRequestLayerMode(string value) => new(value);

    internal class SharesCreateRequestLayerModeSerializer
        : JsonConverter<SharesCreateRequestLayerMode>
    {
        public override SharesCreateRequestLayerMode Read(
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
            return new SharesCreateRequestLayerMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesCreateRequestLayerMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesCreateRequestLayerMode ReadAsPropertyName(
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
            return new SharesCreateRequestLayerMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesCreateRequestLayerMode value,
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
