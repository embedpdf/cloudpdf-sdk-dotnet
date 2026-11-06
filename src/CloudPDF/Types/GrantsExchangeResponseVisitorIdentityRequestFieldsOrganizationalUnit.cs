using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsExchangeResponseVisitorIdentityRequestFieldsOrganizationalUnit.GrantsExchangeResponseVisitorIdentityRequestFieldsOrganizationalUnitSerializer)
)]
[Serializable]
public readonly record struct GrantsExchangeResponseVisitorIdentityRequestFieldsOrganizationalUnit
    : IStringEnum
{
    public static readonly GrantsExchangeResponseVisitorIdentityRequestFieldsOrganizationalUnit Required =
        new(Values.Required);

    public static readonly GrantsExchangeResponseVisitorIdentityRequestFieldsOrganizationalUnit Optional =
        new(Values.Optional);

    public GrantsExchangeResponseVisitorIdentityRequestFieldsOrganizationalUnit(string value)
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
    public static GrantsExchangeResponseVisitorIdentityRequestFieldsOrganizationalUnit FromCustom(
        string value
    )
    {
        return new GrantsExchangeResponseVisitorIdentityRequestFieldsOrganizationalUnit(value);
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
        GrantsExchangeResponseVisitorIdentityRequestFieldsOrganizationalUnit value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsExchangeResponseVisitorIdentityRequestFieldsOrganizationalUnit value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsExchangeResponseVisitorIdentityRequestFieldsOrganizationalUnit value
    ) => value.Value;

    public static explicit operator GrantsExchangeResponseVisitorIdentityRequestFieldsOrganizationalUnit(
        string value
    ) => new(value);

    internal class GrantsExchangeResponseVisitorIdentityRequestFieldsOrganizationalUnitSerializer
        : JsonConverter<GrantsExchangeResponseVisitorIdentityRequestFieldsOrganizationalUnit>
    {
        public override GrantsExchangeResponseVisitorIdentityRequestFieldsOrganizationalUnit Read(
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
            return new GrantsExchangeResponseVisitorIdentityRequestFieldsOrganizationalUnit(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsExchangeResponseVisitorIdentityRequestFieldsOrganizationalUnit value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsExchangeResponseVisitorIdentityRequestFieldsOrganizationalUnit ReadAsPropertyName(
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
            return new GrantsExchangeResponseVisitorIdentityRequestFieldsOrganizationalUnit(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsExchangeResponseVisitorIdentityRequestFieldsOrganizationalUnit value,
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
