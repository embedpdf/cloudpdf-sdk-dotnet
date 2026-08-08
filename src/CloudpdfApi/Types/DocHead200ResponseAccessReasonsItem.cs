using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocHead200ResponseAccessReasonsItem.DocHead200ResponseAccessReasonsItemSerializer)
)]
[Serializable]
public readonly record struct DocHead200ResponseAccessReasonsItem : IStringEnum
{
    public static readonly DocHead200ResponseAccessReasonsItem Password = new(Values.Password);

    public static readonly DocHead200ResponseAccessReasonsItem Cdn = new(Values.Cdn);

    public static readonly DocHead200ResponseAccessReasonsItem PermissionsUnknown = new(
        Values.PermissionsUnknown
    );

    public DocHead200ResponseAccessReasonsItem(string value)
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
    public static DocHead200ResponseAccessReasonsItem FromCustom(string value)
    {
        return new DocHead200ResponseAccessReasonsItem(value);
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

    public static bool operator ==(DocHead200ResponseAccessReasonsItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocHead200ResponseAccessReasonsItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocHead200ResponseAccessReasonsItem value) =>
        value.Value;

    public static explicit operator DocHead200ResponseAccessReasonsItem(string value) => new(value);

    internal class DocHead200ResponseAccessReasonsItemSerializer
        : JsonConverter<DocHead200ResponseAccessReasonsItem>
    {
        public override DocHead200ResponseAccessReasonsItem Read(
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
            return new DocHead200ResponseAccessReasonsItem(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocHead200ResponseAccessReasonsItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocHead200ResponseAccessReasonsItem ReadAsPropertyName(
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
            return new DocHead200ResponseAccessReasonsItem(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocHead200ResponseAccessReasonsItem value,
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
        public const string Password = "password";

        public const string Cdn = "cdn";

        public const string PermissionsUnknown = "permissions-unknown";
    }
}
