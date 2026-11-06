using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsListResponseGrantsItemVisitorIdentityFieldsDisplayName.GrantsListResponseGrantsItemVisitorIdentityFieldsDisplayNameSerializer)
)]
[Serializable]
public readonly record struct GrantsListResponseGrantsItemVisitorIdentityFieldsDisplayName
    : IStringEnum
{
    public static readonly GrantsListResponseGrantsItemVisitorIdentityFieldsDisplayName Required =
        new(Values.Required);

    public static readonly GrantsListResponseGrantsItemVisitorIdentityFieldsDisplayName Optional =
        new(Values.Optional);

    public GrantsListResponseGrantsItemVisitorIdentityFieldsDisplayName(string value)
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
    public static GrantsListResponseGrantsItemVisitorIdentityFieldsDisplayName FromCustom(
        string value
    )
    {
        return new GrantsListResponseGrantsItemVisitorIdentityFieldsDisplayName(value);
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
        GrantsListResponseGrantsItemVisitorIdentityFieldsDisplayName value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsListResponseGrantsItemVisitorIdentityFieldsDisplayName value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsListResponseGrantsItemVisitorIdentityFieldsDisplayName value
    ) => value.Value;

    public static explicit operator GrantsListResponseGrantsItemVisitorIdentityFieldsDisplayName(
        string value
    ) => new(value);

    internal class GrantsListResponseGrantsItemVisitorIdentityFieldsDisplayNameSerializer
        : JsonConverter<GrantsListResponseGrantsItemVisitorIdentityFieldsDisplayName>
    {
        public override GrantsListResponseGrantsItemVisitorIdentityFieldsDisplayName Read(
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
            return new GrantsListResponseGrantsItemVisitorIdentityFieldsDisplayName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsListResponseGrantsItemVisitorIdentityFieldsDisplayName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsListResponseGrantsItemVisitorIdentityFieldsDisplayName ReadAsPropertyName(
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
            return new GrantsListResponseGrantsItemVisitorIdentityFieldsDisplayName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsListResponseGrantsItemVisitorIdentityFieldsDisplayName value,
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
