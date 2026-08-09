// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(DocAnnotationsList200ResponseAnnotationsItem.JsonConverter))]
[Serializable]
public record DocAnnotationsList200ResponseAnnotationsItem
{
    internal DocAnnotationsList200ResponseAnnotationsItem(string type, object? value)
    {
        Subtype = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Highlight"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Highlight value
    )
    {
        Subtype = "highlight";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Underline"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Underline value
    )
    {
        Subtype = "underline";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Squiggly"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Squiggly value
    )
    {
        Subtype = "squiggly";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Strikeout"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Strikeout value
    )
    {
        Subtype = "strikeout";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Circle"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Circle value
    )
    {
        Subtype = "circle";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Square"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Square value
    )
    {
        Subtype = "square";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Polygon"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Polygon value
    )
    {
        Subtype = "polygon";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Polyline"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Polyline value
    )
    {
        Subtype = "polyline";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Line"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Line value
    )
    {
        Subtype = "line";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Link"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Link value
    )
    {
        Subtype = "link";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Ink"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Ink value
    )
    {
        Subtype = "ink";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.FreeText"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.FreeText value
    )
    {
        Subtype = "free-text";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Caret"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Caret value
    )
    {
        Subtype = "caret";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Text"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Text value
    )
    {
        Subtype = "text";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Stamp"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Stamp value
    )
    {
        Subtype = "stamp";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.FileAttachment"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.FileAttachment value
    )
    {
        Subtype = "file-attachment";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Widget"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Widget value
    )
    {
        Subtype = "widget";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Redact"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Redact value
    )
    {
        Subtype = "redact";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of DocAnnotationsList200ResponseAnnotationsItem with <see cref="DocAnnotationsList200ResponseAnnotationsItem.Unsupported"/>.
    /// </summary>
    public DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Unsupported value
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
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemHighlight"/> if <see cref="Subtype"/> is 'highlight', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'highlight'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemHighlight AsHighlight() =>
        IsHighlight
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemHighlight)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'highlight'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnderline"/> if <see cref="Subtype"/> is 'underline', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'underline'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnderline AsUnderline() =>
        IsUnderline
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnderline)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'underline'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquiggly"/> if <see cref="Subtype"/> is 'squiggly', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'squiggly'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquiggly AsSquiggly() =>
        IsSquiggly
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquiggly)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'squiggly'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeout"/> if <see cref="Subtype"/> is 'strikeout', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'strikeout'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeout AsStrikeout() =>
        IsStrikeout
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeout)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'strikeout'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircle"/> if <see cref="Subtype"/> is 'circle', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'circle'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircle AsCircle() =>
        IsCircle
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircle)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'circle'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquare"/> if <see cref="Subtype"/> is 'square', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'square'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquare AsSquare() =>
        IsSquare
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquare)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'square'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolygon"/> if <see cref="Subtype"/> is 'polygon', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'polygon'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolygon AsPolygon() =>
        IsPolygon
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolygon)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'polygon'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolyline"/> if <see cref="Subtype"/> is 'polyline', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'polyline'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolyline AsPolyline() =>
        IsPolyline
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolyline)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'polyline'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLine"/> if <see cref="Subtype"/> is 'line', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'line'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLine AsLine() =>
        IsLine
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLine)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'line'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLink"/> if <see cref="Subtype"/> is 'link', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'link'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLink AsLink() =>
        IsLink
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLink)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'link'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemInk"/> if <see cref="Subtype"/> is 'ink', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'ink'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemInk AsInk() =>
        IsInk
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemInk)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'ink'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFreeText"/> if <see cref="Subtype"/> is 'free-text', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'free-text'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFreeText AsFreeText() =>
        IsFreeText
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFreeText)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'free-text'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCaret"/> if <see cref="Subtype"/> is 'caret', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'caret'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCaret AsCaret() =>
        IsCaret
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCaret)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'caret'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemText"/> if <see cref="Subtype"/> is 'text', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'text'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemText AsText() =>
        IsText
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemText)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'text'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStamp"/> if <see cref="Subtype"/> is 'stamp', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'stamp'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStamp AsStamp() =>
        IsStamp
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStamp)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'stamp'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFileAttachment"/> if <see cref="Subtype"/> is 'file-attachment', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'file-attachment'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFileAttachment AsFileAttachment() =>
        IsFileAttachment
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFileAttachment)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'file-attachment'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemWidget"/> if <see cref="Subtype"/> is 'widget', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'widget'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemWidget AsWidget() =>
        IsWidget
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemWidget)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'widget'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemRedact"/> if <see cref="Subtype"/> is 'redact', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'redact'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemRedact AsRedact() =>
        IsRedact
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemRedact)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'redact'"
            );

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnsupported"/> if <see cref="Subtype"/> is 'unsupported', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'unsupported'.</exception>
    public CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnsupported AsUnsupported() =>
        IsUnsupported
            ? (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnsupported)Value!
            : throw new global::System.Exception(
                "DocAnnotationsList200ResponseAnnotationsItem.Subtype is not 'unsupported'"
            );

    public T Match<T>(
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemHighlight, T> onHighlight,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnderline, T> onUnderline,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquiggly, T> onSquiggly,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeout, T> onStrikeout,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircle, T> onCircle,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquare, T> onSquare,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolygon, T> onPolygon,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolyline, T> onPolyline,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLine, T> onLine,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLink, T> onLink,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemInk, T> onInk,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFreeText, T> onFreeText,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCaret, T> onCaret,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemText, T> onText,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStamp, T> onStamp,
        Func<
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFileAttachment,
            T
        > onFileAttachment,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemWidget, T> onWidget,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemRedact, T> onRedact,
        Func<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnsupported, T> onUnsupported,
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
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemHighlight> onHighlight,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnderline> onUnderline,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquiggly> onSquiggly,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeout> onStrikeout,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircle> onCircle,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquare> onSquare,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolygon> onPolygon,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolyline> onPolyline,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLine> onLine,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLink> onLink,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemInk> onInk,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFreeText> onFreeText,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCaret> onCaret,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemText> onText,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStamp> onStamp,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFileAttachment> onFileAttachment,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemWidget> onWidget,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemRedact> onRedact,
        Action<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnsupported> onUnsupported,
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
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemHighlight"/> and returns true if successful.
    /// </summary>
    public bool TryAsHighlight(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemHighlight? value
    )
    {
        if (Subtype == "highlight")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemHighlight)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnderline"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnderline(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnderline? value
    )
    {
        if (Subtype == "underline")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnderline)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquiggly"/> and returns true if successful.
    /// </summary>
    public bool TryAsSquiggly(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquiggly? value
    )
    {
        if (Subtype == "squiggly")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquiggly)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeout"/> and returns true if successful.
    /// </summary>
    public bool TryAsStrikeout(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeout? value
    )
    {
        if (Subtype == "strikeout")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeout)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircle"/> and returns true if successful.
    /// </summary>
    public bool TryAsCircle(out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircle? value)
    {
        if (Subtype == "circle")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircle)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquare"/> and returns true if successful.
    /// </summary>
    public bool TryAsSquare(out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquare? value)
    {
        if (Subtype == "square")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquare)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolygon"/> and returns true if successful.
    /// </summary>
    public bool TryAsPolygon(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolygon? value
    )
    {
        if (Subtype == "polygon")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolygon)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolyline"/> and returns true if successful.
    /// </summary>
    public bool TryAsPolyline(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolyline? value
    )
    {
        if (Subtype == "polyline")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolyline)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLine"/> and returns true if successful.
    /// </summary>
    public bool TryAsLine(out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLine? value)
    {
        if (Subtype == "line")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLine)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLink"/> and returns true if successful.
    /// </summary>
    public bool TryAsLink(out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLink? value)
    {
        if (Subtype == "link")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLink)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemInk"/> and returns true if successful.
    /// </summary>
    public bool TryAsInk(out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemInk? value)
    {
        if (Subtype == "ink")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemInk)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFreeText"/> and returns true if successful.
    /// </summary>
    public bool TryAsFreeText(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFreeText? value
    )
    {
        if (Subtype == "free-text")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFreeText)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCaret"/> and returns true if successful.
    /// </summary>
    public bool TryAsCaret(out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCaret? value)
    {
        if (Subtype == "caret")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCaret)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemText"/> and returns true if successful.
    /// </summary>
    public bool TryAsText(out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemText? value)
    {
        if (Subtype == "text")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemText)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStamp"/> and returns true if successful.
    /// </summary>
    public bool TryAsStamp(out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStamp? value)
    {
        if (Subtype == "stamp")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStamp)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFileAttachment"/> and returns true if successful.
    /// </summary>
    public bool TryAsFileAttachment(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFileAttachment? value
    )
    {
        if (Subtype == "file-attachment")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFileAttachment)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemWidget"/> and returns true if successful.
    /// </summary>
    public bool TryAsWidget(out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemWidget? value)
    {
        if (Subtype == "widget")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemWidget)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemRedact"/> and returns true if successful.
    /// </summary>
    public bool TryAsRedact(out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemRedact? value)
    {
        if (Subtype == "redact")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemRedact)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnsupported"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnsupported(
        out CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnsupported? value
    )
    {
        if (Subtype == "unsupported")
        {
            value = (CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnsupported)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Highlight value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Underline value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Squiggly value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Strikeout value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Circle value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Square value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Polygon value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Polyline value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Line value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Link value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Ink value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.FreeText value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Caret value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Text value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Stamp value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.FileAttachment value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Widget value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Redact value
    ) => new(value);

    public static implicit operator DocAnnotationsList200ResponseAnnotationsItem(
        DocAnnotationsList200ResponseAnnotationsItem.Unsupported value
    ) => new(value);

    [Serializable]
    internal sealed class JsonConverter
        : JsonConverter<DocAnnotationsList200ResponseAnnotationsItem>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(DocAnnotationsList200ResponseAnnotationsItem).IsAssignableFrom(typeToConvert);

        public override DocAnnotationsList200ResponseAnnotationsItem Read(
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
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemHighlight?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemHighlight"
                        ),
                "underline" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnderline?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnderline"
                        ),
                "squiggly" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquiggly?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquiggly"
                        ),
                "strikeout" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeout?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeout"
                        ),
                "circle" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircle?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircle"
                        ),
                "square" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquare?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquare"
                        ),
                "polygon" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolygon?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolygon"
                        ),
                "polyline" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolyline?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolyline"
                        ),
                "line" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLine?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLine"
                        ),
                "link" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLink?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLink"
                        ),
                "ink" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemInk?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemInk"
                        ),
                "free-text" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFreeText?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFreeText"
                        ),
                "caret" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCaret?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCaret"
                        ),
                "text" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemText?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemText"
                        ),
                "stamp" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStamp?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStamp"
                        ),
                "file-attachment" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFileAttachment?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFileAttachment"
                        ),
                "widget" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemWidget?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemWidget"
                        ),
                "redact" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemRedact?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemRedact"
                        ),
                "unsupported" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnsupported?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnsupported"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new DocAnnotationsList200ResponseAnnotationsItem(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItem value,
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

        public override DocAnnotationsList200ResponseAnnotationsItem ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new DocAnnotationsList200ResponseAnnotationsItem(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            DocAnnotationsList200ResponseAnnotationsItem value,
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
        public Highlight(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemHighlight value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemHighlight Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Highlight(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemHighlight value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for underline
    /// </summary>
    [Serializable]
    public struct Underline
    {
        public Underline(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnderline value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnderline Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Underline(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnderline value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for squiggly
    /// </summary>
    [Serializable]
    public struct Squiggly
    {
        public Squiggly(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquiggly value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquiggly Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Squiggly(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquiggly value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for strikeout
    /// </summary>
    [Serializable]
    public struct Strikeout
    {
        public Strikeout(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeout value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeout Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Strikeout(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStrikeout value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for circle
    /// </summary>
    [Serializable]
    public struct Circle
    {
        public Circle(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircle value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircle Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Circle(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCircle value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for square
    /// </summary>
    [Serializable]
    public struct Square
    {
        public Square(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquare value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquare Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Square(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemSquare value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for polygon
    /// </summary>
    [Serializable]
    public struct Polygon
    {
        public Polygon(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolygon value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolygon Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Polygon(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolygon value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for polyline
    /// </summary>
    [Serializable]
    public struct Polyline
    {
        public Polyline(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolyline value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolyline Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Polyline(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemPolyline value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for line
    /// </summary>
    [Serializable]
    public struct Line
    {
        public Line(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLine value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLine Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Line(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLine value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for link
    /// </summary>
    [Serializable]
    public struct Link
    {
        public Link(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLink value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLink Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Link(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemLink value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for ink
    /// </summary>
    [Serializable]
    public struct Ink
    {
        public Ink(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemInk value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemInk Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Ink(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemInk value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for free-text
    /// </summary>
    [Serializable]
    public struct FreeText
    {
        public FreeText(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFreeText value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFreeText Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.FreeText(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFreeText value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for caret
    /// </summary>
    [Serializable]
    public struct Caret
    {
        public Caret(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCaret value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCaret Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Caret(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemCaret value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for text
    /// </summary>
    [Serializable]
    public struct Text
    {
        public Text(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemText value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemText Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Text(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemText value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for stamp
    /// </summary>
    [Serializable]
    public struct Stamp
    {
        public Stamp(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStamp value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStamp Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Stamp(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemStamp value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for file-attachment
    /// </summary>
    [Serializable]
    public struct FileAttachment
    {
        public FileAttachment(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFileAttachment value
        )
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFileAttachment Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.FileAttachment(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemFileAttachment value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for widget
    /// </summary>
    [Serializable]
    public struct Widget
    {
        public Widget(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemWidget value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemWidget Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Widget(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemWidget value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for redact
    /// </summary>
    [Serializable]
    public struct Redact
    {
        public Redact(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemRedact value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemRedact Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Redact(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemRedact value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for unsupported
    /// </summary>
    [Serializable]
    public struct Unsupported
    {
        public Unsupported(CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnsupported value)
        {
            Value = value;
        }

        internal CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnsupported Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator DocAnnotationsList200ResponseAnnotationsItem.Unsupported(
            CloudPDF.DocAnnotationsList200ResponseAnnotationsItemUnsupported value
        ) => new(value);
    }
}
