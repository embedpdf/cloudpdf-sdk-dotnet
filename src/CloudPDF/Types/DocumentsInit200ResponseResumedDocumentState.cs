using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocumentsInit200ResponseResumedDocumentState.DocumentsInit200ResponseResumedDocumentStateSerializer)
)]
[Serializable]
public readonly record struct DocumentsInit200ResponseResumedDocumentState : IStringEnum
{
    public static readonly DocumentsInit200ResponseResumedDocumentState Pending = new(
        Values.Pending
    );

    public static readonly DocumentsInit200ResponseResumedDocumentState Ready = new(Values.Ready);

    public static readonly DocumentsInit200ResponseResumedDocumentState Failed = new(Values.Failed);

    public static readonly DocumentsInit200ResponseResumedDocumentState Deleting = new(
        Values.Deleting
    );

    public DocumentsInit200ResponseResumedDocumentState(string value)
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
    public static DocumentsInit200ResponseResumedDocumentState FromCustom(string value)
    {
        return new DocumentsInit200ResponseResumedDocumentState(value);
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
        DocumentsInit200ResponseResumedDocumentState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocumentsInit200ResponseResumedDocumentState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocumentsInit200ResponseResumedDocumentState value) =>
        value.Value;

    public static explicit operator DocumentsInit200ResponseResumedDocumentState(string value) =>
        new(value);

    internal class DocumentsInit200ResponseResumedDocumentStateSerializer
        : JsonConverter<DocumentsInit200ResponseResumedDocumentState>
    {
        public override DocumentsInit200ResponseResumedDocumentState Read(
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
            return new DocumentsInit200ResponseResumedDocumentState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsInit200ResponseResumedDocumentState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsInit200ResponseResumedDocumentState ReadAsPropertyName(
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
            return new DocumentsInit200ResponseResumedDocumentState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsInit200ResponseResumedDocumentState value,
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
