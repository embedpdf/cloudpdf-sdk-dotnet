using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(GrantsListResponseGrantsItemVisitorIdentityFieldsTitle.GrantsListResponseGrantsItemVisitorIdentityFieldsTitleSerializer)
)]
[Serializable]
public readonly record struct GrantsListResponseGrantsItemVisitorIdentityFieldsTitle : IStringEnum
{
    public static readonly GrantsListResponseGrantsItemVisitorIdentityFieldsTitle Required = new(
        Values.Required
    );

    public static readonly GrantsListResponseGrantsItemVisitorIdentityFieldsTitle Optional = new(
        Values.Optional
    );

    public GrantsListResponseGrantsItemVisitorIdentityFieldsTitle(string value)
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
    public static GrantsListResponseGrantsItemVisitorIdentityFieldsTitle FromCustom(string value)
    {
        return new GrantsListResponseGrantsItemVisitorIdentityFieldsTitle(value);
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
        GrantsListResponseGrantsItemVisitorIdentityFieldsTitle value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GrantsListResponseGrantsItemVisitorIdentityFieldsTitle value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        GrantsListResponseGrantsItemVisitorIdentityFieldsTitle value
    ) => value.Value;

    public static explicit operator GrantsListResponseGrantsItemVisitorIdentityFieldsTitle(
        string value
    ) => new(value);

    internal class GrantsListResponseGrantsItemVisitorIdentityFieldsTitleSerializer
        : JsonConverter<GrantsListResponseGrantsItemVisitorIdentityFieldsTitle>
    {
        public override GrantsListResponseGrantsItemVisitorIdentityFieldsTitle Read(
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
            return new GrantsListResponseGrantsItemVisitorIdentityFieldsTitle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            GrantsListResponseGrantsItemVisitorIdentityFieldsTitle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override GrantsListResponseGrantsItemVisitorIdentityFieldsTitle ReadAsPropertyName(
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
            return new GrantsListResponseGrantsItemVisitorIdentityFieldsTitle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            GrantsListResponseGrantsItemVisitorIdentityFieldsTitle value,
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
