using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocPagesInsertBlank404ResponseName.DocPagesInsertBlank404ResponseNameSerializer)
)]
[Serializable]
public readonly record struct DocPagesInsertBlank404ResponseName : IStringEnum
{
    public static readonly DocPagesInsertBlank404ResponseName EngineError = new(Values.EngineError);

    public DocPagesInsertBlank404ResponseName(string value)
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
    public static DocPagesInsertBlank404ResponseName FromCustom(string value)
    {
        return new DocPagesInsertBlank404ResponseName(value);
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

    public static bool operator ==(DocPagesInsertBlank404ResponseName value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocPagesInsertBlank404ResponseName value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocPagesInsertBlank404ResponseName value) => value.Value;

    public static explicit operator DocPagesInsertBlank404ResponseName(string value) => new(value);

    internal class DocPagesInsertBlank404ResponseNameSerializer
        : JsonConverter<DocPagesInsertBlank404ResponseName>
    {
        public override DocPagesInsertBlank404ResponseName Read(
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
            return new DocPagesInsertBlank404ResponseName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesInsertBlank404ResponseName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesInsertBlank404ResponseName ReadAsPropertyName(
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
            return new DocPagesInsertBlank404ResponseName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesInsertBlank404ResponseName value,
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
