using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType.DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootTypeSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType Unknown =
        new(Values.Unknown);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType Goto =
        new(Values.Goto);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType GotoRemote =
        new(Values.GotoRemote);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType GotoEmbedded =
        new(Values.GotoEmbedded);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType Launch =
        new(Values.Launch);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType Thread =
        new(Values.Thread);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType Uri =
        new(Values.Uri);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType Sound =
        new(Values.Sound);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType Movie =
        new(Values.Movie);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType Hide =
        new(Values.Hide);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType Named =
        new(Values.Named);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType SubmitForm =
        new(Values.SubmitForm);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType ResetForm =
        new(Values.ResetForm);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType ImportData =
        new(Values.ImportData);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType Javascript =
        new(Values.Javascript);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType SetOcgState =
        new(Values.SetOcgState);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType Rendition =
        new(Values.Rendition);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType Transition =
        new(Values.Transition);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType Goto3DView =
        new(Values.Goto3DView);

    public DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType(
        string value
    )
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
    public static DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType(
            value
        );
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
        DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootTypeSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemSquigglyActionsMouseDownRootType value,
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
