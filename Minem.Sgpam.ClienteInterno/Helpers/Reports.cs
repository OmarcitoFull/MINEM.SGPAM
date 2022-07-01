using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Minem.Sgpam.TransporteDatos.DtoEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Minem.Sgpam.ClienteInterno.Helpers
{
    public class Reports
    {
        public static void ReplaceLabels(string vReportFile, ReportePamDTO vDataReport)
        {
            Type vMiObjeto = vDataReport.GetType();
            IList<PropertyInfo> vMisAtributos = new List<PropertyInfo>(vMiObjeto.GetProperties());

            using (WordprocessingDocument vWordDoc = WordprocessingDocument.Open(vReportFile, true))
            {
                #region Combinación de Etiquetas 
                string vDocTexto = vWordDoc.MainDocumentPart.Document.Body.OuterXml;
                var vDocumentLabels = new List<PropertyInfo>(vDataReport.GetType().GetProperties());
                Regex vRegexTexto;

                foreach (var vLabel in vDocumentLabels)
                {
                    var vProp = vMisAtributos.FirstOrDefault(x => x.Name == vLabel.Name);
                    if (vProp != null)
                    {
                        var vData = vProp.GetValue(vDataReport, null);
                        if (vData != null)
                        {
                            vRegexTexto = new Regex(vLabel.Name);
                            vDocTexto = vRegexTexto.Replace(vDocTexto, vData.ToString());
                        }
                    }
                }

                vWordDoc.MainDocumentPart.Document.Body = new Body(vDocTexto);
                vWordDoc.MainDocumentPart.Document.Save();
                #endregion

                #region Combinacion de Tabla Caracteristica
                Table vTabla = new Table();
                TableBorder(vTabla);

                for (int vRegistro = 0; vRegistro < vDataReport.ListaCaracteristicaPam.Count(); vRegistro++)
                {
                    var vFila = new TableRow();

                    if (vRegistro == 0)
                    {
                        var vCabecera = new List<PropertyInfo>(vDataReport.ListaCaracteristicaPam[vRegistro].GetType().GetProperties());
                        foreach (var vRotulo in vCabecera)
                        {
                            vFila.Append(CellComplete(vWordDoc, vRotulo.Name.ToUpper(), true));
                        }
                        vTabla.Append(vFila);
                        vFila = new TableRow();
                        foreach (var vDatos in vCabecera)
                        {
                            vFila.Append(CellComplete(vWordDoc, vDatos.GetValue(vDataReport.ListaCaracteristicaPam[vRegistro], null).ToString(), false));
                        }
                    }
                    else
                    {
                        var vDetalle = new List<PropertyInfo>(vDataReport.ListaCaracteristicaPam[vRegistro].GetType().GetProperties());
                        foreach (var vDatos in vDetalle)
                        {
                            vFila.Append(CellComplete(vWordDoc, vDatos.GetValue(vDataReport.ListaCaracteristicaPam[vRegistro], null).ToString(), false));
                        }
                    }
                    vTabla.Append(vFila);
                }

                string vTableLabelReplace = "Tabla_Caracteristica";
                Text vTableReplace = vWordDoc.MainDocumentPart.Document.Body.Descendants<Text>().FirstOrDefault(x => x.Text.Contains(vTableLabelReplace));
                if (vTableReplace != null)
                {
                    var vParent = vTableReplace.Parent.Parent.Parent;
                    vParent.InsertAfter(vTabla, vTableReplace.Parent.Parent);
                    vTableReplace.Text = vTableReplace.Text.Replace(vTableLabelReplace, "");
                    vWordDoc.MainDocumentPart.Document.Save();
                }
                #endregion

                #region Combinacion de Tabla Resultado
                Table vTabla2 = new Table();
                TableBorder(vTabla2);

                for (int vRegistro = 0; vRegistro < vDataReport.ListaResultadosPam.Count(); vRegistro++)
                {
                    var vFila = new TableRow();

                    if (vRegistro == 0)
                    {
                        var vCabecera = new List<PropertyInfo>(vDataReport.ListaResultadosPam[vRegistro].GetType().GetProperties());
                        foreach (var vRotulo in vCabecera)
                        {
                            vFila.Append(CellComplete(vWordDoc, vRotulo.Name.ToUpper(), true));
                        }
                        vTabla2.Append(vFila);
                        vFila = new TableRow();
                        foreach (var vDatos in vCabecera)
                        {
                            vFila.Append(CellComplete(vWordDoc, vDatos.GetValue(vDataReport.ListaResultadosPam[vRegistro], null).ToString(), false));
                        }
                    }
                    else
                    {
                        var vDetalle = new List<PropertyInfo>(vDataReport.ListaResultadosPam[vRegistro].GetType().GetProperties());
                        foreach (var vDatos in vDetalle)
                        {
                            vFila.Append(CellComplete(vWordDoc, vDatos.GetValue(vDataReport.ListaResultadosPam[vRegistro], null).ToString(), false));
                        }
                    }
                    vTabla2.Append(vFila);


                    var vDetalle2 = new List<PropertyInfo>(vDataReport.ListaResultadosPam[vRegistro].GetType().GetProperties());
                    vFila = new TableRow();
                    foreach (var vDatos in vDetalle2)
                    {
                        vFila.Append(CellComplete2(vWordDoc));
                    }
                    vTabla2.Append(vFila);
                }

                string vTableLabelReplace2 = "Tabla_Evaluacion";
                Text vTableReplace2 = vWordDoc.MainDocumentPart.Document.Body.Descendants<Text>().FirstOrDefault(x => x.Text.Contains(vTableLabelReplace2));
                if (vTableReplace2 != null)
                {
                    var vParent = vTableReplace2.Parent.Parent.Parent;
                    vParent.InsertAfter(vTabla2, vTableReplace2.Parent.Parent);
                    vTableReplace2.Text = vTableReplace2.Text.Replace(vTableLabelReplace2, "");
                    vWordDoc.MainDocumentPart.Document.Save();
                }
                #endregion
            }
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


    }
}
