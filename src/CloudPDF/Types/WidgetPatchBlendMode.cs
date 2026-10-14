using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(WidgetPatchBlendMode.WidgetPatchBlendModeSerializer))]
[Serializable]
public readonly record struct WidgetPatchBlendMode : IStringEnum
{
    public static readonly WidgetPatchBlendMode Normal = new(Values.Normal);

    public static readonly WidgetPatchBlendMode Multiply = new(Values.Multiply);

    public static readonly WidgetPatchBlendMode Screen = new(Values.Screen);

    public static readonly WidgetPatchBlendMode Overlay = new(Values.Overlay);

    public static readonly WidgetPatchBlendMode Darken = new(Values.Darken);

    public static readonly WidgetPatchBlendMode Lighten = new(Values.Lighten);

    public static readonly WidgetPatchBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly WidgetPatchBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly WidgetPatchBlendMode HardLight = new(Values.HardLight);

    public static readonly WidgetPatchBlendMode SoftLight = new(Values.SoftLight);

    public static readonly WidgetPatchBlendMode Difference = new(Values.Difference);

    public static readonly WidgetPatchBlendMode Exclusion = new(Values.Exclusion);

    public static readonly WidgetPatchBlendMode Hue = new(Values.Hue);

    public static readonly WidgetPatchBlendMode Saturation = new(Values.Saturation);

    public static readonly WidgetPatchBlendMode Color = new(Values.Color);

    public static readonly WidgetPatchBlendMode Luminosity = new(Values.Luminosity);

    public WidgetPatchBlendMode(string value)
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
    public static WidgetPatchBlendMode FromCustom(string value)
    {
        return new WidgetPatchBlendMode(value);
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

    public static bool operator ==(WidgetPatchBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(WidgetPatchBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(WidgetPatchBlendMode value) => value.Value;

    public static explicit operator WidgetPatchBlendMode(string value) => new(value);

    internal class WidgetPatchBlendModeSerializer : JsonConverter<WidgetPatchBlendMode>
    {
        public override WidgetPatchBlendMode Read(
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
            return new WidgetPatchBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            WidgetPatchBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override WidgetPatchBlendMode ReadAsPropertyName(
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
            return new WidgetPatchBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            WidgetPatchBlendMode value,
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
        public const string Normal = "normal";

        public const string Multiply = "multiply";

        public const string Screen = "screen";

        public const string Overlay = "overlay";

        public const string Darken = "darken";

        public const string Lighten = "lighten";

        public const string ColorDodge = "color-dodge";

        public const string ColorBurn = "color-burn";

        public const string HardLight = "hard-light";

        public const string SoftLight = "soft-light";

        public const string Difference = "difference";

        public const string Exclusion = "exclusion";

        public const string Hue = "hue";

        public const string Saturation = "saturation";

        public const string Color = "color";

        public const string Luminosity = "luminosity";
    }
}
