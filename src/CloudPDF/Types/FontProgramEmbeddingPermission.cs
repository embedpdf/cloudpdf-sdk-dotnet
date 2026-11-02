using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(FontProgramEmbeddingPermission.FontProgramEmbeddingPermissionSerializer))]
[Serializable]
public readonly record struct FontProgramEmbeddingPermission : IStringEnum
{
    public static readonly FontProgramEmbeddingPermission Installable = new(Values.Installable);

    public static readonly FontProgramEmbeddingPermission Editable = new(Values.Editable);

    public static readonly FontProgramEmbeddingPermission PreviewAndPrint = new(
        Values.PreviewAndPrint
    );

    public FontProgramEmbeddingPermission(string value)
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
    public static FontProgramEmbeddingPermission FromCustom(string value)
    {
        return new FontProgramEmbeddingPermission(value);
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

    public static bool operator ==(FontProgramEmbeddingPermission value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FontProgramEmbeddingPermission value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FontProgramEmbeddingPermission value) => value.Value;

    public static explicit operator FontProgramEmbeddingPermission(string value) => new(value);

    internal class FontProgramEmbeddingPermissionSerializer
        : JsonConverter<FontProgramEmbeddingPermission>
    {
        public override FontProgramEmbeddingPermission Read(
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
            return new FontProgramEmbeddingPermission(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FontProgramEmbeddingPermission value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FontProgramEmbeddingPermission ReadAsPropertyName(
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
            return new FontProgramEmbeddingPermission(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FontProgramEmbeddingPermission value,
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
        public const string Installable = "installable";

        public const string Editable = "editable";

        public const string PreviewAndPrint = "preview-and-print";
    }
}
