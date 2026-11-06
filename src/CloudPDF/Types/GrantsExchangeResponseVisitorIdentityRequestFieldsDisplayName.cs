using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsExchangeResponseVisitorIdentityRequestFieldsDisplayName.GrantsExchangeResponseVisitorIdentityRequestFieldsDisplayNameSerializer)
)]
[Serializable]
public readonly record struct GrantsExchangeResponseVisitorIdentityRequestFieldsDisplayName
    : IStringEnum
{
    public static readonly GrantsExchangeResponseVisitorIdentityRequestFieldsDisplayName Required =
        new(Values.Required);

    public static readonly GrantsExchangeResponseVisitorIdentityRequestFieldsDisplayName Optional =
        new(Values.Optional);

    public GrantsExchangeResponseVisitorIdentityRequestFieldsDisplayName(string value)
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
    public static GrantsExchangeResponseVisitorIdentityRequestFieldsDisplayName FromCustom(
        string value
    )
    {
        return new GrantsExchangeResponseVisitorIdentityRequestFieldsDisplayName(value);
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
        GrantsExchangeResponseVisitorIdentityRequestFieldsDisplayName value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsExchangeResponseVisitorIdentityRequestFieldsDisplayName value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsExchangeResponseVisitorIdentityRequestFieldsDisplayName value
    ) => value.Value;

    public static explicit operator GrantsExchangeResponseVisitorIdentityRequestFieldsDisplayName(
        string value
    ) => new(value);

    internal class GrantsExchangeResponseVisitorIdentityRequestFieldsDisplayNameSerializer
        : JsonConverter<GrantsExchangeResponseVisitorIdentityRequestFieldsDisplayName>
    {
        public override GrantsExchangeResponseVisitorIdentityRequestFieldsDisplayName Read(
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
            return new GrantsExchangeResponseVisitorIdentityRequestFieldsDisplayName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsExchangeResponseVisitorIdentityRequestFieldsDisplayName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsExchangeResponseVisitorIdentityRequestFieldsDisplayName ReadAsPropertyName(
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
            return new GrantsExchangeResponseVisitorIdentityRequestFieldsDisplayName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsExchangeResponseVisitorIdentityRequestFieldsDisplayName value,
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
