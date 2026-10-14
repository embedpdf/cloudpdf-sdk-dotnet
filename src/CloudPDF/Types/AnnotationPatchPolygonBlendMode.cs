using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPatchPolygonBlendMode.AnnotationPatchPolygonBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationPatchPolygonBlendMode : IStringEnum
{
    public static readonly AnnotationPatchPolygonBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationPatchPolygonBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationPatchPolygonBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationPatchPolygonBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationPatchPolygonBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationPatchPolygonBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationPatchPolygonBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationPatchPolygonBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationPatchPolygonBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationPatchPolygonBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationPatchPolygonBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationPatchPolygonBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationPatchPolygonBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationPatchPolygonBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationPatchPolygonBlendMode Color = new(Values.Color);

    public static readonly AnnotationPatchPolygonBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationPatchPolygonBlendMode(string value)
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
    public static AnnotationPatchPolygonBlendMode FromCustom(string value)
    {
        return new AnnotationPatchPolygonBlendMode(value);
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

    public static bool operator ==(AnnotationPatchPolygonBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchPolygonBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchPolygonBlendMode value) => value.Value;

    public static explicit operator AnnotationPatchPolygonBlendMode(string value) => new(value);

    internal class AnnotationPatchPolygonBlendModeSerializer
        : JsonConverter<AnnotationPatchPolygonBlendMode>
    {
        public override AnnotationPatchPolygonBlendMode Read(
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
            return new AnnotationPatchPolygonBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchPolygonBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchPolygonBlendMode ReadAsPropertyName(
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
            return new AnnotationPatchPolygonBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchPolygonBlendMode value,
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
