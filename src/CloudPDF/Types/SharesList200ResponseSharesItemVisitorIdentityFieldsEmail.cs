using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesList200ResponseSharesItemVisitorIdentityFieldsEmail.SharesList200ResponseSharesItemVisitorIdentityFieldsEmailSerializer)
)]
[Serializable]
public readonly record struct SharesList200ResponseSharesItemVisitorIdentityFieldsEmail
    : IStringEnum
{
    public static readonly SharesList200ResponseSharesItemVisitorIdentityFieldsEmail Required = new(
        Values.Required
    );

    public static readonly SharesList200ResponseSharesItemVisitorIdentityFieldsEmail Optional = new(
        Values.Optional
    );

    public SharesList200ResponseSharesItemVisitorIdentityFieldsEmail(string value)
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
    public static SharesList200ResponseSharesItemVisitorIdentityFieldsEmail FromCustom(string value)
    {
        return new SharesList200ResponseSharesItemVisitorIdentityFieldsEmail(value);
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
        SharesList200ResponseSharesItemVisitorIdentityFieldsEmail value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesList200ResponseSharesItemVisitorIdentityFieldsEmail value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SharesList200ResponseSharesItemVisitorIdentityFieldsEmail value
    ) => value.Value;

    public static explicit operator SharesList200ResponseSharesItemVisitorIdentityFieldsEmail(
        string value
    ) => new(value);

    internal class SharesList200ResponseSharesItemVisitorIdentityFieldsEmailSerializer
        : JsonConverter<SharesList200ResponseSharesItemVisitorIdentityFieldsEmail>
    {
        public override SharesList200ResponseSharesItemVisitorIdentityFieldsEmail Read(
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
            return new SharesList200ResponseSharesItemVisitorIdentityFieldsEmail(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesList200ResponseSharesItemVisitorIdentityFieldsEmail value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesList200ResponseSharesItemVisitorIdentityFieldsEmail ReadAsPropertyName(
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
            return new SharesList200ResponseSharesItemVisitorIdentityFieldsEmail(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesList200ResponseSharesItemVisitorIdentityFieldsEmail value,
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
