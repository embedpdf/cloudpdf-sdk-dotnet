using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesExchange200ResponseVisitorIdentityRequestMissingItem.SharesExchange200ResponseVisitorIdentityRequestMissingItemSerializer)
)]
[Serializable]
public readonly record struct SharesExchange200ResponseVisitorIdentityRequestMissingItem
    : IStringEnum
{
    public static readonly SharesExchange200ResponseVisitorIdentityRequestMissingItem DisplayName =
        new(Values.DisplayName);

    public static readonly SharesExchange200ResponseVisitorIdentityRequestMissingItem Email = new(
        Values.Email
    );

    public static readonly SharesExchange200ResponseVisitorIdentityRequestMissingItem Title = new(
        Values.Title
    );

    public static readonly SharesExchange200ResponseVisitorIdentityRequestMissingItem Organization =
        new(Values.Organization);

    public static readonly SharesExchange200ResponseVisitorIdentityRequestMissingItem OrganizationalUnit =
        new(Values.OrganizationalUnit);

    public SharesExchange200ResponseVisitorIdentityRequestMissingItem(string value)
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
    public static SharesExchange200ResponseVisitorIdentityRequestMissingItem FromCustom(
        string value
    )
    {
        return new SharesExchange200ResponseVisitorIdentityRequestMissingItem(value);
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
        SharesExchange200ResponseVisitorIdentityRequestMissingItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesExchange200ResponseVisitorIdentityRequestMissingItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SharesExchange200ResponseVisitorIdentityRequestMissingItem value
    ) => value.Value;

    public static explicit operator SharesExchange200ResponseVisitorIdentityRequestMissingItem(
        string value
    ) => new(value);

    internal class SharesExchange200ResponseVisitorIdentityRequestMissingItemSerializer
        : JsonConverter<SharesExchange200ResponseVisitorIdentityRequestMissingItem>
    {
        public override SharesExchange200ResponseVisitorIdentityRequestMissingItem Read(
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
            return new SharesExchange200ResponseVisitorIdentityRequestMissingItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesExchange200ResponseVisitorIdentityRequestMissingItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesExchange200ResponseVisitorIdentityRequestMissingItem ReadAsPropertyName(
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
            return new SharesExchange200ResponseVisitorIdentityRequestMissingItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesExchange200ResponseVisitorIdentityRequestMissingItem value,
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
        public const string DisplayName = "displayName";

        public const string Email = "email";

        public const string Title = "title";

        public const string Organization = "organization";

        public const string OrganizationalUnit = "organizationalUnit";
    }
}
