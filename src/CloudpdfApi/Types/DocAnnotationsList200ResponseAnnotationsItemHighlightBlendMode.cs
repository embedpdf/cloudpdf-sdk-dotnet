using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode.DocAnnotationsList200ResponseAnnotationsItemHighlightBlendModeSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode Normal =
        new(Values.Normal);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode Multiply =
        new(Values.Multiply);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode Screen =
        new(Values.Screen);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode Overlay =
        new(Values.Overlay);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode Darken =
        new(Values.Darken);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode Lighten =
        new(Values.Lighten);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode ColorDodge =
        new(Values.ColorDodge);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode ColorBurn =
        new(Values.ColorBurn);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode HardLight =
        new(Values.HardLight);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode SoftLight =
        new(Values.SoftLight);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode Difference =
        new(Values.Difference);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode Exclusion =
        new(Values.Exclusion);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode Hue = new(
        Values.Hue
    );

    public static readonly DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode Saturation =
        new(Values.Saturation);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode Color =
        new(Values.Color);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode Luminosity =
        new(Values.Luminosity);

    public DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode(string value)
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
    public static DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode(value);
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

    public static bool operator ==(
        DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemHighlightBlendModeSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemHighlightBlendMode value,
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
