using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1TrueDBGridPropBagGenerator
{
    public enum GridProperties
    {
        HEIGHT,
        LEFT,
        TABINDEX,
        TOP,
        WIDTH,
        ALLOWUPDATE,
        DEFCOLWIDTH,
        CELLTIPSWIDTH,
        COLUMNS,
        BACKCOLOR,
        DATACHANGED,
        EDITACTIVE,
        ROWDIVIDERCOLOR,
        ROWSUBDIVIDERCOLOR,
        DIRECTIONAFTERENTER,
        ALLOWADDNEW,
        ALLOWARROWS,
        ALLOWDELETE,
        ALLOWDROP,
        BORDERSTYLE,
        CELLTIPS,
        CAPTION,
        CAUSESVALIDATION,
        CELLTIPSDELAY,
        COL,
        COLUMNFOOTERS,
        COLUMNHEADERS,
        CURSOR,
        EDITDROPDOWN,
        EMPTYROWS,
        ENABLED,
        EXPOSECELLMODE,
        GROUPBYCAPTION,
        LEFTCOL,
        LOCATION,
        IMAGES,
        MULTISELECT,
        NAME,
        PREVIEWINFO,
        PRINTINFO,
        PROPBAG,
        ROW,
        ROWDIVIDER,
        ROWDIVIDERSTYLE,
        ROWHEIGHT,
        SCROLLTIPS,
        SCROLLTRACK,
        SELECTIONLENGTH,
        SELECTEDTEXT,
        SELECTIONSTART,
        SIZE,
        SPLITS,
        STYLES,
        TABACROSSSPLITS,
        TABACTION,
        TABSTOP,
        TAG,
        TEXT,
        USECOMPATIBLETEXTRENDERING,
        VISIBLE,
        WRAPCELLPOINTER
    }

    public enum ColumnProperties {
        CAPTION,
        DATAFIELD,
        PRESENTATION,
        TRANSLATE,
        DATAWIDTH,
        DEFAULTVALUE,
        EDITMASK,
        EDITMASKUPDATE,
        FILTERTEXT,
        FOOTERTEXT,
        NUMBERFORMAT,
        VALUE,
        VALUEITEMS,
        _MAXCOMBOITEMS,
        _VLISTSTYLE
    }

    public enum SplitProperties
    {
        NAME,
        EXTENDRIGHTCOLUMN,
        MARQUEESTYLE,
        ALLOWROWSIZING,
        RECORDSELECTORS,
        RECORDSELECTORWIDTH,
        ALLOWCOLSELECT,
        ALLOWCOLMOVE,
        ALLOWFOCUS,
        ALLOWHORIZONTALSIZING,
        ALLOWVERTICALSIZING,
        ALLOWROWSELECT,
        ALTERNATINGROWS,
        CAPTION,
        DISPLAYCOLUMNS,
        FETCHROWSTYLES,
        FILTERBAR,
        HSCROLLBAR,
        LOCKED,
        SCROLLBARS,
        VERTICALSCROLLGROUP,
        VSCROLLBAR,
        HORIZONTALSCROLLGROUP,
        SPLITSIZE,
        SPLITSIZEMODE
    }

    public enum ValueItemCollectionProperties
    {
        ANNOTATEPICTURE,
        CYCLEONCLICK,
        DEFAULTITEM,
        MAXCOMBOITEMS,
        PRESENTATION,
        TRANSLATE,
        VALIDATE,
        VALUES
    }

    public enum ValueItemProperties {
        VALUE,
        DISPLAYVALUE,
        _DEFAULTITEM
    }

    public enum DisplayColumnProperties {
        ALLOWFOCUS,
        ALLOWSIZING,
        AUTOCOMPLETE,
        AUTODROPDOWN,
        BUTTON,
        BUTTONALWAYS,
        BUTTONFOOTER,
        BUTTONHEADER,
        BUTTONTEXT,
        COLUMNDIVIDER,
        DATACOLUMN,
        DROPDOWNLIST,
        FETCHSTYLE,
        FILTERBUTTON,
        FOOTERDIVIDER,
        HEADERDIVIDER,
        LOCKED,
        MERGE,
        MINWIDTH,
        OWNERDRAW,
        VISIBLE,
        WIDTH
    }

    public enum PrintInfoProperties{
        PAGEHEADERHEIGHT,
        PAGEHEADERSTYLE,
        PAGEFOOTERHEIGHT,
        PAGEFOOTERSTYLE,
        PAGEHEADERFONT,
        PAGEFOOTERFONT,
        PAGEFOOTER,
        PAGESETTINGS,
        OWNERDRAWPAGEFOOTER,
        PAGEHEADER,
        OWNERDRAWPAGEHEADER,
        REPEATCOLUMNFOOTERS,
        REPEATCOLUMNHEADERS,
        REPEATGRIDHEADER,
        REPEATSPLITHEADERS,
        VARROWHEIGHT
    }

    public enum StyleProperties
    {
        BACKCOLOR,
        BACKCOLOR2,
        BACKGROUNDPICTURE,
        BACKGROUNDPICTUREDRAWMODE,
        APPEARANCE,
        BORDERCOLOR,
        BORDERS,
        FONT,
        FORECOLOR,
        FOREGROUNDPICTUREPOSITION,
        HORIZONTALALIGNMENT,
        LOCKED,
        PADDING,
        VERTICALALIGNMENT,
        WRAP
    }

    public enum GridLinesProperties
    {
        COLOR,
        STYLE
    }

    public enum StyleTypes
    {
        CAPTIONSTYLE,
        COLUMNSELECTORSTYLE,
        EDITORSTYLE,
        EVENROWSTYLE,
        FILTERBARSTYLE,
        FILTERWATERMARKSTYLE,
        FOOTERSTYLE,
        GROUPFOOTERSTYLE,
        GROUPHEADERSTYLE,
        HEADINGSTYLE,
        HIGHLIGHTROWSTYLE,
        INACTIVESTYLE,
        ODDROWSTYLE,
        RECORDSELECTORSTYLE,
        ROWSELECTORSTYLE,
        SELECTEDSTYLE,
        STYLE
    }

    public enum BorderProperties
    {
        BORDERTYPE,
        BOTTOM,
        COLOR,
        LEFT,
        RIGHT,
        TOP
    }

    public enum CommonProperties
    {
        DATACHANGED,
        TEXT,
        ADD,
        VALUE
    }

    public enum BorderTypes
    {
        NONE,
        FLAT,
        RAISED,
        INSET,
        GROOVE,
        FILLET,
        RAISEDBEVEL,
        INSETBEVEL
    }
}
