using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationFileAttachmentReplyType.AnnotationFileAttachmentReplyTypeSerializer)
)]
[Serializable]
public readonly record struct AnnotationFileAttachmentReplyType : IStringEnum
{
    public static readonly AnnotationFileAttachmentReplyType Reply = new(Values.Reply);

    public static readonly AnnotationFileAttachmentReplyType Group = new(Values.Group);

    public AnnotationFileAttachmentReplyType(string value)
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
    public static AnnotationFileAttachmentReplyType FromCustom(string value)
    {
        return new AnnotationFileAttachmentReplyType(value);
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

    public static bool operator ==(AnnotationFileAttachmentReplyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationFileAttachmentReplyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationFileAttachmentReplyType value) => value.Value;

    public static explicit operator AnnotationFileAttachmentReplyType(string value) => new(value);

    internal class AnnotationFileAttachmentReplyTypeSerializer
        : JsonConverter<AnnotationFileAttachmentReplyType>
    {
        public override AnnotationFileAttachmentReplyType Read(
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
            return new AnnotationFileAttachmentReplyType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationFileAttachmentReplyType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationFileAttachmentReplyType ReadAsPropertyName(
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
            return new AnnotationFileAttachmentReplyType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationFileAttachmentReplyType value,
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
