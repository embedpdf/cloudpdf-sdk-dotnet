using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(TenantsList200ResponseTenantsItemStatus.TenantsList200ResponseTenantsItemStatusSerializer)
)]
[Serializable]
public readonly record struct TenantsList200ResponseTenantsItemStatus : IStringEnum
{
    public static readonly TenantsList200ResponseTenantsItemStatus Active = new(Values.Active);

    public static readonly TenantsList200ResponseTenantsItemStatus Suspended = new(
        Values.Suspended
    );

    public TenantsList200ResponseTenantsItemStatus(string value)
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
    public static TenantsList200ResponseTenantsItemStatus FromCustom(string value)
    {
        return new TenantsList200ResponseTenantsItemStatus(value);
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

    public static bool operator ==(TenantsList200ResponseTenantsItemStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TenantsList200ResponseTenantsItemStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TenantsList200ResponseTenantsItemStatus value) =>
        value.Value;

    public static explicit operator TenantsList200ResponseTenantsItemStatus(string value) =>
        new(value);

    internal class TenantsList200ResponseTenantsItemStatusSerializer
        : JsonConverter<TenantsList200ResponseTenantsItemStatus>
    {
        public override TenantsList200ResponseTenantsItemStatus Read(
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
            return new TenantsList200ResponseTenantsItemStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TenantsList200ResponseTenantsItemStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TenantsList200ResponseTenantsItemStatus ReadAsPropertyName(
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
            return new TenantsList200ResponseTenantsItemStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TenantsList200ResponseTenantsItemStatus value,
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
        public const string Active = "active";

        public const string Suspended = "suspended";
    }
}
