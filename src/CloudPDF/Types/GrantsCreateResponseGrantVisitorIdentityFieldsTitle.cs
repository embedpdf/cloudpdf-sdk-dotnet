using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsCreateResponseGrantVisitorIdentityFieldsTitle.GrantsCreateResponseGrantVisitorIdentityFieldsTitleSerializer)
)]
[Serializable]
public readonly record struct GrantsCreateResponseGrantVisitorIdentityFieldsTitle : IStringEnum
{
    public static readonly GrantsCreateResponseGrantVisitorIdentityFieldsTitle Required = new(
        Values.Required
    );

    public static readonly GrantsCreateResponseGrantVisitorIdentityFieldsTitle Optional = new(
        Values.Optional
    );

    public GrantsCreateResponseGrantVisitorIdentityFieldsTitle(string value)
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
    public static GrantsCreateResponseGrantVisitorIdentityFieldsTitle FromCustom(string value)
    {
        return new GrantsCreateResponseGrantVisitorIdentityFieldsTitle(value);
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
        GrantsCreateResponseGrantVisitorIdentityFieldsTitle value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsCreateResponseGrantVisitorIdentityFieldsTitle value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsCreateResponseGrantVisitorIdentityFieldsTitle value
    ) => value.Value;

    public static explicit operator GrantsCreateResponseGrantVisitorIdentityFieldsTitle(
        string value
    ) => new(value);

    internal class GrantsCreateResponseGrantVisitorIdentityFieldsTitleSerializer
        : JsonConverter<GrantsCreateResponseGrantVisitorIdentityFieldsTitle>
    {
        public override GrantsCreateResponseGrantVisitorIdentityFieldsTitle Read(
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
            return new GrantsCreateResponseGrantVisitorIdentityFieldsTitle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsCreateResponseGrantVisitorIdentityFieldsTitle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsCreateResponseGrantVisitorIdentityFieldsTitle ReadAsPropertyName(
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
            return new GrantsCreateResponseGrantVisitorIdentityFieldsTitle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsCreateResponseGrantVisitorIdentityFieldsTitle value,
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
