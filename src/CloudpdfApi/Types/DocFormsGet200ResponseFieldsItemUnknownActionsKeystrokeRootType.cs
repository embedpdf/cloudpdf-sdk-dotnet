using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType.DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootTypeSerializer)
)]
[Serializable]
public readonly record struct DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType
    : IStringEnum
{
    public static readonly DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType Unknown =
        new(Values.Unknown);

    public static readonly DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType Goto =
        new(Values.Goto);

    public static readonly DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType GotoRemote =
        new(Values.GotoRemote);

    public static readonly DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType GotoEmbedded =
        new(Values.GotoEmbedded);

    public static readonly DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType Launch =
        new(Values.Launch);

    public static readonly DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType Thread =
        new(Values.Thread);

    public static readonly DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType Uri =
        new(Values.Uri);

    public static readonly DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType Sound =
        new(Values.Sound);

    public static readonly DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType Movie =
        new(Values.Movie);

    public static readonly DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType Hide =
        new(Values.Hide);

    public static readonly DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType Named =
        new(Values.Named);

    public static readonly DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType SubmitForm =
        new(Values.SubmitForm);

    public static readonly DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType ResetForm =
        new(Values.ResetForm);

    public static readonly DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType ImportData =
        new(Values.ImportData);

    public static readonly DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType Javascript =
        new(Values.Javascript);

    public static readonly DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType SetOcgState =
        new(Values.SetOcgState);

    public static readonly DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType Rendition =
        new(Values.Rendition);

    public static readonly DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType Transition =
        new(Values.Transition);

    public static readonly DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType Goto3DView =
        new(Values.Goto3DView);

    public DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType(string value)
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
    public static DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType FromCustom(
        string value
    )
    {
        return new DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType(value);
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
        DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType value
    ) => value.Value;

    public static explicit operator DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType(
        string value
    ) => new(value);

    internal class DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootTypeSerializer
        : JsonConverter<DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType>
    {
        public override DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType Read(
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
            return new DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType(stringValue);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType ReadAsPropertyName(
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
            return new DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType(stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocFormsGet200ResponseFieldsItemUnknownActionsKeystrokeRootType value,
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
        public const string Unknown = "unknown";

        public const string Goto = "goto";

        public const string GotoRemote = "goto-remote";

        public const string GotoEmbedded = "goto-embedded";

        public const string Launch = "launch";

        public const string Thread = "thread";

        public const string Uri = "uri";

        public const string Sound = "sound";

        public const string Movie = "movie";

        public const string Hide = "hide";

        public const string Named = "named";

        public const string SubmitForm = "submit-form";

        public const string ResetForm = "reset-form";

        public const string ImportData = "import-data";

        public const string Javascript = "javascript";

        public const string SetOcgState = "set-ocg-state";

        public const string Rendition = "rendition";

        public const string Transition = "transition";

        public const string Goto3DView = "goto-3d-view";
    }
}
