using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsGet200ResponseGrantVisitorIdentityFieldsTitle.GrantsGet200ResponseGrantVisitorIdentityFieldsTitleSerializer)
)]
[Serializable]
public readonly record struct GrantsGet200ResponseGrantVisitorIdentityFieldsTitle : IStringEnum
{
    public static readonly GrantsGet200ResponseGrantVisitorIdentityFieldsTitle Required = new(
        Values.Required
    );

    public static readonly GrantsGet200ResponseGrantVisitorIdentityFieldsTitle Optional = new(
        Values.Optional
    );

    public GrantsGet200ResponseGrantVisitorIdentityFieldsTitle(string value)
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
    public static GrantsGet200ResponseGrantVisitorIdentityFieldsTitle FromCustom(string value)
    {
        return new GrantsGet200ResponseGrantVisitorIdentityFieldsTitle(value);
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
        GrantsGet200ResponseGrantVisitorIdentityFieldsTitle value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsGet200ResponseGrantVisitorIdentityFieldsTitle value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsGet200ResponseGrantVisitorIdentityFieldsTitle value
    ) => value.Value;

    public static explicit operator GrantsGet200ResponseGrantVisitorIdentityFieldsTitle(
        string value
    ) => new(value);

    internal class GrantsGet200ResponseGrantVisitorIdentityFieldsTitleSerializer
        : JsonConverter<GrantsGet200ResponseGrantVisitorIdentityFieldsTitle>
    {
        public override GrantsGet200ResponseGrantVisitorIdentityFieldsTitle Read(
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
            return new GrantsGet200ResponseGrantVisitorIdentityFieldsTitle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsGet200ResponseGrantVisitorIdentityFieldsTitle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsGet200ResponseGrantVisitorIdentityFieldsTitle ReadAsPropertyName(
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
            return new GrantsGet200ResponseGrantVisitorIdentityFieldsTitle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsGet200ResponseGrantVisitorIdentityFieldsTitle value,
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
