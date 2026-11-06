using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsGetResponseGrantVisitorIdentityFieldsTitle.GrantsGetResponseGrantVisitorIdentityFieldsTitleSerializer)
)]
[Serializable]
public readonly record struct GrantsGetResponseGrantVisitorIdentityFieldsTitle : IStringEnum
{
    public static readonly GrantsGetResponseGrantVisitorIdentityFieldsTitle Required = new(
        Values.Required
    );

    public static readonly GrantsGetResponseGrantVisitorIdentityFieldsTitle Optional = new(
        Values.Optional
    );

    public GrantsGetResponseGrantVisitorIdentityFieldsTitle(string value)
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
    public static GrantsGetResponseGrantVisitorIdentityFieldsTitle FromCustom(string value)
    {
        return new GrantsGetResponseGrantVisitorIdentityFieldsTitle(value);
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
        GrantsGetResponseGrantVisitorIdentityFieldsTitle value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsGetResponseGrantVisitorIdentityFieldsTitle value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsGetResponseGrantVisitorIdentityFieldsTitle value
    ) => value.Value;

    public static explicit operator GrantsGetResponseGrantVisitorIdentityFieldsTitle(
        string value
    ) => new(value);

    internal class GrantsGetResponseGrantVisitorIdentityFieldsTitleSerializer
        : JsonConverter<GrantsGetResponseGrantVisitorIdentityFieldsTitle>
    {
        public override GrantsGetResponseGrantVisitorIdentityFieldsTitle Read(
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
            return new GrantsGetResponseGrantVisitorIdentityFieldsTitle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsGetResponseGrantVisitorIdentityFieldsTitle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsGetResponseGrantVisitorIdentityFieldsTitle ReadAsPropertyName(
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
            return new GrantsGetResponseGrantVisitorIdentityFieldsTitle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsGetResponseGrantVisitorIdentityFieldsTitle value,
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
