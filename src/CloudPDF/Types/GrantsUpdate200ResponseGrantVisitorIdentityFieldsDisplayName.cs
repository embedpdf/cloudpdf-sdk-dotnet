using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsUpdate200ResponseGrantVisitorIdentityFieldsDisplayName.GrantsUpdate200ResponseGrantVisitorIdentityFieldsDisplayNameSerializer)
)]
[Serializable]
public readonly record struct GrantsUpdate200ResponseGrantVisitorIdentityFieldsDisplayName
    : IStringEnum
{
    public static readonly GrantsUpdate200ResponseGrantVisitorIdentityFieldsDisplayName Required =
        new(Values.Required);

    public static readonly GrantsUpdate200ResponseGrantVisitorIdentityFieldsDisplayName Optional =
        new(Values.Optional);

    public GrantsUpdate200ResponseGrantVisitorIdentityFieldsDisplayName(string value)
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
    public static GrantsUpdate200ResponseGrantVisitorIdentityFieldsDisplayName FromCustom(
        string value
    )
    {
        return new GrantsUpdate200ResponseGrantVisitorIdentityFieldsDisplayName(value);
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
        GrantsUpdate200ResponseGrantVisitorIdentityFieldsDisplayName value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsUpdate200ResponseGrantVisitorIdentityFieldsDisplayName value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsUpdate200ResponseGrantVisitorIdentityFieldsDisplayName value
    ) => value.Value;

    public static explicit operator GrantsUpdate200ResponseGrantVisitorIdentityFieldsDisplayName(
        string value
    ) => new(value);

    internal class GrantsUpdate200ResponseGrantVisitorIdentityFieldsDisplayNameSerializer
        : JsonConverter<GrantsUpdate200ResponseGrantVisitorIdentityFieldsDisplayName>
    {
        public override GrantsUpdate200ResponseGrantVisitorIdentityFieldsDisplayName Read(
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
            return new GrantsUpdate200ResponseGrantVisitorIdentityFieldsDisplayName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsUpdate200ResponseGrantVisitorIdentityFieldsDisplayName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsUpdate200ResponseGrantVisitorIdentityFieldsDisplayName ReadAsPropertyName(
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
            return new GrantsUpdate200ResponseGrantVisitorIdentityFieldsDisplayName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsUpdate200ResponseGrantVisitorIdentityFieldsDisplayName value,
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
