using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProblema.PDF
{
    public class GeradorPDF
    {
        public string pageOrientation { get; set; } = "portrait";
        public string unit { get; set; } = "mm";
        public int pageSizeX { get; set; } = 210;
        public int pageSizeY { get; set; } = 297;
        public int marginTop { get; set; } = 30;
        public int marginRight { get; set; } = 20;
        public int marginBottom { get; set; } = 30;
        public int marginLeft { get; set; } = 20;
        public bool hasHeader { get; set; } = false;
        public int headerHeight { get; set; } = 0;
        public bool hasFooter { get; set; } = false;
        public int footerHeight { get; set; } = 0;
        public string pageColor { get; set; } = "#ffffff";
        public string encode { get; set; } = "UTF-8";

        public GeradorPDF(string pageOrientation, string unit, int pageSizeX, int pageSizeY, int marginTop, 
            int marginRight, int marginBottom, int marginLeft, bool hasHeader, int headerHeigh, 
            bool hasFooter, int footerHeigh, string pageColor, string encode)
        {
            this.pageOrientation = pageOrientation;
            this.unit = unit;
            this.pageSizeX = pageSizeX;
            this.pageSizeY = pageSizeY;
            this.marginTop = marginTop;
            this.marginRight = marginRight;
            this.marginBottom = marginBottom;
            this.marginLeft = marginLeft;
            this.hasHeader = hasHeader;
            this.headerHeight = headerHeight;
            this.hasFooter = hasFooter;
            this.footerHeight = footerHeight;
            this.pageColor = pageColor;
            this.encode = encode;
        }

        public override string? ToString()
        {
            return $"\nPageOrientation = {pageOrientation}\n" +
               $"Unit = {unit}\n" +
               $"PageSizeX = {pageSizeX}\n" +
               $"PageSizeY = {pageSizeY}\n" +
               $"MarginTop = {marginTop}\n" +
               $"MarginRight = {marginRight}\n" +
               $"MarginBottom = {marginBottom}\n" +
               $"MarginLeft = {marginLeft}\n" +
               $"HasHeader = {hasHeader}\n" +
               $"HeaderHeight = {headerHeight}\n" +
               $"HasFooter = {hasFooter}\n" +
               $"FooterHeight = {footerHeight}\n" +
               $"PageColor = {pageColor}\n" +
               $"Encode = {encode}";
        }
    }
}
