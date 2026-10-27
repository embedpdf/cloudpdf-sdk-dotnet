using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesCreate200ResponseShareVisitorIdentityFieldsOrganization.SharesCreate200ResponseShareVisitorIdentityFieldsOrganizationSerializer)
)]
[Serializable]
public readonly record struct SharesCreate200ResponseShareVisitorIdentityFieldsOrganization
    : IStringEnum
{
    public static readonly SharesCreate200ResponseShareVisitorIdentityFieldsOrganization Required =
        new(Values.Required);

    public static readonly SharesCreate200ResponseShareVisitorIdentityFieldsOrganization Optional =
        new(Values.Optional);

    public SharesCreate200ResponseShareVisitorIdentityFieldsOrganization(string value)
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
    public static SharesCreate200ResponseShareVisitorIdentityFieldsOrganization FromCustom(
        string value
    )
    {
        return new SharesCreate200ResponseShareVisitorIdentityFieldsOrganization(value);
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
        SharesCreate200ResponseShareVisitorIdentityFieldsOrganization value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesCreate200ResponseShareVisitorIdentityFieldsOrganization value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SharesCreate200ResponseShareVisitorIdentityFieldsOrganization value
    ) => value.Value;

    public static explicit operator SharesCreate200ResponseShareVisitorIdentityFieldsOrganization(
        string value
    ) => new(value);

    internal class SharesCreate200ResponseShareVisitorIdentityFieldsOrganizationSerializer
        : JsonConverter<SharesCreate200ResponseShareVisitorIdentityFieldsOrganization>
    {
        public override SharesCreate200ResponseShareVisitorIdentityFieldsOrganization Read(
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
            return new SharesCreate200ResponseShareVisitorIdentityFieldsOrganization(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesCreate200ResponseShareVisitorIdentityFieldsOrganization value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesCreate200ResponseShareVisitorIdentityFieldsOrganization ReadAsPropertyName(
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
            return new SharesCreate200ResponseShareVisitorIdentityFieldsOrganization(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesCreate200ResponseShareVisitorIdentityFieldsOrganization value,
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
