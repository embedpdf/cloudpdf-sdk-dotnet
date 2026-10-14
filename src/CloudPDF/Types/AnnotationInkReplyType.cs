using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationInkReplyType.AnnotationInkReplyTypeSerializer))]
[Serializable]
public readonly record struct AnnotationInkReplyType : IStringEnum
{
    public static readonly AnnotationInkReplyType Reply = new(Values.Reply);

    public static readonly AnnotationInkReplyType Group = new(Values.Group);

    public AnnotationInkReplyType(string value)
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
    public static AnnotationInkReplyType FromCustom(string value)
    {
        return new AnnotationInkReplyType(value);
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

    public static bool operator ==(AnnotationInkReplyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationInkReplyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationInkReplyType value) => value.Value;

    public static explicit operator AnnotationInkReplyType(string value) => new(value);

    internal class AnnotationInkReplyTypeSerializer : JsonConverter<AnnotationInkReplyType>
    {
        public override AnnotationInkReplyType Read(
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
            return new AnnotationInkReplyType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationInkReplyType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationInkReplyType ReadAsPropertyName(
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
            return new AnnotationInkReplyType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationInkReplyType value,
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
