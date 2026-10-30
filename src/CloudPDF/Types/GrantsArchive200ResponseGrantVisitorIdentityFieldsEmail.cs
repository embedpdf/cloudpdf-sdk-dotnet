using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsArchive200ResponseGrantVisitorIdentityFieldsEmail.GrantsArchive200ResponseGrantVisitorIdentityFieldsEmailSerializer)
)]
[Serializable]
public readonly record struct GrantsArchive200ResponseGrantVisitorIdentityFieldsEmail : IStringEnum
{
    public static readonly GrantsArchive200ResponseGrantVisitorIdentityFieldsEmail Required = new(
        Values.Required
    );

    public static readonly GrantsArchive200ResponseGrantVisitorIdentityFieldsEmail Optional = new(
        Values.Optional
    );

    public GrantsArchive200ResponseGrantVisitorIdentityFieldsEmail(string value)
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
    public static GrantsArchive200ResponseGrantVisitorIdentityFieldsEmail FromCustom(string value)
    {
        return new GrantsArchive200ResponseGrantVisitorIdentityFieldsEmail(value);
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
        GrantsArchive200ResponseGrantVisitorIdentityFieldsEmail value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsArchive200ResponseGrantVisitorIdentityFieldsEmail value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsArchive200ResponseGrantVisitorIdentityFieldsEmail value
    ) => value.Value;

    public static explicit operator GrantsArchive200ResponseGrantVisitorIdentityFieldsEmail(
        string value
    ) => new(value);

    internal class GrantsArchive200ResponseGrantVisitorIdentityFieldsEmailSerializer
        : JsonConverter<GrantsArchive200ResponseGrantVisitorIdentityFieldsEmail>
    {
        public override GrantsArchive200ResponseGrantVisitorIdentityFieldsEmail Read(
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
            return new GrantsArchive200ResponseGrantVisitorIdentityFieldsEmail(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsArchive200ResponseGrantVisitorIdentityFieldsEmail value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsArchive200ResponseGrantVisitorIdentityFieldsEmail ReadAsPropertyName(
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
            return new GrantsArchive200ResponseGrantVisitorIdentityFieldsEmail(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsArchive200ResponseGrantVisitorIdentityFieldsEmail value,
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
