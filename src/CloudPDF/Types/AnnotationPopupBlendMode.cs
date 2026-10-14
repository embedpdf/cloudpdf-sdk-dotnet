using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationPopupBlendMode.AnnotationPopupBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationPopupBlendMode : IStringEnum
{
    public static readonly AnnotationPopupBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationPopupBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationPopupBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationPopupBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationPopupBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationPopupBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationPopupBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationPopupBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationPopupBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationPopupBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationPopupBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationPopupBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationPopupBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationPopupBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationPopupBlendMode Color = new(Values.Color);

    public static readonly AnnotationPopupBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationPopupBlendMode(string value)
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
    public static AnnotationPopupBlendMode FromCustom(string value)
    {
        return new AnnotationPopupBlendMode(value);
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

    public static bool operator ==(AnnotationPopupBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPopupBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPopupBlendMode value) => value.Value;

    public static explicit operator AnnotationPopupBlendMode(string value) => new(value);

    internal class AnnotationPopupBlendModeSerializer : JsonConverter<AnnotationPopupBlendMode>
    {
        public override AnnotationPopupBlendMode Read(
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
            return new AnnotationPopupBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPopupBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPopupBlendMode ReadAsPropertyName(
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
            return new AnnotationPopupBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPopupBlendMode value,
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
