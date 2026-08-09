using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocumentsInit200ResponseCreatedDocumentState.DocumentsInit200ResponseCreatedDocumentStateSerializer)
)]
[Serializable]
public readonly record struct DocumentsInit200ResponseCreatedDocumentState : IStringEnum
{
    public static readonly DocumentsInit200ResponseCreatedDocumentState Pending = new(
        Values.Pending
    );

    public static readonly DocumentsInit200ResponseCreatedDocumentState Ready = new(Values.Ready);

    public static readonly DocumentsInit200ResponseCreatedDocumentState Failed = new(Values.Failed);

    public static readonly DocumentsInit200ResponseCreatedDocumentState Deleting = new(
        Values.Deleting
    );

    public DocumentsInit200ResponseCreatedDocumentState(string value)
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
    public static DocumentsInit200ResponseCreatedDocumentState FromCustom(string value)
    {
        return new DocumentsInit200ResponseCreatedDocumentState(value);
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
        DocumentsInit200ResponseCreatedDocumentState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocumentsInit200ResponseCreatedDocumentState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocumentsInit200ResponseCreatedDocumentState value) =>
        value.Value;

    public static explicit operator DocumentsInit200ResponseCreatedDocumentState(string value) =>
        new(value);

    internal class DocumentsInit200ResponseCreatedDocumentStateSerializer
        : JsonConverter<DocumentsInit200ResponseCreatedDocumentState>
    {
        public override DocumentsInit200ResponseCreatedDocumentState Read(
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
            return new DocumentsInit200ResponseCreatedDocumentState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsInit200ResponseCreatedDocumentState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsInit200ResponseCreatedDocumentState ReadAsPropertyName(
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
            return new DocumentsInit200ResponseCreatedDocumentState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsInit200ResponseCreatedDocumentState value,
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
