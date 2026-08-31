using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootTypeSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType
    : IStringEnum
{
    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType Unknown =
        new(Values.Unknown);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType Goto =
        new(Values.Goto);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType GotoRemote =
        new(Values.GotoRemote);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType GotoEmbedded =
        new(Values.GotoEmbedded);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType Launch =
        new(Values.Launch);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType Thread =
        new(Values.Thread);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType Uri =
        new(Values.Uri);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType Sound =
        new(Values.Sound);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType Movie =
        new(Values.Movie);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType Hide =
        new(Values.Hide);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType Named =
        new(Values.Named);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType SubmitForm =
        new(Values.SubmitForm);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType ResetForm =
        new(Values.ResetForm);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType ImportData =
        new(Values.ImportData);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType Javascript =
        new(Values.Javascript);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType SetOcgState =
        new(Values.SetOcgState);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType Rendition =
        new(Values.Rendition);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType Transition =
        new(Values.Transition);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType Goto3DView =
        new(Values.Goto3DView);

    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType(
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
    public static DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType FromCustom(
        string value
    )
    {
        return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType(
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
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType value
    ) => value.Value;

    public static explicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType(
        string value
    ) => new(value);

    internal class DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootTypeSerializer
        : JsonConverter<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType>
    {
        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType Read(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType ReadAsPropertyName(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStampActionsMouseUpRootType value,
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
