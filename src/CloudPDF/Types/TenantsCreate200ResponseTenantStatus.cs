using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(TenantsCreate200ResponseTenantStatus.TenantsCreate200ResponseTenantStatusSerializer)
)]
[Serializable]
public readonly record struct TenantsCreate200ResponseTenantStatus : IStringEnum
{
    public static readonly TenantsCreate200ResponseTenantStatus Active = new(Values.Active);

    public static readonly TenantsCreate200ResponseTenantStatus Suspended = new(Values.Suspended);

    public TenantsCreate200ResponseTenantStatus(string value)
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
    public static TenantsCreate200ResponseTenantStatus FromCustom(string value)
    {
        return new TenantsCreate200ResponseTenantStatus(value);
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

    public static bool operator ==(TenantsCreate200ResponseTenantStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TenantsCreate200ResponseTenantStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TenantsCreate200ResponseTenantStatus value) =>
        value.Value;

    public static explicit operator TenantsCreate200ResponseTenantStatus(string value) =>
        new(value);

    internal class TenantsCreate200ResponseTenantStatusSerializer
        : JsonConverter<TenantsCreate200ResponseTenantStatus>
    {
        public override TenantsCreate200ResponseTenantStatus Read(
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
            return new TenantsCreate200ResponseTenantStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TenantsCreate200ResponseTenantStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TenantsCreate200ResponseTenantStatus ReadAsPropertyName(
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
            return new TenantsCreate200ResponseTenantStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TenantsCreate200ResponseTenantStatus value,
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
