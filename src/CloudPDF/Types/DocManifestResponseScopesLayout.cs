using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocManifestResponseScopesLayout.DocManifestResponseScopesLayoutSerializer))]
[Serializable]
public readonly record struct DocManifestResponseScopesLayout : IStringEnum
{
    public static readonly DocManifestResponseScopesLayout Base = new(Values.Base);

    public static readonly DocManifestResponseScopesLayout Layer = new(Values.Layer);

    public DocManifestResponseScopesLayout(string value)
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
    public static DocManifestResponseScopesLayout FromCustom(string value)
    {
        return new DocManifestResponseScopesLayout(value);
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

    public static bool operator ==(DocManifestResponseScopesLayout value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocManifestResponseScopesLayout value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocManifestResponseScopesLayout value) => value.Value;

    public static explicit operator DocManifestResponseScopesLayout(string value) => new(value);

    internal class DocManifestResponseScopesLayoutSerializer
        : JsonConverter<DocManifestResponseScopesLayout>
    {
        public override DocManifestResponseScopesLayout Read(
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
            return new DocManifestResponseScopesLayout(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocManifestResponseScopesLayout value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocManifestResponseScopesLayout ReadAsPropertyName(
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
            return new DocManifestResponseScopesLayout(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocManifestResponseScopesLayout value,
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
