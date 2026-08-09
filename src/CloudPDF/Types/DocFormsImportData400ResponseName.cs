using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocFormsImportData400ResponseName.DocFormsImportData400ResponseNameSerializer)
)]
[Serializable]
public readonly record struct DocFormsImportData400ResponseName : IStringEnum
{
    public static readonly DocFormsImportData400ResponseName EngineError = new(Values.EngineError);

    public DocFormsImportData400ResponseName(string value)
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
    public static DocFormsImportData400ResponseName FromCustom(string value)
    {
        return new DocFormsImportData400ResponseName(value);
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

    public static bool operator ==(DocFormsImportData400ResponseName value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocFormsImportData400ResponseName value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocFormsImportData400ResponseName value) => value.Value;

    public static explicit operator DocFormsImportData400ResponseName(string value) => new(value);

    internal class DocFormsImportData400ResponseNameSerializer
        : JsonConverter<DocFormsImportData400ResponseName>
    {
        public override DocFormsImportData400ResponseName Read(
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
            return new DocFormsImportData400ResponseName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsImportData400ResponseName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocFormsImportData400ResponseName ReadAsPropertyName(
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
            return new DocFormsImportData400ResponseName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsImportData400ResponseName value,
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
