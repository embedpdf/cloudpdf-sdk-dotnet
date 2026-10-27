using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesCreate200ResponseShareVisitorIdentityAsk.SharesCreate200ResponseShareVisitorIdentityAskSerializer)
)]
[Serializable]
public readonly record struct SharesCreate200ResponseShareVisitorIdentityAsk : IStringEnum
{
    public static readonly SharesCreate200ResponseShareVisitorIdentityAsk OnOpen = new(
        Values.OnOpen
    );

    public static readonly SharesCreate200ResponseShareVisitorIdentityAsk BeforeFirstChange = new(
        Values.BeforeFirstChange
    );

    public SharesCreate200ResponseShareVisitorIdentityAsk(string value)
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
    public static SharesCreate200ResponseShareVisitorIdentityAsk FromCustom(string value)
    {
        return new SharesCreate200ResponseShareVisitorIdentityAsk(value);
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
        SharesCreate200ResponseShareVisitorIdentityAsk value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesCreate200ResponseShareVisitorIdentityAsk value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SharesCreate200ResponseShareVisitorIdentityAsk value) =>
        value.Value;

    public static explicit operator SharesCreate200ResponseShareVisitorIdentityAsk(string value) =>
        new(value);

    internal class SharesCreate200ResponseShareVisitorIdentityAskSerializer
        : JsonConverter<SharesCreate200ResponseShareVisitorIdentityAsk>
    {
        public override SharesCreate200ResponseShareVisitorIdentityAsk Read(
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
            return new SharesCreate200ResponseShareVisitorIdentityAsk(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesCreate200ResponseShareVisitorIdentityAsk value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesCreate200ResponseShareVisitorIdentityAsk ReadAsPropertyName(
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
            return new SharesCreate200ResponseShareVisitorIdentityAsk(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesCreate200ResponseShareVisitorIdentityAsk value,
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
        public const string OnOpen = "on-open";

        public const string BeforeFirstChange = "before-first-change";
    }
}
