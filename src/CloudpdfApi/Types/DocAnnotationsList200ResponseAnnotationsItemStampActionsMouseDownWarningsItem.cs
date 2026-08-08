using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemStampActionsMouseDownWarningsItem.DocAnnotationsList200ResponseAnnotationsItemStampActionsMouseDownWarningsItemSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemStampActionsMouseDownWarningsItem
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemStampActionsMouseDownWarningsItem CycleDropped =
        new(Values.CycleDropped);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemStampActionsMouseDownWarningsItem MalformedNext =
        new(Values.MalformedNext);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemStampActionsMouseDownWarningsItem Incomplete =
        new(Values.Incomplete);

    public DocAnnotationsList200ResponseAnnotationsItemStampActionsMouseDownWarningsItem(
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
    public static DocAnnotationsList200ResponseAnnotationsItemStampActionsMouseDownWarningsItem FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemStampActionsMouseDownWarningsItem(
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
        DocAnnotationsList200ResponseAnnotationsItemStampActionsMouseDownWarningsItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemStampActionsMouseDownWarningsItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemStampActionsMouseDownWarningsItem value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemStampActionsMouseDownWarningsItem(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemStampActionsMouseDownWarningsItemSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemStampActionsMouseDownWarningsItem>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemStampActionsMouseDownWarningsItem Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemStampActionsMouseDownWarningsItem(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemStampActionsMouseDownWarningsItem value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemStampActionsMouseDownWarningsItem ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemStampActionsMouseDownWarningsItem(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemStampActionsMouseDownWarningsItem value,
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
