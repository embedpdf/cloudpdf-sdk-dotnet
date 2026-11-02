using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(FontProgramInfoEmbeddingPermission.FontProgramInfoEmbeddingPermissionSerializer)
)]
[Serializable]
public readonly record struct FontProgramInfoEmbeddingPermission : IStringEnum
{
    public static readonly FontProgramInfoEmbeddingPermission Installable = new(Values.Installable);

    public static readonly FontProgramInfoEmbeddingPermission Editable = new(Values.Editable);

    public static readonly FontProgramInfoEmbeddingPermission PreviewAndPrint = new(
        Values.PreviewAndPrint
    );

    public FontProgramInfoEmbeddingPermission(string value)
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
    public static FontProgramInfoEmbeddingPermission FromCustom(string value)
    {
        return new FontProgramInfoEmbeddingPermission(value);
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

    public static bool operator ==(FontProgramInfoEmbeddingPermission value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FontProgramInfoEmbeddingPermission value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FontProgramInfoEmbeddingPermission value) => value.Value;

    public static explicit operator FontProgramInfoEmbeddingPermission(string value) => new(value);

    internal class FontProgramInfoEmbeddingPermissionSerializer
        : JsonConverter<FontProgramInfoEmbeddingPermission>
    {
        public override FontProgramInfoEmbeddingPermission Read(
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
            return new FontProgramInfoEmbeddingPermission(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            FontProgramInfoEmbeddingPermission value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override FontProgramInfoEmbeddingPermission ReadAsPropertyName(
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
            return new FontProgramInfoEmbeddingPermission(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            FontProgramInfoEmbeddingPermission value,
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
