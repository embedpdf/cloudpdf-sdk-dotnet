using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsGetResponseGrantVisitorIdentityFieldsEmail.GrantsGetResponseGrantVisitorIdentityFieldsEmailSerializer)
)]
[Serializable]
public readonly record struct GrantsGetResponseGrantVisitorIdentityFieldsEmail : IStringEnum
{
    public static readonly GrantsGetResponseGrantVisitorIdentityFieldsEmail Required = new(
        Values.Required
    );

    public static readonly GrantsGetResponseGrantVisitorIdentityFieldsEmail Optional = new(
        Values.Optional
    );

    public GrantsGetResponseGrantVisitorIdentityFieldsEmail(string value)
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
    public static GrantsGetResponseGrantVisitorIdentityFieldsEmail FromCustom(string value)
    {
        return new GrantsGetResponseGrantVisitorIdentityFieldsEmail(value);
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
        GrantsGetResponseGrantVisitorIdentityFieldsEmail value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsGetResponseGrantVisitorIdentityFieldsEmail value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsGetResponseGrantVisitorIdentityFieldsEmail value
    ) => value.Value;

    public static explicit operator GrantsGetResponseGrantVisitorIdentityFieldsEmail(
        string value
    ) => new(value);

    internal class GrantsGetResponseGrantVisitorIdentityFieldsEmailSerializer
        : JsonConverter<GrantsGetResponseGrantVisitorIdentityFieldsEmail>
    {
        public override GrantsGetResponseGrantVisitorIdentityFieldsEmail Read(
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
            return new GrantsGetResponseGrantVisitorIdentityFieldsEmail(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsGetResponseGrantVisitorIdentityFieldsEmail value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsGetResponseGrantVisitorIdentityFieldsEmail ReadAsPropertyName(
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
            return new GrantsGetResponseGrantVisitorIdentityFieldsEmail(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsGetResponseGrantVisitorIdentityFieldsEmail value,
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
