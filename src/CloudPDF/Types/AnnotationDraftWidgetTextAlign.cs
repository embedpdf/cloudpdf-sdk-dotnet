using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftWidgetTextAlign.AnnotationDraftWidgetTextAlignSerializer))]
[Serializable]
public readonly record struct AnnotationDraftWidgetTextAlign : IStringEnum
{
    public static readonly AnnotationDraftWidgetTextAlign Left = new(Values.Left);

    public static readonly AnnotationDraftWidgetTextAlign Center = new(Values.Center);

    public static readonly AnnotationDraftWidgetTextAlign Right = new(Values.Right);

    public AnnotationDraftWidgetTextAlign(string value)
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
    public static AnnotationDraftWidgetTextAlign FromCustom(string value)
    {
        return new AnnotationDraftWidgetTextAlign(value);
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

    public static bool operator ==(AnnotationDraftWidgetTextAlign value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftWidgetTextAlign value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftWidgetTextAlign value) => value.Value;

    public static explicit operator AnnotationDraftWidgetTextAlign(string value) => new(value);

    internal class AnnotationDraftWidgetTextAlignSerializer
        : JsonConverter<AnnotationDraftWidgetTextAlign>
    {
        public override AnnotationDraftWidgetTextAlign Read(
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
            return new AnnotationDraftWidgetTextAlign(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftWidgetTextAlign value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftWidgetTextAlign ReadAsPropertyName(
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
            return new AnnotationDraftWidgetTextAlign(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftWidgetTextAlign value,
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
        public const string Left = "left";

        public const string Center = "center";

        public const string Right = "right";
    }
}
