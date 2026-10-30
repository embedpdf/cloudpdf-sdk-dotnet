using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsExchange200ResponseVisitorIdentityRequestInvalidItem.GrantsExchange200ResponseVisitorIdentityRequestInvalidItemSerializer)
)]
[Serializable]
public readonly record struct GrantsExchange200ResponseVisitorIdentityRequestInvalidItem
    : IStringEnum
{
    public static readonly GrantsExchange200ResponseVisitorIdentityRequestInvalidItem DisplayName =
        new(Values.DisplayName);

    public static readonly GrantsExchange200ResponseVisitorIdentityRequestInvalidItem Email = new(
        Values.Email
    );

    public static readonly GrantsExchange200ResponseVisitorIdentityRequestInvalidItem Title = new(
        Values.Title
    );

    public static readonly GrantsExchange200ResponseVisitorIdentityRequestInvalidItem Organization =
        new(Values.Organization);

    public static readonly GrantsExchange200ResponseVisitorIdentityRequestInvalidItem OrganizationalUnit =
        new(Values.OrganizationalUnit);

    public GrantsExchange200ResponseVisitorIdentityRequestInvalidItem(string value)
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
    public static GrantsExchange200ResponseVisitorIdentityRequestInvalidItem FromCustom(
        string value
    )
    {
        return new GrantsExchange200ResponseVisitorIdentityRequestInvalidItem(value);
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
        GrantsExchange200ResponseVisitorIdentityRequestInvalidItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsExchange200ResponseVisitorIdentityRequestInvalidItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsExchange200ResponseVisitorIdentityRequestInvalidItem value
    ) => value.Value;

    public static explicit operator GrantsExchange200ResponseVisitorIdentityRequestInvalidItem(
        string value
    ) => new(value);

    internal class GrantsExchange200ResponseVisitorIdentityRequestInvalidItemSerializer
        : JsonConverter<GrantsExchange200ResponseVisitorIdentityRequestInvalidItem>
    {
        public override GrantsExchange200ResponseVisitorIdentityRequestInvalidItem Read(
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
            return new GrantsExchange200ResponseVisitorIdentityRequestInvalidItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsExchange200ResponseVisitorIdentityRequestInvalidItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsExchange200ResponseVisitorIdentityRequestInvalidItem ReadAsPropertyName(
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
            return new GrantsExchange200ResponseVisitorIdentityRequestInvalidItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsExchange200ResponseVisitorIdentityRequestInvalidItem value,
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
