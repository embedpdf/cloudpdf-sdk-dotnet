using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPolygonBlendMode.AnnotationPolygonBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationPolygonBlendMode : IStringEnum
{
    public static readonly AnnotationPolygonBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationPolygonBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationPolygonBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationPolygonBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationPolygonBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationPolygonBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationPolygonBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationPolygonBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationPolygonBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationPolygonBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationPolygonBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationPolygonBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationPolygonBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationPolygonBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationPolygonBlendMode Color = new(Values.Color);

    public static readonly AnnotationPolygonBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationPolygonBlendMode(string value)
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
    public static AnnotationPolygonBlendMode FromCustom(string value)
    {
        return new AnnotationPolygonBlendMode(value);
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

    public static bool operator ==(AnnotationPolygonBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPolygonBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPolygonBlendMode value) => value.Value;

    public static explicit operator AnnotationPolygonBlendMode(string value) => new(value);

    internal class AnnotationPolygonBlendModeSerializer : JsonConverter<AnnotationPolygonBlendMode>
    {
        public override AnnotationPolygonBlendMode Read(
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
            return new AnnotationPolygonBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPolygonBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPolygonBlendMode ReadAsPropertyName(
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
            return new AnnotationPolygonBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPolygonBlendMode value,
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
