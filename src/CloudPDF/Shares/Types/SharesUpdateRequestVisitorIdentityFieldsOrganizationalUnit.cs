using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesUpdateRequestVisitorIdentityFieldsOrganizationalUnit.SharesUpdateRequestVisitorIdentityFieldsOrganizationalUnitSerializer)
)]
[Serializable]
public readonly record struct SharesUpdateRequestVisitorIdentityFieldsOrganizationalUnit
    : IStringEnum
{
    public static readonly SharesUpdateRequestVisitorIdentityFieldsOrganizationalUnit Required =
        new(Values.Required);

    public static readonly SharesUpdateRequestVisitorIdentityFieldsOrganizationalUnit Optional =
        new(Values.Optional);

    public SharesUpdateRequestVisitorIdentityFieldsOrganizationalUnit(string value)
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
    public static SharesUpdateRequestVisitorIdentityFieldsOrganizationalUnit FromCustom(
        string value
    )
    {
        return new SharesUpdateRequestVisitorIdentityFieldsOrganizationalUnit(value);
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
        SharesUpdateRequestVisitorIdentityFieldsOrganizationalUnit value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesUpdateRequestVisitorIdentityFieldsOrganizationalUnit value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SharesUpdateRequestVisitorIdentityFieldsOrganizationalUnit value
    ) => value.Value;

    public static explicit operator SharesUpdateRequestVisitorIdentityFieldsOrganizationalUnit(
        string value
    ) => new(value);

    internal class SharesUpdateRequestVisitorIdentityFieldsOrganizationalUnitSerializer
        : JsonConverter<SharesUpdateRequestVisitorIdentityFieldsOrganizationalUnit>
    {
        public override SharesUpdateRequestVisitorIdentityFieldsOrganizationalUnit Read(
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
            return new SharesUpdateRequestVisitorIdentityFieldsOrganizationalUnit(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesUpdateRequestVisitorIdentityFieldsOrganizationalUnit value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesUpdateRequestVisitorIdentityFieldsOrganizationalUnit ReadAsPropertyName(
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
            return new SharesUpdateRequestVisitorIdentityFieldsOrganizationalUnit(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesUpdateRequestVisitorIdentityFieldsOrganizationalUnit value,
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
