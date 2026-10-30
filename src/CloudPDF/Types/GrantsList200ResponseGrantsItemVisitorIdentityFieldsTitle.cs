using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsList200ResponseGrantsItemVisitorIdentityFieldsTitle.GrantsList200ResponseGrantsItemVisitorIdentityFieldsTitleSerializer)
)]
[Serializable]
public readonly record struct GrantsList200ResponseGrantsItemVisitorIdentityFieldsTitle
    : IStringEnum
{
    public static readonly GrantsList200ResponseGrantsItemVisitorIdentityFieldsTitle Required = new(
        Values.Required
    );

    public static readonly GrantsList200ResponseGrantsItemVisitorIdentityFieldsTitle Optional = new(
        Values.Optional
    );

    public GrantsList200ResponseGrantsItemVisitorIdentityFieldsTitle(string value)
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
    public static GrantsList200ResponseGrantsItemVisitorIdentityFieldsTitle FromCustom(string value)
    {
        return new GrantsList200ResponseGrantsItemVisitorIdentityFieldsTitle(value);
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
        GrantsList200ResponseGrantsItemVisitorIdentityFieldsTitle value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsList200ResponseGrantsItemVisitorIdentityFieldsTitle value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsList200ResponseGrantsItemVisitorIdentityFieldsTitle value
    ) => value.Value;

    public static explicit operator GrantsList200ResponseGrantsItemVisitorIdentityFieldsTitle(
        string value
    ) => new(value);

    internal class GrantsList200ResponseGrantsItemVisitorIdentityFieldsTitleSerializer
        : JsonConverter<GrantsList200ResponseGrantsItemVisitorIdentityFieldsTitle>
    {
        public override GrantsList200ResponseGrantsItemVisitorIdentityFieldsTitle Read(
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
            return new GrantsList200ResponseGrantsItemVisitorIdentityFieldsTitle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsList200ResponseGrantsItemVisitorIdentityFieldsTitle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsList200ResponseGrantsItemVisitorIdentityFieldsTitle ReadAsPropertyName(
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
            return new GrantsList200ResponseGrantsItemVisitorIdentityFieldsTitle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsList200ResponseGrantsItemVisitorIdentityFieldsTitle value,
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
