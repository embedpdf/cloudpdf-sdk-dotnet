using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(WidgetPatchCheckStyle.WidgetPatchCheckStyleSerializer))]
[Serializable]
public readonly record struct WidgetPatchCheckStyle : IStringEnum
{
    public static readonly WidgetPatchCheckStyle Check = new(Values.Check);

    public static readonly WidgetPatchCheckStyle Cross = new(Values.Cross);

    public static readonly WidgetPatchCheckStyle Star = new(Values.Star);

    public static readonly WidgetPatchCheckStyle Circle = new(Values.Circle);

    public static readonly WidgetPatchCheckStyle Square = new(Values.Square);

    public static readonly WidgetPatchCheckStyle Diamond = new(Values.Diamond);

    public WidgetPatchCheckStyle(string value)
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
    public static WidgetPatchCheckStyle FromCustom(string value)
    {
        return new WidgetPatchCheckStyle(value);
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

    public static bool operator ==(WidgetPatchCheckStyle value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WidgetPatchCheckStyle value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WidgetPatchCheckStyle value) => value.Value;

    public static explicit operator WidgetPatchCheckStyle(string value) => new(value);

    internal class WidgetPatchCheckStyleSerializer : JsonConverter<WidgetPatchCheckStyle>
    {
        public override WidgetPatchCheckStyle Read(
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
            return new WidgetPatchCheckStyle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WidgetPatchCheckStyle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WidgetPatchCheckStyle ReadAsPropertyName(
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
            return new WidgetPatchCheckStyle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WidgetPatchCheckStyle value,
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
