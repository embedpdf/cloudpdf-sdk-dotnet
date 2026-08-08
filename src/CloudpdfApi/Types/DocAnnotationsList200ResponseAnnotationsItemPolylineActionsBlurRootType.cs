using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType.DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootTypeSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType Unknown =
        new(Values.Unknown);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType Goto =
        new(Values.Goto);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType GotoRemote =
        new(Values.GotoRemote);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType GotoEmbedded =
        new(Values.GotoEmbedded);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType Launch =
        new(Values.Launch);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType Thread =
        new(Values.Thread);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType Uri =
        new(Values.Uri);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType Sound =
        new(Values.Sound);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType Movie =
        new(Values.Movie);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType Hide =
        new(Values.Hide);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType Named =
        new(Values.Named);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType SubmitForm =
        new(Values.SubmitForm);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType ResetForm =
        new(Values.ResetForm);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType ImportData =
        new(Values.ImportData);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType Javascript =
        new(Values.Javascript);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType SetOcgState =
        new(Values.SetOcgState);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType Rendition =
        new(Values.Rendition);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType Transition =
        new(Values.Transition);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType Goto3DView =
        new(Values.Goto3DView);

    public DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType(string value)
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
    public static DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType(value);
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
        DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootTypeSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemPolylineActionsBlurRootType value,
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
