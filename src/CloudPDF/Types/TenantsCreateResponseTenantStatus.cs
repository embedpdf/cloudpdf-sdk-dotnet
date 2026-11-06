using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(TenantsCreateResponseTenantStatus.TenantsCreateResponseTenantStatusSerializer)
)]
[Serializable]
public readonly record struct TenantsCreateResponseTenantStatus : IStringEnum
{
    public static readonly TenantsCreateResponseTenantStatus Active = new(Values.Active);

    public static readonly TenantsCreateResponseTenantStatus Suspended = new(Values.Suspended);

    public TenantsCreateResponseTenantStatus(string value)
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
    public static TenantsCreateResponseTenantStatus FromCustom(string value)
    {
        return new TenantsCreateResponseTenantStatus(value);
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

    public static bool operator ==(TenantsCreateResponseTenantStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TenantsCreateResponseTenantStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TenantsCreateResponseTenantStatus value) => value.Value;

    public static explicit operator TenantsCreateResponseTenantStatus(string value) => new(value);

    internal class TenantsCreateResponseTenantStatusSerializer
        : JsonConverter<TenantsCreateResponseTenantStatus>
    {
        public override TenantsCreateResponseTenantStatus Read(
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
            return new TenantsCreateResponseTenantStatus(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            TenantsCreateResponseTenantStatus value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override TenantsCreateResponseTenantStatus ReadAsPropertyName(
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
            return new TenantsCreateResponseTenantStatus(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            TenantsCreateResponseTenantStatus value,
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
