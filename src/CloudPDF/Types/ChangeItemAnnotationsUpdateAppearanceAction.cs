using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(ChangeItemAnnotationsUpdateAppearanceAction.ChangeItemAnnotationsUpdateAppearanceActionSerializer)
)]
[Serializable]
public readonly record struct ChangeItemAnnotationsUpdateAppearanceAction : IStringEnum
{
    public static readonly ChangeItemAnnotationsUpdateAppearanceAction Preserved = new(
        Values.Preserved
    );

    public static readonly ChangeItemAnnotationsUpdateAppearanceAction Regenerated = new(
        Values.Regenerated
    );

    public static readonly ChangeItemAnnotationsUpdateAppearanceAction GenerationUnavailable = new(
        Values.GenerationUnavailable
    );

    public static readonly ChangeItemAnnotationsUpdateAppearanceAction Restored = new(
        Values.Restored
    );

    public ChangeItemAnnotationsUpdateAppearanceAction(string value)
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
    public static ChangeItemAnnotationsUpdateAppearanceAction FromCustom(string value)
    {
        return new ChangeItemAnnotationsUpdateAppearanceAction(value);
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
        ChangeItemAnnotationsUpdateAppearanceAction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ChangeItemAnnotationsUpdateAppearanceAction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ChangeItemAnnotationsUpdateAppearanceAction value) =>
        value.Value;

    public static explicit operator ChangeItemAnnotationsUpdateAppearanceAction(string value) =>
        new(value);

    internal class ChangeItemAnnotationsUpdateAppearanceActionSerializer
        : JsonConverter<ChangeItemAnnotationsUpdateAppearanceAction>
    {
        public override ChangeItemAnnotationsUpdateAppearanceAction Read(
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
            return new ChangeItemAnnotationsUpdateAppearanceAction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            ChangeItemAnnotationsUpdateAppearanceAction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override ChangeItemAnnotationsUpdateAppearanceAction ReadAsPropertyName(
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
            return new ChangeItemAnnotationsUpdateAppearanceAction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            ChangeItemAnnotationsUpdateAppearanceAction value,
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
