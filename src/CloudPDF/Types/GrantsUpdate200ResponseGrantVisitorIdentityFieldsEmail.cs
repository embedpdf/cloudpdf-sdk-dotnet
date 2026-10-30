using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsUpdate200ResponseGrantVisitorIdentityFieldsEmail.GrantsUpdate200ResponseGrantVisitorIdentityFieldsEmailSerializer)
)]
[Serializable]
public readonly record struct GrantsUpdate200ResponseGrantVisitorIdentityFieldsEmail : IStringEnum
{
    public static readonly GrantsUpdate200ResponseGrantVisitorIdentityFieldsEmail Required = new(
        Values.Required
    );

    public static readonly GrantsUpdate200ResponseGrantVisitorIdentityFieldsEmail Optional = new(
        Values.Optional
    );

    public GrantsUpdate200ResponseGrantVisitorIdentityFieldsEmail(string value)
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
    public static GrantsUpdate200ResponseGrantVisitorIdentityFieldsEmail FromCustom(string value)
    {
        return new GrantsUpdate200ResponseGrantVisitorIdentityFieldsEmail(value);
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
        GrantsUpdate200ResponseGrantVisitorIdentityFieldsEmail value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsUpdate200ResponseGrantVisitorIdentityFieldsEmail value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsUpdate200ResponseGrantVisitorIdentityFieldsEmail value
    ) => value.Value;

    public static explicit operator GrantsUpdate200ResponseGrantVisitorIdentityFieldsEmail(
        string value
    ) => new(value);

    internal class GrantsUpdate200ResponseGrantVisitorIdentityFieldsEmailSerializer
        : JsonConverter<GrantsUpdate200ResponseGrantVisitorIdentityFieldsEmail>
    {
        public override GrantsUpdate200ResponseGrantVisitorIdentityFieldsEmail Read(
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
            return new GrantsUpdate200ResponseGrantVisitorIdentityFieldsEmail(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsUpdate200ResponseGrantVisitorIdentityFieldsEmail value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsUpdate200ResponseGrantVisitorIdentityFieldsEmail ReadAsPropertyName(
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
            return new GrantsUpdate200ResponseGrantVisitorIdentityFieldsEmail(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsUpdate200ResponseGrantVisitorIdentityFieldsEmail value,
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
