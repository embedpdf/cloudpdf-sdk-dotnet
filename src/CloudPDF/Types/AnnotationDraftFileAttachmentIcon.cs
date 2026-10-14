using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationDraftFileAttachmentIcon.AnnotationDraftFileAttachmentIconSerializer)
)]
[Serializable]
public readonly record struct AnnotationDraftFileAttachmentIcon : IStringEnum
{
    public static readonly AnnotationDraftFileAttachmentIcon PushPin = new(Values.PushPin);

    public static readonly AnnotationDraftFileAttachmentIcon Paperclip = new(Values.Paperclip);

    public static readonly AnnotationDraftFileAttachmentIcon Graph = new(Values.Graph);

    public static readonly AnnotationDraftFileAttachmentIcon Tag = new(Values.Tag);

    public AnnotationDraftFileAttachmentIcon(string value)
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
    public static AnnotationDraftFileAttachmentIcon FromCustom(string value)
    {
        return new AnnotationDraftFileAttachmentIcon(value);
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

    public static bool operator ==(AnnotationDraftFileAttachmentIcon value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftFileAttachmentIcon value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftFileAttachmentIcon value) => value.Value;

    public static explicit operator AnnotationDraftFileAttachmentIcon(string value) => new(value);

    internal class AnnotationDraftFileAttachmentIconSerializer
        : JsonConverter<AnnotationDraftFileAttachmentIcon>
    {
        public override AnnotationDraftFileAttachmentIcon Read(
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
            return new AnnotationDraftFileAttachmentIcon(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftFileAttachmentIcon value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftFileAttachmentIcon ReadAsPropertyName(
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
            return new AnnotationDraftFileAttachmentIcon(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftFileAttachmentIcon value,
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
        public const string PushPin = "push-pin";

        public const string Paperclip = "paperclip";

        public const string Graph = "graph";

        public const string Tag = "tag";
    }
}
