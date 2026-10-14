using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(AnnotationDraftLineLineEndingsStart.AnnotationDraftLineLineEndingsStartSerializer)
)]
[Serializable]
public readonly record struct AnnotationDraftLineLineEndingsStart : IStringEnum
{
    public static readonly AnnotationDraftLineLineEndingsStart None = new(Values.None);

    public static readonly AnnotationDraftLineLineEndingsStart Square = new(Values.Square);

    public static readonly AnnotationDraftLineLineEndingsStart Circle = new(Values.Circle);

    public static readonly AnnotationDraftLineLineEndingsStart Diamond = new(Values.Diamond);

    public static readonly AnnotationDraftLineLineEndingsStart OpenArrow = new(Values.OpenArrow);

    public static readonly AnnotationDraftLineLineEndingsStart ClosedArrow = new(
        Values.ClosedArrow
    );

    public static readonly AnnotationDraftLineLineEndingsStart Butt = new(Values.Butt);

    public static readonly AnnotationDraftLineLineEndingsStart ROpenArrow = new(Values.ROpenArrow);

    public static readonly AnnotationDraftLineLineEndingsStart RClosedArrow = new(
        Values.RClosedArrow
    );

    public static readonly AnnotationDraftLineLineEndingsStart Slash = new(Values.Slash);

    public AnnotationDraftLineLineEndingsStart(string value)
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
    public static AnnotationDraftLineLineEndingsStart FromCustom(string value)
    {
        return new AnnotationDraftLineLineEndingsStart(value);
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

    public static bool operator ==(AnnotationDraftLineLineEndingsStart value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AnnotationDraftLineLineEndingsStart value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AnnotationDraftLineLineEndingsStart value) =>
        value.Value;

    public static explicit operator AnnotationDraftLineLineEndingsStart(string value) => new(value);

    internal class AnnotationDraftLineLineEndingsStartSerializer
        : JsonConverter<AnnotationDraftLineLineEndingsStart>
    {
        public override AnnotationDraftLineLineEndingsStart Read(
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
            return new AnnotationDraftLineLineEndingsStart(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            AnnotationDraftLineLineEndingsStart value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override AnnotationDraftLineLineEndingsStart ReadAsPropertyName(
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
            return new AnnotationDraftLineLineEndingsStart(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            AnnotationDraftLineLineEndingsStart value,
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
