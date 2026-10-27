using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesList200ResponseSharesItemVisitorIdentityFieldsDisplayName.SharesList200ResponseSharesItemVisitorIdentityFieldsDisplayNameSerializer)
)]
[Serializable]
public readonly record struct SharesList200ResponseSharesItemVisitorIdentityFieldsDisplayName
    : IStringEnum
{
    public static readonly SharesList200ResponseSharesItemVisitorIdentityFieldsDisplayName Required =
        new(Values.Required);

    public static readonly SharesList200ResponseSharesItemVisitorIdentityFieldsDisplayName Optional =
        new(Values.Optional);

    public SharesList200ResponseSharesItemVisitorIdentityFieldsDisplayName(string value)
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
    public static SharesList200ResponseSharesItemVisitorIdentityFieldsDisplayName FromCustom(
        string value
    )
    {
        return new SharesList200ResponseSharesItemVisitorIdentityFieldsDisplayName(value);
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
        SharesList200ResponseSharesItemVisitorIdentityFieldsDisplayName value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesList200ResponseSharesItemVisitorIdentityFieldsDisplayName value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SharesList200ResponseSharesItemVisitorIdentityFieldsDisplayName value
    ) => value.Value;

    public static explicit operator SharesList200ResponseSharesItemVisitorIdentityFieldsDisplayName(
        string value
    ) => new(value);

    internal class SharesList200ResponseSharesItemVisitorIdentityFieldsDisplayNameSerializer
        : JsonConverter<SharesList200ResponseSharesItemVisitorIdentityFieldsDisplayName>
    {
        public override SharesList200ResponseSharesItemVisitorIdentityFieldsDisplayName Read(
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
            return new SharesList200ResponseSharesItemVisitorIdentityFieldsDisplayName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesList200ResponseSharesItemVisitorIdentityFieldsDisplayName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesList200ResponseSharesItemVisitorIdentityFieldsDisplayName ReadAsPropertyName(
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
            return new SharesList200ResponseSharesItemVisitorIdentityFieldsDisplayName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesList200ResponseSharesItemVisitorIdentityFieldsDisplayName value,
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
