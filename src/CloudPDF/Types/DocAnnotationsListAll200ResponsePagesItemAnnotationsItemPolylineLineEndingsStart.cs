using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStartSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart
    : IStringEnum
{
    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart None =
        new(Values.None);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart Square =
        new(Values.Square);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart Circle =
        new(Values.Circle);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart Diamond =
        new(Values.Diamond);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart OpenArrow =
        new(Values.OpenArrow);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart ClosedArrow =
        new(Values.ClosedArrow);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart Butt =
        new(Values.Butt);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart ROpenArrow =
        new(Values.ROpenArrow);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart RClosedArrow =
        new(Values.RClosedArrow);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart Slash =
        new(Values.Slash);

    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart(
        string value
    )
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
    public static DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart FromCustom(
        string value
    )
    {
        return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart(
            value
        );
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
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart value
    ) => value.Value;

    public static explicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart(
        string value
    ) => new(value);

    internal class DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStartSerializer
        : JsonConverter<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart>
    {
        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart Read(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart ReadAsPropertyName(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolylineLineEndingsStart value,
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
