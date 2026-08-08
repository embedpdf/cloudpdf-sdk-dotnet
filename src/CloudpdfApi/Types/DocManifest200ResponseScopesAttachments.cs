using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocManifest200ResponseScopesAttachments.DocManifest200ResponseScopesAttachmentsSerializer)
)]
[Serializable]
public readonly record struct DocManifest200ResponseScopesAttachments : IStringEnum
{
    public static readonly DocManifest200ResponseScopesAttachments Base = new(Values.Base);

    public static readonly DocManifest200ResponseScopesAttachments Layer = new(Values.Layer);

    public DocManifest200ResponseScopesAttachments(string value)
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
    public static DocManifest200ResponseScopesAttachments FromCustom(string value)
    {
        return new DocManifest200ResponseScopesAttachments(value);
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

    public static bool operator ==(DocManifest200ResponseScopesAttachments value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocManifest200ResponseScopesAttachments value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocManifest200ResponseScopesAttachments value) =>
        value.Value;

    public static explicit operator DocManifest200ResponseScopesAttachments(string value) =>
        new(value);

    internal class DocManifest200ResponseScopesAttachmentsSerializer
        : JsonConverter<DocManifest200ResponseScopesAttachments>
    {
        public override DocManifest200ResponseScopesAttachments Read(
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
            return new DocManifest200ResponseScopesAttachments(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocManifest200ResponseScopesAttachments value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocManifest200ResponseScopesAttachments ReadAsPropertyName(
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
            return new DocManifest200ResponseScopesAttachments(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocManifest200ResponseScopesAttachments value,
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
        public const string Base = "base";

        public const string Layer = "layer";
    }
}
