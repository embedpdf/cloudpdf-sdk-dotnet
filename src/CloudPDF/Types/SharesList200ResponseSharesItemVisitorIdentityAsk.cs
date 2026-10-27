using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesList200ResponseSharesItemVisitorIdentityAsk.SharesList200ResponseSharesItemVisitorIdentityAskSerializer)
)]
[Serializable]
public readonly record struct SharesList200ResponseSharesItemVisitorIdentityAsk : IStringEnum
{
    public static readonly SharesList200ResponseSharesItemVisitorIdentityAsk OnOpen = new(
        Values.OnOpen
    );

    public static readonly SharesList200ResponseSharesItemVisitorIdentityAsk BeforeFirstChange =
        new(Values.BeforeFirstChange);

    public SharesList200ResponseSharesItemVisitorIdentityAsk(string value)
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
    public static SharesList200ResponseSharesItemVisitorIdentityAsk FromCustom(string value)
    {
        return new SharesList200ResponseSharesItemVisitorIdentityAsk(value);
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
        SharesList200ResponseSharesItemVisitorIdentityAsk value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesList200ResponseSharesItemVisitorIdentityAsk value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SharesList200ResponseSharesItemVisitorIdentityAsk value
    ) => value.Value;

    public static explicit operator SharesList200ResponseSharesItemVisitorIdentityAsk(
        string value
    ) => new(value);

    internal class SharesList200ResponseSharesItemVisitorIdentityAskSerializer
        : JsonConverter<SharesList200ResponseSharesItemVisitorIdentityAsk>
    {
        public override SharesList200ResponseSharesItemVisitorIdentityAsk Read(
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
            return new SharesList200ResponseSharesItemVisitorIdentityAsk(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesList200ResponseSharesItemVisitorIdentityAsk value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesList200ResponseSharesItemVisitorIdentityAsk ReadAsPropertyName(
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
            return new SharesList200ResponseSharesItemVisitorIdentityAsk(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesList200ResponseSharesItemVisitorIdentityAsk value,
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
