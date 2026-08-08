using CloudpdfApi.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudpdfApi;

[JsonConverter(
    typeof(DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType.DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootTypeSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType
    : IStringEnum
{
    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType Unknown =
        new(Values.Unknown);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType Goto =
        new(Values.Goto);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType GotoRemote =
        new(Values.GotoRemote);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType GotoEmbedded =
        new(Values.GotoEmbedded);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType Launch =
        new(Values.Launch);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType Thread =
        new(Values.Thread);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType Uri =
        new(Values.Uri);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType Sound =
        new(Values.Sound);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType Movie =
        new(Values.Movie);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType Hide =
        new(Values.Hide);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType Named =
        new(Values.Named);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType SubmitForm =
        new(Values.SubmitForm);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType ResetForm =
        new(Values.ResetForm);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType ImportData =
        new(Values.ImportData);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType Javascript =
        new(Values.Javascript);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType SetOcgState =
        new(Values.SetOcgState);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType Rendition =
        new(Values.Rendition);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType Transition =
        new(Values.Transition);

    public static readonly DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType Goto3DView =
        new(Values.Goto3DView);

    public DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType(string value)
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
    public static DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType FromCustom(
        string value
    )
    {
        return new DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType(value);
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
        DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType value
    ) => value.Value;

    public static explicit operator DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType(
        string value
    ) => new(value);

    internal class DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootTypeSerializer
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType>
    {
        public override DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType Read(
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
            return new DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType ReadAsPropertyName(
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
            return new DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItemSquareActionsPageOpenRootType value,
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
