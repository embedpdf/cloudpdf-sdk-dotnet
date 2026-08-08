using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd.DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEndSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd None =
        new(Values.None);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd Square =
        new(Values.Square);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd Circle =
        new(Values.Circle);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd Diamond =
        new(Values.Diamond);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd OpenArrow =
        new(Values.OpenArrow);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd ClosedArrow =
        new(Values.ClosedArrow);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd Butt =
        new(Values.Butt);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd ROpenArrow =
        new(Values.ROpenArrow);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd RClosedArrow =
        new(Values.RClosedArrow);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd Slash =
        new(Values.Slash);

    public DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd(string value)
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
    public static DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd(value);
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
        DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEndSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemLineLineEndingsEnd value,
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
        public const string None = "none";

        public const string Square = "square";

        public const string Circle = "circle";

        public const string Diamond = "diamond";

        public const string OpenArrow = "open-arrow";

        public const string ClosedArrow = "closed-arrow";

        public const string Butt = "butt";

        public const string ROpenArrow = "r-open-arrow";

        public const string RClosedArrow = "r-closed-arrow";

        public const string Slash = "slash";
    }
}
