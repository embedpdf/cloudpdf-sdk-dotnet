using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocPagesViewports200ResponseViewportsItemMeasureRectilinearSlopeItemLabelPosition.DocPagesViewports200ResponseViewportsItemMeasureRectilinearSlopeItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct DocPagesViewports200ResponseViewportsItemMeasureRectilinearSlopeItemLabelPosition
    : IStringEnum
{
    public static readonly DocPagesViewports200ResponseViewportsItemMeasureRectilinearSlopeItemLabelPosition Suffix =
        new(Values.Suffix);

    public static readonly DocPagesViewports200ResponseViewportsItemMeasureRectilinearSlopeItemLabelPosition Prefix =
        new(Values.Prefix);

    public DocPagesViewports200ResponseViewportsItemMeasureRectilinearSlopeItemLabelPosition(
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
    public static DocPagesViewports200ResponseViewportsItemMeasureRectilinearSlopeItemLabelPosition FromCustom(
        string value
    )
    {
        return new DocPagesViewports200ResponseViewportsItemMeasureRectilinearSlopeItemLabelPosition(
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
        DocPagesViewports200ResponseViewportsItemMeasureRectilinearSlopeItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocPagesViewports200ResponseViewportsItemMeasureRectilinearSlopeItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocPagesViewports200ResponseViewportsItemMeasureRectilinearSlopeItemLabelPosition value
    ) => value.Value;

    public static explicit operator DocPagesViewports200ResponseViewportsItemMeasureRectilinearSlopeItemLabelPosition(
        string value
    ) => new(value);

    internal class DocPagesViewports200ResponseViewportsItemMeasureRectilinearSlopeItemLabelPositionSerializer
        : JsonConverter<DocPagesViewports200ResponseViewportsItemMeasureRectilinearSlopeItemLabelPosition>
    {
        public override DocPagesViewports200ResponseViewportsItemMeasureRectilinearSlopeItemLabelPosition Read(
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
            return new DocPagesViewports200ResponseViewportsItemMeasureRectilinearSlopeItemLabelPosition(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesViewports200ResponseViewportsItemMeasureRectilinearSlopeItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesViewports200ResponseViewportsItemMeasureRectilinearSlopeItemLabelPosition ReadAsPropertyName(
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
            return new DocPagesViewports200ResponseViewportsItemMeasureRectilinearSlopeItemLabelPosition(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesViewports200ResponseViewportsItemMeasureRectilinearSlopeItemLabelPosition value,
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
        public const string Suffix = "suffix";

        public const string Prefix = "prefix";
    }
}
