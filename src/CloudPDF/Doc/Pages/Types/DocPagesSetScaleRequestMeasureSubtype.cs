using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF.Doc;

[JsonConverter(
    typeof(DocPagesSetScaleRequestMeasureSubtype.DocPagesSetScaleRequestMeasureSubtypeSerializer)
)]
[Serializable]
public readonly record struct DocPagesSetScaleRequestMeasureSubtype : IStringEnum
{
    public static readonly DocPagesSetScaleRequestMeasureSubtype Rl = new(Values.Rl);

    public DocPagesSetScaleRequestMeasureSubtype(string value)
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
    public static DocPagesSetScaleRequestMeasureSubtype FromCustom(string value)
    {
        return new DocPagesSetScaleRequestMeasureSubtype(value);
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

    public static bool operator ==(DocPagesSetScaleRequestMeasureSubtype value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocPagesSetScaleRequestMeasureSubtype value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocPagesSetScaleRequestMeasureSubtype value) =>
        value.Value;

    public static explicit operator DocPagesSetScaleRequestMeasureSubtype(string value) =>
        new(value);

    internal class DocPagesSetScaleRequestMeasureSubtypeSerializer
        : JsonConverter<DocPagesSetScaleRequestMeasureSubtype>
    {
        public override DocPagesSetScaleRequestMeasureSubtype Read(
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
            return new DocPagesSetScaleRequestMeasureSubtype(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesSetScaleRequestMeasureSubtype value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesSetScaleRequestMeasureSubtype ReadAsPropertyName(
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
            return new DocPagesSetScaleRequestMeasureSubtype(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesSetScaleRequestMeasureSubtype value,
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
        public const string Rl = "RL";
    }
}
