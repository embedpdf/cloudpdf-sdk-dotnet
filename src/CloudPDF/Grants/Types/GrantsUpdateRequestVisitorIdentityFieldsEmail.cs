using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsUpdateRequestVisitorIdentityFieldsEmail.GrantsUpdateRequestVisitorIdentityFieldsEmailSerializer)
)]
[Serializable]
public readonly record struct GrantsUpdateRequestVisitorIdentityFieldsEmail : IStringEnum
{
    public static readonly GrantsUpdateRequestVisitorIdentityFieldsEmail Required = new(
        Values.Required
    );

    public static readonly GrantsUpdateRequestVisitorIdentityFieldsEmail Optional = new(
        Values.Optional
    );

    public GrantsUpdateRequestVisitorIdentityFieldsEmail(string value)
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
    public static GrantsUpdateRequestVisitorIdentityFieldsEmail FromCustom(string value)
    {
        return new GrantsUpdateRequestVisitorIdentityFieldsEmail(value);
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
        GrantsUpdateRequestVisitorIdentityFieldsEmail value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsUpdateRequestVisitorIdentityFieldsEmail value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GrantsUpdateRequestVisitorIdentityFieldsEmail value) =>
        value.Value;

    public static explicit operator GrantsUpdateRequestVisitorIdentityFieldsEmail(string value) =>
        new(value);

    internal class GrantsUpdateRequestVisitorIdentityFieldsEmailSerializer
        : JsonConverter<GrantsUpdateRequestVisitorIdentityFieldsEmail>
    {
        public override GrantsUpdateRequestVisitorIdentityFieldsEmail Read(
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
            return new GrantsUpdateRequestVisitorIdentityFieldsEmail(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsUpdateRequestVisitorIdentityFieldsEmail value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsUpdateRequestVisitorIdentityFieldsEmail ReadAsPropertyName(
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
            return new GrantsUpdateRequestVisitorIdentityFieldsEmail(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsUpdateRequestVisitorIdentityFieldsEmail value,
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
