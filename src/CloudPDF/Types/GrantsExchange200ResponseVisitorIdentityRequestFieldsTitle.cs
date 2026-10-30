using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsExchange200ResponseVisitorIdentityRequestFieldsTitle.GrantsExchange200ResponseVisitorIdentityRequestFieldsTitleSerializer)
)]
[Serializable]
public readonly record struct GrantsExchange200ResponseVisitorIdentityRequestFieldsTitle
    : IStringEnum
{
    public static readonly GrantsExchange200ResponseVisitorIdentityRequestFieldsTitle Required =
        new(Values.Required);

    public static readonly GrantsExchange200ResponseVisitorIdentityRequestFieldsTitle Optional =
        new(Values.Optional);

    public GrantsExchange200ResponseVisitorIdentityRequestFieldsTitle(string value)
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
    public static GrantsExchange200ResponseVisitorIdentityRequestFieldsTitle FromCustom(
        string value
    )
    {
        return new GrantsExchange200ResponseVisitorIdentityRequestFieldsTitle(value);
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
        GrantsExchange200ResponseVisitorIdentityRequestFieldsTitle value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsExchange200ResponseVisitorIdentityRequestFieldsTitle value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsExchange200ResponseVisitorIdentityRequestFieldsTitle value
    ) => value.Value;

    public static explicit operator GrantsExchange200ResponseVisitorIdentityRequestFieldsTitle(
        string value
    ) => new(value);

    internal class GrantsExchange200ResponseVisitorIdentityRequestFieldsTitleSerializer
        : JsonConverter<GrantsExchange200ResponseVisitorIdentityRequestFieldsTitle>
    {
        public override GrantsExchange200ResponseVisitorIdentityRequestFieldsTitle Read(
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
            return new GrantsExchange200ResponseVisitorIdentityRequestFieldsTitle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsExchange200ResponseVisitorIdentityRequestFieldsTitle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsExchange200ResponseVisitorIdentityRequestFieldsTitle ReadAsPropertyName(
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
            return new GrantsExchange200ResponseVisitorIdentityRequestFieldsTitle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsExchange200ResponseVisitorIdentityRequestFieldsTitle value,
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
