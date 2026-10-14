using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationRedactReplyType.AnnotationRedactReplyTypeSerializer))]
[Serializable]
public readonly record struct AnnotationRedactReplyType : IStringEnum
{
    public static readonly AnnotationRedactReplyType Reply = new(Values.Reply);

    public static readonly AnnotationRedactReplyType Group = new(Values.Group);

    public AnnotationRedactReplyType(string value)
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
    public static AnnotationRedactReplyType FromCustom(string value)
    {
        return new AnnotationRedactReplyType(value);
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

    public static bool operator ==(AnnotationRedactReplyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationRedactReplyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationRedactReplyType value) => value.Value;

    public static explicit operator AnnotationRedactReplyType(string value) => new(value);

    internal class AnnotationRedactReplyTypeSerializer : JsonConverter<AnnotationRedactReplyType>
    {
        public override AnnotationRedactReplyType Read(
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
            return new AnnotationRedactReplyType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationRedactReplyType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationRedactReplyType ReadAsPropertyName(
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
            return new AnnotationRedactReplyType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationRedactReplyType value,
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
