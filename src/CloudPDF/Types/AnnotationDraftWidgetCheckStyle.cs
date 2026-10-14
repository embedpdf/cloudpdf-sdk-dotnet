using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftWidgetCheckStyle.AnnotationDraftWidgetCheckStyleSerializer))]
[Serializable]
public readonly record struct AnnotationDraftWidgetCheckStyle : IStringEnum
{
    public static readonly AnnotationDraftWidgetCheckStyle Check = new(Values.Check);

    public static readonly AnnotationDraftWidgetCheckStyle Cross = new(Values.Cross);

    public static readonly AnnotationDraftWidgetCheckStyle Star = new(Values.Star);

    public static readonly AnnotationDraftWidgetCheckStyle Circle = new(Values.Circle);

    public static readonly AnnotationDraftWidgetCheckStyle Square = new(Values.Square);

    public static readonly AnnotationDraftWidgetCheckStyle Diamond = new(Values.Diamond);

    public AnnotationDraftWidgetCheckStyle(string value)
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
    public static AnnotationDraftWidgetCheckStyle FromCustom(string value)
    {
        return new AnnotationDraftWidgetCheckStyle(value);
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

    public static bool operator ==(AnnotationDraftWidgetCheckStyle value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftWidgetCheckStyle value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftWidgetCheckStyle value) => value.Value;

    public static explicit operator AnnotationDraftWidgetCheckStyle(string value) => new(value);

    internal class AnnotationDraftWidgetCheckStyleSerializer
        : JsonConverter<AnnotationDraftWidgetCheckStyle>
    {
        public override AnnotationDraftWidgetCheckStyle Read(
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
            return new AnnotationDraftWidgetCheckStyle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftWidgetCheckStyle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftWidgetCheckStyle ReadAsPropertyName(
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
            return new AnnotationDraftWidgetCheckStyle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftWidgetCheckStyle value,
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
