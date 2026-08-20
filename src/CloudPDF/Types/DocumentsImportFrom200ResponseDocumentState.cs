using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocumentsImportFrom200ResponseDocumentState.DocumentsImportFrom200ResponseDocumentStateSerializer)
)]
[Serializable]
public readonly record struct DocumentsImportFrom200ResponseDocumentState : IStringEnum
{
    public static readonly DocumentsImportFrom200ResponseDocumentState Pending = new(
        Values.Pending
    );

    public static readonly DocumentsImportFrom200ResponseDocumentState Ready = new(Values.Ready);

    public static readonly DocumentsImportFrom200ResponseDocumentState Failed = new(Values.Failed);

    public static readonly DocumentsImportFrom200ResponseDocumentState Deleting = new(
        Values.Deleting
    );

    public DocumentsImportFrom200ResponseDocumentState(string value)
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
    public static DocumentsImportFrom200ResponseDocumentState FromCustom(string value)
    {
        return new DocumentsImportFrom200ResponseDocumentState(value);
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
        DocumentsImportFrom200ResponseDocumentState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocumentsImportFrom200ResponseDocumentState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocumentsImportFrom200ResponseDocumentState value) =>
        value.Value;

    public static explicit operator DocumentsImportFrom200ResponseDocumentState(string value) =>
        new(value);

    internal class DocumentsImportFrom200ResponseDocumentStateSerializer
        : JsonConverter<DocumentsImportFrom200ResponseDocumentState>
    {
        public override DocumentsImportFrom200ResponseDocumentState Read(
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
            return new DocumentsImportFrom200ResponseDocumentState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsImportFrom200ResponseDocumentState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsImportFrom200ResponseDocumentState ReadAsPropertyName(
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
            return new DocumentsImportFrom200ResponseDocumentState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsImportFrom200ResponseDocumentState value,
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
        public const string Pending = "pending";

        public const string Ready = "ready";

        public const string Failed = "failed";

        public const string Deleting = "deleting";
    }
}
