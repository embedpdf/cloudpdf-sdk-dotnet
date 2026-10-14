using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationDraftPolylineLineEndingsStart.AnnotationDraftPolylineLineEndingsStartSerializer)
)]
[Serializable]
public readonly record struct AnnotationDraftPolylineLineEndingsStart : IStringEnum
{
    public static readonly AnnotationDraftPolylineLineEndingsStart None = new(Values.None);

    public static readonly AnnotationDraftPolylineLineEndingsStart Square = new(Values.Square);

    public static readonly AnnotationDraftPolylineLineEndingsStart Circle = new(Values.Circle);

    public static readonly AnnotationDraftPolylineLineEndingsStart Diamond = new(Values.Diamond);

    public static readonly AnnotationDraftPolylineLineEndingsStart OpenArrow = new(
        Values.OpenArrow
    );

    public static readonly AnnotationDraftPolylineLineEndingsStart ClosedArrow = new(
        Values.ClosedArrow
    );

    public static readonly AnnotationDraftPolylineLineEndingsStart Butt = new(Values.Butt);

    public static readonly AnnotationDraftPolylineLineEndingsStart ROpenArrow = new(
        Values.ROpenArrow
    );

    public static readonly AnnotationDraftPolylineLineEndingsStart RClosedArrow = new(
        Values.RClosedArrow
    );

    public static readonly AnnotationDraftPolylineLineEndingsStart Slash = new(Values.Slash);

    public AnnotationDraftPolylineLineEndingsStart(string value)
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
    public static AnnotationDraftPolylineLineEndingsStart FromCustom(string value)
    {
        return new AnnotationDraftPolylineLineEndingsStart(value);
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

    public static bool operator ==(AnnotationDraftPolylineLineEndingsStart value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftPolylineLineEndingsStart value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftPolylineLineEndingsStart value) =>
        value.Value;

    public static explicit operator AnnotationDraftPolylineLineEndingsStart(string value) =>
        new(value);

    internal class AnnotationDraftPolylineLineEndingsStartSerializer
        : JsonConverter<AnnotationDraftPolylineLineEndingsStart>
    {
        public override AnnotationDraftPolylineLineEndingsStart Read(
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
            return new AnnotationDraftPolylineLineEndingsStart(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftPolylineLineEndingsStart value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftPolylineLineEndingsStart ReadAsPropertyName(
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
            return new AnnotationDraftPolylineLineEndingsStart(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftPolylineLineEndingsStart value,
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
