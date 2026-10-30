using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsList200ResponseGrantsItemVisitorIdentityFieldsDisplayName.GrantsList200ResponseGrantsItemVisitorIdentityFieldsDisplayNameSerializer)
)]
[Serializable]
public readonly record struct GrantsList200ResponseGrantsItemVisitorIdentityFieldsDisplayName
    : IStringEnum
{
    public static readonly GrantsList200ResponseGrantsItemVisitorIdentityFieldsDisplayName Required =
        new(Values.Required);

    public static readonly GrantsList200ResponseGrantsItemVisitorIdentityFieldsDisplayName Optional =
        new(Values.Optional);

    public GrantsList200ResponseGrantsItemVisitorIdentityFieldsDisplayName(string value)
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
    public static GrantsList200ResponseGrantsItemVisitorIdentityFieldsDisplayName FromCustom(
        string value
    )
    {
        return new GrantsList200ResponseGrantsItemVisitorIdentityFieldsDisplayName(value);
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
        GrantsList200ResponseGrantsItemVisitorIdentityFieldsDisplayName value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsList200ResponseGrantsItemVisitorIdentityFieldsDisplayName value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsList200ResponseGrantsItemVisitorIdentityFieldsDisplayName value
    ) => value.Value;

    public static explicit operator GrantsList200ResponseGrantsItemVisitorIdentityFieldsDisplayName(
        string value
    ) => new(value);

    internal class GrantsList200ResponseGrantsItemVisitorIdentityFieldsDisplayNameSerializer
        : JsonConverter<GrantsList200ResponseGrantsItemVisitorIdentityFieldsDisplayName>
    {
        public override GrantsList200ResponseGrantsItemVisitorIdentityFieldsDisplayName Read(
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
            return new GrantsList200ResponseGrantsItemVisitorIdentityFieldsDisplayName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsList200ResponseGrantsItemVisitorIdentityFieldsDisplayName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsList200ResponseGrantsItemVisitorIdentityFieldsDisplayName ReadAsPropertyName(
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
            return new GrantsList200ResponseGrantsItemVisitorIdentityFieldsDisplayName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsList200ResponseGrantsItemVisitorIdentityFieldsDisplayName value,
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
