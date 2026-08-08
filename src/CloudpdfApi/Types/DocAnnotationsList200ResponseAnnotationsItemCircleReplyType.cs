using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemCircleReplyType.DocAnnotationsList200ResponseAnnotationsItemCircleReplyTypeSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemCircleReplyType
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemCircleReplyType Reply = new(
        Values.Reply
    );

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCircleReplyType Group = new(
        Values.Group
    );

    public DocAnnotationsList200ResponseAnnotationsItemCircleReplyType(string value)
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
    public static DocAnnotationsList200ResponseAnnotationsItemCircleReplyType FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemCircleReplyType(value);
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
        DocAnnotationsList200ResponseAnnotationsItemCircleReplyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemCircleReplyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemCircleReplyType value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemCircleReplyType(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemCircleReplyTypeSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemCircleReplyType>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemCircleReplyType Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemCircleReplyType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemCircleReplyType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemCircleReplyType ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemCircleReplyType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemCircleReplyType value,
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
