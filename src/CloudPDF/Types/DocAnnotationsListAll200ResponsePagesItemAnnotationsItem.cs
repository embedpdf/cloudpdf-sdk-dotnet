// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.JsonConverter))]
[Serializable]
public record DocAnnotationsListAll200ResponsePagesItemAnnotationsItem
{
    internal DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(string type, object? value)
    {
        Subtype = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItem with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Highlight"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Highlight value
    )
    {
        Subtype = "highlight";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItem with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Underline"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Underline value
    )
    {
        Subtype = "underline";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItem with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Squiggly"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Squiggly value
    )
    {
        Subtype = "squiggly";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItem with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Strikeout"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Strikeout value
    )
    {
        Subtype = "strikeout";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItem with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Circle"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Circle value
    )
    {
        Subtype = "circle";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItem with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Square"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Square value
    )
    {
        Subtype = "square";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItem with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Polygon"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Polygon value
    )
    {
        Subtype = "polygon";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItem with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Polyline"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Polyline value
    )
    {
        Subtype = "polyline";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItem with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Line"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Line value
    )
    {
        Subtype = "line";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItem with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Link"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Link value
    )
    {
        Subtype = "link";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItem with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Ink"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Ink value
    )
    {
        Subtype = "ink";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItem with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.FreeText"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.FreeText value
    )
    {
        Subtype = "free-text";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItem with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Caret"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Caret value
    )
    {
        Subtype = "caret";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItem with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Text"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Text value
    )
    {
        Subtype = "text";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItem with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Stamp"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Stamp value
    )
    {
        Subtype = "stamp";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItem with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.FileAttachment"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.FileAttachment value
    )
    {
        Subtype = "file-attachment";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItem with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Widget"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Widget value
    )
    {
        Subtype = "widget";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItem with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Redact"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Redact value
    )
    {
        Subtype = "redact";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsListAll200ResponsePagesItemAnnotationsItem with <see cref="DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Unsupported"/>.
    /// </summary>
    public DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Unsupported value
    )
    {
        Subtype = "unsupported";
        Value = value.Value;
    }

    /// <summary>
    /// Discriminant value
    /// </summary>
    [JsonPropertyName("subtype")]
    public string Subtype { get; internal set; }

