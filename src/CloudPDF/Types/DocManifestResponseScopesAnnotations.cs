using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocManifestResponseScopesAnnotations.DocManifestResponseScopesAnnotationsSerializer)
)]
[Serializable]
public readonly record struct DocManifestResponseScopesAnnotations : IStringEnum
{
    public static readonly DocManifestResponseScopesAnnotations Base = new(Values.Base);

    public static readonly DocManifestResponseScopesAnnotations Layer = new(Values.Layer);

    public DocManifestResponseScopesAnnotations(string value)
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
    public static DocManifestResponseScopesAnnotations FromCustom(string value)
    {
        return new DocManifestResponseScopesAnnotations(value);
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

    public static bool operator ==(DocManifestResponseScopesAnnotations value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocManifestResponseScopesAnnotations value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocManifestResponseScopesAnnotations value) =>
        value.Value;

    public static explicit operator DocManifestResponseScopesAnnotations(string value) =>
        new(value);

    internal class DocManifestResponseScopesAnnotationsSerializer
        : JsonConverter<DocManifestResponseScopesAnnotations>
    {
        public override DocManifestResponseScopesAnnotations Read(
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
            return new DocManifestResponseScopesAnnotations(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocManifestResponseScopesAnnotations value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocManifestResponseScopesAnnotations ReadAsPropertyName(
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
            return new DocManifestResponseScopesAnnotations(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocManifestResponseScopesAnnotations value,
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
