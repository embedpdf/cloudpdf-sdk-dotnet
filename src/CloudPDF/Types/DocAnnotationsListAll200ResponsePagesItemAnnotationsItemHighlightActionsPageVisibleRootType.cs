using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootTypeSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType
    : IStringEnum
{
    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType Unknown =
        new(Values.Unknown);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType Goto =
        new(Values.Goto);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType GotoRemote =
        new(Values.GotoRemote);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType GotoEmbedded =
        new(Values.GotoEmbedded);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType Launch =
        new(Values.Launch);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType Thread =
        new(Values.Thread);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType Uri =
        new(Values.Uri);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType Sound =
        new(Values.Sound);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType Movie =
        new(Values.Movie);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType Hide =
        new(Values.Hide);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType Named =
        new(Values.Named);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType SubmitForm =
        new(Values.SubmitForm);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType ResetForm =
        new(Values.ResetForm);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType ImportData =
        new(Values.ImportData);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType Javascript =
        new(Values.Javascript);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType SetOcgState =
        new(Values.SetOcgState);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType Rendition =
        new(Values.Rendition);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType Transition =
        new(Values.Transition);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType Goto3DView =
        new(Values.Goto3DView);

    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType(
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
    public static DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType FromCustom(
        string value
    )
    {
        return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType(
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
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType value
    ) => value.Value;

    public static explicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType(
        string value
    ) => new(value);

    internal class DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootTypeSerializer
        : JsonConverter<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType>
    {
        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType Read(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType ReadAsPropertyName(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlightActionsPageVisibleRootType value,
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
