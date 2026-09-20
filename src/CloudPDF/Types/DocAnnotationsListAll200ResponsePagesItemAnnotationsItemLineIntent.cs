using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineIntent.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineIntentSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineIntent
    : IStringEnum
{
    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineIntent LineArrow =
        new(Values.LineArrow);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineIntent LineDimension =
        new(Values.LineDimension);

    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineIntent(string value)
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
    public static DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineIntent FromCustom(
        string value
    )
    {
        return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineIntent(value);
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
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineIntent value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineIntent value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineIntent value
    ) => value.Value;

    public static explicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineIntent(
        string value
    ) => new(value);

    internal class DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineIntentSerializer
        : JsonConverter<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineIntent>
    {
        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineIntent Read(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineIntent(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineIntent value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineIntent ReadAsPropertyName(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineIntent(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLineIntent value,
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
        public const string LineArrow = "LineArrow";

        public const string LineDimension = "LineDimension";
    }
}
