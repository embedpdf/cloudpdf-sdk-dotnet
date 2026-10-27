using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesGet200ResponseShareVisitorIdentityFieldsOrganizationalUnit.SharesGet200ResponseShareVisitorIdentityFieldsOrganizationalUnitSerializer)
)]
[Serializable]
public readonly record struct SharesGet200ResponseShareVisitorIdentityFieldsOrganizationalUnit
    : IStringEnum
{
    public static readonly SharesGet200ResponseShareVisitorIdentityFieldsOrganizationalUnit Required =
        new(Values.Required);

    public static readonly SharesGet200ResponseShareVisitorIdentityFieldsOrganizationalUnit Optional =
        new(Values.Optional);

    public SharesGet200ResponseShareVisitorIdentityFieldsOrganizationalUnit(string value)
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
    public static SharesGet200ResponseShareVisitorIdentityFieldsOrganizationalUnit FromCustom(
        string value
    )
    {
        return new SharesGet200ResponseShareVisitorIdentityFieldsOrganizationalUnit(value);
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
        SharesGet200ResponseShareVisitorIdentityFieldsOrganizationalUnit value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesGet200ResponseShareVisitorIdentityFieldsOrganizationalUnit value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SharesGet200ResponseShareVisitorIdentityFieldsOrganizationalUnit value
    ) => value.Value;

    public static explicit operator SharesGet200ResponseShareVisitorIdentityFieldsOrganizationalUnit(
        string value
    ) => new(value);

    internal class SharesGet200ResponseShareVisitorIdentityFieldsOrganizationalUnitSerializer
        : JsonConverter<SharesGet200ResponseShareVisitorIdentityFieldsOrganizationalUnit>
    {
        public override SharesGet200ResponseShareVisitorIdentityFieldsOrganizationalUnit Read(
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
            return new SharesGet200ResponseShareVisitorIdentityFieldsOrganizationalUnit(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesGet200ResponseShareVisitorIdentityFieldsOrganizationalUnit value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesGet200ResponseShareVisitorIdentityFieldsOrganizationalUnit ReadAsPropertyName(
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
            return new SharesGet200ResponseShareVisitorIdentityFieldsOrganizationalUnit(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesGet200ResponseShareVisitorIdentityFieldsOrganizationalUnit value,
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
