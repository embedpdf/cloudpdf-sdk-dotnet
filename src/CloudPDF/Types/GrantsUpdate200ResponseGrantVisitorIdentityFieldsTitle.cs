using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsUpdate200ResponseGrantVisitorIdentityFieldsTitle.GrantsUpdate200ResponseGrantVisitorIdentityFieldsTitleSerializer)
)]
[Serializable]
public readonly record struct GrantsUpdate200ResponseGrantVisitorIdentityFieldsTitle : IStringEnum
{
    public static readonly GrantsUpdate200ResponseGrantVisitorIdentityFieldsTitle Required = new(
        Values.Required
    );

    public static readonly GrantsUpdate200ResponseGrantVisitorIdentityFieldsTitle Optional = new(
        Values.Optional
    );

    public GrantsUpdate200ResponseGrantVisitorIdentityFieldsTitle(string value)
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
    public static GrantsUpdate200ResponseGrantVisitorIdentityFieldsTitle FromCustom(string value)
    {
        return new GrantsUpdate200ResponseGrantVisitorIdentityFieldsTitle(value);
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
        GrantsUpdate200ResponseGrantVisitorIdentityFieldsTitle value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsUpdate200ResponseGrantVisitorIdentityFieldsTitle value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsUpdate200ResponseGrantVisitorIdentityFieldsTitle value
    ) => value.Value;

    public static explicit operator GrantsUpdate200ResponseGrantVisitorIdentityFieldsTitle(
        string value
    ) => new(value);

    internal class GrantsUpdate200ResponseGrantVisitorIdentityFieldsTitleSerializer
        : JsonConverter<GrantsUpdate200ResponseGrantVisitorIdentityFieldsTitle>
    {
        public override GrantsUpdate200ResponseGrantVisitorIdentityFieldsTitle Read(
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
            return new GrantsUpdate200ResponseGrantVisitorIdentityFieldsTitle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsUpdate200ResponseGrantVisitorIdentityFieldsTitle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsUpdate200ResponseGrantVisitorIdentityFieldsTitle ReadAsPropertyName(
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
            return new GrantsUpdate200ResponseGrantVisitorIdentityFieldsTitle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsUpdate200ResponseGrantVisitorIdentityFieldsTitle value,
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
