using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsExchangeResponseVisitorIdentityRequestFieldsTitle.GrantsExchangeResponseVisitorIdentityRequestFieldsTitleSerializer)
)]
[Serializable]
public readonly record struct GrantsExchangeResponseVisitorIdentityRequestFieldsTitle : IStringEnum
{
    public static readonly GrantsExchangeResponseVisitorIdentityRequestFieldsTitle Required = new(
        Values.Required
    );

    public static readonly GrantsExchangeResponseVisitorIdentityRequestFieldsTitle Optional = new(
        Values.Optional
    );

    public GrantsExchangeResponseVisitorIdentityRequestFieldsTitle(string value)
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
    public static GrantsExchangeResponseVisitorIdentityRequestFieldsTitle FromCustom(string value)
    {
        return new GrantsExchangeResponseVisitorIdentityRequestFieldsTitle(value);
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
        GrantsExchangeResponseVisitorIdentityRequestFieldsTitle value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsExchangeResponseVisitorIdentityRequestFieldsTitle value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsExchangeResponseVisitorIdentityRequestFieldsTitle value
    ) => value.Value;

    public static explicit operator GrantsExchangeResponseVisitorIdentityRequestFieldsTitle(
        string value
    ) => new(value);

    internal class GrantsExchangeResponseVisitorIdentityRequestFieldsTitleSerializer
        : JsonConverter<GrantsExchangeResponseVisitorIdentityRequestFieldsTitle>
    {
        public override GrantsExchangeResponseVisitorIdentityRequestFieldsTitle Read(
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
            return new GrantsExchangeResponseVisitorIdentityRequestFieldsTitle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsExchangeResponseVisitorIdentityRequestFieldsTitle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsExchangeResponseVisitorIdentityRequestFieldsTitle ReadAsPropertyName(
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
            return new GrantsExchangeResponseVisitorIdentityRequestFieldsTitle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsExchangeResponseVisitorIdentityRequestFieldsTitle value,
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
