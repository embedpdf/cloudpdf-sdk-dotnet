using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType.DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootTypeSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType Unknown =
        new(Values.Unknown);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType Goto =
        new(Values.Goto);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType GotoRemote =
        new(Values.GotoRemote);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType GotoEmbedded =
        new(Values.GotoEmbedded);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType Launch =
        new(Values.Launch);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType Thread =
        new(Values.Thread);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType Uri =
        new(Values.Uri);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType Sound =
        new(Values.Sound);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType Movie =
        new(Values.Movie);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType Hide =
        new(Values.Hide);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType Named =
        new(Values.Named);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType SubmitForm =
        new(Values.SubmitForm);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType ResetForm =
        new(Values.ResetForm);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType ImportData =
        new(Values.ImportData);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType Javascript =
        new(Values.Javascript);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType SetOcgState =
        new(Values.SetOcgState);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType Rendition =
        new(Values.Rendition);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType Transition =
        new(Values.Transition);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType Goto3DView =
        new(Values.Goto3DView);

    public DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType(string value)
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
    public static DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType(value);
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
        DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootTypeSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemCaretActionsMouseDownRootType value,
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
