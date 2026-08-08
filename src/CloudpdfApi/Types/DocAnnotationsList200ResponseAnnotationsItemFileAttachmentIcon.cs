using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemFileAttachmentIcon.DocAnnotationsList200ResponseAnnotationsItemFileAttachmentIconSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemFileAttachmentIcon
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemFileAttachmentIcon PushPin =
        new(Values.PushPin);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemFileAttachmentIcon Paperclip =
        new(Values.Paperclip);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemFileAttachmentIcon Graph =
        new(Values.Graph);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemFileAttachmentIcon Tag = new(
        Values.Tag
    );

    public DocAnnotationsList200ResponseAnnotationsItemFileAttachmentIcon(string value)
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
    public static DocAnnotationsList200ResponseAnnotationsItemFileAttachmentIcon FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemFileAttachmentIcon(value);
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
        DocAnnotationsList200ResponseAnnotationsItemFileAttachmentIcon value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemFileAttachmentIcon value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemFileAttachmentIcon value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemFileAttachmentIcon(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemFileAttachmentIconSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemFileAttachmentIcon>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemFileAttachmentIcon Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemFileAttachmentIcon(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemFileAttachmentIcon value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemFileAttachmentIcon ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemFileAttachmentIcon(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemFileAttachmentIcon value,
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
