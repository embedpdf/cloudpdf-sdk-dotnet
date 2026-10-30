using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsUpdateRequestVisitorIdentityFieldsOrganization.GrantsUpdateRequestVisitorIdentityFieldsOrganizationSerializer)
)]
[Serializable]
public readonly record struct GrantsUpdateRequestVisitorIdentityFieldsOrganization : IStringEnum
{
    public static readonly GrantsUpdateRequestVisitorIdentityFieldsOrganization Required = new(
        Values.Required
    );

    public static readonly GrantsUpdateRequestVisitorIdentityFieldsOrganization Optional = new(
        Values.Optional
    );

    public GrantsUpdateRequestVisitorIdentityFieldsOrganization(string value)
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
    public static GrantsUpdateRequestVisitorIdentityFieldsOrganization FromCustom(string value)
    {
        return new GrantsUpdateRequestVisitorIdentityFieldsOrganization(value);
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
        GrantsUpdateRequestVisitorIdentityFieldsOrganization value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsUpdateRequestVisitorIdentityFieldsOrganization value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsUpdateRequestVisitorIdentityFieldsOrganization value
    ) => value.Value;

    public static explicit operator GrantsUpdateRequestVisitorIdentityFieldsOrganization(
        string value
    ) => new(value);

    internal class GrantsUpdateRequestVisitorIdentityFieldsOrganizationSerializer
        : JsonConverter<GrantsUpdateRequestVisitorIdentityFieldsOrganization>
    {
        public override GrantsUpdateRequestVisitorIdentityFieldsOrganization Read(
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
            return new GrantsUpdateRequestVisitorIdentityFieldsOrganization(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsUpdateRequestVisitorIdentityFieldsOrganization value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsUpdateRequestVisitorIdentityFieldsOrganization ReadAsPropertyName(
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
            return new GrantsUpdateRequestVisitorIdentityFieldsOrganization(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsUpdateRequestVisitorIdentityFieldsOrganization value,
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
