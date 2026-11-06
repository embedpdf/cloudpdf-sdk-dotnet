using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocFormsUpdateWidgetResponseAppearanceAction.DocFormsUpdateWidgetResponseAppearanceActionSerializer)
)]
[Serializable]
public readonly record struct DocFormsUpdateWidgetResponseAppearanceAction : IStringEnum
{
    public static readonly DocFormsUpdateWidgetResponseAppearanceAction Preserved = new(
        Values.Preserved
    );

    public static readonly DocFormsUpdateWidgetResponseAppearanceAction Regenerated = new(
        Values.Regenerated
    );

    public static readonly DocFormsUpdateWidgetResponseAppearanceAction GenerationUnavailable = new(
        Values.GenerationUnavailable
    );

    public static readonly DocFormsUpdateWidgetResponseAppearanceAction Restored = new(
        Values.Restored
    );

    public DocFormsUpdateWidgetResponseAppearanceAction(string value)
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
    public static DocFormsUpdateWidgetResponseAppearanceAction FromCustom(string value)
    {
        return new DocFormsUpdateWidgetResponseAppearanceAction(value);
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
        DocFormsUpdateWidgetResponseAppearanceAction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocFormsUpdateWidgetResponseAppearanceAction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocFormsUpdateWidgetResponseAppearanceAction value) =>
        value.Value;

    public static explicit operator DocFormsUpdateWidgetResponseAppearanceAction(string value) =>
        new(value);

    internal class DocFormsUpdateWidgetResponseAppearanceActionSerializer
        : JsonConverter<DocFormsUpdateWidgetResponseAppearanceAction>
    {
        public override DocFormsUpdateWidgetResponseAppearanceAction Read(
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
            return new DocFormsUpdateWidgetResponseAppearanceAction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsUpdateWidgetResponseAppearanceAction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocFormsUpdateWidgetResponseAppearanceAction ReadAsPropertyName(
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
            return new DocFormsUpdateWidgetResponseAppearanceAction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsUpdateWidgetResponseAppearanceAction value,
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
