using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsListResponseGrantsItemVisitorIdentityFieldsOrganizationalUnit.GrantsListResponseGrantsItemVisitorIdentityFieldsOrganizationalUnitSerializer)
)]
[Serializable]
public readonly record struct GrantsListResponseGrantsItemVisitorIdentityFieldsOrganizationalUnit
    : IStringEnum
{
    public static readonly GrantsListResponseGrantsItemVisitorIdentityFieldsOrganizationalUnit Required =
        new(Values.Required);

    public static readonly GrantsListResponseGrantsItemVisitorIdentityFieldsOrganizationalUnit Optional =
        new(Values.Optional);

    public GrantsListResponseGrantsItemVisitorIdentityFieldsOrganizationalUnit(string value)
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
    public static GrantsListResponseGrantsItemVisitorIdentityFieldsOrganizationalUnit FromCustom(
        string value
    )
    {
        return new GrantsListResponseGrantsItemVisitorIdentityFieldsOrganizationalUnit(value);
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
        GrantsListResponseGrantsItemVisitorIdentityFieldsOrganizationalUnit value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsListResponseGrantsItemVisitorIdentityFieldsOrganizationalUnit value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsListResponseGrantsItemVisitorIdentityFieldsOrganizationalUnit value
    ) => value.Value;

    public static explicit operator GrantsListResponseGrantsItemVisitorIdentityFieldsOrganizationalUnit(
        string value
    ) => new(value);

    internal class GrantsListResponseGrantsItemVisitorIdentityFieldsOrganizationalUnitSerializer
        : JsonConverter<GrantsListResponseGrantsItemVisitorIdentityFieldsOrganizationalUnit>
    {
        public override GrantsListResponseGrantsItemVisitorIdentityFieldsOrganizationalUnit Read(
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
            return new GrantsListResponseGrantsItemVisitorIdentityFieldsOrganizationalUnit(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsListResponseGrantsItemVisitorIdentityFieldsOrganizationalUnit value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsListResponseGrantsItemVisitorIdentityFieldsOrganizationalUnit ReadAsPropertyName(
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
            return new GrantsListResponseGrantsItemVisitorIdentityFieldsOrganizationalUnit(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsListResponseGrantsItemVisitorIdentityFieldsOrganizationalUnit value,
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
