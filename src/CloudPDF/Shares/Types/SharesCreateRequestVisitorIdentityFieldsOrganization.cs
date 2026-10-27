using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesCreateRequestVisitorIdentityFieldsOrganization.SharesCreateRequestVisitorIdentityFieldsOrganizationSerializer)
)]
[Serializable]
public readonly record struct SharesCreateRequestVisitorIdentityFieldsOrganization : IStringEnum
{
    public static readonly SharesCreateRequestVisitorIdentityFieldsOrganization Required = new(
        Values.Required
    );

    public static readonly SharesCreateRequestVisitorIdentityFieldsOrganization Optional = new(
        Values.Optional
    );

    public SharesCreateRequestVisitorIdentityFieldsOrganization(string value)
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
    public static SharesCreateRequestVisitorIdentityFieldsOrganization FromCustom(string value)
    {
        return new SharesCreateRequestVisitorIdentityFieldsOrganization(value);
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
        SharesCreateRequestVisitorIdentityFieldsOrganization value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesCreateRequestVisitorIdentityFieldsOrganization value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SharesCreateRequestVisitorIdentityFieldsOrganization value
    ) => value.Value;

    public static explicit operator SharesCreateRequestVisitorIdentityFieldsOrganization(
        string value
    ) => new(value);

    internal class SharesCreateRequestVisitorIdentityFieldsOrganizationSerializer
        : JsonConverter<SharesCreateRequestVisitorIdentityFieldsOrganization>
    {
        public override SharesCreateRequestVisitorIdentityFieldsOrganization Read(
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
            return new SharesCreateRequestVisitorIdentityFieldsOrganization(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesCreateRequestVisitorIdentityFieldsOrganization value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesCreateRequestVisitorIdentityFieldsOrganization ReadAsPropertyName(
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
            return new SharesCreateRequestVisitorIdentityFieldsOrganization(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesCreateRequestVisitorIdentityFieldsOrganization value,
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
