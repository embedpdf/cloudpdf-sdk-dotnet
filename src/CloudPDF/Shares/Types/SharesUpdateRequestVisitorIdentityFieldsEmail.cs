using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesUpdateRequestVisitorIdentityFieldsEmail.SharesUpdateRequestVisitorIdentityFieldsEmailSerializer)
)]
[Serializable]
public readonly record struct SharesUpdateRequestVisitorIdentityFieldsEmail : IStringEnum
{
    public static readonly SharesUpdateRequestVisitorIdentityFieldsEmail Required = new(
        Values.Required
    );

    public static readonly SharesUpdateRequestVisitorIdentityFieldsEmail Optional = new(
        Values.Optional
    );

    public SharesUpdateRequestVisitorIdentityFieldsEmail(string value)
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
    public static SharesUpdateRequestVisitorIdentityFieldsEmail FromCustom(string value)
    {
        return new SharesUpdateRequestVisitorIdentityFieldsEmail(value);
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
        SharesUpdateRequestVisitorIdentityFieldsEmail value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesUpdateRequestVisitorIdentityFieldsEmail value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SharesUpdateRequestVisitorIdentityFieldsEmail value) =>
        value.Value;

    public static explicit operator SharesUpdateRequestVisitorIdentityFieldsEmail(string value) =>
        new(value);

    internal class SharesUpdateRequestVisitorIdentityFieldsEmailSerializer
        : JsonConverter<SharesUpdateRequestVisitorIdentityFieldsEmail>
    {
        public override SharesUpdateRequestVisitorIdentityFieldsEmail Read(
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
            return new SharesUpdateRequestVisitorIdentityFieldsEmail(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesUpdateRequestVisitorIdentityFieldsEmail value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesUpdateRequestVisitorIdentityFieldsEmail ReadAsPropertyName(
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
            return new SharesUpdateRequestVisitorIdentityFieldsEmail(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesUpdateRequestVisitorIdentityFieldsEmail value,
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
