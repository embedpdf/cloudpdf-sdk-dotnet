using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsExportAppearance404ResponseName.DocAnnotationsExportAppearance404ResponseNameSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsExportAppearance404ResponseName : IStringEnum
{
    public static readonly DocAnnotationsExportAppearance404ResponseName EngineError = new(
        Values.EngineError
    );

    public DocAnnotationsExportAppearance404ResponseName(string value)
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
    public static DocAnnotationsExportAppearance404ResponseName FromCustom(string value)
    {
        return new DocAnnotationsExportAppearance404ResponseName(value);
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
        DocAnnotationsExportAppearance404ResponseName value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsExportAppearance404ResponseName value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocAnnotationsExportAppearance404ResponseName value) =>
        value.Value;

    public static explicit operator DocAnnotationsExportAppearance404ResponseName(string value) =>
        new(value);

    internal class DocAnnotationsExportAppearance404ResponseNameSerializer
        : JsonConverter<DocAnnotationsExportAppearance404ResponseName>
    {
        public override DocAnnotationsExportAppearance404ResponseName Read(
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
            return new DocAnnotationsExportAppearance404ResponseName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsExportAppearance404ResponseName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsExportAppearance404ResponseName ReadAsPropertyName(
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
            return new DocAnnotationsExportAppearance404ResponseName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsExportAppearance404ResponseName value,
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
        public const string EngineError = "EngineError";
    }
}
