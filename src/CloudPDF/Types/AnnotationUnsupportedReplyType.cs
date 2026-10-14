using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationUnsupportedReplyType.AnnotationUnsupportedReplyTypeSerializer))]
[Serializable]
public readonly record struct AnnotationUnsupportedReplyType : IStringEnum
{
    public static readonly AnnotationUnsupportedReplyType Reply = new(Values.Reply);

    public static readonly AnnotationUnsupportedReplyType Group = new(Values.Group);

    public AnnotationUnsupportedReplyType(string value)
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
    public static AnnotationUnsupportedReplyType FromCustom(string value)
    {
        return new AnnotationUnsupportedReplyType(value);
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

    public static bool operator ==(AnnotationUnsupportedReplyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationUnsupportedReplyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationUnsupportedReplyType value) => value.Value;

    public static explicit operator AnnotationUnsupportedReplyType(string value) => new(value);

    internal class AnnotationUnsupportedReplyTypeSerializer
        : JsonConverter<AnnotationUnsupportedReplyType>
    {
        public override AnnotationUnsupportedReplyType Read(
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
            return new AnnotationUnsupportedReplyType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationUnsupportedReplyType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationUnsupportedReplyType ReadAsPropertyName(
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
            return new AnnotationUnsupportedReplyType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationUnsupportedReplyType value,
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
