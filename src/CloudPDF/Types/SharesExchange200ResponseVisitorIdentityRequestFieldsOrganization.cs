using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesExchange200ResponseVisitorIdentityRequestFieldsOrganization.SharesExchange200ResponseVisitorIdentityRequestFieldsOrganizationSerializer)
)]
[Serializable]
public readonly record struct SharesExchange200ResponseVisitorIdentityRequestFieldsOrganization
    : IStringEnum
{
    public static readonly SharesExchange200ResponseVisitorIdentityRequestFieldsOrganization Required =
        new(Values.Required);

    public static readonly SharesExchange200ResponseVisitorIdentityRequestFieldsOrganization Optional =
        new(Values.Optional);

    public SharesExchange200ResponseVisitorIdentityRequestFieldsOrganization(string value)
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
    public static SharesExchange200ResponseVisitorIdentityRequestFieldsOrganization FromCustom(
        string value
    )
    {
        return new SharesExchange200ResponseVisitorIdentityRequestFieldsOrganization(value);
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
        SharesExchange200ResponseVisitorIdentityRequestFieldsOrganization value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesExchange200ResponseVisitorIdentityRequestFieldsOrganization value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SharesExchange200ResponseVisitorIdentityRequestFieldsOrganization value
    ) => value.Value;

    public static explicit operator SharesExchange200ResponseVisitorIdentityRequestFieldsOrganization(
        string value
    ) => new(value);

    internal class SharesExchange200ResponseVisitorIdentityRequestFieldsOrganizationSerializer
        : JsonConverter<SharesExchange200ResponseVisitorIdentityRequestFieldsOrganization>
    {
        public override SharesExchange200ResponseVisitorIdentityRequestFieldsOrganization Read(
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
            return new SharesExchange200ResponseVisitorIdentityRequestFieldsOrganization(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesExchange200ResponseVisitorIdentityRequestFieldsOrganization value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesExchange200ResponseVisitorIdentityRequestFieldsOrganization ReadAsPropertyName(
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
            return new SharesExchange200ResponseVisitorIdentityRequestFieldsOrganization(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesExchange200ResponseVisitorIdentityRequestFieldsOrganization value,
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
