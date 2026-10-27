using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesUpdate200ResponseShareVisitorIdentityFieldsOrganizationalUnit.SharesUpdate200ResponseShareVisitorIdentityFieldsOrganizationalUnitSerializer)
)]
[Serializable]
public readonly record struct SharesUpdate200ResponseShareVisitorIdentityFieldsOrganizationalUnit
    : IStringEnum
{
    public static readonly SharesUpdate200ResponseShareVisitorIdentityFieldsOrganizationalUnit Required =
        new(Values.Required);

    public static readonly SharesUpdate200ResponseShareVisitorIdentityFieldsOrganizationalUnit Optional =
        new(Values.Optional);

    public SharesUpdate200ResponseShareVisitorIdentityFieldsOrganizationalUnit(string value)
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
    public static SharesUpdate200ResponseShareVisitorIdentityFieldsOrganizationalUnit FromCustom(
        string value
    )
    {
        return new SharesUpdate200ResponseShareVisitorIdentityFieldsOrganizationalUnit(value);
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
        SharesUpdate200ResponseShareVisitorIdentityFieldsOrganizationalUnit value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesUpdate200ResponseShareVisitorIdentityFieldsOrganizationalUnit value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SharesUpdate200ResponseShareVisitorIdentityFieldsOrganizationalUnit value
    ) => value.Value;

    public static explicit operator SharesUpdate200ResponseShareVisitorIdentityFieldsOrganizationalUnit(
        string value
    ) => new(value);

    internal class SharesUpdate200ResponseShareVisitorIdentityFieldsOrganizationalUnitSerializer
        : JsonConverter<SharesUpdate200ResponseShareVisitorIdentityFieldsOrganizationalUnit>
    {
        public override SharesUpdate200ResponseShareVisitorIdentityFieldsOrganizationalUnit Read(
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
            return new SharesUpdate200ResponseShareVisitorIdentityFieldsOrganizationalUnit(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesUpdate200ResponseShareVisitorIdentityFieldsOrganizationalUnit value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesUpdate200ResponseShareVisitorIdentityFieldsOrganizationalUnit ReadAsPropertyName(
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
            return new SharesUpdate200ResponseShareVisitorIdentityFieldsOrganizationalUnit(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesUpdate200ResponseShareVisitorIdentityFieldsOrganizationalUnit value,
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
