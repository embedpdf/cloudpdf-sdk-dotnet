using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocPagesExtract404ResponseName.DocPagesExtract404ResponseNameSerializer))]
[Serializable]
public readonly record struct DocPagesExtract404ResponseName : IStringEnum
{
    public static readonly DocPagesExtract404ResponseName EngineError = new(Values.EngineError);

    public DocPagesExtract404ResponseName(string value)
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
    public static DocPagesExtract404ResponseName FromCustom(string value)
    {
        return new DocPagesExtract404ResponseName(value);
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

    public static bool operator ==(DocPagesExtract404ResponseName value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocPagesExtract404ResponseName value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocPagesExtract404ResponseName value) => value.Value;

    public static explicit operator DocPagesExtract404ResponseName(string value) => new(value);

    internal class DocPagesExtract404ResponseNameSerializer
        : JsonConverter<DocPagesExtract404ResponseName>
    {
        public override DocPagesExtract404ResponseName Read(
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
            return new DocPagesExtract404ResponseName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesExtract404ResponseName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesExtract404ResponseName ReadAsPropertyName(
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
            return new DocPagesExtract404ResponseName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesExtract404ResponseName value,
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
