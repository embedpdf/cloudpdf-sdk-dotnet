using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationPatchLineLineEndingsStart.AnnotationPatchLineLineEndingsStartSerializer)
)]
[Serializable]
public readonly record struct AnnotationPatchLineLineEndingsStart : IStringEnum
{
    public static readonly AnnotationPatchLineLineEndingsStart None = new(Values.None);

    public static readonly AnnotationPatchLineLineEndingsStart Square = new(Values.Square);

    public static readonly AnnotationPatchLineLineEndingsStart Circle = new(Values.Circle);

    public static readonly AnnotationPatchLineLineEndingsStart Diamond = new(Values.Diamond);

    public static readonly AnnotationPatchLineLineEndingsStart OpenArrow = new(Values.OpenArrow);

    public static readonly AnnotationPatchLineLineEndingsStart ClosedArrow = new(
        Values.ClosedArrow
    );

    public static readonly AnnotationPatchLineLineEndingsStart Butt = new(Values.Butt);

    public static readonly AnnotationPatchLineLineEndingsStart ROpenArrow = new(Values.ROpenArrow);

    public static readonly AnnotationPatchLineLineEndingsStart RClosedArrow = new(
        Values.RClosedArrow
    );

    public static readonly AnnotationPatchLineLineEndingsStart Slash = new(Values.Slash);

    public AnnotationPatchLineLineEndingsStart(string value)
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
    public static AnnotationPatchLineLineEndingsStart FromCustom(string value)
    {
        return new AnnotationPatchLineLineEndingsStart(value);
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

    public static bool operator ==(AnnotationPatchLineLineEndingsStart value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationPatchLineLineEndingsStart value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationPatchLineLineEndingsStart value) =>
        value.Value;

    public static explicit operator AnnotationPatchLineLineEndingsStart(string value) => new(value);

    internal class AnnotationPatchLineLineEndingsStartSerializer
        : JsonConverter<AnnotationPatchLineLineEndingsStart>
    {
        public override AnnotationPatchLineLineEndingsStart Read(
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
            return new AnnotationPatchLineLineEndingsStart(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationPatchLineLineEndingsStart value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationPatchLineLineEndingsStart ReadAsPropertyName(
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
            return new AnnotationPatchLineLineEndingsStart(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationPatchLineLineEndingsStart value,
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
