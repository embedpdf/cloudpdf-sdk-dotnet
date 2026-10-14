// ReSharper disable NullableWarningSuppressionIsUsed
// ReSharper disable InconsistentNaming

using CloudPDF.Core;
using global::System.Text.Json;
using global::System.Text.Json.Nodes;
using global::System.Text.Json.Serialization;

namespace CloudPDF;

[JsonConverter(typeof(Annotation.JsonConverter))]
[Serializable]
public record Annotation
{
    internal Annotation(string type, object? value)
    {
        Subtype = type;
        Value = value;
    }

    /// <summary>
    /// Create an instance of Annotation with <see cref="Annotation.Highlight"/>.
    /// </summary>
    public Annotation(Annotation.Highlight value)
    {
        Subtype = "highlight";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of Annotation with <see cref="Annotation.Underline"/>.
    /// </summary>
    public Annotation(Annotation.Underline value)
    {
        Subtype = "underline";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of Annotation with <see cref="Annotation.Squiggly"/>.
    /// </summary>
    public Annotation(Annotation.Squiggly value)
    {
        Subtype = "squiggly";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of Annotation with <see cref="Annotation.Strikeout"/>.
    /// </summary>
    public Annotation(Annotation.Strikeout value)
    {
        Subtype = "strikeout";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of Annotation with <see cref="Annotation.Circle"/>.
    /// </summary>
    public Annotation(Annotation.Circle value)
    {
        Subtype = "circle";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of Annotation with <see cref="Annotation.Square"/>.
    /// </summary>
    public Annotation(Annotation.Square value)
    {
        Subtype = "square";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of Annotation with <see cref="Annotation.Polygon"/>.
    /// </summary>
    public Annotation(Annotation.Polygon value)
    {
        Subtype = "polygon";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of Annotation with <see cref="Annotation.Polyline"/>.
    /// </summary>
    public Annotation(Annotation.Polyline value)
    {
        Subtype = "polyline";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of Annotation with <see cref="Annotation.Line"/>.
    /// </summary>
    public Annotation(Annotation.Line value)
    {
        Subtype = "line";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of Annotation with <see cref="Annotation.Link"/>.
    /// </summary>
    public Annotation(Annotation.Link value)
    {
        Subtype = "link";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of Annotation with <see cref="Annotation.Ink"/>.
    /// </summary>
    public Annotation(Annotation.Ink value)
    {
        Subtype = "ink";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of Annotation with <see cref="Annotation.FreeText"/>.
    /// </summary>
    public Annotation(Annotation.FreeText value)
    {
        Subtype = "free-text";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of Annotation with <see cref="Annotation.Caret"/>.
    /// </summary>
    public Annotation(Annotation.Caret value)
    {
        Subtype = "caret";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of Annotation with <see cref="Annotation.Text"/>.
    /// </summary>
    public Annotation(Annotation.Text value)
    {
        Subtype = "text";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of Annotation with <see cref="Annotation.Stamp"/>.
    /// </summary>
    public Annotation(Annotation.Stamp value)
    {
        Subtype = "stamp";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of Annotation with <see cref="Annotation.FileAttachment"/>.
    /// </summary>
    public Annotation(Annotation.FileAttachment value)
    {
        Subtype = "file-attachment";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of Annotation with <see cref="Annotation.Widget"/>.
    /// </summary>
    public Annotation(Annotation.Widget value)
    {
        Subtype = "widget";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of Annotation with <see cref="Annotation.Redact"/>.
    /// </summary>
    public Annotation(Annotation.Redact value)
    {
        Subtype = "redact";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of Annotation with <see cref="Annotation.Popup"/>.
    /// </summary>
    public Annotation(Annotation.Popup value)
    {
        Subtype = "popup";
        Value = value.Value;
    }

    /// <summary>
    /// Create an instance of Annotation with <see cref="Annotation.Unsupported"/>.
    /// </summary>
    public Annotation(Annotation.Unsupported value)
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
    /// Returns true if <see cref="Subtype"/> is "popup"
    /// </summary>
    public bool IsPopup => Subtype == "popup";

    /// <summary>
    /// Returns true if <see cref="Subtype"/> is "unsupported"
    /// </summary>
    public bool IsUnsupported => Subtype == "unsupported";

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationHighlight"/> if <see cref="Subtype"/> is 'highlight', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'highlight'.</exception>
    public CloudPDF.AnnotationHighlight AsHighlight() =>
        IsHighlight
            ? (CloudPDF.AnnotationHighlight)Value!
            : throw new global::System.Exception("Annotation.Subtype is not 'highlight'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationUnderline"/> if <see cref="Subtype"/> is 'underline', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'underline'.</exception>
    public CloudPDF.AnnotationUnderline AsUnderline() =>
        IsUnderline
            ? (CloudPDF.AnnotationUnderline)Value!
            : throw new global::System.Exception("Annotation.Subtype is not 'underline'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationSquiggly"/> if <see cref="Subtype"/> is 'squiggly', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'squiggly'.</exception>
    public CloudPDF.AnnotationSquiggly AsSquiggly() =>
        IsSquiggly
            ? (CloudPDF.AnnotationSquiggly)Value!
            : throw new global::System.Exception("Annotation.Subtype is not 'squiggly'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationStrikeout"/> if <see cref="Subtype"/> is 'strikeout', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'strikeout'.</exception>
    public CloudPDF.AnnotationStrikeout AsStrikeout() =>
        IsStrikeout
            ? (CloudPDF.AnnotationStrikeout)Value!
            : throw new global::System.Exception("Annotation.Subtype is not 'strikeout'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationCircle"/> if <see cref="Subtype"/> is 'circle', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'circle'.</exception>
    public CloudPDF.AnnotationCircle AsCircle() =>
        IsCircle
            ? (CloudPDF.AnnotationCircle)Value!
            : throw new global::System.Exception("Annotation.Subtype is not 'circle'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationSquare"/> if <see cref="Subtype"/> is 'square', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'square'.</exception>
    public CloudPDF.AnnotationSquare AsSquare() =>
        IsSquare
            ? (CloudPDF.AnnotationSquare)Value!
            : throw new global::System.Exception("Annotation.Subtype is not 'square'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPolygon"/> if <see cref="Subtype"/> is 'polygon', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'polygon'.</exception>
    public CloudPDF.AnnotationPolygon AsPolygon() =>
        IsPolygon
            ? (CloudPDF.AnnotationPolygon)Value!
            : throw new global::System.Exception("Annotation.Subtype is not 'polygon'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPolyline"/> if <see cref="Subtype"/> is 'polyline', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'polyline'.</exception>
    public CloudPDF.AnnotationPolyline AsPolyline() =>
        IsPolyline
            ? (CloudPDF.AnnotationPolyline)Value!
            : throw new global::System.Exception("Annotation.Subtype is not 'polyline'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationLine"/> if <see cref="Subtype"/> is 'line', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'line'.</exception>
    public CloudPDF.AnnotationLine AsLine() =>
        IsLine
            ? (CloudPDF.AnnotationLine)Value!
            : throw new global::System.Exception("Annotation.Subtype is not 'line'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationLink"/> if <see cref="Subtype"/> is 'link', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'link'.</exception>
    public CloudPDF.AnnotationLink AsLink() =>
        IsLink
            ? (CloudPDF.AnnotationLink)Value!
            : throw new global::System.Exception("Annotation.Subtype is not 'link'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationInk"/> if <see cref="Subtype"/> is 'ink', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'ink'.</exception>
    public CloudPDF.AnnotationInk AsInk() =>
        IsInk
            ? (CloudPDF.AnnotationInk)Value!
            : throw new global::System.Exception("Annotation.Subtype is not 'ink'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationFreeText"/> if <see cref="Subtype"/> is 'free-text', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'free-text'.</exception>
    public CloudPDF.AnnotationFreeText AsFreeText() =>
        IsFreeText
            ? (CloudPDF.AnnotationFreeText)Value!
            : throw new global::System.Exception("Annotation.Subtype is not 'free-text'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationCaret"/> if <see cref="Subtype"/> is 'caret', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'caret'.</exception>
    public CloudPDF.AnnotationCaret AsCaret() =>
        IsCaret
            ? (CloudPDF.AnnotationCaret)Value!
            : throw new global::System.Exception("Annotation.Subtype is not 'caret'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationText"/> if <see cref="Subtype"/> is 'text', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'text'.</exception>
    public CloudPDF.AnnotationText AsText() =>
        IsText
            ? (CloudPDF.AnnotationText)Value!
            : throw new global::System.Exception("Annotation.Subtype is not 'text'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationStamp"/> if <see cref="Subtype"/> is 'stamp', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'stamp'.</exception>
    public CloudPDF.AnnotationStamp AsStamp() =>
        IsStamp
            ? (CloudPDF.AnnotationStamp)Value!
            : throw new global::System.Exception("Annotation.Subtype is not 'stamp'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationFileAttachment"/> if <see cref="Subtype"/> is 'file-attachment', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'file-attachment'.</exception>
    public CloudPDF.AnnotationFileAttachment AsFileAttachment() =>
        IsFileAttachment
            ? (CloudPDF.AnnotationFileAttachment)Value!
            : throw new global::System.Exception("Annotation.Subtype is not 'file-attachment'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.WidgetAnnotation"/> if <see cref="Subtype"/> is 'widget', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'widget'.</exception>
    public CloudPDF.WidgetAnnotation AsWidget() =>
        IsWidget
            ? (CloudPDF.WidgetAnnotation)Value!
            : throw new global::System.Exception("Annotation.Subtype is not 'widget'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationRedact"/> if <see cref="Subtype"/> is 'redact', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'redact'.</exception>
    public CloudPDF.AnnotationRedact AsRedact() =>
        IsRedact
            ? (CloudPDF.AnnotationRedact)Value!
            : throw new global::System.Exception("Annotation.Subtype is not 'redact'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationPopup"/> if <see cref="Subtype"/> is 'popup', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'popup'.</exception>
    public CloudPDF.AnnotationPopup AsPopup() =>
        IsPopup
            ? (CloudPDF.AnnotationPopup)Value!
            : throw new global::System.Exception("Annotation.Subtype is not 'popup'");

    /// <summary>
    /// Returns the value as a <see cref="CloudPDF.AnnotationUnsupported"/> if <see cref="Subtype"/> is 'unsupported', otherwise throws an exception.
    /// </summary>
    /// <exception cref="Exception">Thrown when <see cref="Subtype"/> is not 'unsupported'.</exception>
    public CloudPDF.AnnotationUnsupported AsUnsupported() =>
        IsUnsupported
            ? (CloudPDF.AnnotationUnsupported)Value!
            : throw new global::System.Exception("Annotation.Subtype is not 'unsupported'");

    public T Match<T>(
        Func<CloudPDF.AnnotationHighlight, T> onHighlight,
        Func<CloudPDF.AnnotationUnderline, T> onUnderline,
        Func<CloudPDF.AnnotationSquiggly, T> onSquiggly,
        Func<CloudPDF.AnnotationStrikeout, T> onStrikeout,
        Func<CloudPDF.AnnotationCircle, T> onCircle,
        Func<CloudPDF.AnnotationSquare, T> onSquare,
        Func<CloudPDF.AnnotationPolygon, T> onPolygon,
        Func<CloudPDF.AnnotationPolyline, T> onPolyline,
        Func<CloudPDF.AnnotationLine, T> onLine,
        Func<CloudPDF.AnnotationLink, T> onLink,
        Func<CloudPDF.AnnotationInk, T> onInk,
        Func<CloudPDF.AnnotationFreeText, T> onFreeText,
        Func<CloudPDF.AnnotationCaret, T> onCaret,
        Func<CloudPDF.AnnotationText, T> onText,
        Func<CloudPDF.AnnotationStamp, T> onStamp,
        Func<CloudPDF.AnnotationFileAttachment, T> onFileAttachment,
        Func<CloudPDF.WidgetAnnotation, T> onWidget,
        Func<CloudPDF.AnnotationRedact, T> onRedact,
        Func<CloudPDF.AnnotationPopup, T> onPopup,
        Func<CloudPDF.AnnotationUnsupported, T> onUnsupported,
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
            "popup" => onPopup(AsPopup()),
            "unsupported" => onUnsupported(AsUnsupported()),
            _ => onUnknown_(Subtype, Value),
        };
    }

    public void Visit(
        Action<CloudPDF.AnnotationHighlight> onHighlight,
        Action<CloudPDF.AnnotationUnderline> onUnderline,
        Action<CloudPDF.AnnotationSquiggly> onSquiggly,
        Action<CloudPDF.AnnotationStrikeout> onStrikeout,
        Action<CloudPDF.AnnotationCircle> onCircle,
        Action<CloudPDF.AnnotationSquare> onSquare,
        Action<CloudPDF.AnnotationPolygon> onPolygon,
        Action<CloudPDF.AnnotationPolyline> onPolyline,
        Action<CloudPDF.AnnotationLine> onLine,
        Action<CloudPDF.AnnotationLink> onLink,
        Action<CloudPDF.AnnotationInk> onInk,
        Action<CloudPDF.AnnotationFreeText> onFreeText,
        Action<CloudPDF.AnnotationCaret> onCaret,
        Action<CloudPDF.AnnotationText> onText,
        Action<CloudPDF.AnnotationStamp> onStamp,
        Action<CloudPDF.AnnotationFileAttachment> onFileAttachment,
        Action<CloudPDF.WidgetAnnotation> onWidget,
        Action<CloudPDF.AnnotationRedact> onRedact,
        Action<CloudPDF.AnnotationPopup> onPopup,
        Action<CloudPDF.AnnotationUnsupported> onUnsupported,
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
            case "popup":
                onPopup(AsPopup());
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
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationHighlight"/> and returns true if successful.
    /// </summary>
    public bool TryAsHighlight(out CloudPDF.AnnotationHighlight? value)
    {
        if (Subtype == "highlight")
        {
            value = (CloudPDF.AnnotationHighlight)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationUnderline"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnderline(out CloudPDF.AnnotationUnderline? value)
    {
        if (Subtype == "underline")
        {
            value = (CloudPDF.AnnotationUnderline)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationSquiggly"/> and returns true if successful.
    /// </summary>
    public bool TryAsSquiggly(out CloudPDF.AnnotationSquiggly? value)
    {
        if (Subtype == "squiggly")
        {
            value = (CloudPDF.AnnotationSquiggly)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationStrikeout"/> and returns true if successful.
    /// </summary>
    public bool TryAsStrikeout(out CloudPDF.AnnotationStrikeout? value)
    {
        if (Subtype == "strikeout")
        {
            value = (CloudPDF.AnnotationStrikeout)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationCircle"/> and returns true if successful.
    /// </summary>
    public bool TryAsCircle(out CloudPDF.AnnotationCircle? value)
    {
        if (Subtype == "circle")
        {
            value = (CloudPDF.AnnotationCircle)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationSquare"/> and returns true if successful.
    /// </summary>
    public bool TryAsSquare(out CloudPDF.AnnotationSquare? value)
    {
        if (Subtype == "square")
        {
            value = (CloudPDF.AnnotationSquare)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPolygon"/> and returns true if successful.
    /// </summary>
    public bool TryAsPolygon(out CloudPDF.AnnotationPolygon? value)
    {
        if (Subtype == "polygon")
        {
            value = (CloudPDF.AnnotationPolygon)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPolyline"/> and returns true if successful.
    /// </summary>
    public bool TryAsPolyline(out CloudPDF.AnnotationPolyline? value)
    {
        if (Subtype == "polyline")
        {
            value = (CloudPDF.AnnotationPolyline)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationLine"/> and returns true if successful.
    /// </summary>
    public bool TryAsLine(out CloudPDF.AnnotationLine? value)
    {
        if (Subtype == "line")
        {
            value = (CloudPDF.AnnotationLine)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationLink"/> and returns true if successful.
    /// </summary>
    public bool TryAsLink(out CloudPDF.AnnotationLink? value)
    {
        if (Subtype == "link")
        {
            value = (CloudPDF.AnnotationLink)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationInk"/> and returns true if successful.
    /// </summary>
    public bool TryAsInk(out CloudPDF.AnnotationInk? value)
    {
        if (Subtype == "ink")
        {
            value = (CloudPDF.AnnotationInk)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationFreeText"/> and returns true if successful.
    /// </summary>
    public bool TryAsFreeText(out CloudPDF.AnnotationFreeText? value)
    {
        if (Subtype == "free-text")
        {
            value = (CloudPDF.AnnotationFreeText)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationCaret"/> and returns true if successful.
    /// </summary>
    public bool TryAsCaret(out CloudPDF.AnnotationCaret? value)
    {
        if (Subtype == "caret")
        {
            value = (CloudPDF.AnnotationCaret)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationText"/> and returns true if successful.
    /// </summary>
    public bool TryAsText(out CloudPDF.AnnotationText? value)
    {
        if (Subtype == "text")
        {
            value = (CloudPDF.AnnotationText)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationStamp"/> and returns true if successful.
    /// </summary>
    public bool TryAsStamp(out CloudPDF.AnnotationStamp? value)
    {
        if (Subtype == "stamp")
        {
            value = (CloudPDF.AnnotationStamp)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationFileAttachment"/> and returns true if successful.
    /// </summary>
    public bool TryAsFileAttachment(out CloudPDF.AnnotationFileAttachment? value)
    {
        if (Subtype == "file-attachment")
        {
            value = (CloudPDF.AnnotationFileAttachment)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.WidgetAnnotation"/> and returns true if successful.
    /// </summary>
    public bool TryAsWidget(out CloudPDF.WidgetAnnotation? value)
    {
        if (Subtype == "widget")
        {
            value = (CloudPDF.WidgetAnnotation)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationRedact"/> and returns true if successful.
    /// </summary>
    public bool TryAsRedact(out CloudPDF.AnnotationRedact? value)
    {
        if (Subtype == "redact")
        {
            value = (CloudPDF.AnnotationRedact)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationPopup"/> and returns true if successful.
    /// </summary>
    public bool TryAsPopup(out CloudPDF.AnnotationPopup? value)
    {
        if (Subtype == "popup")
        {
            value = (CloudPDF.AnnotationPopup)Value!;
            return true;
        }
        value = null;
        return false;
    }

    /// <summary>
    /// Attempts to cast the value to a <see cref="CloudPDF.AnnotationUnsupported"/> and returns true if successful.
    /// </summary>
    public bool TryAsUnsupported(out CloudPDF.AnnotationUnsupported? value)
    {
        if (Subtype == "unsupported")
        {
            value = (CloudPDF.AnnotationUnsupported)Value!;
            return true;
        }
        value = null;
        return false;
    }

    public override string ToString() => JsonUtils.Serialize(this);

    public static implicit operator Annotation(Annotation.Highlight value) => new(value);

    public static implicit operator Annotation(Annotation.Underline value) => new(value);

    public static implicit operator Annotation(Annotation.Squiggly value) => new(value);

    public static implicit operator Annotation(Annotation.Strikeout value) => new(value);

    public static implicit operator Annotation(Annotation.Circle value) => new(value);

    public static implicit operator Annotation(Annotation.Square value) => new(value);

    public static implicit operator Annotation(Annotation.Polygon value) => new(value);

    public static implicit operator Annotation(Annotation.Polyline value) => new(value);

    public static implicit operator Annotation(Annotation.Line value) => new(value);

    public static implicit operator Annotation(Annotation.Link value) => new(value);

    public static implicit operator Annotation(Annotation.Ink value) => new(value);

    public static implicit operator Annotation(Annotation.FreeText value) => new(value);

    public static implicit operator Annotation(Annotation.Caret value) => new(value);

    public static implicit operator Annotation(Annotation.Text value) => new(value);

    public static implicit operator Annotation(Annotation.Stamp value) => new(value);

    public static implicit operator Annotation(Annotation.FileAttachment value) => new(value);

    public static implicit operator Annotation(Annotation.Widget value) => new(value);

    public static implicit operator Annotation(Annotation.Redact value) => new(value);

    public static implicit operator Annotation(Annotation.Popup value) => new(value);

    public static implicit operator Annotation(Annotation.Unsupported value) => new(value);

    [Serializable]
    internal sealed class JsonConverter : JsonConverter<Annotation>
    {
        public override bool CanConvert(global::System.Type typeToConvert) =>
            typeof(Annotation).IsAssignableFrom(typeToConvert);

        public override Annotation Read(
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
                "highlight" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationHighlight?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationHighlight"),
                "underline" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationUnderline?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationUnderline"),
                "squiggly" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationSquiggly?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationSquiggly"),
                "strikeout" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationStrikeout?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationStrikeout"),
                "circle" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationCircle?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationCircle"),
                "square" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationSquare?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationSquare"),
                "polygon" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPolygon?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationPolygon"),
                "polyline" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPolyline?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationPolyline"),
                "line" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationLine?>(options)
                    ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationLine"),
                "link" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationLink?>(options)
                    ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationLink"),
                "ink" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationInk?>(options)
                    ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationInk"),
                "free-text" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationFreeText?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationFreeText"),
                "caret" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationCaret?>(options)
                    ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationCaret"),
                "text" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationText?>(options)
                    ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationText"),
                "stamp" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationStamp?>(options)
                    ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationStamp"),
                "file-attachment" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationFileAttachment?>(
                        options
                    )
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationFileAttachment"
                        ),
                "widget" => json.Deserialize<CloudPDF.WidgetAnnotation?>(options)
                    ?? throw new JsonException("Failed to deserialize CloudPDF.WidgetAnnotation"),
                "redact" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationRedact?>(
                    options
                ) ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationRedact"),
                "popup" => jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationPopup?>(options)
                    ?? throw new JsonException("Failed to deserialize CloudPDF.AnnotationPopup"),
                "unsupported" =>
                    jsonWithoutDiscriminator.Deserialize<CloudPDF.AnnotationUnsupported?>(options)
                        ?? throw new JsonException(
                            "Failed to deserialize CloudPDF.AnnotationUnsupported"
                        ),
                _ => json.Deserialize<object?>(options),
            };
            return new Annotation(discriminator, value);
        }

        public override void Write(
            Utf8JsonWriter writer,
            Annotation value,
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
                    "popup" => JsonSerializer.SerializeToNode(value.Value, options),
                    "unsupported" => JsonSerializer.SerializeToNode(value.Value, options),
                    _ => JsonSerializer.SerializeToNode(value.Value, options),
                } ?? new JsonObject();
            json["subtype"] = value.Subtype;
            json.WriteTo(writer, options);
        }

        public override Annotation ReadAsPropertyName(
            ref Utf8JsonReader reader,
            global::System.Type typeToConvert,
            JsonSerializerOptions options
        )
        {
            var stringValue =
                reader.GetString()
                ?? throw new JsonException("The JSON property name could not be read as a string.");
            return new Annotation(stringValue, stringValue);
        }

        public override void WriteAsPropertyName(
            Utf8JsonWriter writer,
            Annotation value,
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
        public Highlight(CloudPDF.AnnotationHighlight value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationHighlight Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator Annotation.Highlight(CloudPDF.AnnotationHighlight value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for underline
    /// </summary>
    [Serializable]
    public struct Underline
    {
        public Underline(CloudPDF.AnnotationUnderline value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationUnderline Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator Annotation.Underline(CloudPDF.AnnotationUnderline value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for squiggly
    /// </summary>
    [Serializable]
    public struct Squiggly
    {
        public Squiggly(CloudPDF.AnnotationSquiggly value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationSquiggly Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator Annotation.Squiggly(CloudPDF.AnnotationSquiggly value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for strikeout
    /// </summary>
    [Serializable]
    public struct Strikeout
    {
        public Strikeout(CloudPDF.AnnotationStrikeout value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationStrikeout Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator Annotation.Strikeout(CloudPDF.AnnotationStrikeout value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for circle
    /// </summary>
    [Serializable]
    public struct Circle
    {
        public Circle(CloudPDF.AnnotationCircle value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationCircle Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator Annotation.Circle(CloudPDF.AnnotationCircle value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for square
    /// </summary>
    [Serializable]
    public struct Square
    {
        public Square(CloudPDF.AnnotationSquare value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationSquare Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator Annotation.Square(CloudPDF.AnnotationSquare value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for polygon
    /// </summary>
    [Serializable]
    public struct Polygon
    {
        public Polygon(CloudPDF.AnnotationPolygon value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPolygon Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator Annotation.Polygon(CloudPDF.AnnotationPolygon value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for polyline
    /// </summary>
    [Serializable]
    public struct Polyline
    {
        public Polyline(CloudPDF.AnnotationPolyline value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPolyline Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator Annotation.Polyline(CloudPDF.AnnotationPolyline value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for line
    /// </summary>
    [Serializable]
    public struct Line
    {
        public Line(CloudPDF.AnnotationLine value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationLine Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator Annotation.Line(CloudPDF.AnnotationLine value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for link
    /// </summary>
    [Serializable]
    public struct Link
    {
        public Link(CloudPDF.AnnotationLink value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationLink Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator Annotation.Link(CloudPDF.AnnotationLink value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for ink
    /// </summary>
    [Serializable]
    public struct Ink
    {
        public Ink(CloudPDF.AnnotationInk value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationInk Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator Annotation.Ink(CloudPDF.AnnotationInk value) => new(value);
    }

    /// <summary>
    /// Discriminated union type for free-text
    /// </summary>
    [Serializable]
    public struct FreeText
    {
        public FreeText(CloudPDF.AnnotationFreeText value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationFreeText Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator Annotation.FreeText(CloudPDF.AnnotationFreeText value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for caret
    /// </summary>
    [Serializable]
    public struct Caret
    {
        public Caret(CloudPDF.AnnotationCaret value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationCaret Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator Annotation.Caret(CloudPDF.AnnotationCaret value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for text
    /// </summary>
    [Serializable]
    public struct Text
    {
        public Text(CloudPDF.AnnotationText value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationText Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator Annotation.Text(CloudPDF.AnnotationText value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for stamp
    /// </summary>
    [Serializable]
    public struct Stamp
    {
        public Stamp(CloudPDF.AnnotationStamp value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationStamp Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator Annotation.Stamp(CloudPDF.AnnotationStamp value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for file-attachment
    /// </summary>
    [Serializable]
    public struct FileAttachment
    {
        public FileAttachment(CloudPDF.AnnotationFileAttachment value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationFileAttachment Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator Annotation.FileAttachment(
            CloudPDF.AnnotationFileAttachment value
        ) => new(value);
    }

    /// <summary>
    /// Discriminated union type for widget
    /// </summary>
    [Serializable]
    public struct Widget
    {
        public Widget(CloudPDF.WidgetAnnotation value)
        {
            Value = value;
        }

        internal CloudPDF.WidgetAnnotation Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator Annotation.Widget(CloudPDF.WidgetAnnotation value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for redact
    /// </summary>
    [Serializable]
    public struct Redact
    {
        public Redact(CloudPDF.AnnotationRedact value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationRedact Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator Annotation.Redact(CloudPDF.AnnotationRedact value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for popup
    /// </summary>
    [Serializable]
    public struct Popup
    {
        public Popup(CloudPDF.AnnotationPopup value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationPopup Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator Annotation.Popup(CloudPDF.AnnotationPopup value) =>
            new(value);
    }

    /// <summary>
    /// Discriminated union type for unsupported
    /// </summary>
    [Serializable]
    public struct Unsupported
    {
        public Unsupported(CloudPDF.AnnotationUnsupported value)
        {
            Value = value;
        }

        internal CloudPDF.AnnotationUnsupported Value { get; set; }

        public override string ToString() => Value.ToString() ?? "null";

        public static implicit operator Annotation.Unsupported(
            CloudPDF.AnnotationUnsupported value
        ) => new(value);
    }
}
