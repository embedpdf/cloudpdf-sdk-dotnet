using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchPolylineLineEndingsStart.AnnotationPatchPolylineLineEndingsStartSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchPolylineLineEndingsStart : IStringEnum
{
    public static readonly AnnotationPatchPolylineLineEndingsStart None = new(Values.None);

    public static readonly AnnotationPatchPolylineLineEndingsStart Square = new(Values.Square);

    public static readonly AnnotationPatchPolylineLineEndingsStart Circle = new(Values.Circle);

    public static readonly AnnotationPatchPolylineLineEndingsStart Diamond = new(Values.Diamond);

    public static readonly AnnotationPatchPolylineLineEndingsStart OpenArrow = new(
        Values.OpenArrow
    );

    public static readonly AnnotationPatchPolylineLineEndingsStart ClosedArrow = new(
        Values.ClosedArrow
    );

    public static readonly AnnotationPatchPolylineLineEndingsStart Butt = new(Values.Butt);

    public static readonly AnnotationPatchPolylineLineEndingsStart ROpenArrow = new(
        Values.ROpenArrow
    );

    public static readonly AnnotationPatchPolylineLineEndingsStart RClosedArrow = new(
        Values.RClosedArrow
    );

    public static readonly AnnotationPatchPolylineLineEndingsStart Slash = new(Values.Slash);

    public AnnotationPatchPolylineLineEndingsStart(string value)
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
    public static AnnotationPatchPolylineLineEndingsStart FromCustom(string value)
    {
        return new AnnotationPatchPolylineLineEndingsStart(value);
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

    public static bool operator ==(AnnotationPatchPolylineLineEndingsStart value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchPolylineLineEndingsStart value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchPolylineLineEndingsStart value) =>
        value.Value;

    public static explicit operator AnnotationPatchPolylineLineEndingsStart(string value) =>
        new(value);

    internal class AnnotationPatchPolylineLineEndingsStartSerializer
        : JsonConverter<AnnotationPatchPolylineLineEndingsStart>
    {
        public override AnnotationPatchPolylineLineEndingsStart Read(
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
            return new AnnotationPatchPolylineLineEndingsStart(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchPolylineLineEndingsStart value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchPolylineLineEndingsStart ReadAsPropertyName(
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
            return new AnnotationPatchPolylineLineEndingsStart(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchPolylineLineEndingsStart value,
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
