using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationFileAttachmentIcon.AnnotationFileAttachmentIconSerializer))]
[Serializable]
public readonly record struct AnnotationFileAttachmentIcon : IStringEnum
{
    public static readonly AnnotationFileAttachmentIcon PushPin = new(Values.PushPin);

    public static readonly AnnotationFileAttachmentIcon Paperclip = new(Values.Paperclip);

    public static readonly AnnotationFileAttachmentIcon Graph = new(Values.Graph);

    public static readonly AnnotationFileAttachmentIcon Tag = new(Values.Tag);

    public AnnotationFileAttachmentIcon(string value)
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
    public static AnnotationFileAttachmentIcon FromCustom(string value)
    {
        return new AnnotationFileAttachmentIcon(value);
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

    public static bool operator ==(AnnotationFileAttachmentIcon value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationFileAttachmentIcon value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationFileAttachmentIcon value) => value.Value;

    public static explicit operator AnnotationFileAttachmentIcon(string value) => new(value);

    internal class AnnotationFileAttachmentIconSerializer
        : JsonConverter<AnnotationFileAttachmentIcon>
    {
        public override AnnotationFileAttachmentIcon Read(
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
            return new AnnotationFileAttachmentIcon(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationFileAttachmentIcon value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationFileAttachmentIcon ReadAsPropertyName(
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
            return new AnnotationFileAttachmentIcon(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationFileAttachmentIcon value,
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
