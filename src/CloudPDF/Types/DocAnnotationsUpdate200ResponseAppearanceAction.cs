using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsUpdate200ResponseAppearanceAction.DocAnnotationsUpdate200ResponseAppearanceActionSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsUpdate200ResponseAppearanceAction : IStringEnum
{
    public static readonly DocAnnotationsUpdate200ResponseAppearanceAction Preserved = new(
        Values.Preserved
    );

    public static readonly DocAnnotationsUpdate200ResponseAppearanceAction Regenerated = new(
        Values.Regenerated
    );

    public static readonly DocAnnotationsUpdate200ResponseAppearanceAction GenerationUnavailable =
        new(Values.GenerationUnavailable);

    public static readonly DocAnnotationsUpdate200ResponseAppearanceAction Restored = new(
        Values.Restored
    );

    public DocAnnotationsUpdate200ResponseAppearanceAction(string value)
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
    public static DocAnnotationsUpdate200ResponseAppearanceAction FromCustom(string value)
    {
        return new DocAnnotationsUpdate200ResponseAppearanceAction(value);
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
        DocAnnotationsUpdate200ResponseAppearanceAction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsUpdate200ResponseAppearanceAction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocAnnotationsUpdate200ResponseAppearanceAction value) =>
        value.Value;

    public static explicit operator DocAnnotationsUpdate200ResponseAppearanceAction(string value) =>
        new(value);

    internal class DocAnnotationsUpdate200ResponseAppearanceActionSerializer
        : JsonConverter<DocAnnotationsUpdate200ResponseAppearanceAction>
    {
        public override DocAnnotationsUpdate200ResponseAppearanceAction Read(
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
            return new DocAnnotationsUpdate200ResponseAppearanceAction(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsUpdate200ResponseAppearanceAction value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsUpdate200ResponseAppearanceAction ReadAsPropertyName(
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
            return new DocAnnotationsUpdate200ResponseAppearanceAction(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsUpdate200ResponseAppearanceAction value,
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
