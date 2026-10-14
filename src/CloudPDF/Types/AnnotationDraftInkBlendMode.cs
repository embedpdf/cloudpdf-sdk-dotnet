using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftInkBlendMode.AnnotationDraftInkBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationDraftInkBlendMode : IStringEnum
{
    public static readonly AnnotationDraftInkBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationDraftInkBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationDraftInkBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationDraftInkBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationDraftInkBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationDraftInkBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationDraftInkBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationDraftInkBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationDraftInkBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationDraftInkBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationDraftInkBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationDraftInkBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationDraftInkBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationDraftInkBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationDraftInkBlendMode Color = new(Values.Color);

    public static readonly AnnotationDraftInkBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationDraftInkBlendMode(string value)
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
    public static AnnotationDraftInkBlendMode FromCustom(string value)
    {
        return new AnnotationDraftInkBlendMode(value);
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

    public static bool operator ==(AnnotationDraftInkBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftInkBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftInkBlendMode value) => value.Value;

    public static explicit operator AnnotationDraftInkBlendMode(string value) => new(value);

    internal class AnnotationDraftInkBlendModeSerializer
        : JsonConverter<AnnotationDraftInkBlendMode>
    {
        public override AnnotationDraftInkBlendMode Read(
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
            return new AnnotationDraftInkBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftInkBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftInkBlendMode ReadAsPropertyName(
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
            return new AnnotationDraftInkBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftInkBlendMode value,
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
