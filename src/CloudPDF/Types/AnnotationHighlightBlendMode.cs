using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationHighlightBlendMode.AnnotationHighlightBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationHighlightBlendMode : IStringEnum
{
    public static readonly AnnotationHighlightBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationHighlightBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationHighlightBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationHighlightBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationHighlightBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationHighlightBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationHighlightBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationHighlightBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationHighlightBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationHighlightBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationHighlightBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationHighlightBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationHighlightBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationHighlightBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationHighlightBlendMode Color = new(Values.Color);

    public static readonly AnnotationHighlightBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationHighlightBlendMode(string value)
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
    public static AnnotationHighlightBlendMode FromCustom(string value)
    {
        return new AnnotationHighlightBlendMode(value);
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

    public static bool operator ==(AnnotationHighlightBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationHighlightBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationHighlightBlendMode value) => value.Value;

    public static explicit operator AnnotationHighlightBlendMode(string value) => new(value);

    internal class AnnotationHighlightBlendModeSerializer
        : JsonConverter<AnnotationHighlightBlendMode>
    {
        public override AnnotationHighlightBlendMode Read(
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
            return new AnnotationHighlightBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationHighlightBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationHighlightBlendMode ReadAsPropertyName(
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
            return new AnnotationHighlightBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationHighlightBlendMode value,
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
