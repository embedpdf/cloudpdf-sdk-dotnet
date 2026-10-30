using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsGet200ResponseGrantVisitorIdentityFieldsEmail.GrantsGet200ResponseGrantVisitorIdentityFieldsEmailSerializer)
)]
[Serializable]
public readonly record struct GrantsGet200ResponseGrantVisitorIdentityFieldsEmail : IStringEnum
{
    public static readonly GrantsGet200ResponseGrantVisitorIdentityFieldsEmail Required = new(
        Values.Required
    );

    public static readonly GrantsGet200ResponseGrantVisitorIdentityFieldsEmail Optional = new(
        Values.Optional
    );

    public GrantsGet200ResponseGrantVisitorIdentityFieldsEmail(string value)
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
    public static GrantsGet200ResponseGrantVisitorIdentityFieldsEmail FromCustom(string value)
    {
        return new GrantsGet200ResponseGrantVisitorIdentityFieldsEmail(value);
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
        GrantsGet200ResponseGrantVisitorIdentityFieldsEmail value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsGet200ResponseGrantVisitorIdentityFieldsEmail value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsGet200ResponseGrantVisitorIdentityFieldsEmail value
    ) => value.Value;

    public static explicit operator GrantsGet200ResponseGrantVisitorIdentityFieldsEmail(
        string value
    ) => new(value);

    internal class GrantsGet200ResponseGrantVisitorIdentityFieldsEmailSerializer
        : JsonConverter<GrantsGet200ResponseGrantVisitorIdentityFieldsEmail>
    {
        public override GrantsGet200ResponseGrantVisitorIdentityFieldsEmail Read(
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
            return new GrantsGet200ResponseGrantVisitorIdentityFieldsEmail(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsGet200ResponseGrantVisitorIdentityFieldsEmail value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsGet200ResponseGrantVisitorIdentityFieldsEmail ReadAsPropertyName(
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
            return new GrantsGet200ResponseGrantVisitorIdentityFieldsEmail(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsGet200ResponseGrantVisitorIdentityFieldsEmail value,
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
