using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsExchange200ResponseVisitorIdentityRequestMissingItem.GrantsExchange200ResponseVisitorIdentityRequestMissingItemSerializer)
)]
[Serializable]
public readonly record struct GrantsExchange200ResponseVisitorIdentityRequestMissingItem
    : IStringEnum
{
    public static readonly GrantsExchange200ResponseVisitorIdentityRequestMissingItem DisplayName =
        new(Values.DisplayName);

    public static readonly GrantsExchange200ResponseVisitorIdentityRequestMissingItem Email = new(
        Values.Email
    );

    public static readonly GrantsExchange200ResponseVisitorIdentityRequestMissingItem Title = new(
        Values.Title
    );

    public static readonly GrantsExchange200ResponseVisitorIdentityRequestMissingItem Organization =
        new(Values.Organization);

    public static readonly GrantsExchange200ResponseVisitorIdentityRequestMissingItem OrganizationalUnit =
        new(Values.OrganizationalUnit);

    public GrantsExchange200ResponseVisitorIdentityRequestMissingItem(string value)
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
    public static GrantsExchange200ResponseVisitorIdentityRequestMissingItem FromCustom(
        string value
    )
    {
        return new GrantsExchange200ResponseVisitorIdentityRequestMissingItem(value);
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
        GrantsExchange200ResponseVisitorIdentityRequestMissingItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsExchange200ResponseVisitorIdentityRequestMissingItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsExchange200ResponseVisitorIdentityRequestMissingItem value
    ) => value.Value;

    public static explicit operator GrantsExchange200ResponseVisitorIdentityRequestMissingItem(
        string value
    ) => new(value);

    internal class GrantsExchange200ResponseVisitorIdentityRequestMissingItemSerializer
        : JsonConverter<GrantsExchange200ResponseVisitorIdentityRequestMissingItem>
    {
        public override GrantsExchange200ResponseVisitorIdentityRequestMissingItem Read(
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
            return new GrantsExchange200ResponseVisitorIdentityRequestMissingItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsExchange200ResponseVisitorIdentityRequestMissingItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsExchange200ResponseVisitorIdentityRequestMissingItem ReadAsPropertyName(
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
            return new GrantsExchange200ResponseVisitorIdentityRequestMissingItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsExchange200ResponseVisitorIdentityRequestMissingItem value,
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
