using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsExchangeResponseVisitorIdentityRequestMissingItem.GrantsExchangeResponseVisitorIdentityRequestMissingItemSerializer)
)]
[Serializable]
public readonly record struct GrantsExchangeResponseVisitorIdentityRequestMissingItem : IStringEnum
{
    public static readonly GrantsExchangeResponseVisitorIdentityRequestMissingItem DisplayName =
        new(Values.DisplayName);

    public static readonly GrantsExchangeResponseVisitorIdentityRequestMissingItem Email = new(
        Values.Email
    );

    public static readonly GrantsExchangeResponseVisitorIdentityRequestMissingItem Title = new(
        Values.Title
    );

    public static readonly GrantsExchangeResponseVisitorIdentityRequestMissingItem Organization =
        new(Values.Organization);

    public static readonly GrantsExchangeResponseVisitorIdentityRequestMissingItem OrganizationalUnit =
        new(Values.OrganizationalUnit);

    public GrantsExchangeResponseVisitorIdentityRequestMissingItem(string value)
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
    public static GrantsExchangeResponseVisitorIdentityRequestMissingItem FromCustom(string value)
    {
        return new GrantsExchangeResponseVisitorIdentityRequestMissingItem(value);
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
        GrantsExchangeResponseVisitorIdentityRequestMissingItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsExchangeResponseVisitorIdentityRequestMissingItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsExchangeResponseVisitorIdentityRequestMissingItem value
    ) => value.Value;

    public static explicit operator GrantsExchangeResponseVisitorIdentityRequestMissingItem(
        string value
    ) => new(value);

    internal class GrantsExchangeResponseVisitorIdentityRequestMissingItemSerializer
        : JsonConverter<GrantsExchangeResponseVisitorIdentityRequestMissingItem>
    {
        public override GrantsExchangeResponseVisitorIdentityRequestMissingItem Read(
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
            return new GrantsExchangeResponseVisitorIdentityRequestMissingItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsExchangeResponseVisitorIdentityRequestMissingItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsExchangeResponseVisitorIdentityRequestMissingItem ReadAsPropertyName(
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
            return new GrantsExchangeResponseVisitorIdentityRequestMissingItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsExchangeResponseVisitorIdentityRequestMissingItem value,
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
