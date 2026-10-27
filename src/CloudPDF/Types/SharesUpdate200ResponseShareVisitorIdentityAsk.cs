using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesUpdate200ResponseShareVisitorIdentityAsk.SharesUpdate200ResponseShareVisitorIdentityAskSerializer)
)]
[Serializable]
public readonly record struct SharesUpdate200ResponseShareVisitorIdentityAsk : IStringEnum
{
    public static readonly SharesUpdate200ResponseShareVisitorIdentityAsk OnOpen = new(
        Values.OnOpen
    );

    public static readonly SharesUpdate200ResponseShareVisitorIdentityAsk BeforeFirstChange = new(
        Values.BeforeFirstChange
    );

    public SharesUpdate200ResponseShareVisitorIdentityAsk(string value)
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
    public static SharesUpdate200ResponseShareVisitorIdentityAsk FromCustom(string value)
    {
        return new SharesUpdate200ResponseShareVisitorIdentityAsk(value);
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
        SharesUpdate200ResponseShareVisitorIdentityAsk value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesUpdate200ResponseShareVisitorIdentityAsk value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SharesUpdate200ResponseShareVisitorIdentityAsk value) =>
        value.Value;

    public static explicit operator SharesUpdate200ResponseShareVisitorIdentityAsk(string value) =>
        new(value);

    internal class SharesUpdate200ResponseShareVisitorIdentityAskSerializer
        : JsonConverter<SharesUpdate200ResponseShareVisitorIdentityAsk>
    {
        public override SharesUpdate200ResponseShareVisitorIdentityAsk Read(
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
            return new SharesUpdate200ResponseShareVisitorIdentityAsk(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesUpdate200ResponseShareVisitorIdentityAsk value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesUpdate200ResponseShareVisitorIdentityAsk ReadAsPropertyName(
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
            return new SharesUpdate200ResponseShareVisitorIdentityAsk(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesUpdate200ResponseShareVisitorIdentityAsk value,
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
