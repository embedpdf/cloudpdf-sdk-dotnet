using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemUnderlineReplyType.DocAnnotationsList200ResponseAnnotationsItemUnderlineReplyTypeSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemUnderlineReplyType
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemUnderlineReplyType Reply =
        new(Values.Reply);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemUnderlineReplyType Group =
        new(Values.Group);

    public DocAnnotationsList200ResponseAnnotationsItemUnderlineReplyType(string value)
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
    public static DocAnnotationsList200ResponseAnnotationsItemUnderlineReplyType FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemUnderlineReplyType(value);
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
        DocAnnotationsList200ResponseAnnotationsItemUnderlineReplyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemUnderlineReplyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemUnderlineReplyType value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemUnderlineReplyType(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemUnderlineReplyTypeSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemUnderlineReplyType>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemUnderlineReplyType Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemUnderlineReplyType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemUnderlineReplyType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemUnderlineReplyType ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemUnderlineReplyType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemUnderlineReplyType value,
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
        public const string Reply = "reply";

        public const string Group = "group";
    }
}
