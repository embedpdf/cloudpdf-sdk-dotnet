using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationSquareBlendMode.AnnotationSquareBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationSquareBlendMode : IStringEnum
{
    public static readonly AnnotationSquareBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationSquareBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationSquareBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationSquareBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationSquareBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationSquareBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationSquareBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationSquareBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationSquareBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationSquareBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationSquareBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationSquareBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationSquareBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationSquareBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationSquareBlendMode Color = new(Values.Color);

    public static readonly AnnotationSquareBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationSquareBlendMode(string value)
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
    public static AnnotationSquareBlendMode FromCustom(string value)
    {
        return new AnnotationSquareBlendMode(value);
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

    public static bool operator ==(AnnotationSquareBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationSquareBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationSquareBlendMode value) => value.Value;

    public static explicit operator AnnotationSquareBlendMode(string value) => new(value);

    internal class AnnotationSquareBlendModeSerializer : JsonConverter<AnnotationSquareBlendMode>
    {
        public override AnnotationSquareBlendMode Read(
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
            return new AnnotationSquareBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationSquareBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationSquareBlendMode ReadAsPropertyName(
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
            return new AnnotationSquareBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationSquareBlendMode value,
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
