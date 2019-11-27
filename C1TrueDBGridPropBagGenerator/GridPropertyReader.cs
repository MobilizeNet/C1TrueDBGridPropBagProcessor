using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C1TrueDBGridPropBagGenerator
{
    public static class GridPropertyReader
    {
        public static void ProcessGridProperty(Dictionary<string, C1TrueDBGrid> grids, Dictionary<string, C1DataColumn> columns, Dictionary<string, ValueItem> valueItemsDict, string line)
        {
            //Verify if the line is the assignment of a known grid
            GroupCollection groups = RegularExpressions.ComplexProperty.Matches(line)[0].Groups;
            C1TrueDBGrid grid = grids[groups[1].Value];
            int index = -1;
            if (groups[4].Value != "")
            {
                index = int.Parse(groups[4].Value);
            }
            string value = groups[15].Value;
            string subLine = groups[5].Value;
            string property = groups[2].Value;
            switch (property.ToUpper())
            {
                case nameof(SplitProperties.ALTERNATINGROWS):
                    grid.Splits[0].Properties["AlternatingRowStyle"] = Utilities.FirstCharToUpper(value);
                    break;
                case nameof(GridProperties.CAPTION):
                    grid.Properties["Caption"] = Utilities.RemoveBeginEndQuotes(value);
                    break;
                case nameof(GridProperties.BACKCOLOR):
                    grid.TimesReadBackColor++;
                    grid.Properties["BackColor"] = value;
                    break;
                case nameof(StyleProperties.FONT):
                    grid.Styles["Style"].Properties["Font"] = Utilities.ProcessFontProperty(value);
                    break;
                case nameof(GridProperties.HEIGHT):
                    grid.Height = Utilities.PropertyValueTwipsToPixels(value);
                    break;
                case nameof(SplitProperties.HSCROLLBAR):
                    if (groups[5].Value.Equals("Style"))
                    {
                        grid.Splits[0].Properties["HBarStyle"] = Utilities.EnumValueToString(value);
                    }
                    break;
                case nameof(GridProperties.IMAGES):
                    string imageName = RegularExpressions.GetObject.Matches(groups[12].Value)[0].Groups[1].Value;
                    ResourceImage image = new ResourceImage();
                    image.Name = imageName;
                    grid.Images[imageName] = image;
                    break;
                case nameof(GridProperties.NAME):
                    grid.Properties["Name"] = value;
                    grid.TimesReadName++;
                    break;
                case nameof(GridProperties.PREVIEWINFO):
                    PreviewInfoPropertyReader.ProcessPreviewInfoProperty(grid.PreviewInfo, subLine, value);
                    break;
                case nameof(GridProperties.PRINTINFO):
                    PrintInfoPropertyReader.ProcessPrintInfoProperty(grid.PrintInfo, subLine, value);
                    break;
                case nameof(GridProperties.ROWDIVIDER):
                    GridLinesPropertyReader.ProcessGridLinesProperty(grid.RowDivider, subLine, value);
                    break;
                case nameof(GridProperties.SIZE):
                    GroupCollection groupsSize = RegularExpressions.Size.Matches(line)[0].Groups;
                    grid.Width = Int32.Parse(groupsSize[1].Value);
                    grid.Height = Int32.Parse(groupsSize[2].Value);
                    break;
                case nameof(GridProperties.STYLES):
                    grid.IncorrectPropertiesInDesigner = true;
                    break;
                case nameof(SplitProperties.VSCROLLBAR):
                    if (groups[5].Value.Equals("Style"))
                    {
                        grid.Splits[0].Properties["VBarStyle"] = Utilities.EnumValueToString(value);
                    }
                    break;
                case nameof(GridProperties.COLUMNS):
                    grid.IncorrectPropertiesInDesigner = true;
                    if (groups[7].Value == "Add")
                    {
                        string argument = groups[12].Value;
                        if(!argument.StartsWith("new "))
                        {
                            string columnName = argument.Split('.')[1];
                            grid.DataCols.Add(columns[columnName]);
                        }
                    }
                    else
                    {
                        int columnIndex = Utilities.StringToIndex(groups[4].Value);
                        C1DataColumn column = Utilities.GetCreateListElement<C1DataColumn>(grid.DataCols, columnIndex);
                        ColumnPropertyReader.ProcessColumnProperty(column, valueItemsDict, subLine, value);
                    }
                    break;
                case nameof(GridProperties.WIDTH):
                    grid.Width = Int32.Parse(value);
                    break;
                case nameof(GridProperties.SPLITS):
                    grid.IncorrectPropertiesInDesigner = true;
                    int splitIndex = Utilities.StringToIndex(groups[4].Value);
                    Split split = Utilities.GetCreateListElement<Split>(grid.Splits, splitIndex);
                    SplitPropertyReader.ProcessSplitProperty(split, subLine, value);
                    break;
                default:
                    if (grid.Splits[0].Properties.ContainsKey(property) && !grid.Properties.ContainsKey(property))
                    {
                        grid.Splits[0].Properties[property] = Utilities.CleanXMLProperty(value);
                    }
                    else if (grid.Styles.ContainsKey(property))
                    {
                        grid.IncorrectPropertiesInDesigner = true;
                        StylePropertyReader.ProcessStyleProperty(grid.Styles[property], subLine, value);
                    }
                    else if(groups[11].Value == "") // if it isn't a method call from the grid
                    {
                        grid.Properties[property] = Utilities.CleanGridProperty(value);
                    }
                    break;
            }
        }

        public static bool MustRemoveLine(Dictionary<string, C1TrueDBGrid> grids, string line)
        {

            GroupCollection groups = RegularExpressions.ComplexProperty.Matches(line)[0].Groups;
            C1TrueDBGrid grid = grids[groups[1].Value];
            int index = -1;
            if (groups[4].Value != "")
            {
                index = int.Parse(groups[4].Value);
            }
            string subLine = groups[5].Value;
            string property = groups[2].Value;
            switch (property.ToUpper())
            {
                case nameof(GridProperties.BACKCOLOR):
                    grid.TimesReadBackColor--;
                    return grid.TimesReadBackColor > 0 || grid.Properties[property].Equals(Constants.GridAbsentPropertyValues[property]);
                case nameof(StyleProperties.FONT):
                case nameof(GridProperties.GROUPBYCAPTION):
                case nameof(GridProperties.LOCATION):
                case nameof(GridProperties.SIZE):
                case nameof(GridProperties.TABINDEX):
                    return false;
                case nameof(GridProperties.NAME):
                    grid.TimesReadName--;
                    return grid.TimesReadName > 0;
                case nameof(GridProperties.PREVIEWINFO):
                    return PreviewInfoPropertyReader.MustRemoveLine(grid.PreviewInfo, subLine);
                case nameof(GridProperties.PRINTINFO):
                    return PrintInfoPropertyReader.MustRemoveLine(grid.PrintInfo, subLine);
                case nameof(GridProperties.ROWDIVIDER):
                    return GridLinesPropertyReader.MustRemoveLine(grid.RowDivider, subLine);
                case nameof(GridProperties.STYLES):
                case nameof(GridProperties.COL):
                case nameof(GridProperties.DATACHANGED):
                case nameof(GridProperties.EDITACTIVE):
                case nameof(GridProperties.LEFTCOL):
                case nameof(GridProperties.PROPBAG):
                case nameof(GridProperties.ROW):
                case nameof(GridProperties.SELECTEDTEXT):
                case nameof(GridProperties.SELECTIONLENGTH):
                case nameof(GridProperties.SELECTIONSTART):
                    return true;
                default:
                    if (grid.Properties.ContainsKey(property))
                    {
                        if (Constants.GridAbsentPropertyValues.ContainsKey(property))
                        {
                            return grid.Properties[property].Equals(Constants.GridAbsentPropertyValues[property]);
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else if (grid.Splits[0].Properties.ContainsKey(property))
                    {
                        if (Constants.SplitDesignerAbsentPropertyValues.ContainsKey(property))
                        {
                            return grid.Splits[0].Properties[property].Equals(Constants.SplitDesignerAbsentPropertyValues[property]);
                        } else
                        {
                            return false;
                        }
                        
                    }
                    else
                    {
                        return groups[14].Value != "+";
                    }
            }
        }
    }
}
