using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsExchangeResponseVisitorIdentityRequestInvalidItem.GrantsExchangeResponseVisitorIdentityRequestInvalidItemSerializer)
)]
[Serializable]
public readonly record struct GrantsExchangeResponseVisitorIdentityRequestInvalidItem : IStringEnum
{
    public static readonly GrantsExchangeResponseVisitorIdentityRequestInvalidItem DisplayName =
        new(Values.DisplayName);

    public static readonly GrantsExchangeResponseVisitorIdentityRequestInvalidItem Email = new(
        Values.Email
    );

    public static readonly GrantsExchangeResponseVisitorIdentityRequestInvalidItem Title = new(
        Values.Title
    );

    public static readonly GrantsExchangeResponseVisitorIdentityRequestInvalidItem Organization =
        new(Values.Organization);

    public static readonly GrantsExchangeResponseVisitorIdentityRequestInvalidItem OrganizationalUnit =
        new(Values.OrganizationalUnit);

    public GrantsExchangeResponseVisitorIdentityRequestInvalidItem(string value)
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
    public static GrantsExchangeResponseVisitorIdentityRequestInvalidItem FromCustom(string value)
    {
        return new GrantsExchangeResponseVisitorIdentityRequestInvalidItem(value);
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
        GrantsExchangeResponseVisitorIdentityRequestInvalidItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsExchangeResponseVisitorIdentityRequestInvalidItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsExchangeResponseVisitorIdentityRequestInvalidItem value
    ) => value.Value;

    public static explicit operator GrantsExchangeResponseVisitorIdentityRequestInvalidItem(
        string value
    ) => new(value);

    internal class GrantsExchangeResponseVisitorIdentityRequestInvalidItemSerializer
        : JsonConverter<GrantsExchangeResponseVisitorIdentityRequestInvalidItem>
    {
        public override GrantsExchangeResponseVisitorIdentityRequestInvalidItem Read(
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
            return new GrantsExchangeResponseVisitorIdentityRequestInvalidItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsExchangeResponseVisitorIdentityRequestInvalidItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsExchangeResponseVisitorIdentityRequestInvalidItem ReadAsPropertyName(
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
            return new GrantsExchangeResponseVisitorIdentityRequestInvalidItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsExchangeResponseVisitorIdentityRequestInvalidItem value,
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
