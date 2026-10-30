using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsArchive200ResponseGrantVisitorIdentityFieldsDisplayName.GrantsArchive200ResponseGrantVisitorIdentityFieldsDisplayNameSerializer)
)]
[Serializable]
public readonly record struct GrantsArchive200ResponseGrantVisitorIdentityFieldsDisplayName
    : IStringEnum
{
    public static readonly GrantsArchive200ResponseGrantVisitorIdentityFieldsDisplayName Required =
        new(Values.Required);

    public static readonly GrantsArchive200ResponseGrantVisitorIdentityFieldsDisplayName Optional =
        new(Values.Optional);

    public GrantsArchive200ResponseGrantVisitorIdentityFieldsDisplayName(string value)
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
    public static GrantsArchive200ResponseGrantVisitorIdentityFieldsDisplayName FromCustom(
        string value
    )
    {
        return new GrantsArchive200ResponseGrantVisitorIdentityFieldsDisplayName(value);
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
        GrantsArchive200ResponseGrantVisitorIdentityFieldsDisplayName value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsArchive200ResponseGrantVisitorIdentityFieldsDisplayName value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsArchive200ResponseGrantVisitorIdentityFieldsDisplayName value
    ) => value.Value;

    public static explicit operator GrantsArchive200ResponseGrantVisitorIdentityFieldsDisplayName(
        string value
    ) => new(value);

    internal class GrantsArchive200ResponseGrantVisitorIdentityFieldsDisplayNameSerializer
        : JsonConverter<GrantsArchive200ResponseGrantVisitorIdentityFieldsDisplayName>
    {
        public override GrantsArchive200ResponseGrantVisitorIdentityFieldsDisplayName Read(
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
            return new GrantsArchive200ResponseGrantVisitorIdentityFieldsDisplayName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsArchive200ResponseGrantVisitorIdentityFieldsDisplayName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsArchive200ResponseGrantVisitorIdentityFieldsDisplayName ReadAsPropertyName(
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
            return new GrantsArchive200ResponseGrantVisitorIdentityFieldsDisplayName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsArchive200ResponseGrantVisitorIdentityFieldsDisplayName value,
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
