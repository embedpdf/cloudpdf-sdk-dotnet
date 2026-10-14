using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(WidgetAnnotationSubtype.WidgetAnnotationSubtypeSerializer))]
[Serializable]
public readonly record struct WidgetAnnotationSubtype : IStringEnum
{
    public static readonly WidgetAnnotationSubtype Widget = new(Values.Widget);

    public WidgetAnnotationSubtype(string value)
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
    public static WidgetAnnotationSubtype FromCustom(string value)
    {
        return new WidgetAnnotationSubtype(value);
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

    public static bool operator ==(WidgetAnnotationSubtype value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WidgetAnnotationSubtype value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WidgetAnnotationSubtype value) => value.Value;

    public static explicit operator WidgetAnnotationSubtype(string value) => new(value);

    internal class WidgetAnnotationSubtypeSerializer : JsonConverter<WidgetAnnotationSubtype>
    {
        public override WidgetAnnotationSubtype Read(
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
            return new WidgetAnnotationSubtype(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WidgetAnnotationSubtype value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WidgetAnnotationSubtype ReadAsPropertyName(
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
            return new WidgetAnnotationSubtype(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WidgetAnnotationSubtype value,
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
        public const string Widget = "widget";
    }
}
