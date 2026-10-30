using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsCreate200ResponseGrantVisitorIdentityFieldsOrganization.GrantsCreate200ResponseGrantVisitorIdentityFieldsOrganizationSerializer)
)]
[Serializable]
public readonly record struct GrantsCreate200ResponseGrantVisitorIdentityFieldsOrganization
    : IStringEnum
{
    public static readonly GrantsCreate200ResponseGrantVisitorIdentityFieldsOrganization Required =
        new(Values.Required);

    public static readonly GrantsCreate200ResponseGrantVisitorIdentityFieldsOrganization Optional =
        new(Values.Optional);

    public GrantsCreate200ResponseGrantVisitorIdentityFieldsOrganization(string value)
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
    public static GrantsCreate200ResponseGrantVisitorIdentityFieldsOrganization FromCustom(
        string value
    )
    {
        return new GrantsCreate200ResponseGrantVisitorIdentityFieldsOrganization(value);
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
        GrantsCreate200ResponseGrantVisitorIdentityFieldsOrganization value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsCreate200ResponseGrantVisitorIdentityFieldsOrganization value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsCreate200ResponseGrantVisitorIdentityFieldsOrganization value
    ) => value.Value;

    public static explicit operator GrantsCreate200ResponseGrantVisitorIdentityFieldsOrganization(
        string value
    ) => new(value);

    internal class GrantsCreate200ResponseGrantVisitorIdentityFieldsOrganizationSerializer
        : JsonConverter<GrantsCreate200ResponseGrantVisitorIdentityFieldsOrganization>
    {
        public override GrantsCreate200ResponseGrantVisitorIdentityFieldsOrganization Read(
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
            return new GrantsCreate200ResponseGrantVisitorIdentityFieldsOrganization(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsCreate200ResponseGrantVisitorIdentityFieldsOrganization value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsCreate200ResponseGrantVisitorIdentityFieldsOrganization ReadAsPropertyName(
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
            return new GrantsCreate200ResponseGrantVisitorIdentityFieldsOrganization(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsCreate200ResponseGrantVisitorIdentityFieldsOrganization value,
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
