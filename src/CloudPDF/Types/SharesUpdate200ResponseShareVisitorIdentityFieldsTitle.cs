using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesUpdate200ResponseShareVisitorIdentityFieldsTitle.SharesUpdate200ResponseShareVisitorIdentityFieldsTitleSerializer)
)]
[Serializable]
public readonly record struct SharesUpdate200ResponseShareVisitorIdentityFieldsTitle : IStringEnum
{
    public static readonly SharesUpdate200ResponseShareVisitorIdentityFieldsTitle Required = new(
        Values.Required
    );

    public static readonly SharesUpdate200ResponseShareVisitorIdentityFieldsTitle Optional = new(
        Values.Optional
    );

    public SharesUpdate200ResponseShareVisitorIdentityFieldsTitle(string value)
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
    public static SharesUpdate200ResponseShareVisitorIdentityFieldsTitle FromCustom(string value)
    {
        return new SharesUpdate200ResponseShareVisitorIdentityFieldsTitle(value);
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
        SharesUpdate200ResponseShareVisitorIdentityFieldsTitle value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesUpdate200ResponseShareVisitorIdentityFieldsTitle value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SharesUpdate200ResponseShareVisitorIdentityFieldsTitle value
    ) => value.Value;

    public static explicit operator SharesUpdate200ResponseShareVisitorIdentityFieldsTitle(
        string value
    ) => new(value);

    internal class SharesUpdate200ResponseShareVisitorIdentityFieldsTitleSerializer
        : JsonConverter<SharesUpdate200ResponseShareVisitorIdentityFieldsTitle>
    {
        public override SharesUpdate200ResponseShareVisitorIdentityFieldsTitle Read(
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
            return new SharesUpdate200ResponseShareVisitorIdentityFieldsTitle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesUpdate200ResponseShareVisitorIdentityFieldsTitle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesUpdate200ResponseShareVisitorIdentityFieldsTitle ReadAsPropertyName(
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
            return new SharesUpdate200ResponseShareVisitorIdentityFieldsTitle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesUpdate200ResponseShareVisitorIdentityFieldsTitle value,
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
