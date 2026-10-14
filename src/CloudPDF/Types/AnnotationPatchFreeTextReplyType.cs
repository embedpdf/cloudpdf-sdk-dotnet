using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPatchFreeTextReplyType.AnnotationPatchFreeTextReplyTypeSerializer))]
[Serializable]
public readonly record struct AnnotationPatchFreeTextReplyType : IStringEnum
{
    public static readonly AnnotationPatchFreeTextReplyType Reply = new(Values.Reply);

    public static readonly AnnotationPatchFreeTextReplyType Group = new(Values.Group);

    public AnnotationPatchFreeTextReplyType(string value)
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
    public static AnnotationPatchFreeTextReplyType FromCustom(string value)
    {
        return new AnnotationPatchFreeTextReplyType(value);
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

    public static bool operator ==(AnnotationPatchFreeTextReplyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchFreeTextReplyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchFreeTextReplyType value) => value.Value;

    public static explicit operator AnnotationPatchFreeTextReplyType(string value) => new(value);

    internal class AnnotationPatchFreeTextReplyTypeSerializer
        : JsonConverter<AnnotationPatchFreeTextReplyType>
    {
        public override AnnotationPatchFreeTextReplyType Read(
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
            return new AnnotationPatchFreeTextReplyType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchFreeTextReplyType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchFreeTextReplyType ReadAsPropertyName(
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
            return new AnnotationPatchFreeTextReplyType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchFreeTextReplyType value,
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
