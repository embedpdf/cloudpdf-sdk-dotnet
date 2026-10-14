using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(WidgetAnnotationCheckStyle.WidgetAnnotationCheckStyleSerializer))]
[Serializable]
public readonly record struct WidgetAnnotationCheckStyle : IStringEnum
{
    public static readonly WidgetAnnotationCheckStyle Check = new(Values.Check);

    public static readonly WidgetAnnotationCheckStyle Cross = new(Values.Cross);

    public static readonly WidgetAnnotationCheckStyle Star = new(Values.Star);

    public static readonly WidgetAnnotationCheckStyle Circle = new(Values.Circle);

    public static readonly WidgetAnnotationCheckStyle Square = new(Values.Square);

    public static readonly WidgetAnnotationCheckStyle Diamond = new(Values.Diamond);

    public WidgetAnnotationCheckStyle(string value)
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
    public static WidgetAnnotationCheckStyle FromCustom(string value)
    {
        return new WidgetAnnotationCheckStyle(value);
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

    public static bool operator ==(WidgetAnnotationCheckStyle value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WidgetAnnotationCheckStyle value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WidgetAnnotationCheckStyle value) => value.Value;

    public static explicit operator WidgetAnnotationCheckStyle(string value) => new(value);

    internal class WidgetAnnotationCheckStyleSerializer : JsonConverter<WidgetAnnotationCheckStyle>
    {
        public override WidgetAnnotationCheckStyle Read(
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
            return new WidgetAnnotationCheckStyle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WidgetAnnotationCheckStyle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WidgetAnnotationCheckStyle ReadAsPropertyName(
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
            return new WidgetAnnotationCheckStyle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WidgetAnnotationCheckStyle value,
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
        public const string Check = "check";

        public const string Cross = "cross";

        public const string Star = "star";

        public const string Circle = "circle";

        public const string Square = "square";

        public const string Diamond = "diamond";
    }
}
