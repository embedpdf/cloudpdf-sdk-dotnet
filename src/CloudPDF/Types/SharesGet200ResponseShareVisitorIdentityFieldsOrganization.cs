using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesGet200ResponseShareVisitorIdentityFieldsOrganization.SharesGet200ResponseShareVisitorIdentityFieldsOrganizationSerializer)
)]
[Serializable]
public readonly record struct SharesGet200ResponseShareVisitorIdentityFieldsOrganization
    : IStringEnum
{
    public static readonly SharesGet200ResponseShareVisitorIdentityFieldsOrganization Required =
        new(Values.Required);

    public static readonly SharesGet200ResponseShareVisitorIdentityFieldsOrganization Optional =
        new(Values.Optional);

    public SharesGet200ResponseShareVisitorIdentityFieldsOrganization(string value)
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
    public static SharesGet200ResponseShareVisitorIdentityFieldsOrganization FromCustom(
        string value
    )
    {
        return new SharesGet200ResponseShareVisitorIdentityFieldsOrganization(value);
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
        SharesGet200ResponseShareVisitorIdentityFieldsOrganization value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesGet200ResponseShareVisitorIdentityFieldsOrganization value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SharesGet200ResponseShareVisitorIdentityFieldsOrganization value
    ) => value.Value;

    public static explicit operator SharesGet200ResponseShareVisitorIdentityFieldsOrganization(
        string value
    ) => new(value);

    internal class SharesGet200ResponseShareVisitorIdentityFieldsOrganizationSerializer
        : JsonConverter<SharesGet200ResponseShareVisitorIdentityFieldsOrganization>
    {
        public override SharesGet200ResponseShareVisitorIdentityFieldsOrganization Read(
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
            return new SharesGet200ResponseShareVisitorIdentityFieldsOrganization(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesGet200ResponseShareVisitorIdentityFieldsOrganization value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesGet200ResponseShareVisitorIdentityFieldsOrganization ReadAsPropertyName(
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
            return new SharesGet200ResponseShareVisitorIdentityFieldsOrganization(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesGet200ResponseShareVisitorIdentityFieldsOrganization value,
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
