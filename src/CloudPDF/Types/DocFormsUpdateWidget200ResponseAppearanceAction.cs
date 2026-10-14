using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocFormsUpdateWidget200ResponseAppearanceAction.DocFormsUpdateWidget200ResponseAppearanceActionSerializer)
)]
[Serializable]
public readonly record struct DocFormsUpdateWidget200ResponseAppearanceAction : IStringEnum
{
    public static readonly DocFormsUpdateWidget200ResponseAppearanceAction Preserved = new(
        Values.Preserved
    );

    public static readonly DocFormsUpdateWidget200ResponseAppearanceAction Regenerated = new(
        Values.Regenerated
    );

    public static readonly DocFormsUpdateWidget200ResponseAppearanceAction GenerationUnavailable =
        new(Values.GenerationUnavailable);

    public static readonly DocFormsUpdateWidget200ResponseAppearanceAction Restored = new(
        Values.Restored
    );

    public DocFormsUpdateWidget200ResponseAppearanceAction(string value)
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
    public static DocFormsUpdateWidget200ResponseAppearanceAction FromCustom(string value)
    {
        return new DocFormsUpdateWidget200ResponseAppearanceAction(value);
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
        DocFormsUpdateWidget200ResponseAppearanceAction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocFormsUpdateWidget200ResponseAppearanceAction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocFormsUpdateWidget200ResponseAppearanceAction value) =>
        value.Value;

    public static explicit operator DocFormsUpdateWidget200ResponseAppearanceAction(string value) =>
        new(value);

    internal class DocFormsUpdateWidget200ResponseAppearanceActionSerializer
        : JsonConverter<DocFormsUpdateWidget200ResponseAppearanceAction>
    {
        public override DocFormsUpdateWidget200ResponseAppearanceAction Read(
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
            return new DocFormsUpdateWidget200ResponseAppearanceAction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsUpdateWidget200ResponseAppearanceAction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocFormsUpdateWidget200ResponseAppearanceAction ReadAsPropertyName(
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
            return new DocFormsUpdateWidget200ResponseAppearanceAction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsUpdateWidget200ResponseAppearanceAction value,
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
