using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationCaretBlendMode.AnnotationCaretBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationCaretBlendMode : IStringEnum
{
    public static readonly AnnotationCaretBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationCaretBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationCaretBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationCaretBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationCaretBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationCaretBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationCaretBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationCaretBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationCaretBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationCaretBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationCaretBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationCaretBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationCaretBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationCaretBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationCaretBlendMode Color = new(Values.Color);

    public static readonly AnnotationCaretBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationCaretBlendMode(string value)
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
    public static AnnotationCaretBlendMode FromCustom(string value)
    {
        return new AnnotationCaretBlendMode(value);
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

    public static bool operator ==(AnnotationCaretBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationCaretBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationCaretBlendMode value) => value.Value;

    public static explicit operator AnnotationCaretBlendMode(string value) => new(value);

    internal class AnnotationCaretBlendModeSerializer : JsonConverter<AnnotationCaretBlendMode>
    {
        public override AnnotationCaretBlendMode Read(
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
            return new AnnotationCaretBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationCaretBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationCaretBlendMode ReadAsPropertyName(
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
            return new AnnotationCaretBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationCaretBlendMode value,
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
