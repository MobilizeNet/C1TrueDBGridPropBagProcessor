using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C1TrueDBGridPropBagGenerator
{
    public class RegularExpressions
    {
        // format matched: this.GridName.PropertyName = value;
        public const string COMPLEX_PROPERTY_REGEX = @"this\.(\w+)\.(\w+)(\[(\d+)\])?\.?(" + BRACKETS_REGEX + "+)?" +  ASSIGN_VALUE_REGEX + @";";
        public static readonly Regex ComplexProperty = new Regex(COMPLEX_PROPERTY_REGEX, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        // formats matched: 
        //     property[i]
        //     method()
        public const string BRACKETS_REGEX = @"((\w+)?((\[(.+)\])|(\((.*)\)))?\.?)";
        // format matched: ' = value'
        public const string ASSIGN_VALUE_REGEX = @"(\s*(\+)?=\s*(.+))?";

        // formats matched: this.Column01.DataField = "abc";
        //                  this.ValueItem_0_Column_1_TDBGrid.Value = "Valor10";
        public const string SIMPLE_PROPERTY_REGEX = @"^this\.(\w+)(\.((\w+\.?)+))?" + ASSIGN_VALUE_REGEX + @";";
        public static readonly Regex SimpleProperty = new Regex(SIMPLE_PROPERTY_REGEX, RegexOptions.Compiled | RegexOptions.IgnoreCase);

        // format matched: property1[i].property2
        public const string PROPERTY_REGEX = BRACKETS_REGEX + @"(" + BRACKETS_REGEX + "+)";
        public static readonly Regex PropertyRegex = new Regex(PROPERTY_REGEX, RegexOptions.Compiled | RegexOptions.IgnoreCase);

        // format matched: this.gridName.Columns[i]
        public const string DISPLAY_COLUMN_INDEX = @"^this\.\w+\.Columns\[(\d+)\]";
        public static readonly Regex DisplayColumnIndexRegex = new Regex(DISPLAY_COLUMN_INDEX, RegexOptions.Compiled | RegexOptions.IgnoreCase);

        // format matched: public C1.Win.C1TrueDBGrid.C1TrueDBGrid gridName;
        public const string GRID_NAME_REGEX = "^" + ACCESS_TYPES_REGEX + @"\s+(" + C1TRUEDBGRID + "|" + C1TRUEDBGRIDHELPER + @")\s+(\w*);";
        public static readonly Regex GridName = new Regex(GRID_NAME_REGEX, RegexOptions.Compiled | RegexOptions.IgnoreCase);
        // format matched: C1.Win.C1TrueDBGrid.C1TrueDBGrid
        public const string C1TRUEDBGRID = @"(C1\.Win\.C1TrueDBGrid\.C1TrueDBGrid)";
        // format matched: UpgradeHelpers.Helpers.C1TrueDBGridHelper 
        public const string C1TRUEDBGRIDHELPER = @"(UpgradeHelpers\.Helpers\.C1TrueDBGridHelper)";
        // format matched: public
        public const string ACCESS_TYPES_REGEX = @"(public|private|protected|internal)";

        // format matched: public C1.Win.C1TrueDBGrid.C1DataColumn column0;
        public const string C1DATACOLUMN_NAME_REGEX = "^" + ACCESS_TYPES_REGEX + @"\s+C1\.Win\.C1TrueDBGrid\.C1DataColumn\s+(\w*);";
        public static readonly Regex ColumnName = new Regex(C1DATACOLUMN_NAME_REGEX, RegexOptions.Compiled | RegexOptions.IgnoreCase);

        // format matched: public C1.Win.C1TrueDBGrid.ValueItem ValueItem_0_Column_1_TDBGrid;
        public const string VALUEITEM_NAME_REGEX = "^" + ACCESS_TYPES_REGEX + @"\s+C1\.Win\.C1TrueDBGrid\.ValueItem\s+(\w*);";
        public static readonly Regex ValueItemName = new Regex(VALUEITEM_NAME_REGEX, RegexOptions.Compiled | RegexOptions.IgnoreCase);

        // format matched: new System.Drawing.Size(width, height)
        public const string SIZE_REGEX = @"new\s+System\.Drawing.Size\((\d+),\s*(\d+)\)";
        public static readonly Regex Size = new Regex(SIZE_REGEX, RegexOptions.Compiled | RegexOptions.IgnoreCase);

        // format matched: formName.Designer.cs
        public const string DESIGNER_FILENAME_REGEX = @"(\w*)\.[dD]esigner\.cs";
        public static readonly Regex DesignerFileName = new Regex(DESIGNER_FILENAME_REGEX, RegexOptions.Compiled | RegexOptions.IgnoreCase);

        // format matched: System.Drawing.Color.FromArgb(r, g, b);
        public const string RGB_COLOR_REGEX = @"System\.Drawing\.Color\.FromArgb\((\d+,\s*\d+,\s*\d+)\)";
        public static readonly Regex RgbColor = new Regex(RGB_COLOR_REGEX, RegexOptions.Compiled | RegexOptions.IgnoreCase);

        // format matched: 'System.Drawing.FontStyle.styleName |'
        public const string FONTSTYLE = @"(\sSystem\.Drawing\.FontStyle\.(\w*)\s*\|)?";
        // format matched: System.Drawing.FontStyle.Regular
        public const string REGULARSTYLEFONT = @"(\sSystem\.Drawing\.FontStyle\.Regular)?";
        // new System.Drawing.Font("FontName", 9.75f, System.Drawing.FontStyle.styleName1 | System.Drawing.FontStyle.styleName2 | System.Drawing.FontStyle.Regular
        public const string FONT_REGEX = @"new\s+System\.Drawing\.Font\(""((\w|\s)*)"",\s*(\d*(\.\d*)?)f," + 
                                        FONTSTYLE + FONTSTYLE + FONTSTYLE + FONTSTYLE + REGULARSTYLEFONT;
        public static readonly Regex FontRegex = new Regex(FONT_REGEX, RegexOptions.Compiled | RegexOptions.IgnoreCase);

        // format matched: Editor{AlignVert:Bottom;ForeColor:WindowFrame;AlignHorz:Center;BackColor:Lime;}
        public const string STYLE_SHEET_REGEX = @"(((?!\{|\}).)+)\{((" + STYLE_PROPERTY_SHEET_REGEX + @")*)\}";
        public const string STYLE_PROPERTY_SHEET_REGEX = @"\w+:[\w\s\,\.=]+;";
        public static readonly Regex StyleSheet = new Regex(STYLE_SHEET_REGEX, RegexOptions.Compiled | RegexOptions.IgnoreCase);

        // format matched: Raised,Black,1 ,1, 1, 1
        public const string BORDERS_STRING_VALUE_REGEX = @"(\w+)\s*,\s*([\w|,|\s]*),\s*(\d)\s*,\s*(\d)\s*,\s*(\d)\s*,\s*(\d)";
        public static readonly Regex BordersStringValue = new Regex(BORDERS_STRING_VALUE_REGEX, RegexOptions.Compiled | RegexOptions.IgnoreCase);

        // format matched: new System.Drawing.Printing.Margins(1, 2, 3, 4)
        public const string MARGINS_OBJECT_REGEX = @"new\s+System\.Drawing\.Printing\.Margins\(\s*(\d+)\s*,\s*(\d+)\s*,\s*(\d+)\s*,\s*(\d+)\)";
        public static readonly Regex MarginsObject = new Regex(MARGINS_OBJECT_REGEX, RegexOptions.Compiled | RegexOptions.IgnoreCase);

        // format matched: resources.GetObject("TablaElaborada.Images")
        public const string GET_OBJECT_REGEX = @"^[\w\.\(\)\s]+""(.*)""\)";
        public static readonly Regex GetObject = new Regex(GET_OBJECT_REGEX, RegexOptions.Compiled | RegexOptions.IgnoreCase);
    }
}
