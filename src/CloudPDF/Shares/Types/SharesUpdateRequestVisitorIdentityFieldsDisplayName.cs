using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(SharesUpdateRequestVisitorIdentityFieldsDisplayName.SharesUpdateRequestVisitorIdentityFieldsDisplayNameSerializer)
)]
[Serializable]
public readonly record struct SharesUpdateRequestVisitorIdentityFieldsDisplayName : IStringEnum
{
    public static readonly SharesUpdateRequestVisitorIdentityFieldsDisplayName Required = new(
        Values.Required
    );

    public static readonly SharesUpdateRequestVisitorIdentityFieldsDisplayName Optional = new(
        Values.Optional
    );

    public SharesUpdateRequestVisitorIdentityFieldsDisplayName(string value)
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
    public static SharesUpdateRequestVisitorIdentityFieldsDisplayName FromCustom(string value)
    {
        return new SharesUpdateRequestVisitorIdentityFieldsDisplayName(value);
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
        SharesUpdateRequestVisitorIdentityFieldsDisplayName value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        SharesUpdateRequestVisitorIdentityFieldsDisplayName value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        SharesUpdateRequestVisitorIdentityFieldsDisplayName value
    ) => value.Value;

    public static explicit operator SharesUpdateRequestVisitorIdentityFieldsDisplayName(
        string value
    ) => new(value);

    internal class SharesUpdateRequestVisitorIdentityFieldsDisplayNameSerializer
        : JsonConverter<SharesUpdateRequestVisitorIdentityFieldsDisplayName>
    {
        public override SharesUpdateRequestVisitorIdentityFieldsDisplayName Read(
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
            return new SharesUpdateRequestVisitorIdentityFieldsDisplayName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            SharesUpdateRequestVisitorIdentityFieldsDisplayName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override SharesUpdateRequestVisitorIdentityFieldsDisplayName ReadAsPropertyName(
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
            return new SharesUpdateRequestVisitorIdentityFieldsDisplayName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            SharesUpdateRequestVisitorIdentityFieldsDisplayName value,
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
