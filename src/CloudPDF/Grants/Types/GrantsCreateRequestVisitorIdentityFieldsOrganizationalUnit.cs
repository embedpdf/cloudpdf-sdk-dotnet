using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsCreateRequestVisitorIdentityFieldsOrganizationalUnit.GrantsCreateRequestVisitorIdentityFieldsOrganizationalUnitSerializer)
)]
[Serializable]
public readonly record struct GrantsCreateRequestVisitorIdentityFieldsOrganizationalUnit
    : IStringEnum
{
    public static readonly GrantsCreateRequestVisitorIdentityFieldsOrganizationalUnit Required =
        new(Values.Required);

    public static readonly GrantsCreateRequestVisitorIdentityFieldsOrganizationalUnit Optional =
        new(Values.Optional);

    public GrantsCreateRequestVisitorIdentityFieldsOrganizationalUnit(string value)
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
    public static GrantsCreateRequestVisitorIdentityFieldsOrganizationalUnit FromCustom(
        string value
    )
    {
        return new GrantsCreateRequestVisitorIdentityFieldsOrganizationalUnit(value);
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
        GrantsCreateRequestVisitorIdentityFieldsOrganizationalUnit value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsCreateRequestVisitorIdentityFieldsOrganizationalUnit value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsCreateRequestVisitorIdentityFieldsOrganizationalUnit value
    ) => value.Value;

    public static explicit operator GrantsCreateRequestVisitorIdentityFieldsOrganizationalUnit(
        string value
    ) => new(value);

    internal class GrantsCreateRequestVisitorIdentityFieldsOrganizationalUnitSerializer
        : JsonConverter<GrantsCreateRequestVisitorIdentityFieldsOrganizationalUnit>
    {
        public override GrantsCreateRequestVisitorIdentityFieldsOrganizationalUnit Read(
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
            return new GrantsCreateRequestVisitorIdentityFieldsOrganizationalUnit(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsCreateRequestVisitorIdentityFieldsOrganizationalUnit value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsCreateRequestVisitorIdentityFieldsOrganizationalUnit ReadAsPropertyName(
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
            return new GrantsCreateRequestVisitorIdentityFieldsOrganizationalUnit(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsCreateRequestVisitorIdentityFieldsOrganizationalUnit value,
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
