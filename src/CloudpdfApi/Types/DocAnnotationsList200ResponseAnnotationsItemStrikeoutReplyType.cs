using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemStrikeoutReplyType.DocAnnotationsList200ResponseAnnotationsItemStrikeoutReplyTypeSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemStrikeoutReplyType
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemStrikeoutReplyType Reply =
        new(Values.Reply);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemStrikeoutReplyType Group =
        new(Values.Group);

    public DocAnnotationsList200ResponseAnnotationsItemStrikeoutReplyType(string value)
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
    public static DocAnnotationsList200ResponseAnnotationsItemStrikeoutReplyType FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemStrikeoutReplyType(value);
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
        DocAnnotationsList200ResponseAnnotationsItemStrikeoutReplyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemStrikeoutReplyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemStrikeoutReplyType value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemStrikeoutReplyType(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemStrikeoutReplyTypeSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemStrikeoutReplyType>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemStrikeoutReplyType Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemStrikeoutReplyType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemStrikeoutReplyType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemStrikeoutReplyType ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemStrikeoutReplyType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemStrikeoutReplyType value,
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
