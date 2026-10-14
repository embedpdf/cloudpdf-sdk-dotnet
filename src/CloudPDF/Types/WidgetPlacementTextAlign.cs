using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(WidgetPlacementTextAlign.WidgetPlacementTextAlignSerializer))]
[Serializable]
public readonly record struct WidgetPlacementTextAlign : IStringEnum
{
    public static readonly WidgetPlacementTextAlign Left = new(Values.Left);

    public static readonly WidgetPlacementTextAlign Center = new(Values.Center);

    public static readonly WidgetPlacementTextAlign Right = new(Values.Right);

    public WidgetPlacementTextAlign(string value)
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
    public static WidgetPlacementTextAlign FromCustom(string value)
    {
        return new WidgetPlacementTextAlign(value);
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

    public static bool operator ==(WidgetPlacementTextAlign value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WidgetPlacementTextAlign value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WidgetPlacementTextAlign value) => value.Value;

    public static explicit operator WidgetPlacementTextAlign(string value) => new(value);

    internal class WidgetPlacementTextAlignSerializer : JsonConverter<WidgetPlacementTextAlign>
    {
        public override WidgetPlacementTextAlign Read(
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
            return new WidgetPlacementTextAlign(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WidgetPlacementTextAlign value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WidgetPlacementTextAlign ReadAsPropertyName(
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
            return new WidgetPlacementTextAlign(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WidgetPlacementTextAlign value,
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