    /// <summary>
    /// Discriminated union value
    /// </summary>
    public object? Value { get; internal set; }

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "highlight"
    /// </summary>
    public bool IsHighlight => Subtype == "highlight";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "underline"
    /// </summary>
    public bool IsUnderline => Subtype == "underline";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "squiggly"
    /// </summary>
    public bool IsSquiggly => Subtype == "squiggly";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "strikeout"
    /// </summary>
    public bool IsStrikeout => Subtype == "strikeout";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "circle"
    /// </summary>
    public bool IsCircle => Subtype == "circle";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "square"
    /// </summary>
    public bool IsSquare => Subtype == "square";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "polygon"
    /// </summary>
    public bool IsPolygon => Subtype == "polygon";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "polyline"
    /// </summary>
    public bool IsPolyline => Subtype == "polyline";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "line"
    /// </summary>
    public bool IsLine => Subtype == "line";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "link"
    /// </summary>
    public bool IsLink => Subtype == "link";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "ink"
    /// </summary>
    public bool IsInk => Subtype == "ink";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "free-text"
    /// </summary>
    public bool IsFreeText => Subtype == "free-text";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "caret"
    /// </summary>
    public bool IsCaret => Subtype == "caret";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "text"
    /// </summary>
    public bool IsText => Subtype == "text";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "stamp"
    /// </summary>
    public bool IsStamp => Subtype == "stamp";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "file-attachment"
    /// </summary>
    public bool IsFileAttachment => Subtype == "file-attachment";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "widget"
    /// </summary>
    public bool IsWidget => Subtype == "widget";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "redact"
    /// </summary>
    public bool IsRedact => Subtype == "redact";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "unsupported"
    /// </summary>
    public bool IsUnsupported => Subtype == "unsupported";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlight"/> if <see cref="Subtype"/> is 'highlight', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'highlight'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlight AsHighlight() =>
        IsHighlight
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlight)Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Subtype is not 'highlight'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnderline"/> if <see cref="Subtype"/> is 'underline', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'underline'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnderline AsUnderline() =>
        IsUnderline
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnderline)Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Subtype is not 'underline'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquiggly"/> if <see cref="Subtype"/> is 'squiggly', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'squiggly'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquiggly AsSquiggly() =>
        IsSquiggly
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquiggly)Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Subtype is not 'squiggly'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStrikeout"/> if <see cref="Subtype"/> is 'strikeout', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'strikeout'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStrikeout AsStrikeout() =>
        IsStrikeout
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStrikeout)Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Subtype is not 'strikeout'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircle"/> if <see cref="Subtype"/> is 'circle', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'circle'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircle AsCircle() =>
        IsCircle
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircle)Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Subtype is not 'circle'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquare"/> if <see cref="Subtype"/> is 'square', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'square'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquare AsSquare() =>
        IsSquare
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquare)Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Subtype is not 'square'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygon"/> if <see cref="Subtype"/> is 'polygon', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'polygon'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygon AsPolygon() =>
        IsPolygon
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygon)Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Subtype is not 'polygon'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolyline"/> if <see cref="Subtype"/> is 'polyline', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'polyline'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolyline AsPolyline() =>
        IsPolyline
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolyline)Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Subtype is not 'polyline'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLine"/> if <see cref="Subtype"/> is 'line', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'line'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLine AsLine() =>
        IsLine
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLine)Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Subtype is not 'line'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLink"/> if <see cref="Subtype"/> is 'link', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'link'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLink AsLink() =>
        IsLink
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLink)Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Subtype is not 'link'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemInk"/> if <see cref="Subtype"/> is 'ink', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'ink'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemInk AsInk() =>
        IsInk
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemInk)Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Subtype is not 'ink'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeText"/> if <see cref="Subtype"/> is 'free-text', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'free-text'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeText AsFreeText() =>
        IsFreeText
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeText)Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Subtype is not 'free-text'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaret"/> if <see cref="Subtype"/> is 'caret', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'caret'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaret AsCaret() =>
        IsCaret
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaret)Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Subtype is not 'caret'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemText"/> if <see cref="Subtype"/> is 'text', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'text'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemText AsText() =>
        IsText
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemText)Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Subtype is not 'text'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStamp"/> if <see cref="Subtype"/> is 'stamp', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'stamp'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStamp AsStamp() =>
        IsStamp
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStamp)Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Subtype is not 'stamp'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachment"/> if <see cref="Subtype"/> is 'file-attachment', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'file-attachment'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachment AsFileAttachment() =>
        IsFileAttachment
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachment)
                Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Subtype is not 'file-attachment'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidget"/> if <see cref="Subtype"/> is 'widget', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'widget'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidget AsWidget() =>
        IsWidget
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidget)Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Subtype is not 'widget'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedact"/> if <see cref="Subtype"/> is 'redact', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'redact'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedact AsRedact() =>
        IsRedact
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedact)Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Subtype is not 'redact'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnsupported"/> if <see cref="Subtype"/> is 'unsupported', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'unsupported'.</exception>
    public CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnsupported AsUnsupported() =>
        IsUnsupported
            ? (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnsupported)Value!
            : throw new global::System.Exception(
                "DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Subtype is not 'unsupported'"
            );

    public T Match<T>(
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlight,
            T
        > onHighlight,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnderline,
            T
        > onUnderline,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquiggly,
            T
        > onSquiggly,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStrikeout,
            T
        > onStrikeout,
        Func<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircle, T> onCircle,
        Func<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquare, T> onSquare,
        Func<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygon, T> onPolygon,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolyline,
            T
        > onPolyline,
        Func<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLine, T> onLine,
        Func<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLink, T> onLink,
        Func<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemInk, T> onInk,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeText,
            T
        > onFreeText,
        Func<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaret, T> onCaret,
        Func<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemText, T> onText,
        Func<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStamp, T> onStamp,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachment,
            T
        > onFileAttachment,
        Func<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidget, T> onWidget,
        Func<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedact, T> onRedact,
        Func<
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnsupported,
            T
        > onUnsupported,
        Func<string, object?, T> onUnknown_
    )
    {
        return Subtype switch
        {
            "highlight" => onHighlight(AsHighlight()),
            "underline" => onUnderline(AsUnderline()),
            "squiggly" => onSquiggly(AsSquiggly()),
            "strikeout" => onStrikeout(AsStrikeout()),
            "circle" => onCircle(AsCircle()),
            "square" => onSquare(AsSquare()),
            "polygon" => onPolygon(AsPolygon()),
            "polyline" => onPolyline(AsPolyline()),
            "line" => onLine(AsLine()),
            "link" => onLink(AsLink()),
            "ink" => onInk(AsInk()),
            "free-text" => onFreeText(AsFreeText()),
            "caret" => onCaret(AsCaret()),
            "text" => onText(AsText()),
            "stamp" => onStamp(AsStamp()),
            "file-attachment" => onFileAttachment(AsFileAttachment()),
            "widget" => onWidget(AsWidget()),
            "redact" => onRedact(AsRedact()),
            "unsupported" => onUnsupported(AsUnsupported()),
            _ => onUnknown_(Subtype, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlight> onHighlight,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnderline> onUnderline,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquiggly> onSquiggly,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStrikeout> onStrikeout,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircle> onCircle,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquare> onSquare,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygon> onPolygon,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolyline> onPolyline,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLine> onLine,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLink> onLink,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemInk> onInk,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeText> onFreeText,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaret> onCaret,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemText> onText,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStamp> onStamp,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachment> onFileAttachment,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidget> onWidget,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedact> onRedact,
        Action<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnsupported> onUnsupported,
        Action<string, object?> onUnknown_
    )
    {
        switch (Subtype)
        {
            case "highlight":
                onHighlight(AsHighlight());
                break;
            case "underline":
                onUnderline(AsUnderline());
                break;
            case "squiggly":
                onSquiggly(AsSquiggly());
                break;
            case "strikeout":
                onStrikeout(AsStrikeout());
                break;
            case "circle":
                onCircle(AsCircle());
                break;
            case "square":
                onSquare(AsSquare());
                break;
            case "polygon":
                onPolygon(AsPolygon());
                break;
            case "polyline":
                onPolyline(AsPolyline());
                break;
            case "line":
                onLine(AsLine());
                break;
            case "link":
                onLink(AsLink());
                break;
            case "ink":
                onInk(AsInk());
                break;
            case "free-text":
                onFreeText(AsFreeText());
                break;
            case "caret":
                onCaret(AsCaret());
                break;
            case "text":
                onText(AsText());
                break;
            case "stamp":
                onStamp(AsStamp());
                break;
            case "file-attachment":
                onFileAttachment(AsFileAttachment());
                break;
            case "widget":
                onWidget(AsWidget());
                break;
            case "redact":
                onRedact(AsRedact());
                break;
            case "unsupported":
                onUnsupported(AsUnsupported());
                break;
            default:
                onUnknown_(Subtype, Value);
                break;
        }
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlight"/> and returns true if successful.
    /// </summary>
    public bool TryAsHighlight(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlight? value
    )
    {
        if (Subtype == "highlight")
        {
            value = (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlight)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnderline"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnderline(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnderline? value
    )
    {
        if (Subtype == "underline")
        {
            value = (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnderline)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquiggly"/> and returns true if successful.
    /// </summary>
    public bool TryAsSquiggly(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquiggly? value
    )
    {
        if (Subtype == "squiggly")
        {
            value = (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquiggly)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStrikeout"/> and returns true if successful.
    /// </summary>
    public bool TryAsStrikeout(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStrikeout? value
    )
    {
        if (Subtype == "strikeout")
        {
            value = (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStrikeout)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircle"/> and returns true if successful.
    /// </summary>
    public bool TryAsCircle(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircle? value
    )
    {
        if (Subtype == "circle")
        {
            value = (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircle)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquare"/> and returns true if successful.
    /// </summary>
    public bool TryAsSquare(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquare? value
    )
    {
        if (Subtype == "square")
        {
            value = (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquare)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygon"/> and returns true if successful.
    /// </summary>
    public bool TryAsPolygon(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygon? value
    )
    {
        if (Subtype == "polygon")
        {
            value = (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygon)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolyline"/> and returns true if successful.
    /// </summary>
    public bool TryAsPolyline(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolyline? value
    )
    {
        if (Subtype == "polyline")
        {
            value = (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolyline)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLine"/> and returns true if successful.
    /// </summary>
    public bool TryAsLine(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLine? value
    )
    {
        if (Subtype == "line")
        {
            value = (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLine)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLink"/> and returns true if successful.
    /// </summary>
    public bool TryAsLink(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLink? value
    )
    {
        if (Subtype == "link")
        {
            value = (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLink)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemInk"/> and returns true if successful.
    /// </summary>
    public bool TryAsInk(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemInk? value
    )
    {
        if (Subtype == "ink")
        {
            value = (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemInk)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeText"/> and returns true if successful.
    /// </summary>
    public bool TryAsFreeText(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeText? value
    )
    {
        if (Subtype == "free-text")
        {
            value = (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeText)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaret"/> and returns true if successful.
    /// </summary>
    public bool TryAsCaret(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaret? value
    )
    {
        if (Subtype == "caret")
        {
            value = (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaret)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemText"/> and returns true if successful.
    /// </summary>
    public bool TryAsText(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemText? value
    )
    {
        if (Subtype == "text")
        {
            value = (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemText)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStamp"/> and returns true if successful.
    /// </summary>
    public bool TryAsStamp(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStamp? value
    )
    {
        if (Subtype == "stamp")
        {
            value = (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStamp)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachment"/> and returns true if successful.
    /// </summary>
    public bool TryAsFileAttachment(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachment? value
    )
    {
        if (Subtype == "file-attachment")
        {
            value =
                (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachment)
                    Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidget"/> and returns true if successful.
    /// </summary>
    public bool TryAsWidget(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidget? value
    )
    {
        if (Subtype == "widget")
        {
            value = (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidget)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedact"/> and returns true if successful.
    /// </summary>
    public bool TryAsRedact(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedact? value
    )
    {
        if (Subtype == "redact")
        {
            value = (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedact)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnsupported"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnsupported(
        out CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnsupported? value
    )
    {
        if (Subtype == "unsupported")
        {
            value = (CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnsupported)
                Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Highlight value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Underline value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Squiggly value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Strikeout value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Circle value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Square value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Polygon value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Polyline value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Line value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Link value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Ink value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.FreeText value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Caret value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Text value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Stamp value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.FileAttachment value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Widget value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Redact value
    ) => new(value);

    public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
        DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Unsupported value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocAnnotationsListAll200ResponsePagesItemAnnotationsItem>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocAnnotationsListAll200ResponsePagesItemAnnotationsItem).IsAssignableFrom(
                typeToConvert
            );

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItem Read(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var json = JsonElement.ParseValue(ref reader);
            if (!json.TryGetProperty("subtype", out var discriminatorElement))
            {
                throw new JsonException("Missing discriminator property 'subtype'");
            }
            if (discriminatorElement.ValueKind != JsonValueKind.String)
            {
                if (discriminatorElement.ValueKind == JsonValueKind.Null)
                {
                    throw new JsonException("Discriminator property 'subtype' is null");
                }

                throw new JsonException(
                    $"Discriminator property 'subtype' is not a string, instead is {discriminatorElement.ToString()}"
                );
            }

            var discriminator =
                discriminatorElement.GetString()
                ?? throw new JsonException("Discriminator property 'subtype' is null");

            // Strip the discriminant property to prevent it from leaking into AdditionalProperties
            var jsonObject = System.Text.Json.Nodes.JsonObject.Create(json);
            jsonObject?.Remove("subtype");
            var jsonWithoutDiscriminator =
                jsonObject != null ? JsonSerializer.SerializeToElement(jsonObject, options) : json;

            var value = discriminator switch
            {
                "highlight" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlight?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlight"
                        ),
                "underline" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnderline?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnderline"
                        ),
                "squiggly" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquiggly?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquiggly"
                        ),
                "strikeout" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStrikeout?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStrikeout"
                        ),
                "circle" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircle?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircle"
                        ),
                "square" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquare?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquare"
                        ),
                "polygon" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygon?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygon"
                        ),
                "polyline" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolyline?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolyline"
                        ),
                "line" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLine?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLine"
                        ),
                "link" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLink?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLink"
                        ),
                "ink" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemInk?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemInk"
                        ),
                "free-text" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeText?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeText"
                        ),
                "caret" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaret?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaret"
                        ),
                "text" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemText?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemText"
                        ),
                "stamp" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStamp?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStamp"
                        ),
                "file-attachment" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachment?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachment"
                        ),
                "widget" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidget?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidget"
                        ),
                "redact" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedact?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedact"
                        ),
                "unsupported" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnsupported?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnsupported"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
                discriminator,
                value
            );
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItem value,
            JsonSerializerOptions options
        )
        {
            JsonNode json =
                value.Subtype switch
                {
                    "highlight" => JsonSerializer.SerializeToNode(value.Value, options),
                    "underline" => JsonSerializer.SerializeToNode(value.Value, options),
                    "squiggly" => JsonSerializer.SerializeToNode(value.Value, options),
                    "strikeout" => JsonSerializer.SerializeToNode(value.Value, options),
                    "circle" => JsonSerializer.SerializeToNode(value.Value, options),
                    "square" => JsonSerializer.SerializeToNode(value.Value, options),
                    "polygon" => JsonSerializer.SerializeToNode(value.Value, options),
                    "polyline" => JsonSerializer.SerializeToNode(value.Value, options),
                    "line" => JsonSerializer.SerializeToNode(value.Value, options),
                    "link" => JsonSerializer.SerializeToNode(value.Value, options),
                    "ink" => JsonSerializer.SerializeToNode(value.Value, options),
                    "free-text" => JsonSerializer.SerializeToNode(value.Value, options),
                    "caret" => JsonSerializer.SerializeToNode(value.Value, options),
                    "text" => JsonSerializer.SerializeToNode(value.Value, options),
                    "stamp" => JsonSerializer.SerializeToNode(value.Value, options),
                    "file-attachment" => JsonSerializer.SerializeToNode(value.Value, options),
                    "widget" => JsonSerializer.SerializeToNode(value.Value, options),
                    "redact" => JsonSerializer.SerializeToNode(value.Value, options),
                    "unsupported" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["subtype"] = value.Subtype;
            json.WriteTo(writer, options);
        }

        public override DocAnnotationsListAll200ResponsePagesItemAnnotationsItem ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocAnnotationsListAll200ResponsePagesItemAnnotationsItem(
                stringValue,
                stringValue
            );
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsListAll200ResponsePagesItemAnnotationsItem value,
            JsonSerializerOptions options
        )
        {
            writer.WritePropertyName(value.Subtype);
        }
    }

    /// <summary>
    /// Discriminated union type for highlight
    /// </summary>
    [Serializable]
    public struct Highlight
    {
        public Highlight(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlight value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlight Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Highlight(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemHighlight value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for underline
    /// </summary>
    [Serializable]
    public struct Underline
    {
        public Underline(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnderline value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnderline Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Underline(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnderline value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for squiggly
    /// </summary>
    [Serializable]
    public struct Squiggly
    {
        public Squiggly(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquiggly value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquiggly Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Squiggly(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquiggly value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for strikeout
    /// </summary>
    [Serializable]
    public struct Strikeout
    {
        public Strikeout(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStrikeout value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStrikeout Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Strikeout(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStrikeout value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for circle
    /// </summary>
    [Serializable]
    public struct Circle
    {
        public Circle(CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircle value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircle Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Circle(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCircle value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for square
    /// </summary>
    [Serializable]
    public struct Square
    {
        public Square(CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquare value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquare Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Square(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemSquare value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for polygon
    /// </summary>
    [Serializable]
    public struct Polygon
    {
        public Polygon(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygon value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygon Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Polygon(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolygon value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for polyline
    /// </summary>
    [Serializable]
    public struct Polyline
    {
        public Polyline(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolyline value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolyline Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Polyline(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemPolyline value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for line
    /// </summary>
    [Serializable]
    public struct Line
    {
        public Line(CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLine value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLine Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Line(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLine value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for link
    /// </summary>
    [Serializable]
    public struct Link
    {
        public Link(CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLink value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLink Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Link(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemLink value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for ink
    /// </summary>
    [Serializable]
    public struct Ink
    {
        public Ink(CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemInk value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemInk Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Ink(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemInk value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for free-text
    /// </summary>
    [Serializable]
    public struct FreeText
    {
        public FreeText(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeText value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeText Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.FreeText(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFreeText value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for caret
    /// </summary>
    [Serializable]
    public struct Caret
    {
        public Caret(CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaret value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaret Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Caret(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemCaret value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for text
    /// </summary>
    [Serializable]
    public struct Text
    {
        public Text(CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemText value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemText Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Text(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemText value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for stamp
    /// </summary>
    [Serializable]
    public struct Stamp
    {
        public Stamp(CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStamp value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStamp Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Stamp(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemStamp value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for file-attachment
    /// </summary>
    [Serializable]
    public struct FileAttachment
    {
        public FileAttachment(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachment value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachment Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.FileAttachment(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemFileAttachment value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for widget
    /// </summary>
    [Serializable]
    public struct Widget
    {
        public Widget(CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidget value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidget Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Widget(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemWidget value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for redact
    /// </summary>
    [Serializable]
    public struct Redact
    {
        public Redact(CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedact value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedact Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Redact(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemRedact value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unsupported
    /// </summary>
    [Serializable]
    public struct Unsupported
    {
        public Unsupported(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnsupported value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnsupported Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsListAll200ResponsePagesItemAnnotationsItem.Unsupported(
            CloudPDF.DocAnnotationsListAll200ResponsePagesItemAnnotationsItemUnsupported value
        ) => new(value);
    }
}
