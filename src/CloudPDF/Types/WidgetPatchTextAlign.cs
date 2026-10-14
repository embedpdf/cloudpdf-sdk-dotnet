using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(WidgetPatchTextAlign.WidgetPatchTextAlignSerializer))]
[Serializable]
public readonly record struct WidgetPatchTextAlign : IStringEnum
{
    public static readonly WidgetPatchTextAlign Left = new(Values.Left);

    public static readonly WidgetPatchTextAlign Center = new(Values.Center);

    public static readonly WidgetPatchTextAlign Right = new(Values.Right);

    public WidgetPatchTextAlign(string value)
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
    public static WidgetPatchTextAlign FromCustom(string value)
    {
        return new WidgetPatchTextAlign(value);
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

    public static bool operator ==(WidgetPatchTextAlign value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WidgetPatchTextAlign value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WidgetPatchTextAlign value) => value.Value;

    public static explicit operator WidgetPatchTextAlign(string value) => new(value);

    internal class WidgetPatchTextAlignSerializer : JsonConverter<WidgetPatchTextAlign>
    {
        public override WidgetPatchTextAlign Read(
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
            return new WidgetPatchTextAlign(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WidgetPatchTextAlign value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WidgetPatchTextAlign ReadAsPropertyName(
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
            return new WidgetPatchTextAlign(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WidgetPatchTextAlign value,
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
