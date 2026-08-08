using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocManifest200ResponseScopesLayout.DocManifest200ResponseScopesLayoutSerializer)
)]
[Serializable]
public readonly record struct DocManifest200ResponseScopesLayout : IStringEnum
{
    public static readonly DocManifest200ResponseScopesLayout Base = new(Values.Base);

    public static readonly DocManifest200ResponseScopesLayout Layer = new(Values.Layer);

    public DocManifest200ResponseScopesLayout(string value)
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
    public static DocManifest200ResponseScopesLayout FromCustom(string value)
    {
        return new DocManifest200ResponseScopesLayout(value);
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

    public static bool operator ==(DocManifest200ResponseScopesLayout value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocManifest200ResponseScopesLayout value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocManifest200ResponseScopesLayout value) => value.Value;

    public static explicit operator DocManifest200ResponseScopesLayout(string value) => new(value);

    internal class DocManifest200ResponseScopesLayoutSerializer
        : JsonConverter<DocManifest200ResponseScopesLayout>
    {
        public override DocManifest200ResponseScopesLayout Read(
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
            return new DocManifest200ResponseScopesLayout(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocManifest200ResponseScopesLayout value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocManifest200ResponseScopesLayout ReadAsPropertyName(
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
            return new DocManifest200ResponseScopesLayout(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocManifest200ResponseScopesLayout value,
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
