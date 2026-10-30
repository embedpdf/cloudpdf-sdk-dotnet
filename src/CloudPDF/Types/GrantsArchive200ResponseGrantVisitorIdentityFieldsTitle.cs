using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsArchive200ResponseGrantVisitorIdentityFieldsTitle.GrantsArchive200ResponseGrantVisitorIdentityFieldsTitleSerializer)
)]
[Serializable]
public readonly record struct GrantsArchive200ResponseGrantVisitorIdentityFieldsTitle : IStringEnum
{
    public static readonly GrantsArchive200ResponseGrantVisitorIdentityFieldsTitle Required = new(
        Values.Required
    );

    public static readonly GrantsArchive200ResponseGrantVisitorIdentityFieldsTitle Optional = new(
        Values.Optional
    );

    public GrantsArchive200ResponseGrantVisitorIdentityFieldsTitle(string value)
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
    public static GrantsArchive200ResponseGrantVisitorIdentityFieldsTitle FromCustom(string value)
    {
        return new GrantsArchive200ResponseGrantVisitorIdentityFieldsTitle(value);
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
        GrantsArchive200ResponseGrantVisitorIdentityFieldsTitle value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsArchive200ResponseGrantVisitorIdentityFieldsTitle value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsArchive200ResponseGrantVisitorIdentityFieldsTitle value
    ) => value.Value;

    public static explicit operator GrantsArchive200ResponseGrantVisitorIdentityFieldsTitle(
        string value
    ) => new(value);

    internal class GrantsArchive200ResponseGrantVisitorIdentityFieldsTitleSerializer
        : JsonConverter<GrantsArchive200ResponseGrantVisitorIdentityFieldsTitle>
    {
        public override GrantsArchive200ResponseGrantVisitorIdentityFieldsTitle Read(
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
            return new GrantsArchive200ResponseGrantVisitorIdentityFieldsTitle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsArchive200ResponseGrantVisitorIdentityFieldsTitle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsArchive200ResponseGrantVisitorIdentityFieldsTitle ReadAsPropertyName(
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
            return new GrantsArchive200ResponseGrantVisitorIdentityFieldsTitle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsArchive200ResponseGrantVisitorIdentityFieldsTitle value,
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
