using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1TrueDBGridPropBagGenerator
{
    public static class Constants
    {
        public const string DIRECTION_AFTER_ENTER_ENUM = TRUEDBGRID_NAMESPACE + "DirectionAfterEnterEnum.";
        public const string CELL_TIPS_ENUM = TRUEDBGRID_NAMESPACE + "CellTipEnum.";
        public const string EXPOSE_CELL_MODE_ENUM = TRUEDBGRID_NAMESPACE + "ExposeCellModeEnum.";
        public const string MULTI_SELECT_ENUM = TRUEDBGRID_NAMESPACE + "MultiSelectEnum.";
        public const string ROW_DIVIDER_STYLE_ENUM = TRUEDBGRID_NAMESPACE + "LineStyleEnum.";
        public const string TAB_ACTION_ENUM = TRUEDBGRID_NAMESPACE + "TabActionEnum.";
        public const string COLOR_ENUM = "System.Drawing.Color.";
        public const string BORDER_STYLE = "System.Windows.Forms.BorderStyle.";
        public const string MARQUEE_ENUM = TRUEDBGRID_NAMESPACE + "MarqueeEnum.";
        public const string ALLOWROWSIZING_ENUM = TRUEDBGRID_NAMESPACE + "RowSizingEnum.";
        public const string VARROWHEIGHT_ENUM = TRUEDBGRID_NAMESPACE + "PrintInfo.RowHeightEnum.";
        public const string TRUEDBGRID_NAMESPACE = "C1.Win.C1TrueDBGrid.";

        public static readonly string[] GridNodeProperties = { "vertSplits", "horzSplits", "Layout", "DefaultRecSelWidth", "ClientArea" };
        public static readonly HashSet<string> DataColumnXmlAttributes = new HashSet<string> {
            "Caption", "DataField", "DataWidth", "DefaultValue", "DropDownCtl", "EnableDateTimeEditor",
            "EditMask", "EditMaskUpdate", "FilterText", "FooterText", "NumberFormat", "Relation", "DataTypeInternal",
            "FilterEscape", "FilterKeys", "FilterOperator", "FooterExpression", "Level", "SortDirection"
        };
        public static readonly HashSet<string> DataColumnNodeProperties = new HashSet<string> {
            "FilterCancelText", "FilterClearText", "Aggregate", "buttonPicIdx", "Expression",
            "FilterApplyText", "filterButtonPicIdx", "FilterCascade", "FilterDropDown", "FilterDropDownText",
            "FilterMultiSelect", "FilterSeparator", "FilterSortType", "FilterWaterMark", "ImeMode"
        };
        public static readonly HashSet<string> DisplayColumnNodeProperties = new HashSet<string> {
                "AutoDropDown", "AutoComplete", "DropDownList", "Visible", "Width", "Height",
                "AllowFocus", "Locked", "Merge", "AllowSizing", "ButtonText", "ButtonAlways",
                "Button", "FilterButton", "MinWidth", "HeaderDivider", "FooterDivider",
                "FetchStyle", "ButtonHeader", "ButtonFooter", "OwnerDraw", "SubLine", "DCIdx",
                "AllowExpressionEditing", "ButtonCustomStyle", "Frozen", "ShowReadOnlyAsDisabled"
            };

        public static readonly HashSet<string> SplitNodeProperties = new HashSet<string> {
            "Caption", "SplitSize", "SplitSizeMode", "ClientRect", "BorderSide", "BorderStyle"
        };

        public static readonly HashSet<string> SplitXmlAttributes = new HashSet<string>{
                "Name", "CaptionHeight", "ColumnCaptionHeight", "ColumnFooterHeight", "MarqueeStyle",
                "RecordSelectorWidth", "DefRecSelWidth", "VerticalScrollGroup", "HorizontalScrollGroup",
                "AllowFocus", "AllowColMove", "AllowColSelect", "AllowRowSelect",
                "AllowRowSizing", "AllowHorizontalSizing", "AllowVerticalSizing", "AlternatingRowStyle",
                "ExtendRightColumn", "FetchRowStyles", "FilterBar", "FilterBorderStyle", "Locked", "RecordSelectors",
                "HBarStyle", "VBarStyle", "VBarHeight", "SubRows", "HBarHeight"
            };

        public static readonly string[] DisplayColumnOrderedStyles = {
                "HeadingStyle", "ColumnSelectorStyle", "Style", "FooterStyle",
                "EditorStyle","GroupHeaderStyle", "GroupFooterStyle"
            };

        public static readonly string[] SplitOrderedStyles = {
                "CaptionStyle", "EditorStyle", "EvenRowStyle", "FilterBarStyle", "FilterWatermarkStyle", "FooterStyle",
                "GroupStyle", "HeadingStyle", "HighLightRowStyle", "InactiveStyle", "OddRowStyle", "RecordSelectorStyle",
                "RowSelectorStyle", "ColumnSelectorStyle", "SelectedStyle", "Style"
            };

        public static readonly string[] GridOrderedStyles = {
                "Style", "HeadingStyle", "FooterStyle", "CaptionStyle", "InactiveStyle", "SelectedStyle",
                "EditorStyle", "HighLightRowStyle", "EvenRowStyle", "OddRowStyle", "RecordSelectorStyle",
                "FilterBarStyle", "FilterWatermarkStyle", "GroupStyle", "RowSelectorStyle", "ColumnSelectorStyle"
            };
        private static Dictionary<String, String> gridAbsentPropertyValues;
        public static Dictionary<String, String> GridAbsentPropertyValues
        {
            get {
                if(gridAbsentPropertyValues == null)
                {
                    gridAbsentPropertyValues = new Dictionary<string, string>(33);
                    AddGridAbsentValues();
                }
                return gridAbsentPropertyValues;
            }
        }

        private static Dictionary<String, String> columnAbsentPropertyValues;
        public static Dictionary<String, String> ColumnAbsentPropertyValues
        {
            get
            {
                if (columnAbsentPropertyValues == null)
                {
                    columnAbsentPropertyValues = new Dictionary<string, string>(7);
                    AddColumnAbsentValues();
                }
                return columnAbsentPropertyValues;
            }
        }

        private static Dictionary<String, String> splitDesignerAbsentPropertyValues;
        public static Dictionary<String, String> SplitDesignerAbsentPropertyValues
        {
            get
            {
                if (splitDesignerAbsentPropertyValues == null)
                {
                    splitDesignerAbsentPropertyValues = new Dictionary<string, string>(21);
                    AddSplitDesignerAbsentValues();
                }
                return splitDesignerAbsentPropertyValues;
            }
        }

        private static Dictionary<String, String> splitXmlAbsentPropertyValues;
        public static Dictionary<String, String> SplitXmlAbsentPropertyValues
        {
            get
            {
                if (splitXmlAbsentPropertyValues == null)
                {
                    splitXmlAbsentPropertyValues = new Dictionary<string, string>(21);
                    AddSplitXmlAbsentValues();
                }
                return splitXmlAbsentPropertyValues;
            }
        }

        private static Dictionary<String, String> displayColumnAbsentPropertyValues;
        public static Dictionary<String, String> DisplayColumnAbsentPropertyValues
        {
            get
            {
                if (displayColumnAbsentPropertyValues == null)
                {
                    displayColumnAbsentPropertyValues = new Dictionary<string, string>(22);
                    AddDisplayColumnAbsentValues();
                }
                return displayColumnAbsentPropertyValues;
            }
        }

        private static Dictionary<String, String> gridLinesAbsentPropertyValues;
        public static Dictionary<String, String> GridLinesAbsentPropertyValues
        {
            get
            {
                if (gridLinesAbsentPropertyValues == null)
                {
                    gridLinesAbsentPropertyValues = new Dictionary<string, string>(2);
                    AddGridLinesAbsentValues();
                }
                return gridLinesAbsentPropertyValues;
            }
        }

        private static Dictionary<String, String> valueItemCollectionAbsentPropertyValues;
        public static Dictionary<String, String> ValueItemCollectionAbsentPropertyValues
        {
            get
            {
                if (valueItemCollectionAbsentPropertyValues == null)
                {
                    valueItemCollectionAbsentPropertyValues = new Dictionary<string, string>(7);
                    AddValueItemCollectionAbsentValues();
                }
                return valueItemCollectionAbsentPropertyValues;
            }
        }

        private static Dictionary<String, String> printInfoAbsentPropertyValues;
        public static Dictionary<String, String> PrintInfoAbsentPropertyValues
        {
            get
            {
                if (printInfoAbsentPropertyValues == null)
                {
                    printInfoAbsentPropertyValues = new Dictionary<string, string>(11);
                    AddPrintInfoAbsentValues();
                }
                return printInfoAbsentPropertyValues;
            }
        }

        private static Dictionary<String, String> previewInfoAbsentPropertyValues;
        public static Dictionary<String, String> PreviewInfoAbsentPropertyValues
        {
            get
            {
                if (previewInfoAbsentPropertyValues == null)
                {
                    previewInfoAbsentPropertyValues = new Dictionary<string, string>(11);
                    AddPreviewInfoAbsentValues();
                }
                return previewInfoAbsentPropertyValues;
            }
        }

        private static Dictionary<String, String> groupInfoAbsentPropertyValues;
        public static Dictionary<String, String> GroupInfoAbsentPropertyValues
        {
            get
            {
                if (groupInfoAbsentPropertyValues == null)
                {
                    groupInfoAbsentPropertyValues = new Dictionary<string, string>(11);
                    AddGroupInfoAbsentValues();
                }
                return groupInfoAbsentPropertyValues;
            }
        }

        private static void AddGridAbsentValues()
        {
            gridAbsentPropertyValues.Add("AccessibleDescription", "");
            gridAbsentPropertyValues.Add("AccessibleName", "");
            gridAbsentPropertyValues.Add("AccessibleRole", "Default");
            gridAbsentPropertyValues.Add("AllowAddNew", "false");
            gridAbsentPropertyValues.Add("AllowArrows", "true");
            gridAbsentPropertyValues.Add("AllowDelete", "false");
            gridAbsentPropertyValues.Add("AllowDrag", "false");
            gridAbsentPropertyValues.Add("AllowDrop", "false");
            gridAbsentPropertyValues.Add("AllowFilter", "true");
            gridAbsentPropertyValues.Add("AllowHorizontalSplit", "false");
            gridAbsentPropertyValues.Add("AllowInactiveStyle", "false");
            gridAbsentPropertyValues.Add("AllowSort", "true");
            gridAbsentPropertyValues.Add("AllowUpdate", "true");
            gridAbsentPropertyValues.Add("AllowUpdateOnBlur", "true");
            gridAbsentPropertyValues.Add("AllowVerticalSplit", "false");
            gridAbsentPropertyValues.Add("BackColor", "System.Drawing.SystemColors.Control");
            gridAbsentPropertyValues.Add("BackgroundIageLayout", "Tile");
            gridAbsentPropertyValues.Add("BorderStyle", "FixedSingle");
            gridAbsentPropertyValues.Add("Caption", "");
            gridAbsentPropertyValues.Add("CaptionHeight", "17");
            gridAbsentPropertyValues.Add("CausesValidation", "true");
            gridAbsentPropertyValues.Add("CellTips", "NoCellTips");
            gridAbsentPropertyValues.Add("CellTipsDelay", "500");
            gridAbsentPropertyValues.Add("CellTipsWidth", "0");
            gridAbsentPropertyValues.Add("CollapseColor", "System.Drawing.Color.Black");
            gridAbsentPropertyValues.Add("ColumnFooters", "false");
            gridAbsentPropertyValues.Add("ColumnHeaders", "true");
            gridAbsentPropertyValues.Add("Cursor", "Default");
            gridAbsentPropertyValues.Add("DataView", "Normal");
            gridAbsentPropertyValues.Add("DefColWidth", "0");
            gridAbsentPropertyValues.Add("DirectionAfterEnter", "MoveRight");
            gridAbsentPropertyValues.Add("Dock", "None");
            gridAbsentPropertyValues.Add("EditDropDown", "true");
            gridAbsentPropertyValues.Add("EmptyRows", "false");
            gridAbsentPropertyValues.Add("Enabled", "true");
            gridAbsentPropertyValues.Add("ExpandColor", "System.Drawing.Color.Black");
            gridAbsentPropertyValues.Add("ExposeCellMode", "ScrollOnSelect");
            gridAbsentPropertyValues.Add("GroupByAreaVisible", "true");
            gridAbsentPropertyValues.Add("ImeMode", "Inherit");
            gridAbsentPropertyValues.Add("Language", "Default");
            gridAbsentPropertyValues.Add("MaintainRowCurrency", "false");
            gridAbsentPropertyValues.Add("MultiSelect", "Extended");
            gridAbsentPropertyValues.Add("RowHeight", "15");
            gridAbsentPropertyValues.Add("ScrollTips", "false");
            gridAbsentPropertyValues.Add("ScrollTrack", "true");
            gridAbsentPropertyValues.Add("SpringMode", "false");
            gridAbsentPropertyValues.Add("TabAcrossSplits", "false");
            gridAbsentPropertyValues.Add("TabAction", "ControlNavigation");
            gridAbsentPropertyValues.Add("TabStop", "true");
            gridAbsentPropertyValues.Add("Tag", "");
            gridAbsentPropertyValues.Add("Text", "");
            gridAbsentPropertyValues.Add("UseColumnStyles", "true");
            gridAbsentPropertyValues.Add("UseCompatibleTextRendering", "true");
            gridAbsentPropertyValues.Add("UseWaitCursor", "false");
            gridAbsentPropertyValues.Add("Visible", "true");
            gridAbsentPropertyValues.Add("WrapCellPointer", "false");
        }

        public static void AddDisplayColumnAbsentValues()
        {
            displayColumnAbsentPropertyValues.Add("AllowExpressionEditing", "False");
            displayColumnAbsentPropertyValues.Add("AllowFocus", "True");
            displayColumnAbsentPropertyValues.Add("AllowSizing", "True");
            displayColumnAbsentPropertyValues.Add("AutoDropDown", "False");
            displayColumnAbsentPropertyValues.Add("AutoComplete", "False");
            displayColumnAbsentPropertyValues.Add("ButtonDefault", "False");
            displayColumnAbsentPropertyValues.Add("Button", "False");
            displayColumnAbsentPropertyValues.Add("ButtonAlways", "False");
            displayColumnAbsentPropertyValues.Add("ButtonCustomStyle", "False");
            displayColumnAbsentPropertyValues.Add("ButtonFooter", "False");
            displayColumnAbsentPropertyValues.Add("ButtonHeader", "False");
            displayColumnAbsentPropertyValues.Add("ButtonText", "False");
            displayColumnAbsentPropertyValues.Add("DropDownList", "False");
            displayColumnAbsentPropertyValues.Add("FetchStyle", "False");
            displayColumnAbsentPropertyValues.Add("FilterButton", "False");
            displayColumnAbsentPropertyValues.Add("FooterDivider", "True");
            displayColumnAbsentPropertyValues.Add("Frozen", "Empty");
            displayColumnAbsentPropertyValues.Add("HeaderDivider", "True");
            displayColumnAbsentPropertyValues.Add("Height", "0");
            displayColumnAbsentPropertyValues.Add("Locked", "False");
            displayColumnAbsentPropertyValues.Add("Merge", "None");
            displayColumnAbsentPropertyValues.Add("MinWidth", "0");
            displayColumnAbsentPropertyValues.Add("OwnerDraw", "False");
            displayColumnAbsentPropertyValues.Add("ShowReadOnlyAsDisabled", "True");
            displayColumnAbsentPropertyValues.Add("Visible", "False");
            displayColumnAbsentPropertyValues.Add("Width", "100");
        }

        public static void AddGridLinesAbsentValues()
        {
            gridLinesAbsentPropertyValues.Add("Color", "DarkGray");
            gridLinesAbsentPropertyValues.Add("Style", "Single");
        }

        public static void AddColumnAbsentValues()
        {
            columnAbsentPropertyValues.Add("Aggregate", "None");
            columnAbsentPropertyValues.Add("DataTypeInternal", "String");
            columnAbsentPropertyValues.Add("DataWidth", "0");
            columnAbsentPropertyValues.Add("DefaultValue", "");
            columnAbsentPropertyValues.Add("EditMask", "");
            columnAbsentPropertyValues.Add("EditMaskUpdate", "False");
            columnAbsentPropertyValues.Add("EnableDateTimeEditor", "True");
            columnAbsentPropertyValues.Add("FilterApply", "&Apply");
            columnAbsentPropertyValues.Add("FilterCancelText", "");
            columnAbsentPropertyValues.Add("FilterCascade", "False");
            columnAbsentPropertyValues.Add("FilterClearText", "");
            columnAbsentPropertyValues.Add("FilterDropDown", "False");
            columnAbsentPropertyValues.Add("FilterDropDownText", "All");
            columnAbsentPropertyValues.Add("FilterEscape", "*%");
            columnAbsentPropertyValues.Add("FilterKeys", "");
            columnAbsentPropertyValues.Add("FilterMultiSelect", "False");
            columnAbsentPropertyValues.Add("FilterOperator", "");
            columnAbsentPropertyValues.Add("FilterSeparator", ",");
            columnAbsentPropertyValues.Add("FilterText", "");
            columnAbsentPropertyValues.Add("FilterSortType", "DataType");
            columnAbsentPropertyValues.Add("FilterWaterMark", "");
            columnAbsentPropertyValues.Add("FooterExpression", "");
            columnAbsentPropertyValues.Add("FooterText", "");
            columnAbsentPropertyValues.Add("ImeMode", "Inherit");
            columnAbsentPropertyValues.Add("NumberFormat", "");
            columnAbsentPropertyValues.Add("SortDirection", "None");
        }

        public static void AddSplitDesignerAbsentValues()
        {
            splitDesignerAbsentPropertyValues.Add("AllowColMove", "True");
            splitDesignerAbsentPropertyValues.Add("AllowColSelect", "True");
            splitDesignerAbsentPropertyValues.Add("AllowRowSelect", "True");
            splitDesignerAbsentPropertyValues.Add("AllowRowSizing", "AllRows");
            splitDesignerAbsentPropertyValues.Add("AlternatingRowStyle", "False");
            splitDesignerAbsentPropertyValues.Add("ExtendRightColumn", "False");
            splitDesignerAbsentPropertyValues.Add("FetchRowStyles", "False");
            splitDesignerAbsentPropertyValues.Add("FilterBar", "False");
            splitDesignerAbsentPropertyValues.Add("MarqueeStyle", "DottedCellBorder");
            splitDesignerAbsentPropertyValues.Add("RecordSelectors", "True");
            splitDesignerAbsentPropertyValues.Add("RecordSelectorWidth", "17");
        }

        public static void AddSplitXmlAbsentValues()
        {
            splitXmlAbsentPropertyValues.Add("AllowFocus", "True");
            splitXmlAbsentPropertyValues.Add("AllowColMove", "True");
            splitXmlAbsentPropertyValues.Add("AllowColSelect", "True");
            splitXmlAbsentPropertyValues.Add("AllowRowSelect", "True");
            splitXmlAbsentPropertyValues.Add("AllowRowSizing", "AllRows");
            splitXmlAbsentPropertyValues.Add("AllowHorizontalSizing", "True");
            splitXmlAbsentPropertyValues.Add("AllowVerticalSizing", "True");
            splitXmlAbsentPropertyValues.Add("AlternatingRowStyle", "False");
            splitXmlAbsentPropertyValues.Add("BorderStyle", "Flat");
            splitXmlAbsentPropertyValues.Add("Caption", "");
            splitXmlAbsentPropertyValues.Add("ExtendRightColumn", "False");
            splitXmlAbsentPropertyValues.Add("FetchRowStyles", "False");
            splitXmlAbsentPropertyValues.Add("FilterBar", "False");
            splitXmlAbsentPropertyValues.Add("FilterBorderStyle", "Flat");
            splitXmlAbsentPropertyValues.Add("HBarStyle", "Automatic");
            splitXmlAbsentPropertyValues.Add("Locked", "False");
            splitXmlAbsentPropertyValues.Add("RecordSelectors", "True");
            splitXmlAbsentPropertyValues.Add("SplitSize", "1");
            splitXmlAbsentPropertyValues.Add("SplitSizeMode", "Scalable");
            splitXmlAbsentPropertyValues.Add("VBarStyle", "Automatic");
        }

        public static void AddValueItemCollectionAbsentValues()
        {
            valueItemCollectionAbsentPropertyValues.Add("AnnotatePicture", "False");
            valueItemCollectionAbsentPropertyValues.Add("CycleOnClick", "False");
            valueItemCollectionAbsentPropertyValues.Add("DefaultItem", "-1");
            valueItemCollectionAbsentPropertyValues.Add("MaxComboItems", "5");
            valueItemCollectionAbsentPropertyValues.Add("Presentation", "Normal");
            valueItemCollectionAbsentPropertyValues.Add("Translate", "False");
            valueItemCollectionAbsentPropertyValues.Add("Validate", "False");
        }

        public static void AddPrintInfoAbsentValues()
        {
            printInfoAbsentPropertyValues.Add("FillAreaWidth", "ExtendAll");
            printInfoAbsentPropertyValues.Add("GridLines", "Always");
            printInfoAbsentPropertyValues.Add("OneFormPerPage", "true");
            printInfoAbsentPropertyValues.Add("OwnerDrawPageFooter", "false");
            printInfoAbsentPropertyValues.Add("OwnerDrawPageHeader", "false");
            printInfoAbsentPropertyValues.Add("PageBreak", "FitIntoArea");
            printInfoAbsentPropertyValues.Add("PageFooter", "");
            printInfoAbsentPropertyValues.Add("PageFooterHeight", "30");
            printInfoAbsentPropertyValues.Add("PageHeader", "");
            printInfoAbsentPropertyValues.Add("PageHeaderHeight", "30");
            printInfoAbsentPropertyValues.Add("PrintEmptyGrid", "false");
            printInfoAbsentPropertyValues.Add("PrintHorizontalSplits", "false");
            printInfoAbsentPropertyValues.Add("ProgressCaption", "");
            printInfoAbsentPropertyValues.Add("RepeatColumnFooters", "false");
            printInfoAbsentPropertyValues.Add("RepeatColumnHeaders", "true");
            printInfoAbsentPropertyValues.Add("RepeatGridHeader", "false");
            printInfoAbsentPropertyValues.Add("RepeatSplitHeaders", "false");
            printInfoAbsentPropertyValues.Add("RowCanSplit", "false");
            printInfoAbsentPropertyValues.Add("ShowOptionsDialog", "false");
            printInfoAbsentPropertyValues.Add("ShowProgressForm", "true");
            printInfoAbsentPropertyValues.Add("ShowSelection", "true");
            printInfoAbsentPropertyValues.Add("UseGridColors", "true");
            printInfoAbsentPropertyValues.Add("VarRowHeight", "StretchToFit");
            printInfoAbsentPropertyValues.Add("WrapText", "Wrap");
        }

        public static void AddPreviewInfoAbsentValues()
        {
            previewInfoAbsentPropertyValues.Add("AllowSizing", "true");
            previewInfoAbsentPropertyValues.Add("Caption", "PrintPreview Window");
            previewInfoAbsentPropertyValues.Add("NavigationPaneDockingStyle", "None");
            previewInfoAbsentPropertyValues.Add("ToolBars", "true");
        }

        public static void AddGroupInfoAbsentValues()
        {
            groupInfoAbsentPropertyValues.Add("Position", "Header");
            groupInfoAbsentPropertyValues.Add("OutlineMode", "StartCollapsed");
            groupInfoAbsentPropertyValues.Add("HeaderText", "{1}: {0}");
            groupInfoAbsentPropertyValues.Add("FooterText", "");
            groupInfoAbsentPropertyValues.Add("Interval", "Default");
            groupInfoAbsentPropertyValues.Add("ColumnVisible", "False");
        }

        public static class ValueItemDefaultValues
        {
            public const string DISPVAL_DEFAULT_VALUE = "";
        }
    }
}
