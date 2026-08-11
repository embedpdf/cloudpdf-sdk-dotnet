using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocumentsInitRequestUploadPreference.DocumentsInitRequestUploadPreferenceSerializer)
)]
[Serializable]
public readonly record struct DocumentsInitRequestUploadPreference : IStringEnum
{
    public static readonly DocumentsInitRequestUploadPreference Auto = new(Values.Auto);

    public static readonly DocumentsInitRequestUploadPreference Presigned = new(Values.Presigned);

    public static readonly DocumentsInitRequestUploadPreference Proxy = new(Values.Proxy);

    public DocumentsInitRequestUploadPreference(string value)
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
    public static DocumentsInitRequestUploadPreference FromCustom(string value)
    {
        return new DocumentsInitRequestUploadPreference(value);
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

    public static bool operator ==(DocumentsInitRequestUploadPreference value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DocumentsInitRequestUploadPreference value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DocumentsInitRequestUploadPreference value) =>
        value.Value;

    public static explicit operator DocumentsInitRequestUploadPreference(string value) =>
        new(value);

    internal class DocumentsInitRequestUploadPreferenceSerializer
        : JsonConverter<DocumentsInitRequestUploadPreference>
    {
        public override DocumentsInitRequestUploadPreference Read(
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
            return new DocumentsInitRequestUploadPreference(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsInitRequestUploadPreference value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsInitRequestUploadPreference ReadAsPropertyName(
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
            return new DocumentsInitRequestUploadPreference(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsInitRequestUploadPreference value,
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
        public const string Auto = "auto";

        public const string Presigned = "presigned";

        public const string Proxy = "proxy";
    }
}
