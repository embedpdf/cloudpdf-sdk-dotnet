using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsCreateResponseGrantVisitorIdentityFieldsOrganization.GrantsCreateResponseGrantVisitorIdentityFieldsOrganizationSerializer)
)]
[Serializable]
public readonly record struct GrantsCreateResponseGrantVisitorIdentityFieldsOrganization
    : IStringEnum
{
    public static readonly GrantsCreateResponseGrantVisitorIdentityFieldsOrganization Required =
        new(Values.Required);

    public static readonly GrantsCreateResponseGrantVisitorIdentityFieldsOrganization Optional =
        new(Values.Optional);

    public GrantsCreateResponseGrantVisitorIdentityFieldsOrganization(string value)
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
    public static GrantsCreateResponseGrantVisitorIdentityFieldsOrganization FromCustom(
        string value
    )
    {
        return new GrantsCreateResponseGrantVisitorIdentityFieldsOrganization(value);
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
        GrantsCreateResponseGrantVisitorIdentityFieldsOrganization value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsCreateResponseGrantVisitorIdentityFieldsOrganization value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsCreateResponseGrantVisitorIdentityFieldsOrganization value
    ) => value.Value;

    public static explicit operator GrantsCreateResponseGrantVisitorIdentityFieldsOrganization(
        string value
    ) => new(value);

    internal class GrantsCreateResponseGrantVisitorIdentityFieldsOrganizationSerializer
        : JsonConverter<GrantsCreateResponseGrantVisitorIdentityFieldsOrganization>
    {
        public override GrantsCreateResponseGrantVisitorIdentityFieldsOrganization Read(
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
            return new GrantsCreateResponseGrantVisitorIdentityFieldsOrganization(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsCreateResponseGrantVisitorIdentityFieldsOrganization value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsCreateResponseGrantVisitorIdentityFieldsOrganization ReadAsPropertyName(
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
            return new GrantsCreateResponseGrantVisitorIdentityFieldsOrganization(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsCreateResponseGrantVisitorIdentityFieldsOrganization value,
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
