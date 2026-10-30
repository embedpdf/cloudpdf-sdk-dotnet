using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsExchange200ResponseVisitorIdentityRequestFieldsDisplayName.GrantsExchange200ResponseVisitorIdentityRequestFieldsDisplayNameSerializer)
)]
[Serializable]
public readonly record struct GrantsExchange200ResponseVisitorIdentityRequestFieldsDisplayName
    : IStringEnum
{
    public static readonly GrantsExchange200ResponseVisitorIdentityRequestFieldsDisplayName Required =
        new(Values.Required);

    public static readonly GrantsExchange200ResponseVisitorIdentityRequestFieldsDisplayName Optional =
        new(Values.Optional);

    public GrantsExchange200ResponseVisitorIdentityRequestFieldsDisplayName(string value)
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
    public static GrantsExchange200ResponseVisitorIdentityRequestFieldsDisplayName FromCustom(
        string value
    )
    {
        return new GrantsExchange200ResponseVisitorIdentityRequestFieldsDisplayName(value);
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
        GrantsExchange200ResponseVisitorIdentityRequestFieldsDisplayName value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsExchange200ResponseVisitorIdentityRequestFieldsDisplayName value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsExchange200ResponseVisitorIdentityRequestFieldsDisplayName value
    ) => value.Value;

    public static explicit operator GrantsExchange200ResponseVisitorIdentityRequestFieldsDisplayName(
        string value
    ) => new(value);

    internal class GrantsExchange200ResponseVisitorIdentityRequestFieldsDisplayNameSerializer
        : JsonConverter<GrantsExchange200ResponseVisitorIdentityRequestFieldsDisplayName>
    {
        public override GrantsExchange200ResponseVisitorIdentityRequestFieldsDisplayName Read(
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
            return new GrantsExchange200ResponseVisitorIdentityRequestFieldsDisplayName(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsExchange200ResponseVisitorIdentityRequestFieldsDisplayName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsExchange200ResponseVisitorIdentityRequestFieldsDisplayName ReadAsPropertyName(
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
            return new GrantsExchange200ResponseVisitorIdentityRequestFieldsDisplayName(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsExchange200ResponseVisitorIdentityRequestFieldsDisplayName value,
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
