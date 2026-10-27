using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesCreateRequestVisitorIdentityFieldsEmail.SharesCreateRequestVisitorIdentityFieldsEmailSerializer)
)]
[Serializable]
public readonly record struct SharesCreateRequestVisitorIdentityFieldsEmail : IStringEnum
{
    public static readonly SharesCreateRequestVisitorIdentityFieldsEmail Required = new(
        Values.Required
    );

    public static readonly SharesCreateRequestVisitorIdentityFieldsEmail Optional = new(
        Values.Optional
    );

    public SharesCreateRequestVisitorIdentityFieldsEmail(string value)
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
    public static SharesCreateRequestVisitorIdentityFieldsEmail FromCustom(string value)
    {
        return new SharesCreateRequestVisitorIdentityFieldsEmail(value);
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
        SharesCreateRequestVisitorIdentityFieldsEmail value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesCreateRequestVisitorIdentityFieldsEmail value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(SharesCreateRequestVisitorIdentityFieldsEmail value) =>
        value.Value;

    public static explicit operator SharesCreateRequestVisitorIdentityFieldsEmail(string value) =>
        new(value);

    internal class SharesCreateRequestVisitorIdentityFieldsEmailSerializer
        : JsonConverter<SharesCreateRequestVisitorIdentityFieldsEmail>
    {
        public override SharesCreateRequestVisitorIdentityFieldsEmail Read(
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
            return new SharesCreateRequestVisitorIdentityFieldsEmail(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesCreateRequestVisitorIdentityFieldsEmail value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesCreateRequestVisitorIdentityFieldsEmail ReadAsPropertyName(
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
            return new SharesCreateRequestVisitorIdentityFieldsEmail(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesCreateRequestVisitorIdentityFieldsEmail value,
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
