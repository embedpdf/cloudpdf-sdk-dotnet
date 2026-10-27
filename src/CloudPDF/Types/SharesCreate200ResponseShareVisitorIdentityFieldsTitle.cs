using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesCreate200ResponseShareVisitorIdentityFieldsTitle.SharesCreate200ResponseShareVisitorIdentityFieldsTitleSerializer)
)]
[Serializable]
public readonly record struct SharesCreate200ResponseShareVisitorIdentityFieldsTitle : IStringEnum
{
    public static readonly SharesCreate200ResponseShareVisitorIdentityFieldsTitle Required = new(
        Values.Required
    );

    public static readonly SharesCreate200ResponseShareVisitorIdentityFieldsTitle Optional = new(
        Values.Optional
    );

    public SharesCreate200ResponseShareVisitorIdentityFieldsTitle(string value)
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
    public static SharesCreate200ResponseShareVisitorIdentityFieldsTitle FromCustom(string value)
    {
        return new SharesCreate200ResponseShareVisitorIdentityFieldsTitle(value);
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
        SharesCreate200ResponseShareVisitorIdentityFieldsTitle value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesCreate200ResponseShareVisitorIdentityFieldsTitle value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SharesCreate200ResponseShareVisitorIdentityFieldsTitle value
    ) => value.Value;

    public static explicit operator SharesCreate200ResponseShareVisitorIdentityFieldsTitle(
        string value
    ) => new(value);

    internal class SharesCreate200ResponseShareVisitorIdentityFieldsTitleSerializer
        : JsonConverter<SharesCreate200ResponseShareVisitorIdentityFieldsTitle>
    {
        public override SharesCreate200ResponseShareVisitorIdentityFieldsTitle Read(
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
            return new SharesCreate200ResponseShareVisitorIdentityFieldsTitle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesCreate200ResponseShareVisitorIdentityFieldsTitle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesCreate200ResponseShareVisitorIdentityFieldsTitle ReadAsPropertyName(
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
            return new SharesCreate200ResponseShareVisitorIdentityFieldsTitle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesCreate200ResponseShareVisitorIdentityFieldsTitle value,
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
