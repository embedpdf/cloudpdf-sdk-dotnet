using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesArchive200ResponseShareVisitorIdentityAsk.SharesArchive200ResponseShareVisitorIdentityAskSerializer)
)]
[Serializable]
public readonly record struct SharesArchive200ResponseShareVisitorIdentityAsk : IStringEnum
{
    public static readonly SharesArchive200ResponseShareVisitorIdentityAsk OnOpen = new(
        Values.OnOpen
    );

    public static readonly SharesArchive200ResponseShareVisitorIdentityAsk BeforeFirstChange = new(
        Values.BeforeFirstChange
    );

    public SharesArchive200ResponseShareVisitorIdentityAsk(string value)
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
    public static SharesArchive200ResponseShareVisitorIdentityAsk FromCustom(string value)
    {
        return new SharesArchive200ResponseShareVisitorIdentityAsk(value);
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
        SharesArchive200ResponseShareVisitorIdentityAsk value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesArchive200ResponseShareVisitorIdentityAsk value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SharesArchive200ResponseShareVisitorIdentityAsk value) =>
        value.Value;

    public static explicit operator SharesArchive200ResponseShareVisitorIdentityAsk(string value) =>
        new(value);

    internal class SharesArchive200ResponseShareVisitorIdentityAskSerializer
        : JsonConverter<SharesArchive200ResponseShareVisitorIdentityAsk>
    {
        public override SharesArchive200ResponseShareVisitorIdentityAsk Read(
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
            return new SharesArchive200ResponseShareVisitorIdentityAsk(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesArchive200ResponseShareVisitorIdentityAsk value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesArchive200ResponseShareVisitorIdentityAsk ReadAsPropertyName(
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
            return new SharesArchive200ResponseShareVisitorIdentityAsk(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesArchive200ResponseShareVisitorIdentityAsk value,
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
