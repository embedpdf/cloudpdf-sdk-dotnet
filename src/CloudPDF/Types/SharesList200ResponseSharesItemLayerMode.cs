using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesList200ResponseSharesItemLayerMode.SharesList200ResponseSharesItemLayerModeSerializer)
)]
[Serializable]
public readonly record struct SharesList200ResponseSharesItemLayerMode : IStringEnum
{
    public static readonly SharesList200ResponseSharesItemLayerMode Shared = new(Values.Shared);

    public static readonly SharesList200ResponseSharesItemLayerMode PerVisitor = new(
        Values.PerVisitor
    );

    public SharesList200ResponseSharesItemLayerMode(string value)
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
    public static SharesList200ResponseSharesItemLayerMode FromCustom(string value)
    {
        return new SharesList200ResponseSharesItemLayerMode(value);
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
        SharesList200ResponseSharesItemLayerMode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesList200ResponseSharesItemLayerMode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SharesList200ResponseSharesItemLayerMode value) =>
        value.Value;

    public static explicit operator SharesList200ResponseSharesItemLayerMode(string value) =>
        new(value);

    internal class SharesList200ResponseSharesItemLayerModeSerializer
        : JsonConverter<SharesList200ResponseSharesItemLayerMode>
    {
        public override SharesList200ResponseSharesItemLayerMode Read(
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
            return new SharesList200ResponseSharesItemLayerMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesList200ResponseSharesItemLayerMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesList200ResponseSharesItemLayerMode ReadAsPropertyName(
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
            return new SharesList200ResponseSharesItemLayerMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesList200ResponseSharesItemLayerMode value,
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
