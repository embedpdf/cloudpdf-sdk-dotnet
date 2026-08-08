using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocumentsList200ResponseDocumentsItemState.DocumentsList200ResponseDocumentsItemStateSerializer)
)]
[Serializable]
public readonly record struct DocumentsList200ResponseDocumentsItemState : IStringEnum
{
    public static readonly DocumentsList200ResponseDocumentsItemState Pending = new(Values.Pending);

    public static readonly DocumentsList200ResponseDocumentsItemState Ready = new(Values.Ready);

    public static readonly DocumentsList200ResponseDocumentsItemState Failed = new(Values.Failed);

    public static readonly DocumentsList200ResponseDocumentsItemState Deleting = new(
        Values.Deleting
    );

    public DocumentsList200ResponseDocumentsItemState(string value)
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
    public static DocumentsList200ResponseDocumentsItemState FromCustom(string value)
    {
        return new DocumentsList200ResponseDocumentsItemState(value);
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
        DocumentsList200ResponseDocumentsItemState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocumentsList200ResponseDocumentsItemState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DocumentsList200ResponseDocumentsItemState value) =>
        value.Value;

    public static explicit operator DocumentsList200ResponseDocumentsItemState(string value) =>
        new(value);

    internal class DocumentsList200ResponseDocumentsItemStateSerializer
        : JsonConverter<DocumentsList200ResponseDocumentsItemState>
    {
        public override DocumentsList200ResponseDocumentsItemState Read(
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
            return new DocumentsList200ResponseDocumentsItemState(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocumentsList200ResponseDocumentsItemState value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocumentsList200ResponseDocumentsItemState ReadAsPropertyName(
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
            return new DocumentsList200ResponseDocumentsItemState(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocumentsList200ResponseDocumentsItemState value,
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
