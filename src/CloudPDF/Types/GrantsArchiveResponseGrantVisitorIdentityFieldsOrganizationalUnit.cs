using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsArchiveResponseGrantVisitorIdentityFieldsOrganizationalUnit.GrantsArchiveResponseGrantVisitorIdentityFieldsOrganizationalUnitSerializer)
)]
[Serializable]
public readonly record struct GrantsArchiveResponseGrantVisitorIdentityFieldsOrganizationalUnit
    : IStringEnum
{
    public static readonly GrantsArchiveResponseGrantVisitorIdentityFieldsOrganizationalUnit Required =
        new(Values.Required);

    public static readonly GrantsArchiveResponseGrantVisitorIdentityFieldsOrganizationalUnit Optional =
        new(Values.Optional);

    public GrantsArchiveResponseGrantVisitorIdentityFieldsOrganizationalUnit(string value)
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
    public static GrantsArchiveResponseGrantVisitorIdentityFieldsOrganizationalUnit FromCustom(
        string value
    )
    {
        return new GrantsArchiveResponseGrantVisitorIdentityFieldsOrganizationalUnit(value);
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
        GrantsArchiveResponseGrantVisitorIdentityFieldsOrganizationalUnit value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsArchiveResponseGrantVisitorIdentityFieldsOrganizationalUnit value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsArchiveResponseGrantVisitorIdentityFieldsOrganizationalUnit value
    ) => value.Value;

    public static explicit operator GrantsArchiveResponseGrantVisitorIdentityFieldsOrganizationalUnit(
        string value
    ) => new(value);

    internal class GrantsArchiveResponseGrantVisitorIdentityFieldsOrganizationalUnitSerializer
        : JsonConverter<GrantsArchiveResponseGrantVisitorIdentityFieldsOrganizationalUnit>
    {
        public override GrantsArchiveResponseGrantVisitorIdentityFieldsOrganizationalUnit Read(
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
            return new GrantsArchiveResponseGrantVisitorIdentityFieldsOrganizationalUnit(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsArchiveResponseGrantVisitorIdentityFieldsOrganizationalUnit value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsArchiveResponseGrantVisitorIdentityFieldsOrganizationalUnit ReadAsPropertyName(
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
            return new GrantsArchiveResponseGrantVisitorIdentityFieldsOrganizationalUnit(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsArchiveResponseGrantVisitorIdentityFieldsOrganizationalUnit value,
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
