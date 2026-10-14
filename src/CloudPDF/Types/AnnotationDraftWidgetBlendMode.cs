using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(AnnotationDraftWidgetBlendMode.AnnotationDraftWidgetBlendModeSerializer))]
[Serializable]
public readonly record struct AnnotationDraftWidgetBlendMode : IStringEnum
{
    public static readonly AnnotationDraftWidgetBlendMode Normal = new(Values.Normal);

    public static readonly AnnotationDraftWidgetBlendMode Multiply = new(Values.Multiply);

    public static readonly AnnotationDraftWidgetBlendMode Screen = new(Values.Screen);

    public static readonly AnnotationDraftWidgetBlendMode Overlay = new(Values.Overlay);

    public static readonly AnnotationDraftWidgetBlendMode Darken = new(Values.Darken);

    public static readonly AnnotationDraftWidgetBlendMode Lighten = new(Values.Lighten);

    public static readonly AnnotationDraftWidgetBlendMode ColorDodge = new(Values.ColorDodge);

    public static readonly AnnotationDraftWidgetBlendMode ColorBurn = new(Values.ColorBurn);

    public static readonly AnnotationDraftWidgetBlendMode HardLight = new(Values.HardLight);

    public static readonly AnnotationDraftWidgetBlendMode SoftLight = new(Values.SoftLight);

    public static readonly AnnotationDraftWidgetBlendMode Difference = new(Values.Difference);

    public static readonly AnnotationDraftWidgetBlendMode Exclusion = new(Values.Exclusion);

    public static readonly AnnotationDraftWidgetBlendMode Hue = new(Values.Hue);

    public static readonly AnnotationDraftWidgetBlendMode Saturation = new(Values.Saturation);

    public static readonly AnnotationDraftWidgetBlendMode Color = new(Values.Color);

    public static readonly AnnotationDraftWidgetBlendMode Luminosity = new(Values.Luminosity);

    public AnnotationDraftWidgetBlendMode(string value)
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
    public static AnnotationDraftWidgetBlendMode FromCustom(string value)
    {
        return new AnnotationDraftWidgetBlendMode(value);
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

    public static bool operator ==(AnnotationDraftWidgetBlendMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftWidgetBlendMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftWidgetBlendMode value) => value.Value;

    public static explicit operator AnnotationDraftWidgetBlendMode(string value) => new(value);

    internal class AnnotationDraftWidgetBlendModeSerializer
        : JsonConverter<AnnotationDraftWidgetBlendMode>
    {
        public override AnnotationDraftWidgetBlendMode Read(
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
            return new AnnotationDraftWidgetBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftWidgetBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftWidgetBlendMode ReadAsPropertyName(
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
            return new AnnotationDraftWidgetBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftWidgetBlendMode value,
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
