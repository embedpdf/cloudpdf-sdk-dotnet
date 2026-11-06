using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocManifestResponseScopesActions.DocManifestResponseScopesActionsSerializer))]
[Serializable]
public readonly record struct DocManifestResponseScopesActions : IStringEnum
{
    public static readonly DocManifestResponseScopesActions Base = new(Values.Base);

    public static readonly DocManifestResponseScopesActions Layer = new(Values.Layer);

    public DocManifestResponseScopesActions(string value)
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
    public static DocManifestResponseScopesActions FromCustom(string value)
    {
        return new DocManifestResponseScopesActions(value);
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

    public static bool operator ==(DocManifestResponseScopesActions value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocManifestResponseScopesActions value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocManifestResponseScopesActions value) => value.Value;

    public static explicit operator DocManifestResponseScopesActions(string value) => new(value);

    internal class DocManifestResponseScopesActionsSerializer
        : JsonConverter<DocManifestResponseScopesActions>
    {
        public override DocManifestResponseScopesActions Read(
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
            return new DocManifestResponseScopesActions(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocManifestResponseScopesActions value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocManifestResponseScopesActions ReadAsPropertyName(
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
            return new DocManifestResponseScopesActions(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocManifestResponseScopesActions value,
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
