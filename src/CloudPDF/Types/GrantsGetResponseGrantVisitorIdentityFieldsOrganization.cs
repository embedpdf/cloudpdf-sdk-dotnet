using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsGetResponseGrantVisitorIdentityFieldsOrganization.GrantsGetResponseGrantVisitorIdentityFieldsOrganizationSerializer)
)]
[Serializable]
public readonly record struct GrantsGetResponseGrantVisitorIdentityFieldsOrganization : IStringEnum
{
    public static readonly GrantsGetResponseGrantVisitorIdentityFieldsOrganization Required = new(
        Values.Required
    );

    public static readonly GrantsGetResponseGrantVisitorIdentityFieldsOrganization Optional = new(
        Values.Optional
    );

    public GrantsGetResponseGrantVisitorIdentityFieldsOrganization(string value)
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
    public static GrantsGetResponseGrantVisitorIdentityFieldsOrganization FromCustom(string value)
    {
        return new GrantsGetResponseGrantVisitorIdentityFieldsOrganization(value);
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
        GrantsGetResponseGrantVisitorIdentityFieldsOrganization value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsGetResponseGrantVisitorIdentityFieldsOrganization value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsGetResponseGrantVisitorIdentityFieldsOrganization value
    ) => value.Value;

    public static explicit operator GrantsGetResponseGrantVisitorIdentityFieldsOrganization(
        string value
    ) => new(value);

    internal class GrantsGetResponseGrantVisitorIdentityFieldsOrganizationSerializer
        : JsonConverter<GrantsGetResponseGrantVisitorIdentityFieldsOrganization>
    {
        public override GrantsGetResponseGrantVisitorIdentityFieldsOrganization Read(
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
            return new GrantsGetResponseGrantVisitorIdentityFieldsOrganization(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsGetResponseGrantVisitorIdentityFieldsOrganization value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsGetResponseGrantVisitorIdentityFieldsOrganization ReadAsPropertyName(
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
            return new GrantsGetResponseGrantVisitorIdentityFieldsOrganization(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsGetResponseGrantVisitorIdentityFieldsOrganization value,
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
