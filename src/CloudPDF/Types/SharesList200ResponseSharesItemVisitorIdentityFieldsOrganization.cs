using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesList200ResponseSharesItemVisitorIdentityFieldsOrganization.SharesList200ResponseSharesItemVisitorIdentityFieldsOrganizationSerializer)
)]
[Serializable]
public readonly record struct SharesList200ResponseSharesItemVisitorIdentityFieldsOrganization
    : IStringEnum
{
    public static readonly SharesList200ResponseSharesItemVisitorIdentityFieldsOrganization Required =
        new(Values.Required);

    public static readonly SharesList200ResponseSharesItemVisitorIdentityFieldsOrganization Optional =
        new(Values.Optional);

    public SharesList200ResponseSharesItemVisitorIdentityFieldsOrganization(string value)
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
    public static SharesList200ResponseSharesItemVisitorIdentityFieldsOrganization FromCustom(
        string value
    )
    {
        return new SharesList200ResponseSharesItemVisitorIdentityFieldsOrganization(value);
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
        SharesList200ResponseSharesItemVisitorIdentityFieldsOrganization value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesList200ResponseSharesItemVisitorIdentityFieldsOrganization value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SharesList200ResponseSharesItemVisitorIdentityFieldsOrganization value
    ) => value.Value;

    public static explicit operator SharesList200ResponseSharesItemVisitorIdentityFieldsOrganization(
        string value
    ) => new(value);

    internal class SharesList200ResponseSharesItemVisitorIdentityFieldsOrganizationSerializer
        : JsonConverter<SharesList200ResponseSharesItemVisitorIdentityFieldsOrganization>
    {
        public override SharesList200ResponseSharesItemVisitorIdentityFieldsOrganization Read(
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
            return new SharesList200ResponseSharesItemVisitorIdentityFieldsOrganization(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesList200ResponseSharesItemVisitorIdentityFieldsOrganization value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesList200ResponseSharesItemVisitorIdentityFieldsOrganization ReadAsPropertyName(
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
            return new SharesList200ResponseSharesItemVisitorIdentityFieldsOrganization(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesList200ResponseSharesItemVisitorIdentityFieldsOrganization value,
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
