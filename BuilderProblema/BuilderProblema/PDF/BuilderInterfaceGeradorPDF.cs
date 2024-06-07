using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderProblema.PDF
{
    public interface  BuilderInterfaceGeradorPDF
    {
        public GeradorPDF getGeradorPDF();
        public void setPageConfiguration();
        public void setMargin();
        public void setHeader();
        public void setFooter();
    }
}
