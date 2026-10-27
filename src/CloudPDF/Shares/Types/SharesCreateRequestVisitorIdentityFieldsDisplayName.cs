using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesCreateRequestVisitorIdentityFieldsDisplayName.SharesCreateRequestVisitorIdentityFieldsDisplayNameSerializer)
)]
[Serializable]
public readonly record struct SharesCreateRequestVisitorIdentityFieldsDisplayName : IStringEnum
{
    public static readonly SharesCreateRequestVisitorIdentityFieldsDisplayName Required = new(
        Values.Required
    );

    public static readonly SharesCreateRequestVisitorIdentityFieldsDisplayName Optional = new(
        Values.Optional
    );

    public SharesCreateRequestVisitorIdentityFieldsDisplayName(string value)
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
    public static SharesCreateRequestVisitorIdentityFieldsDisplayName FromCustom(string value)
    {
        return new SharesCreateRequestVisitorIdentityFieldsDisplayName(value);
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
        SharesCreateRequestVisitorIdentityFieldsDisplayName value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesCreateRequestVisitorIdentityFieldsDisplayName value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SharesCreateRequestVisitorIdentityFieldsDisplayName value
    ) => value.Value;

    public static explicit operator SharesCreateRequestVisitorIdentityFieldsDisplayName(
        string value
    ) => new(value);

    internal class SharesCreateRequestVisitorIdentityFieldsDisplayNameSerializer
        : JsonConverter<SharesCreateRequestVisitorIdentityFieldsDisplayName>
    {
        public override SharesCreateRequestVisitorIdentityFieldsDisplayName Read(
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
            return new SharesCreateRequestVisitorIdentityFieldsDisplayName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesCreateRequestVisitorIdentityFieldsDisplayName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesCreateRequestVisitorIdentityFieldsDisplayName ReadAsPropertyName(
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
            return new SharesCreateRequestVisitorIdentityFieldsDisplayName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesCreateRequestVisitorIdentityFieldsDisplayName value,
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
