using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesUpdateRequestVisitorIdentityFieldsOrganization.SharesUpdateRequestVisitorIdentityFieldsOrganizationSerializer)
)]
[Serializable]
public readonly record struct SharesUpdateRequestVisitorIdentityFieldsOrganization : IStringEnum
{
    public static readonly SharesUpdateRequestVisitorIdentityFieldsOrganization Required = new(
        Values.Required
    );

    public static readonly SharesUpdateRequestVisitorIdentityFieldsOrganization Optional = new(
        Values.Optional
    );

    public SharesUpdateRequestVisitorIdentityFieldsOrganization(string value)
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
    public static SharesUpdateRequestVisitorIdentityFieldsOrganization FromCustom(string value)
    {
        return new SharesUpdateRequestVisitorIdentityFieldsOrganization(value);
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
        SharesUpdateRequestVisitorIdentityFieldsOrganization value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesUpdateRequestVisitorIdentityFieldsOrganization value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SharesUpdateRequestVisitorIdentityFieldsOrganization value
    ) => value.Value;

    public static explicit operator SharesUpdateRequestVisitorIdentityFieldsOrganization(
        string value
    ) => new(value);

    internal class SharesUpdateRequestVisitorIdentityFieldsOrganizationSerializer
        : JsonConverter<SharesUpdateRequestVisitorIdentityFieldsOrganization>
    {
        public override SharesUpdateRequestVisitorIdentityFieldsOrganization Read(
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
            return new SharesUpdateRequestVisitorIdentityFieldsOrganization(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesUpdateRequestVisitorIdentityFieldsOrganization value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesUpdateRequestVisitorIdentityFieldsOrganization ReadAsPropertyName(
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
            return new SharesUpdateRequestVisitorIdentityFieldsOrganization(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesUpdateRequestVisitorIdentityFieldsOrganization value,
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
