using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesCreate200ResponseShareVisitorIdentityFieldsDisplayName.SharesCreate200ResponseShareVisitorIdentityFieldsDisplayNameSerializer)
)]
[Serializable]
public readonly record struct SharesCreate200ResponseShareVisitorIdentityFieldsDisplayName
    : IStringEnum
{
    public static readonly SharesCreate200ResponseShareVisitorIdentityFieldsDisplayName Required =
        new(Values.Required);

    public static readonly SharesCreate200ResponseShareVisitorIdentityFieldsDisplayName Optional =
        new(Values.Optional);

    public SharesCreate200ResponseShareVisitorIdentityFieldsDisplayName(string value)
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
    public static SharesCreate200ResponseShareVisitorIdentityFieldsDisplayName FromCustom(
        string value
    )
    {
        return new SharesCreate200ResponseShareVisitorIdentityFieldsDisplayName(value);
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
        SharesCreate200ResponseShareVisitorIdentityFieldsDisplayName value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesCreate200ResponseShareVisitorIdentityFieldsDisplayName value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SharesCreate200ResponseShareVisitorIdentityFieldsDisplayName value
    ) => value.Value;

    public static explicit operator SharesCreate200ResponseShareVisitorIdentityFieldsDisplayName(
        string value
    ) => new(value);

    internal class SharesCreate200ResponseShareVisitorIdentityFieldsDisplayNameSerializer
        : JsonConverter<SharesCreate200ResponseShareVisitorIdentityFieldsDisplayName>
    {
        public override SharesCreate200ResponseShareVisitorIdentityFieldsDisplayName Read(
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
            return new SharesCreate200ResponseShareVisitorIdentityFieldsDisplayName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesCreate200ResponseShareVisitorIdentityFieldsDisplayName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesCreate200ResponseShareVisitorIdentityFieldsDisplayName ReadAsPropertyName(
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
            return new SharesCreate200ResponseShareVisitorIdentityFieldsDisplayName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesCreate200ResponseShareVisitorIdentityFieldsDisplayName value,
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
