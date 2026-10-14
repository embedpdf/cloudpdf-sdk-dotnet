using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPatchPolylineBlendMode.AnnotationPatchPolylineBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationPatchPolylineBlendMode : IStringEnum
{
    public static readonly AnnotationPatchPolylineBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationPatchPolylineBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationPatchPolylineBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationPatchPolylineBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationPatchPolylineBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationPatchPolylineBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationPatchPolylineBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationPatchPolylineBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationPatchPolylineBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationPatchPolylineBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationPatchPolylineBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationPatchPolylineBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationPatchPolylineBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationPatchPolylineBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationPatchPolylineBlendMode Color = new(Values.Color);

    public static readonly AnnotationPatchPolylineBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationPatchPolylineBlendMode(string value)
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
    public static AnnotationPatchPolylineBlendMode FromCustom(string value)
    {
        return new AnnotationPatchPolylineBlendMode(value);
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

    public static bool operator ==(AnnotationPatchPolylineBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchPolylineBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchPolylineBlendMode value) => value.Value;

    public static explicit operator AnnotationPatchPolylineBlendMode(string value) => new(value);

    internal class AnnotationPatchPolylineBlendModeSerializer
        : JsonConverter<AnnotationPatchPolylineBlendMode>
    {
        public override AnnotationPatchPolylineBlendMode Read(
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
            return new AnnotationPatchPolylineBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchPolylineBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchPolylineBlendMode ReadAsPropertyName(
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
            return new AnnotationPatchPolylineBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchPolylineBlendMode value,
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
