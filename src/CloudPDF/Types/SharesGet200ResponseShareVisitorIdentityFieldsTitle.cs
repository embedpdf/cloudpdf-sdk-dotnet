using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesGet200ResponseShareVisitorIdentityFieldsTitle.SharesGet200ResponseShareVisitorIdentityFieldsTitleSerializer)
)]
[Serializable]
public readonly record struct SharesGet200ResponseShareVisitorIdentityFieldsTitle : IStringEnum
{
    public static readonly SharesGet200ResponseShareVisitorIdentityFieldsTitle Required = new(
        Values.Required
    );

    public static readonly SharesGet200ResponseShareVisitorIdentityFieldsTitle Optional = new(
        Values.Optional
    );

    public SharesGet200ResponseShareVisitorIdentityFieldsTitle(string value)
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
    public static SharesGet200ResponseShareVisitorIdentityFieldsTitle FromCustom(string value)
    {
        return new SharesGet200ResponseShareVisitorIdentityFieldsTitle(value);
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
        SharesGet200ResponseShareVisitorIdentityFieldsTitle value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesGet200ResponseShareVisitorIdentityFieldsTitle value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SharesGet200ResponseShareVisitorIdentityFieldsTitle value
    ) => value.Value;

    public static explicit operator SharesGet200ResponseShareVisitorIdentityFieldsTitle(
        string value
    ) => new(value);

    internal class SharesGet200ResponseShareVisitorIdentityFieldsTitleSerializer
        : JsonConverter<SharesGet200ResponseShareVisitorIdentityFieldsTitle>
    {
        public override SharesGet200ResponseShareVisitorIdentityFieldsTitle Read(
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
            return new SharesGet200ResponseShareVisitorIdentityFieldsTitle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesGet200ResponseShareVisitorIdentityFieldsTitle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesGet200ResponseShareVisitorIdentityFieldsTitle ReadAsPropertyName(
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
            return new SharesGet200ResponseShareVisitorIdentityFieldsTitle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesGet200ResponseShareVisitorIdentityFieldsTitle value,
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
