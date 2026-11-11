using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(ChangeItemAnnotationsCopyDroppedItemReason.ChangeItemAnnotationsCopyDroppedItemReasonSerializer)
)]
[Serializable]
public readonly record struct ChangeItemAnnotationsCopyDroppedItemReason : IStringEnum
{
    public static readonly ChangeItemAnnotationsCopyDroppedItemReason UnsupportedKind = new(
        Values.UnsupportedKind
    );

    public static readonly ChangeItemAnnotationsCopyDroppedItemReason Widget = new(Values.Widget);

    public static readonly ChangeItemAnnotationsCopyDroppedItemReason Geospatial = new(
        Values.Geospatial
    );

    public static readonly ChangeItemAnnotationsCopyDroppedItemReason UnknownMeasure = new(
        Values.UnknownMeasure
    );

    public static readonly ChangeItemAnnotationsCopyDroppedItemReason UnsupportedAction = new(
        Values.UnsupportedAction
    );

    public static readonly ChangeItemAnnotationsCopyDroppedItemReason UnsupportedValue = new(
        Values.UnsupportedValue
    );

    public static readonly ChangeItemAnnotationsCopyDroppedItemReason NameConflict = new(
        Values.NameConflict
    );

    public static readonly ChangeItemAnnotationsCopyDroppedItemReason ParentDropped = new(
        Values.ParentDropped
    );

    public static readonly ChangeItemAnnotationsCopyDroppedItemReason ParentMissing = new(
        Values.ParentMissing
    );

    public static readonly ChangeItemAnnotationsCopyDroppedItemReason PopupTaken = new(
        Values.PopupTaken
    );

    public ChangeItemAnnotationsCopyDroppedItemReason(string value)
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
    public static ChangeItemAnnotationsCopyDroppedItemReason FromCustom(string value)
    {
        return new ChangeItemAnnotationsCopyDroppedItemReason(value);
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
        ChangeItemAnnotationsCopyDroppedItemReason value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ChangeItemAnnotationsCopyDroppedItemReason value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ChangeItemAnnotationsCopyDroppedItemReason value) =>
        value.Value;

    public static explicit operator ChangeItemAnnotationsCopyDroppedItemReason(string value) =>
        new(value);

    internal class ChangeItemAnnotationsCopyDroppedItemReasonSerializer
        : JsonConverter<ChangeItemAnnotationsCopyDroppedItemReason>
    {
        public override ChangeItemAnnotationsCopyDroppedItemReason Read(
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
            return new ChangeItemAnnotationsCopyDroppedItemReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeItemAnnotationsCopyDroppedItemReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChangeItemAnnotationsCopyDroppedItemReason ReadAsPropertyName(
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
            return new ChangeItemAnnotationsCopyDroppedItemReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeItemAnnotationsCopyDroppedItemReason value,
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
        public const string UnsupportedKind = "unsupported-kind";

        public const string Widget = "widget";

        public const string Geospatial = "geospatial";

        public const string UnknownMeasure = "unknown-measure";

        public const string UnsupportedAction = "unsupported-action";

        public const string UnsupportedValue = "unsupported-value";

        public const string NameConflict = "name-conflict";

        public const string ParentDropped = "parent-dropped";

        public const string ParentMissing = "parent-missing";

        public const string PopupTaken = "popup-taken";
    }
}
