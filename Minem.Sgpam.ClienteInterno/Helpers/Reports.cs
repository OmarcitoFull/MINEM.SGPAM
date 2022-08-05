using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using A = DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Drawing.Wordprocessing;
using DocumentFormat.OpenXml.Drawing.Pictures;


namespace Minem.Sgpam.ClienteInterno.Helpers
{
    public class Reports
    {
        public static void ReplaceLabels(string vReportFile, ReportePamDTO vDataReport)
        {
            Type vMiObjeto = vDataReport.GetType();
            IList<PropertyInfo> vMyGetProperties = new List<PropertyInfo>(vMiObjeto.GetProperties());

            using (WordprocessingDocument vWordDoc = WordprocessingDocument.Open(vReportFile, true))
            {
                string vTableLabelReplace = "";

                #region Combinación de Etiquetas 
                var vTextDocument = vWordDoc.MainDocumentPart.Document.Body.OuterXml;
                var vLabelsDocument = new List<PropertyInfo>(vDataReport.GetType().GetProperties());
                Regex vTextRegularExpression;

                foreach (var vLabel in vLabelsDocument)
                {
                    var vProperty = vMyGetProperties.FirstOrDefault(x => x.Name == vLabel.Name);
                    if (vProperty != null)
                    {
                        var vData = vProperty.GetValue(vDataReport, null);
                        if (vData != null)
                        {
                            vTextRegularExpression = new Regex(vLabel.Name);
                            vTextDocument = vTextRegularExpression.Replace(vTextDocument, vData.ToString());
                        }
                    }
                }

                vWordDoc.MainDocumentPart.Document.Body = new Body(vTextDocument);
                vWordDoc.MainDocumentPart.Document.Save();
                #endregion

                #region Combinacion de Tabla Caracteristica
                Table vTableTrait = new Table();
                TableBorder(vTableTrait);

                for (int vRecord = 0; vRecord < vDataReport.ListaCaracteristicaPam.Count(); vRecord++)
                {
                    var vRow = new TableRow();

                    if (vRecord == 0)
                    {
                        var vHead = new List<PropertyInfo>(vDataReport.ListaCaracteristicaPam[vRecord].GetType().GetProperties());
                        foreach (var vLabel in vHead)
                        {
                            vRow.Append(CellComplete(vWordDoc, vLabel.Name.ToUpper(), true));
                        }
                        vTableTrait.Append(vRow);
                        vRow = new TableRow();
                        foreach (var vData in vHead)
                        {
                            vRow.Append(CellComplete(vWordDoc, vData.GetValue(vDataReport.ListaCaracteristicaPam[vRecord], null).ToString(), false));
                        }
                    }
                    else
                    {
                        var vDetail = new List<PropertyInfo>(vDataReport.ListaCaracteristicaPam[vRecord].GetType().GetProperties());
                        foreach (var vData in vDetail)
                        {
                            vRow.Append(CellComplete(vWordDoc, vData.GetValue(vDataReport.ListaCaracteristicaPam[vRecord], null).ToString(), false));
                        }
                    }
                    vTableTrait.Append(vRow);
                }

                vTableLabelReplace = "Tabla_Caracteristica";
                Text vTableReplace = vWordDoc.MainDocumentPart.Document.Body.Descendants<Text>().FirstOrDefault(x => x.Text.Contains(vTableLabelReplace));
                if (vTableReplace != null)
                {
                    var vParent = vTableReplace.Parent.Parent.Parent;
                    vParent.InsertAfter(vTableTrait, vTableReplace.Parent.Parent);
                    vTableReplace.Text = vTableReplace.Text.Replace(vTableLabelReplace, "");
                    vWordDoc.MainDocumentPart.Document.Save();
                }
                #endregion

                #region Combinacion de Tabla Resultado
                Table vTableResult = new Table();
                TableBorder(vTableResult);

                for (int vRecord = 0; vRecord < vDataReport.ListaResultadosPam.Count(); vRecord++)
                {
                    var vRow = new TableRow();

                    if (vRecord == 0)
                    {
                        var vHead = new List<PropertyInfo>(vDataReport.ListaResultadosPam[vRecord].GetType().GetProperties());
                        foreach (var vLabel in vHead)
                        {
                            vRow.Append(CellComplete(vWordDoc, vLabel.Name.ToUpper(), true));
                        }
                        vTableResult.Append(vRow);
                        vRow = new TableRow();
                        foreach (var vData in vHead)
                        {
                            vRow.Append(CellComplete(vWordDoc, vData.GetValue(vDataReport.ListaResultadosPam[vRecord], null).ToString(), false));
                        }
                    }
                    else
                    {
                        var vDetail = new List<PropertyInfo>(vDataReport.ListaResultadosPam[vRecord].GetType().GetProperties());
                        foreach (var vData in vDetail)
                        {
                            vRow.Append(CellComplete(vWordDoc, vData.GetValue(vDataReport.ListaResultadosPam[vRecord], null).ToString(), false));
                        }
                    }
                    vTableResult.Append(vRow);

                    var vDetailLineEmpty = new List<PropertyInfo>(vDataReport.ListaResultadosPam[vRecord].GetType().GetProperties());
                    vRow = new TableRow();
                    foreach (var vData in vDetailLineEmpty)
                    {
                        vRow.Append(CellComplete2(vWordDoc));
                    }
                    vTableResult.Append(vRow);
                }

                vTableLabelReplace = "Tabla_Evaluacion";
                Text vTableReplace2 = vWordDoc.MainDocumentPart.Document.Body.Descendants<Text>().FirstOrDefault(x => x.Text.Contains(vTableLabelReplace));
                if (vTableReplace2 != null)
                {
                    var vParent = vTableReplace2.Parent.Parent.Parent;
                    vParent.InsertAfter(vTableResult, vTableReplace2.Parent.Parent);
                    vTableReplace2.Text = vTableReplace2.Text.Replace(vTableLabelReplace, "");
                    vWordDoc.MainDocumentPart.Document.Save();
                }
                #endregion

                #region Combinacion de Tabla Anexos
                var vLastTable = vWordDoc.MainDocumentPart.Document.Body.Descendants<Table>().LastOrDefault();
                var vLastLine = vWordDoc.MainDocumentPart.Document.Body.Descendants<Break>().LastOrDefault();
                var vSection = vWordDoc.MainDocumentPart.Document.Body.Descendants<Text>().FirstOrDefault(x => x.Text.Contains("ANEXO:"));

                if (vSection != null)
                {
                    var vParent = vSection.Parent.Parent.Parent;
                    int vCount = vDataReport.ListaAnexoPam.Count;
                    Paragraph vWhiteSpace = vWordDoc.MainDocumentPart.Document.Body.AppendChild(new Paragraph());

                    foreach (var vComponente in vDataReport.ListaAnexoPam)
                    {
                        if (vCount != vDataReport.ListaAnexoPam.Count) vParent.InsertAfter(vLastLine.CloneNode(true), vSection.Parent.Parent);
                        var vCloneTable = vLastTable.CloneNode(true);
                        var vTextTable = vCloneTable.OuterXml;
                        vTextTable = vTextTable.Replace("Imagen1", "Full" + vCount.ToString());

                        Regex vTextRegularExpression2;
                        var vLabelsTable = new List<PropertyInfo>(vComponente.GetType().GetProperties());
                        foreach (var vLabel in vLabelsTable)
                        {
                            var vProperty = vLabelsTable.FirstOrDefault(x => x.Name == vLabel.Name);
                            if (vProperty != null)
                            {
                                var vData = vProperty.GetValue(vComponente, null);
                                if (vData != null)
                                {
                                    if (vLabel.Name == "Imagen1")
                                    {
                                        bool vFileExist = File.Exists(vData.ToString());
                                        if (vFileExist)
                                        {
                                            var vKey = vLabelsTable.FirstOrDefault(X => X.Name == "Id").GetValue(vComponente, null);
                                            vTextTable = vTextTable.Replace("Full" + vCount.ToString(), "Full" + vKey.ToString());
                                        }
                                        else
                                        {
                                            vTextTable = vTextTable.Replace("Full" + vCount.ToString(), "");
                                        }
                                    }
                                    else
                                    {
                                        vTextRegularExpression2 = new Regex(vLabel.Name);
                                        vTextTable = vTextRegularExpression2.Replace(vTextTable, vData.ToString());
                                    }
                                }
                            }
                        }

                        vCount -= 1;
                        vCloneTable.InnerXml = vTextTable;
                        vParent.InsertAfter(vCloneTable, vSection.Parent.Parent);
                        vParent.InsertAfter(vWhiteSpace.CloneNode(true), vSection.Parent.Parent);
                    }

                    vLastTable.Remove();
                    vWordDoc.MainDocumentPart.Document.Save();
                }

                #endregion
            }


            #region Combinacion de Imagenes en Tabla 
            using (WordprocessingDocument vWordDoc = WordprocessingDocument.Open(vReportFile, true))
            {
                foreach (var vComponente in vDataReport.ListaAnexoPam)
                {
                    var vLabelsTable = new List<PropertyInfo>(vComponente.GetType().GetProperties());
                    string vKey = "";
                    string vImage = "";

                    var vPropertyKey = vLabelsTable.FirstOrDefault(x => x.Name == "Id");
                    if (vPropertyKey != null) vKey = vPropertyKey.GetValue(vComponente, null).ToString();

                    var vPropertyImage = vLabelsTable.FirstOrDefault(x => x.Name == "Imagen1");
                    if (vPropertyImage != null) vImage = vPropertyImage.GetValue(vComponente, null).ToString();

                    if (vPropertyKey != null && vPropertyImage != null)
                    {
                        bool vFileExist = File.Exists(vImage);
                        if (vFileExist)
                        {
                            ImagePart vImagePart = vWordDoc.MainDocumentPart.AddImagePart(ImagePartType.Jpeg);
                            var vTableList = vWordDoc.MainDocumentPart.Document.Body.Elements<Table>().ToList();

                            foreach (Table vTable in vTableList)
                            {
                                var vElement = vTable.Elements().FirstOrDefault().Elements().FirstOrDefault(x => x.InnerText.Contains("Full" + vKey.ToString()));
                                if (vElement != null)
                                {
                                    var vOpenXmlElement = vElement.ChildElements.FirstOrDefault().Elements().LastOrDefault().Elements().LastOrDefault().Elements().LastOrDefault();

                                    FileStream vStream = new FileStream(vImage, FileMode.Open);
                                    vImagePart.FeedData(vStream);
                                    AddImageToCell(vOpenXmlElement, vWordDoc.MainDocumentPart.GetIdOfPart(vImagePart));
                                }
                            }
                        }
                    }
                }
            }
            #endregion
        }



