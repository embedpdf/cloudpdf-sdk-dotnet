using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocManifestResponseScopesAttachments.DocManifestResponseScopesAttachmentsSerializer)
)]
[Serializable]
public readonly record struct DocManifestResponseScopesAttachments : IStringEnum
{
    public static readonly DocManifestResponseScopesAttachments Base = new(Values.Base);

    public static readonly DocManifestResponseScopesAttachments Layer = new(Values.Layer);

    public DocManifestResponseScopesAttachments(string value)
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
    public static DocManifestResponseScopesAttachments FromCustom(string value)
    {
        return new DocManifestResponseScopesAttachments(value);
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

    public static bool operator ==(DocManifestResponseScopesAttachments value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocManifestResponseScopesAttachments value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocManifestResponseScopesAttachments value) =>
        value.Value;

    public static explicit operator DocManifestResponseScopesAttachments(string value) =>
        new(value);

    internal class DocManifestResponseScopesAttachmentsSerializer
        : JsonConverter<DocManifestResponseScopesAttachments>
    {
        public override DocManifestResponseScopesAttachments Read(
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
            return new DocManifestResponseScopesAttachments(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocManifestResponseScopesAttachments value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocManifestResponseScopesAttachments ReadAsPropertyName(
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
            return new DocManifestResponseScopesAttachments(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocManifestResponseScopesAttachments value,
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
