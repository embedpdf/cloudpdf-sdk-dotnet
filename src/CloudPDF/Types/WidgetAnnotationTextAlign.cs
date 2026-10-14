using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(WidgetAnnotationTextAlign.WidgetAnnotationTextAlignSerializer))]
[Serializable]
public readonly record struct WidgetAnnotationTextAlign : IStringEnum
{
    public static readonly WidgetAnnotationTextAlign Left = new(Values.Left);

    public static readonly WidgetAnnotationTextAlign Center = new(Values.Center);

    public static readonly WidgetAnnotationTextAlign Right = new(Values.Right);

    public WidgetAnnotationTextAlign(string value)
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
    public static WidgetAnnotationTextAlign FromCustom(string value)
    {
        return new WidgetAnnotationTextAlign(value);
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

    public static bool operator ==(WidgetAnnotationTextAlign value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WidgetAnnotationTextAlign value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WidgetAnnotationTextAlign value) => value.Value;

    public static explicit operator WidgetAnnotationTextAlign(string value) => new(value);

    internal class WidgetAnnotationTextAlignSerializer : JsonConverter<WidgetAnnotationTextAlign>
    {
        public override WidgetAnnotationTextAlign Read(
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
            return new WidgetAnnotationTextAlign(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WidgetAnnotationTextAlign value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WidgetAnnotationTextAlign ReadAsPropertyName(
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
            return new WidgetAnnotationTextAlign(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WidgetAnnotationTextAlign value,
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
