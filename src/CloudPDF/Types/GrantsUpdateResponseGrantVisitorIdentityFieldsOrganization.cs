using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsUpdateResponseGrantVisitorIdentityFieldsOrganization.GrantsUpdateResponseGrantVisitorIdentityFieldsOrganizationSerializer)
)]
[Serializable]
public readonly record struct GrantsUpdateResponseGrantVisitorIdentityFieldsOrganization
    : IStringEnum
{
    public static readonly GrantsUpdateResponseGrantVisitorIdentityFieldsOrganization Required =
        new(Values.Required);

    public static readonly GrantsUpdateResponseGrantVisitorIdentityFieldsOrganization Optional =
        new(Values.Optional);

    public GrantsUpdateResponseGrantVisitorIdentityFieldsOrganization(string value)
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
    public static GrantsUpdateResponseGrantVisitorIdentityFieldsOrganization FromCustom(
        string value
    )
    {
        return new GrantsUpdateResponseGrantVisitorIdentityFieldsOrganization(value);
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
        GrantsUpdateResponseGrantVisitorIdentityFieldsOrganization value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsUpdateResponseGrantVisitorIdentityFieldsOrganization value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsUpdateResponseGrantVisitorIdentityFieldsOrganization value
    ) => value.Value;

    public static explicit operator GrantsUpdateResponseGrantVisitorIdentityFieldsOrganization(
        string value
    ) => new(value);

    internal class GrantsUpdateResponseGrantVisitorIdentityFieldsOrganizationSerializer
        : JsonConverter<GrantsUpdateResponseGrantVisitorIdentityFieldsOrganization>
    {
        public override GrantsUpdateResponseGrantVisitorIdentityFieldsOrganization Read(
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
            return new GrantsUpdateResponseGrantVisitorIdentityFieldsOrganization(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsUpdateResponseGrantVisitorIdentityFieldsOrganization value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsUpdateResponseGrantVisitorIdentityFieldsOrganization ReadAsPropertyName(
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
            return new GrantsUpdateResponseGrantVisitorIdentityFieldsOrganization(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsUpdateResponseGrantVisitorIdentityFieldsOrganization value,
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
