using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchUnderlineReplyType.AnnotationPatchUnderlineReplyTypeSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchUnderlineReplyType : IStringEnum
{
    public static readonly AnnotationPatchUnderlineReplyType Reply = new(Values.Reply);

    public static readonly AnnotationPatchUnderlineReplyType Group = new(Values.Group);

    public AnnotationPatchUnderlineReplyType(string value)
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
    public static AnnotationPatchUnderlineReplyType FromCustom(string value)
    {
        return new AnnotationPatchUnderlineReplyType(value);
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

    public static bool operator ==(AnnotationPatchUnderlineReplyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchUnderlineReplyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchUnderlineReplyType value) => value.Value;

    public static explicit operator AnnotationPatchUnderlineReplyType(string value) => new(value);

    internal class AnnotationPatchUnderlineReplyTypeSerializer
        : JsonConverter<AnnotationPatchUnderlineReplyType>
    {
        public override AnnotationPatchUnderlineReplyType Read(
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
            return new AnnotationPatchUnderlineReplyType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchUnderlineReplyType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchUnderlineReplyType ReadAsPropertyName(
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
            return new AnnotationPatchUnderlineReplyType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchUnderlineReplyType value,
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
