using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationDraftUnderlineBlendMode.AnnotationDraftUnderlineBlendModeSerializer)
)]
[Serializable]
public readonly record struct AnnotationDraftUnderlineBlendMode : IStringEnum
{
    public static readonly AnnotationDraftUnderlineBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationDraftUnderlineBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationDraftUnderlineBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationDraftUnderlineBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationDraftUnderlineBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationDraftUnderlineBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationDraftUnderlineBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationDraftUnderlineBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationDraftUnderlineBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationDraftUnderlineBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationDraftUnderlineBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationDraftUnderlineBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationDraftUnderlineBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationDraftUnderlineBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationDraftUnderlineBlendMode Color = new(Values.Color);

    public static readonly AnnotationDraftUnderlineBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationDraftUnderlineBlendMode(string value)
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
    public static AnnotationDraftUnderlineBlendMode FromCustom(string value)
    {
        return new AnnotationDraftUnderlineBlendMode(value);
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

    public static bool operator ==(AnnotationDraftUnderlineBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftUnderlineBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftUnderlineBlendMode value) => value.Value;

    public static explicit operator AnnotationDraftUnderlineBlendMode(string value) => new(value);

    internal class AnnotationDraftUnderlineBlendModeSerializer
        : JsonConverter<AnnotationDraftUnderlineBlendMode>
    {
        public override AnnotationDraftUnderlineBlendMode Read(
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
            return new AnnotationDraftUnderlineBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftUnderlineBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftUnderlineBlendMode ReadAsPropertyName(
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
            return new AnnotationDraftUnderlineBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftUnderlineBlendMode value,
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
