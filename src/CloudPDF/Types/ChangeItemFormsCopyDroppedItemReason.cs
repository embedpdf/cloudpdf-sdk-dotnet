using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(ChangeItemFormsCopyDroppedItemReason.ChangeItemFormsCopyDroppedItemReasonSerializer)
)]
[Serializable]
public readonly record struct ChangeItemFormsCopyDroppedItemReason : IStringEnum
{
    public static readonly ChangeItemFormsCopyDroppedItemReason NameConflict = new(
        Values.NameConflict
    );

    public static readonly ChangeItemFormsCopyDroppedItemReason NoField = new(Values.NoField);

    public static readonly ChangeItemFormsCopyDroppedItemReason UnsupportedKind = new(
        Values.UnsupportedKind
    );

    public static readonly ChangeItemFormsCopyDroppedItemReason ScriptNotAllowed = new(
        Values.ScriptNotAllowed
    );

    public static readonly ChangeItemFormsCopyDroppedItemReason UnsupportedAction = new(
        Values.UnsupportedAction
    );

    public ChangeItemFormsCopyDroppedItemReason(string value)
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
    public static ChangeItemFormsCopyDroppedItemReason FromCustom(string value)
    {
        return new ChangeItemFormsCopyDroppedItemReason(value);
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

    public static bool operator ==(ChangeItemFormsCopyDroppedItemReason value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ChangeItemFormsCopyDroppedItemReason value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ChangeItemFormsCopyDroppedItemReason value) =>
        value.Value;

    public static explicit operator ChangeItemFormsCopyDroppedItemReason(string value) =>
        new(value);

    internal class ChangeItemFormsCopyDroppedItemReasonSerializer
        : JsonConverter<ChangeItemFormsCopyDroppedItemReason>
    {
        public override ChangeItemFormsCopyDroppedItemReason Read(
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
            return new ChangeItemFormsCopyDroppedItemReason(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeItemFormsCopyDroppedItemReason value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChangeItemFormsCopyDroppedItemReason ReadAsPropertyName(
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
            return new ChangeItemFormsCopyDroppedItemReason(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeItemFormsCopyDroppedItemReason value,
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
        public const string NameConflict = "name-conflict";

        public const string NoField = "no-field";

        public const string UnsupportedKind = "unsupported-kind";

        public const string ScriptNotAllowed = "script-not-allowed";

        public const string UnsupportedAction = "unsupported-action";
    }
}
