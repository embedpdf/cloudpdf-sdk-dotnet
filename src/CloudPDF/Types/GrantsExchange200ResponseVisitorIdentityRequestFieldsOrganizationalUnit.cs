using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsExchange200ResponseVisitorIdentityRequestFieldsOrganizationalUnit.GrantsExchange200ResponseVisitorIdentityRequestFieldsOrganizationalUnitSerializer)
)]
[Serializable]
public readonly record struct GrantsExchange200ResponseVisitorIdentityRequestFieldsOrganizationalUnit
    : IStringEnum
{
    public static readonly GrantsExchange200ResponseVisitorIdentityRequestFieldsOrganizationalUnit Required =
        new(Values.Required);

    public static readonly GrantsExchange200ResponseVisitorIdentityRequestFieldsOrganizationalUnit Optional =
        new(Values.Optional);

    public GrantsExchange200ResponseVisitorIdentityRequestFieldsOrganizationalUnit(string value)
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
    public static GrantsExchange200ResponseVisitorIdentityRequestFieldsOrganizationalUnit FromCustom(
        string value
    )
    {
        return new GrantsExchange200ResponseVisitorIdentityRequestFieldsOrganizationalUnit(value);
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
        GrantsExchange200ResponseVisitorIdentityRequestFieldsOrganizationalUnit value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsExchange200ResponseVisitorIdentityRequestFieldsOrganizationalUnit value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsExchange200ResponseVisitorIdentityRequestFieldsOrganizationalUnit value
    ) => value.Value;

    public static explicit operator GrantsExchange200ResponseVisitorIdentityRequestFieldsOrganizationalUnit(
        string value
    ) => new(value);

    internal class GrantsExchange200ResponseVisitorIdentityRequestFieldsOrganizationalUnitSerializer
        : JsonConverter<GrantsExchange200ResponseVisitorIdentityRequestFieldsOrganizationalUnit>
    {
        public override GrantsExchange200ResponseVisitorIdentityRequestFieldsOrganizationalUnit Read(
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
            return new GrantsExchange200ResponseVisitorIdentityRequestFieldsOrganizationalUnit(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsExchange200ResponseVisitorIdentityRequestFieldsOrganizationalUnit value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsExchange200ResponseVisitorIdentityRequestFieldsOrganizationalUnit ReadAsPropertyName(
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
            return new GrantsExchange200ResponseVisitorIdentityRequestFieldsOrganizationalUnit(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsExchange200ResponseVisitorIdentityRequestFieldsOrganizationalUnit value,
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
        public const string Required = "required";

        public const string Optional = "optional";
    }
}
