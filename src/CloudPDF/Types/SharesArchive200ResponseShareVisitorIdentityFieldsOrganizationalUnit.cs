using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesArchive200ResponseShareVisitorIdentityFieldsOrganizationalUnit.SharesArchive200ResponseShareVisitorIdentityFieldsOrganizationalUnitSerializer)
)]
[Serializable]
public readonly record struct SharesArchive200ResponseShareVisitorIdentityFieldsOrganizationalUnit
    : IStringEnum
{
    public static readonly SharesArchive200ResponseShareVisitorIdentityFieldsOrganizationalUnit Required =
        new(Values.Required);

    public static readonly SharesArchive200ResponseShareVisitorIdentityFieldsOrganizationalUnit Optional =
        new(Values.Optional);

    public SharesArchive200ResponseShareVisitorIdentityFieldsOrganizationalUnit(string value)
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
    public static SharesArchive200ResponseShareVisitorIdentityFieldsOrganizationalUnit FromCustom(
        string value
    )
    {
        return new SharesArchive200ResponseShareVisitorIdentityFieldsOrganizationalUnit(value);
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
        SharesArchive200ResponseShareVisitorIdentityFieldsOrganizationalUnit value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesArchive200ResponseShareVisitorIdentityFieldsOrganizationalUnit value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SharesArchive200ResponseShareVisitorIdentityFieldsOrganizationalUnit value
    ) => value.Value;

    public static explicit operator SharesArchive200ResponseShareVisitorIdentityFieldsOrganizationalUnit(
        string value
    ) => new(value);

    internal class SharesArchive200ResponseShareVisitorIdentityFieldsOrganizationalUnitSerializer
        : JsonConverter<SharesArchive200ResponseShareVisitorIdentityFieldsOrganizationalUnit>
    {
        public override SharesArchive200ResponseShareVisitorIdentityFieldsOrganizationalUnit Read(
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
            return new SharesArchive200ResponseShareVisitorIdentityFieldsOrganizationalUnit(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesArchive200ResponseShareVisitorIdentityFieldsOrganizationalUnit value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesArchive200ResponseShareVisitorIdentityFieldsOrganizationalUnit ReadAsPropertyName(
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
            return new SharesArchive200ResponseShareVisitorIdentityFieldsOrganizationalUnit(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesArchive200ResponseShareVisitorIdentityFieldsOrganizationalUnit value,
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
