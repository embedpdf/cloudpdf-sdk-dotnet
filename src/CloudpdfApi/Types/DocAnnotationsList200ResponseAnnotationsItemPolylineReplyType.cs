using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemPolylineReplyType.DocAnnotationsList200ResponseAnnotationsItemPolylineReplyTypeSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemPolylineReplyType
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineReplyType Reply =
        new(Values.Reply);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineReplyType Group =
        new(Values.Group);

    public DocAnnotationsList200ResponseAnnotationsItemPolylineReplyType(string value)
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
    public static DocAnnotationsList200ResponseAnnotationsItemPolylineReplyType FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemPolylineReplyType(value);
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
        DocAnnotationsList200ResponseAnnotationsItemPolylineReplyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemPolylineReplyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemPolylineReplyType value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemPolylineReplyType(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemPolylineReplyTypeSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemPolylineReplyType>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemPolylineReplyType Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemPolylineReplyType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemPolylineReplyType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemPolylineReplyType ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemPolylineReplyType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemPolylineReplyType value,
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
