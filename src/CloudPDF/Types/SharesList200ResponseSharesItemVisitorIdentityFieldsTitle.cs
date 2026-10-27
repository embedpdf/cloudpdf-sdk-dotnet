using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesList200ResponseSharesItemVisitorIdentityFieldsTitle.SharesList200ResponseSharesItemVisitorIdentityFieldsTitleSerializer)
)]
[Serializable]
public readonly record struct SharesList200ResponseSharesItemVisitorIdentityFieldsTitle
    : IStringEnum
{
    public static readonly SharesList200ResponseSharesItemVisitorIdentityFieldsTitle Required = new(
        Values.Required
    );

    public static readonly SharesList200ResponseSharesItemVisitorIdentityFieldsTitle Optional = new(
        Values.Optional
    );

    public SharesList200ResponseSharesItemVisitorIdentityFieldsTitle(string value)
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
    public static SharesList200ResponseSharesItemVisitorIdentityFieldsTitle FromCustom(string value)
    {
        return new SharesList200ResponseSharesItemVisitorIdentityFieldsTitle(value);
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
        SharesList200ResponseSharesItemVisitorIdentityFieldsTitle value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesList200ResponseSharesItemVisitorIdentityFieldsTitle value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SharesList200ResponseSharesItemVisitorIdentityFieldsTitle value
    ) => value.Value;

    public static explicit operator SharesList200ResponseSharesItemVisitorIdentityFieldsTitle(
        string value
    ) => new(value);

    internal class SharesList200ResponseSharesItemVisitorIdentityFieldsTitleSerializer
        : JsonConverter<SharesList200ResponseSharesItemVisitorIdentityFieldsTitle>
    {
        public override SharesList200ResponseSharesItemVisitorIdentityFieldsTitle Read(
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
            return new SharesList200ResponseSharesItemVisitorIdentityFieldsTitle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesList200ResponseSharesItemVisitorIdentityFieldsTitle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesList200ResponseSharesItemVisitorIdentityFieldsTitle ReadAsPropertyName(
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
            return new SharesList200ResponseSharesItemVisitorIdentityFieldsTitle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesList200ResponseSharesItemVisitorIdentityFieldsTitle value,
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
