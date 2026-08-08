using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemHighlightActionsFocusWarningsItem.DocAnnotationsList200ResponseAnnotationsItemHighlightActionsFocusWarningsItemSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemHighlightActionsFocusWarningsItem
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemHighlightActionsFocusWarningsItem CycleDropped =
        new(Values.CycleDropped);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemHighlightActionsFocusWarningsItem MalformedNext =
        new(Values.MalformedNext);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemHighlightActionsFocusWarningsItem Incomplete =
        new(Values.Incomplete);

    public DocAnnotationsList200ResponseAnnotationsItemHighlightActionsFocusWarningsItem(
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
    public static DocAnnotationsList200ResponseAnnotationsItemHighlightActionsFocusWarningsItem FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemHighlightActionsFocusWarningsItem(
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
        DocAnnotationsList200ResponseAnnotationsItemHighlightActionsFocusWarningsItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemHighlightActionsFocusWarningsItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemHighlightActionsFocusWarningsItem value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemHighlightActionsFocusWarningsItem(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemHighlightActionsFocusWarningsItemSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemHighlightActionsFocusWarningsItem>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemHighlightActionsFocusWarningsItem Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemHighlightActionsFocusWarningsItem(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemHighlightActionsFocusWarningsItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemHighlightActionsFocusWarningsItem ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemHighlightActionsFocusWarningsItem(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemHighlightActionsFocusWarningsItem value,
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
