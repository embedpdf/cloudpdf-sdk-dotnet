using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationCircleReplyType.AnnotationCircleReplyTypeSerializer))]
[Serializable]
public readonly record struct AnnotationCircleReplyType : IStringEnum
{
    public static readonly AnnotationCircleReplyType Reply = new(Values.Reply);

    public static readonly AnnotationCircleReplyType Group = new(Values.Group);

    public AnnotationCircleReplyType(string value)
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
    public static AnnotationCircleReplyType FromCustom(string value)
    {
        return new AnnotationCircleReplyType(value);
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

    public static bool operator ==(AnnotationCircleReplyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationCircleReplyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationCircleReplyType value) => value.Value;

    public static explicit operator AnnotationCircleReplyType(string value) => new(value);

    internal class AnnotationCircleReplyTypeSerializer : JsonConverter<AnnotationCircleReplyType>
    {
        public override AnnotationCircleReplyType Read(
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
            return new AnnotationCircleReplyType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationCircleReplyType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationCircleReplyType ReadAsPropertyName(
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
            return new AnnotationCircleReplyType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationCircleReplyType value,
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
