using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(WidgetPlacementCheckStyle.WidgetPlacementCheckStyleSerializer))]
[Serializable]
public readonly record struct WidgetPlacementCheckStyle : IStringEnum
{
    public static readonly WidgetPlacementCheckStyle Check = new(Values.Check);

    public static readonly WidgetPlacementCheckStyle Cross = new(Values.Cross);

    public static readonly WidgetPlacementCheckStyle Star = new(Values.Star);

    public static readonly WidgetPlacementCheckStyle Circle = new(Values.Circle);

    public static readonly WidgetPlacementCheckStyle Square = new(Values.Square);

    public static readonly WidgetPlacementCheckStyle Diamond = new(Values.Diamond);

    public WidgetPlacementCheckStyle(string value)
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
    public static WidgetPlacementCheckStyle FromCustom(string value)
    {
        return new WidgetPlacementCheckStyle(value);
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

    public static bool operator ==(WidgetPlacementCheckStyle value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WidgetPlacementCheckStyle value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WidgetPlacementCheckStyle value) => value.Value;

    public static explicit operator WidgetPlacementCheckStyle(string value) => new(value);

    internal class WidgetPlacementCheckStyleSerializer : JsonConverter<WidgetPlacementCheckStyle>
    {
        public override WidgetPlacementCheckStyle Read(
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
            return new WidgetPlacementCheckStyle(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WidgetPlacementCheckStyle value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WidgetPlacementCheckStyle ReadAsPropertyName(
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
            return new WidgetPlacementCheckStyle(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WidgetPlacementCheckStyle value,
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
