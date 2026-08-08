using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemHighlightActionsPageInvisibleWarningsItem.DocAnnotationsList200ResponseAnnotationsItemHighlightActionsPageInvisibleWarningsItemSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemHighlightActionsPageInvisibleWarningsItem
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemHighlightActionsPageInvisibleWarningsItem CycleDropped =
        new(Values.CycleDropped);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemHighlightActionsPageInvisibleWarningsItem MalformedNext =
        new(Values.MalformedNext);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemHighlightActionsPageInvisibleWarningsItem Incomplete =
        new(Values.Incomplete);

    public DocAnnotationsList200ResponseAnnotationsItemHighlightActionsPageInvisibleWarningsItem(
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
    public static DocAnnotationsList200ResponseAnnotationsItemHighlightActionsPageInvisibleWarningsItem FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemHighlightActionsPageInvisibleWarningsItem(
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
        DocAnnotationsList200ResponseAnnotationsItemHighlightActionsPageInvisibleWarningsItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemHighlightActionsPageInvisibleWarningsItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemHighlightActionsPageInvisibleWarningsItem value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemHighlightActionsPageInvisibleWarningsItem(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemHighlightActionsPageInvisibleWarningsItemSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemHighlightActionsPageInvisibleWarningsItem>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemHighlightActionsPageInvisibleWarningsItem Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemHighlightActionsPageInvisibleWarningsItem(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemHighlightActionsPageInvisibleWarningsItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemHighlightActionsPageInvisibleWarningsItem ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemHighlightActionsPageInvisibleWarningsItem(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemHighlightActionsPageInvisibleWarningsItem value,
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
        public const string CycleDropped = "cycle-dropped";

        public const string MalformedNext = "malformed-next";

        public const string Incomplete = "incomplete";
    }
}
