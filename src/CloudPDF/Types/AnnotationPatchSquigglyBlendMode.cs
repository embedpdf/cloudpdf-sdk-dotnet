using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPatchSquigglyBlendMode.AnnotationPatchSquigglyBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationPatchSquigglyBlendMode : IStringEnum
{
    public static readonly AnnotationPatchSquigglyBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationPatchSquigglyBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationPatchSquigglyBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationPatchSquigglyBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationPatchSquigglyBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationPatchSquigglyBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationPatchSquigglyBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationPatchSquigglyBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationPatchSquigglyBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationPatchSquigglyBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationPatchSquigglyBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationPatchSquigglyBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationPatchSquigglyBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationPatchSquigglyBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationPatchSquigglyBlendMode Color = new(Values.Color);

    public static readonly AnnotationPatchSquigglyBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationPatchSquigglyBlendMode(string value)
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
    public static AnnotationPatchSquigglyBlendMode FromCustom(string value)
    {
        return new AnnotationPatchSquigglyBlendMode(value);
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

    public static bool operator ==(AnnotationPatchSquigglyBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchSquigglyBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchSquigglyBlendMode value) => value.Value;

    public static explicit operator AnnotationPatchSquigglyBlendMode(string value) => new(value);

    internal class AnnotationPatchSquigglyBlendModeSerializer
        : JsonConverter<AnnotationPatchSquigglyBlendMode>
    {
        public override AnnotationPatchSquigglyBlendMode Read(
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
            return new AnnotationPatchSquigglyBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchSquigglyBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchSquigglyBlendMode ReadAsPropertyName(
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
            return new AnnotationPatchSquigglyBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchSquigglyBlendMode value,
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
