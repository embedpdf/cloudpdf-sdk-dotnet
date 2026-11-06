using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocManifestResponseScopesOutline.DocManifestResponseScopesOutlineSerializer))]
[Serializable]
public readonly record struct DocManifestResponseScopesOutline : IStringEnum
{
    public static readonly DocManifestResponseScopesOutline Base = new(Values.Base);

    public static readonly DocManifestResponseScopesOutline Layer = new(Values.Layer);

    public DocManifestResponseScopesOutline(string value)
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
    public static DocManifestResponseScopesOutline FromCustom(string value)
    {
        return new DocManifestResponseScopesOutline(value);
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

    public static bool operator ==(DocManifestResponseScopesOutline value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocManifestResponseScopesOutline value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocManifestResponseScopesOutline value) => value.Value;

    public static explicit operator DocManifestResponseScopesOutline(string value) => new(value);

    internal class DocManifestResponseScopesOutlineSerializer
        : JsonConverter<DocManifestResponseScopesOutline>
    {
        public override DocManifestResponseScopesOutline Read(
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
            return new DocManifestResponseScopesOutline(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocManifestResponseScopesOutline value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocManifestResponseScopesOutline ReadAsPropertyName(
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
            return new DocManifestResponseScopesOutline(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocManifestResponseScopesOutline value,
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
