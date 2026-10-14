using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationDraftFileAttachmentReplyType.AnnotationDraftFileAttachmentReplyTypeSerializer)
)]
[Serializable]
public readonly record struct AnnotationDraftFileAttachmentReplyType : IStringEnum
{
    public static readonly AnnotationDraftFileAttachmentReplyType Reply = new(Values.Reply);

    public static readonly AnnotationDraftFileAttachmentReplyType Group = new(Values.Group);

    public AnnotationDraftFileAttachmentReplyType(string value)
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
    public static AnnotationDraftFileAttachmentReplyType FromCustom(string value)
    {
        return new AnnotationDraftFileAttachmentReplyType(value);
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

    public static bool operator ==(AnnotationDraftFileAttachmentReplyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftFileAttachmentReplyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftFileAttachmentReplyType value) =>
        value.Value;

    public static explicit operator AnnotationDraftFileAttachmentReplyType(string value) =>
        new(value);

    internal class AnnotationDraftFileAttachmentReplyTypeSerializer
        : JsonConverter<AnnotationDraftFileAttachmentReplyType>
    {
        public override AnnotationDraftFileAttachmentReplyType Read(
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
            return new AnnotationDraftFileAttachmentReplyType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftFileAttachmentReplyType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftFileAttachmentReplyType ReadAsPropertyName(
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
            return new AnnotationDraftFileAttachmentReplyType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftFileAttachmentReplyType value,
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