        public static TableCell CellComplete(WordprocessingDocument vWordDoc, string vDataCell, bool vIsHeader)
        {
            var vColumna = new TableCell();
            vColumna.Append(new Paragraph(new Run(new Text(vDataCell), new RunFonts() { Ascii = "Tahoma" }, new FontSize() { Val = "8" })));

            var vTableCellProperties = new TableCellProperties();
            if (vIsHeader) vTableCellProperties.Append(new Shading() { Color = "auto", Fill = "SILVER", Val = ShadingPatternValues.Clear });
            vTableCellProperties.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });
            vColumna.Append(vTableCellProperties);

            Paragraph vParagraph = vColumna.Descendants<Paragraph>().ElementAtOrDefault(0);
            ApplyStyleToParagraph(vWordDoc, (vIsHeader) ? "FullHeader" : "FullBody", vParagraph);
            return vColumna;
        }

        public static TableCell CellComplete2(WordprocessingDocument vWordDoc)
        {
            var vColumna = new TableCell();
            vColumna.Append(new Paragraph(new Run(new Text(""), new RunFonts() { Ascii = "Tahoma" }, new FontSize() { Val = "8" })));

            var vTableCellProperties = new TableCellProperties();
            vTableCellProperties.Append(new Shading() { Color = "auto", Fill = "#FED8B1", Val = ShadingPatternValues.Clear });
            vTableCellProperties.Append(new TableCellVerticalAlignment() { Val = TableVerticalAlignmentValues.Center });

            vColumna.Append(vTableCellProperties);

            Paragraph vParagraph = vColumna.Descendants<Paragraph>().ElementAtOrDefault(0);
            ApplyStyleToParagraph(vWordDoc, "FullBodyAlter", vParagraph);
            return vColumna;
        }

        public static void TableBorder(Table vTabla)
        {
            TableProperties vProperties = new TableProperties(
            new TableBorders(
            new TopBorder
            {
                Val = new EnumValue<BorderValues>(BorderValues.Thick)
            },
            new BottomBorder
            {
                Val = new EnumValue<BorderValues>(BorderValues.Thick)
            },
            new LeftBorder
            {
                Val = new EnumValue<BorderValues>(BorderValues.Thick)
            },
            new RightBorder
            {
                Val = new EnumValue<BorderValues>(BorderValues.Thick)
            },
            new InsideHorizontalBorder
            {
                Val = new EnumValue<BorderValues>(BorderValues.Thick)
            },
            new InsideVerticalBorder
            {
                Val = new EnumValue<BorderValues>(BorderValues.Thick)
            }
            ));

            TableWidth vTableWidth = new TableWidth() { Width = "100%" };
            vProperties.Append(vTableWidth);

            RunFonts font1 = new RunFonts() { Ascii = "Tahoma" };
            FontSize fontSize1 = new FontSize() { Val = "24" };
            StyleRunProperties styleRunProperties1 = new StyleRunProperties();

            styleRunProperties1.RunFonts = font1;
            styleRunProperties1.FontSize = fontSize1;

            vProperties.PrependChild<StyleRunProperties>(styleRunProperties1);
            vTabla.AppendChild<TableProperties>(vProperties);
        }

        public static void ApplyStyleToParagraph(WordprocessingDocument vDoc, string vStyleId, Paragraph vParagraph)
        {
            vParagraph.PrependChild<ParagraphProperties>(new ParagraphProperties());

            if (!IsStyleIdInDocument(vDoc, vStyleId))
            {
                StyleDefinitionsPart vStyleDefinitionsPart = vDoc.MainDocumentPart.StyleDefinitionsPart;

                if ("FullHeader" == vStyleId)
                    AddTHeaderStyle(vStyleDefinitionsPart, vStyleId);
                else
                    AddTBodyStyle(vStyleDefinitionsPart, vStyleId);
            }

            ParagraphProperties vParagraphProperties = vParagraph.Elements<ParagraphProperties>().First();
            vParagraphProperties.ParagraphStyleId = new ParagraphStyleId() { Val = vStyleId };
            SpacingBetweenLines vSpacingBetweenLines = new SpacingBetweenLines() { Line = "240", LineRule = LineSpacingRuleValues.Exact, Before = "0", After = "0", AfterLines = 0, BeforeLines = 0, BeforeAutoSpacing = new OnOffValue() { Value = false }, AfterAutoSpacing = new OnOffValue() { Value = false } };
            vParagraphProperties.Append(vSpacingBetweenLines);
        }

        public static bool IsStyleIdInDocument(WordprocessingDocument vDoc, string vStyleId)
        {
            Styles vFullStyle = vDoc.MainDocumentPart.StyleDefinitionsPart.Styles;

            Style vExist = vFullStyle.Elements<Style>().FirstOrDefault(st => (st.StyleId == vStyleId) && (st.Type == StyleValues.Paragraph));
            if (vExist == null) return false;

            return true;
        }

        private static void AddTHeaderStyle(StyleDefinitionsPart vStyleDefinitionsPart, string vStyleId)
        {
            Styles vStyles = vStyleDefinitionsPart.Styles;

            Style vMyStyle = new Style() { Type = StyleValues.Paragraph, StyleId = vStyleId, CustomStyle = true };
            vMyStyle.Append(new StyleName() { Val = vStyleId });

            StyleRunProperties vStyleRunProperties = new StyleRunProperties();
            vStyleRunProperties.Append(new Bold());
            vStyleRunProperties.Append(new Color() { Val = "Black" });
            vStyleRunProperties.Append(new RunFonts() { Ascii = "Tahoma" });
            vStyleRunProperties.Append(new FontSize() { Val = "16" });

            vMyStyle.Append(vStyleRunProperties);
            vStyles.Append(vMyStyle);
        }

        private static void AddTBodyStyle(StyleDefinitionsPart vStyleDefinitionsPart, string vStyleId)
        {
            Styles vStyles = vStyleDefinitionsPart.Styles;

            Style vMyStyle = new Style() { Type = StyleValues.Paragraph, StyleId = vStyleId, CustomStyle = true };
            vMyStyle.Append(new StyleName() { Val = vStyleId });

            StyleRunProperties vStyleRunProperties = new StyleRunProperties();
            vStyleRunProperties.Append(new Color() { Val = "Black" });
            vStyleRunProperties.Append(new RunFonts() { Ascii = "Tahoma" });
            vStyleRunProperties.Append(new FontSize() { Val = "14" });

            vMyStyle.Append(vStyleRunProperties);
            vStyles.Append(vMyStyle);
        }

        private static void AddImageToCell(OpenXmlElement vOpenXmlElement, string vGetIdOfPart)
        {
            var vImagen =
                 new Drawing(
                     new Inline(
                         new Extent() { Cx = 2139893L, Cy = 1918499L },
                         new DocProperties() { Id = (UInt32Value)1U, Name = "Picture" },
                         new A.Graphic(
                             new A.GraphicData(
                                 new DocumentFormat.OpenXml.Drawing.Pictures.Picture(
                                     new NonVisualPictureProperties(new NonVisualDrawingProperties() { Id = (UInt32Value)0U, Name = "fullshito.jpg" }, new NonVisualPictureDrawingProperties()),
                                     new BlipFill(new A.Blip() { Embed = vGetIdOfPart, CompressionState = A.BlipCompressionValues.Print }, new A.Stretch(new A.FillRectangle())),
                                     new ShapeProperties(new A.Transform2D(new A.Offset() { X = 0L, Y = 0L }, new A.Extents() { Cx = 2139893L, Cy = 1918499L }), new A.PresetGeometry(new A.AdjustValueList()) { Preset = A.ShapeTypeValues.Rectangle })
                                     )
                             )
                             { Uri = "http://schemas.openxmlformats.org/drawingml/2006/picture" }
                             )
                     )
                     );

            vOpenXmlElement.AppendChild(new Paragraph(new Run(vImagen)));
        }
    }
}
