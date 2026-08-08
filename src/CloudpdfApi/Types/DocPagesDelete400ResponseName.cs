using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(typeof(DocPagesDelete400ResponseName.DocPagesDelete400ResponseNameSerializer))]
[Serializable]
public readonly record struct DocPagesDelete400ResponseName : IStringEnum
{
    public static readonly DocPagesDelete400ResponseName EngineError = new(Values.EngineError);

    public DocPagesDelete400ResponseName(string value)
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
    public static DocPagesDelete400ResponseName FromCustom(string value)
    {
        return new DocPagesDelete400ResponseName(value);
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

    public static bool operator ==(DocPagesDelete400ResponseName value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocPagesDelete400ResponseName value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocPagesDelete400ResponseName value) => value.Value;

    public static explicit operator DocPagesDelete400ResponseName(string value) => new(value);

    internal class DocPagesDelete400ResponseNameSerializer
        : JsonConverter<DocPagesDelete400ResponseName>
    {
        public override DocPagesDelete400ResponseName Read(
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
            return new DocPagesDelete400ResponseName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesDelete400ResponseName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesDelete400ResponseName ReadAsPropertyName(
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
            return new DocPagesDelete400ResponseName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesDelete400ResponseName value,
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
