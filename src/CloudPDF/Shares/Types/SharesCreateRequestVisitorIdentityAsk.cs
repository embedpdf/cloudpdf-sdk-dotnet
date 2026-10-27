using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesCreateRequestVisitorIdentityAsk.SharesCreateRequestVisitorIdentityAskSerializer)
)]
[Serializable]
public readonly record struct SharesCreateRequestVisitorIdentityAsk : IStringEnum
{
    public static readonly SharesCreateRequestVisitorIdentityAsk OnOpen = new(Values.OnOpen);

    public static readonly SharesCreateRequestVisitorIdentityAsk BeforeFirstChange = new(
        Values.BeforeFirstChange
    );

    public SharesCreateRequestVisitorIdentityAsk(string value)
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
    public static SharesCreateRequestVisitorIdentityAsk FromCustom(string value)
    {
        return new SharesCreateRequestVisitorIdentityAsk(value);
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

    public static bool operator ==(SharesCreateRequestVisitorIdentityAsk value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(SharesCreateRequestVisitorIdentityAsk value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(SharesCreateRequestVisitorIdentityAsk value) =>
        value.Value;

    public static explicit operator SharesCreateRequestVisitorIdentityAsk(string value) =>
        new(value);

    internal class SharesCreateRequestVisitorIdentityAskSerializer
        : JsonConverter<SharesCreateRequestVisitorIdentityAsk>
    {
        public override SharesCreateRequestVisitorIdentityAsk Read(
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
            return new SharesCreateRequestVisitorIdentityAsk(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesCreateRequestVisitorIdentityAsk value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesCreateRequestVisitorIdentityAsk ReadAsPropertyName(
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
            return new SharesCreateRequestVisitorIdentityAsk(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesCreateRequestVisitorIdentityAsk value,
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
