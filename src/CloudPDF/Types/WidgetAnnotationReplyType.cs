using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(WidgetAnnotationReplyType.WidgetAnnotationReplyTypeSerializer))]
[Serializable]
public readonly record struct WidgetAnnotationReplyType : IStringEnum
{
    public static readonly WidgetAnnotationReplyType Reply = new(Values.Reply);

    public static readonly WidgetAnnotationReplyType Group = new(Values.Group);

    public WidgetAnnotationReplyType(string value)
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
    public static WidgetAnnotationReplyType FromCustom(string value)
    {
        return new WidgetAnnotationReplyType(value);
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

    public static bool operator ==(WidgetAnnotationReplyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WidgetAnnotationReplyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WidgetAnnotationReplyType value) => value.Value;

    public static explicit operator WidgetAnnotationReplyType(string value) => new(value);

    internal class WidgetAnnotationReplyTypeSerializer : JsonConverter<WidgetAnnotationReplyType>
    {
        public override WidgetAnnotationReplyType Read(
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
            return new WidgetAnnotationReplyType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WidgetAnnotationReplyType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WidgetAnnotationReplyType ReadAsPropertyName(
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
            return new WidgetAnnotationReplyType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WidgetAnnotationReplyType value,
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
