using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPatchRedactReplyType.AnnotationPatchRedactReplyTypeSerializer))]
[Serializable]
public readonly record struct AnnotationPatchRedactReplyType : IStringEnum
{
    public static readonly AnnotationPatchRedactReplyType Reply = new(Values.Reply);

    public static readonly AnnotationPatchRedactReplyType Group = new(Values.Group);

    public AnnotationPatchRedactReplyType(string value)
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
    public static AnnotationPatchRedactReplyType FromCustom(string value)
    {
        return new AnnotationPatchRedactReplyType(value);
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

    public static bool operator ==(AnnotationPatchRedactReplyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchRedactReplyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchRedactReplyType value) => value.Value;

    public static explicit operator AnnotationPatchRedactReplyType(string value) => new(value);

    internal class AnnotationPatchRedactReplyTypeSerializer
        : JsonConverter<AnnotationPatchRedactReplyType>
    {
        public override AnnotationPatchRedactReplyType Read(
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
            return new AnnotationPatchRedactReplyType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchRedactReplyType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchRedactReplyType ReadAsPropertyName(
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
            return new AnnotationPatchRedactReplyType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchRedactReplyType value,
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
