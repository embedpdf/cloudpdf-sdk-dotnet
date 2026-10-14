using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocPagesViewports200ResponseViewportsItemMeasureRectilinearXItemLabelPosition.DocPagesViewports200ResponseViewportsItemMeasureRectilinearXItemLabelPositionSerializer)
)]
[Serializable]
public readonly record struct DocPagesViewports200ResponseViewportsItemMeasureRectilinearXItemLabelPosition
    : IStringEnum
{
    public static readonly DocPagesViewports200ResponseViewportsItemMeasureRectilinearXItemLabelPosition Suffix =
        new(Values.Suffix);

    public static readonly DocPagesViewports200ResponseViewportsItemMeasureRectilinearXItemLabelPosition Prefix =
        new(Values.Prefix);

    public DocPagesViewports200ResponseViewportsItemMeasureRectilinearXItemLabelPosition(
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
    public static DocPagesViewports200ResponseViewportsItemMeasureRectilinearXItemLabelPosition FromCustom(
        string value
    )
    {
        return new DocPagesViewports200ResponseViewportsItemMeasureRectilinearXItemLabelPosition(
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
        DocPagesViewports200ResponseViewportsItemMeasureRectilinearXItemLabelPosition value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocPagesViewports200ResponseViewportsItemMeasureRectilinearXItemLabelPosition value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocPagesViewports200ResponseViewportsItemMeasureRectilinearXItemLabelPosition value
    ) => value.Value;

    public static explicit operator DocPagesViewports200ResponseViewportsItemMeasureRectilinearXItemLabelPosition(
        string value
    ) => new(value);

    internal class DocPagesViewports200ResponseViewportsItemMeasureRectilinearXItemLabelPositionSerializer
        : JsonConverter<DocPagesViewports200ResponseViewportsItemMeasureRectilinearXItemLabelPosition>
    {
        public override DocPagesViewports200ResponseViewportsItemMeasureRectilinearXItemLabelPosition Read(
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
            return new DocPagesViewports200ResponseViewportsItemMeasureRectilinearXItemLabelPosition(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocPagesViewports200ResponseViewportsItemMeasureRectilinearXItemLabelPosition value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocPagesViewports200ResponseViewportsItemMeasureRectilinearXItemLabelPosition ReadAsPropertyName(
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
            return new DocPagesViewports200ResponseViewportsItemMeasureRectilinearXItemLabelPosition(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocPagesViewports200ResponseViewportsItemMeasureRectilinearXItemLabelPosition value,
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
