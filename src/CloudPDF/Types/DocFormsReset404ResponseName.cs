using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocFormsReset404ResponseName.DocFormsReset404ResponseNameSerializer))]
[Serializable]
public readonly record struct DocFormsReset404ResponseName : IStringEnum
{
    public static readonly DocFormsReset404ResponseName EngineError = new(Values.EngineError);

    public DocFormsReset404ResponseName(string value)
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
    public static DocFormsReset404ResponseName FromCustom(string value)
    {
        return new DocFormsReset404ResponseName(value);
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

    public static bool operator ==(DocFormsReset404ResponseName value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocFormsReset404ResponseName value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocFormsReset404ResponseName value) => value.Value;

    public static explicit operator DocFormsReset404ResponseName(string value) => new(value);

    internal class DocFormsReset404ResponseNameSerializer
        : JsonConverter<DocFormsReset404ResponseName>
    {
        public override DocFormsReset404ResponseName Read(
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
            return new DocFormsReset404ResponseName(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsReset404ResponseName value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocFormsReset404ResponseName ReadAsPropertyName(
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
            return new DocFormsReset404ResponseName(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsReset404ResponseName value,
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
