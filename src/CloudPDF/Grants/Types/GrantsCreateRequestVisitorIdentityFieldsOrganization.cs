using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsCreateRequestVisitorIdentityFieldsOrganization.GrantsCreateRequestVisitorIdentityFieldsOrganizationSerializer)
)]
[Serializable]
public readonly record struct GrantsCreateRequestVisitorIdentityFieldsOrganization : IStringEnum
{
    public static readonly GrantsCreateRequestVisitorIdentityFieldsOrganization Required = new(
        Values.Required
    );

    public static readonly GrantsCreateRequestVisitorIdentityFieldsOrganization Optional = new(
        Values.Optional
    );

    public GrantsCreateRequestVisitorIdentityFieldsOrganization(string value)
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
    public static GrantsCreateRequestVisitorIdentityFieldsOrganization FromCustom(string value)
    {
        return new GrantsCreateRequestVisitorIdentityFieldsOrganization(value);
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
        GrantsCreateRequestVisitorIdentityFieldsOrganization value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsCreateRequestVisitorIdentityFieldsOrganization value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsCreateRequestVisitorIdentityFieldsOrganization value
    ) => value.Value;

    public static explicit operator GrantsCreateRequestVisitorIdentityFieldsOrganization(
        string value
    ) => new(value);

    internal class GrantsCreateRequestVisitorIdentityFieldsOrganizationSerializer
        : JsonConverter<GrantsCreateRequestVisitorIdentityFieldsOrganization>
    {
        public override GrantsCreateRequestVisitorIdentityFieldsOrganization Read(
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
            return new GrantsCreateRequestVisitorIdentityFieldsOrganization(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsCreateRequestVisitorIdentityFieldsOrganization value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsCreateRequestVisitorIdentityFieldsOrganization ReadAsPropertyName(
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
            return new GrantsCreateRequestVisitorIdentityFieldsOrganization(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsCreateRequestVisitorIdentityFieldsOrganization value,
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
