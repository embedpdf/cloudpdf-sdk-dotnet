using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(ChangeItemFormsUpdateWidgetAppearanceAction.ChangeItemFormsUpdateWidgetAppearanceActionSerializer)
)]
[Serializable]
public readonly record struct ChangeItemFormsUpdateWidgetAppearanceAction : IStringEnum
{
    public static readonly ChangeItemFormsUpdateWidgetAppearanceAction Preserved = new(
        Values.Preserved
    );

    public static readonly ChangeItemFormsUpdateWidgetAppearanceAction Regenerated = new(
        Values.Regenerated
    );

    public static readonly ChangeItemFormsUpdateWidgetAppearanceAction GenerationUnavailable = new(
        Values.GenerationUnavailable
    );

    public static readonly ChangeItemFormsUpdateWidgetAppearanceAction Restored = new(
        Values.Restored
    );

    public ChangeItemFormsUpdateWidgetAppearanceAction(string value)
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
    public static ChangeItemFormsUpdateWidgetAppearanceAction FromCustom(string value)
    {
        return new ChangeItemFormsUpdateWidgetAppearanceAction(value);
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
        ChangeItemFormsUpdateWidgetAppearanceAction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ChangeItemFormsUpdateWidgetAppearanceAction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ChangeItemFormsUpdateWidgetAppearanceAction value) =>
        value.Value;

    public static explicit operator ChangeItemFormsUpdateWidgetAppearanceAction(string value) =>
        new(value);

    internal class ChangeItemFormsUpdateWidgetAppearanceActionSerializer
        : JsonConverter<ChangeItemFormsUpdateWidgetAppearanceAction>
    {
        public override ChangeItemFormsUpdateWidgetAppearanceAction Read(
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
            return new ChangeItemFormsUpdateWidgetAppearanceAction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeItemFormsUpdateWidgetAppearanceAction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChangeItemFormsUpdateWidgetAppearanceAction ReadAsPropertyName(
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
            return new ChangeItemFormsUpdateWidgetAppearanceAction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeItemFormsUpdateWidgetAppearanceAction value,
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
        public const string Preserved = "preserved";

        public const string Regenerated = "regenerated";

        public const string GenerationUnavailable = "generation-unavailable";

        public const string Restored = "restored";
    }
}
