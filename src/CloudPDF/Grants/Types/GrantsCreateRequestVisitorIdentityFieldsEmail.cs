using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsCreateRequestVisitorIdentityFieldsEmail.GrantsCreateRequestVisitorIdentityFieldsEmailSerializer)
)]
[Serializable]
public readonly record struct GrantsCreateRequestVisitorIdentityFieldsEmail : IStringEnum
{
    public static readonly GrantsCreateRequestVisitorIdentityFieldsEmail Required = new(
        Values.Required
    );

    public static readonly GrantsCreateRequestVisitorIdentityFieldsEmail Optional = new(
        Values.Optional
    );

    public GrantsCreateRequestVisitorIdentityFieldsEmail(string value)
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
    public static GrantsCreateRequestVisitorIdentityFieldsEmail FromCustom(string value)
    {
        return new GrantsCreateRequestVisitorIdentityFieldsEmail(value);
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
        GrantsCreateRequestVisitorIdentityFieldsEmail value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsCreateRequestVisitorIdentityFieldsEmail value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GrantsCreateRequestVisitorIdentityFieldsEmail value) =>
        value.Value;

    public static explicit operator GrantsCreateRequestVisitorIdentityFieldsEmail(string value) =>
        new(value);

    internal class GrantsCreateRequestVisitorIdentityFieldsEmailSerializer
        : JsonConverter<GrantsCreateRequestVisitorIdentityFieldsEmail>
    {
        public override GrantsCreateRequestVisitorIdentityFieldsEmail Read(
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
            return new GrantsCreateRequestVisitorIdentityFieldsEmail(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsCreateRequestVisitorIdentityFieldsEmail value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsCreateRequestVisitorIdentityFieldsEmail ReadAsPropertyName(
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
            return new GrantsCreateRequestVisitorIdentityFieldsEmail(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsCreateRequestVisitorIdentityFieldsEmail value,
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
