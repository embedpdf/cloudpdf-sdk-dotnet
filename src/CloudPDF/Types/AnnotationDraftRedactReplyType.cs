using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftRedactReplyType.AnnotationDraftRedactReplyTypeSerializer))]
[Serializable]
public readonly record struct AnnotationDraftRedactReplyType : IStringEnum
{
    public static readonly AnnotationDraftRedactReplyType Reply = new(Values.Reply);

    public static readonly AnnotationDraftRedactReplyType Group = new(Values.Group);

    public AnnotationDraftRedactReplyType(string value)
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
    public static AnnotationDraftRedactReplyType FromCustom(string value)
    {
        return new AnnotationDraftRedactReplyType(value);
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

    public static bool operator ==(AnnotationDraftRedactReplyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftRedactReplyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftRedactReplyType value) => value.Value;

    public static explicit operator AnnotationDraftRedactReplyType(string value) => new(value);

    internal class AnnotationDraftRedactReplyTypeSerializer
        : JsonConverter<AnnotationDraftRedactReplyType>
    {
        public override AnnotationDraftRedactReplyType Read(
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
            return new AnnotationDraftRedactReplyType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftRedactReplyType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftRedactReplyType ReadAsPropertyName(
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
            return new AnnotationDraftRedactReplyType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftRedactReplyType value,
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
