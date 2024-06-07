using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProblema.PDF
{
    public class BuilderA3 : BuilderInterfaceGeradorPDF
    {
        private GeradorPDF geradorPDF;

        public BuilderA3()
        {
            this.geradorPDF = new GeradorPDF();
        }
        public GeradorPDF getGeradorPDF()
        {
            return this.geradorPDF;
        }

        public void setFooter()
        {
            this.geradorPDF.hasFooter = true;
            this.geradorPDF.footerHeight = 15;
        }

        public void setHeader()
        {
            this.geradorPDF.hasFooter = true;
            this.geradorPDF.footerHeight = 15;
        }

        public void setMargin()
        {
            this.geradorPDF.marginLeft = 20;
            this.geradorPDF.marginRight = 20;
            this.geradorPDF.marginBottom = 30;
            this.geradorPDF.marginTop = 30;
        }

        public void setPageConfiguration()
        {
            this.geradorPDF.pageOrientation = "portrait";
            this.geradorPDF.unit = "mm";
            this.geradorPDF.pageSizeX = 297;
            this.geradorPDF.pageSizeY = 420;
            this.geradorPDF.pageColor = "#ffffff";
            this.geradorPDF.encode = "UTF-8";
        }
    }
}
