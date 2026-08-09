using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocManifest200ResponseScopesActions.DocManifest200ResponseScopesActionsSerializer)
)]
[Serializable]
public readonly record struct DocManifest200ResponseScopesActions : IStringEnum
{
    public static readonly DocManifest200ResponseScopesActions Base = new(Values.Base);

    public static readonly DocManifest200ResponseScopesActions Layer = new(Values.Layer);

    public DocManifest200ResponseScopesActions(string value)
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
    public static DocManifest200ResponseScopesActions FromCustom(string value)
    {
        return new DocManifest200ResponseScopesActions(value);
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

    public static bool operator ==(DocManifest200ResponseScopesActions value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocManifest200ResponseScopesActions value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocManifest200ResponseScopesActions value) =>
        value.Value;

    public static explicit operator DocManifest200ResponseScopesActions(string value) => new(value);

    internal class DocManifest200ResponseScopesActionsSerializer
        : JsonConverter<DocManifest200ResponseScopesActions>
    {
        public override DocManifest200ResponseScopesActions Read(
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
            return new DocManifest200ResponseScopesActions(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocManifest200ResponseScopesActions value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocManifest200ResponseScopesActions ReadAsPropertyName(
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
            return new DocManifest200ResponseScopesActions(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocManifest200ResponseScopesActions value,
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
