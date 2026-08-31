using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(
    typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootTypeSerializer)
)]
[Serializable]
public readonly record struct DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType
    : IStringEnum
{
    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType Unknown =
        new(Values.Unknown);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType Goto =
        new(Values.Goto);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType GotoRemote =
        new(Values.GotoRemote);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType GotoEmbedded =
        new(Values.GotoEmbedded);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType Launch =
        new(Values.Launch);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType Thread =
        new(Values.Thread);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType Uri =
        new(Values.Uri);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType Sound =
        new(Values.Sound);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType Movie =
        new(Values.Movie);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType Hide =
        new(Values.Hide);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType Named =
        new(Values.Named);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType SubmitForm =
        new(Values.SubmitForm);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType ResetForm =
        new(Values.ResetForm);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType ImportData =
        new(Values.ImportData);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType Javascript =
        new(Values.Javascript);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType SetOcgState =
        new(Values.SetOcgState);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType Rendition =
        new(Values.Rendition);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType Transition =
        new(Values.Transition);

    public static readonly DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType Goto3DView =
        new(Values.Goto3DView);

    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType(
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
    public static DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType FromCustom(
        string value
    )
    {
        return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType(
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
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType value
    ) => value.Value;

    public static explicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType(
        string value
    ) => new(value);

    internal class DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootTypeSerializer
        : JsonConverter<DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType>
    {
        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType Read(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType(
                stringValue
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType value,
            JsonSerializerOptions options
        )
        {
            writer.WriteStringValue(value.Value);
        }

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType ReadAsPropertyName(
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
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType(
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircleActionsPageInvisibleRootType value,
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
