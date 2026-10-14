using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPolylineBlendMode.AnnotationPolylineBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationPolylineBlendMode : IStringEnum
{
    public static readonly AnnotationPolylineBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationPolylineBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationPolylineBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationPolylineBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationPolylineBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationPolylineBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationPolylineBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationPolylineBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationPolylineBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationPolylineBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationPolylineBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationPolylineBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationPolylineBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationPolylineBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationPolylineBlendMode Color = new(Values.Color);

    public static readonly AnnotationPolylineBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationPolylineBlendMode(string value)
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
    public static AnnotationPolylineBlendMode FromCustom(string value)
    {
        return new AnnotationPolylineBlendMode(value);
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

    public static bool operator ==(AnnotationPolylineBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPolylineBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPolylineBlendMode value) => value.Value;

    public static explicit operator AnnotationPolylineBlendMode(string value) => new(value);

    internal class AnnotationPolylineBlendModeSerializer
        : JsonConverter<AnnotationPolylineBlendMode>
    {
        public override AnnotationPolylineBlendMode Read(
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
            return new AnnotationPolylineBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPolylineBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPolylineBlendMode ReadAsPropertyName(
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
            return new AnnotationPolylineBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPolylineBlendMode value,
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
