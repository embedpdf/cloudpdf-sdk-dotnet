using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesGet200ResponseShareVisitorIdentityFieldsDisplayName.SharesGet200ResponseShareVisitorIdentityFieldsDisplayNameSerializer)
)]
[Serializable]
public readonly record struct SharesGet200ResponseShareVisitorIdentityFieldsDisplayName
    : IStringEnum
{
    public static readonly SharesGet200ResponseShareVisitorIdentityFieldsDisplayName Required = new(
        Values.Required
    );

    public static readonly SharesGet200ResponseShareVisitorIdentityFieldsDisplayName Optional = new(
        Values.Optional
    );

    public SharesGet200ResponseShareVisitorIdentityFieldsDisplayName(string value)
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
    public static SharesGet200ResponseShareVisitorIdentityFieldsDisplayName FromCustom(string value)
    {
        return new SharesGet200ResponseShareVisitorIdentityFieldsDisplayName(value);
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
        SharesGet200ResponseShareVisitorIdentityFieldsDisplayName value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesGet200ResponseShareVisitorIdentityFieldsDisplayName value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SharesGet200ResponseShareVisitorIdentityFieldsDisplayName value
    ) => value.Value;

    public static explicit operator SharesGet200ResponseShareVisitorIdentityFieldsDisplayName(
        string value
    ) => new(value);

    internal class SharesGet200ResponseShareVisitorIdentityFieldsDisplayNameSerializer
        : JsonConverter<SharesGet200ResponseShareVisitorIdentityFieldsDisplayName>
    {
        public override SharesGet200ResponseShareVisitorIdentityFieldsDisplayName Read(
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
            return new SharesGet200ResponseShareVisitorIdentityFieldsDisplayName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesGet200ResponseShareVisitorIdentityFieldsDisplayName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesGet200ResponseShareVisitorIdentityFieldsDisplayName ReadAsPropertyName(
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
            return new SharesGet200ResponseShareVisitorIdentityFieldsDisplayName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesGet200ResponseShareVisitorIdentityFieldsDisplayName value,
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
