// See https://aka.ms/new-console-template for more information
using BuilderProblema.PDF;

BuilderA4 builderA4 = new BuilderA4();
GeradorPDFDirector director = new GeradorPDFDirector(builderA4);
director.criarGeradorPDF();
GeradorPDF pdfA4 = builderA4.getGeradorPDF();
Console.WriteLine(pdfA4.ToString());

BuilderA3 builderA3 = new BuilderA3();
GeradorPDFDirector director2 = new GeradorPDFDirector(builderA3);
director.criarGeradorPDFNotHeaderNotFooter();
GeradorPDF pdfA3 = builderA3.getGeradorPDF();
Console.WriteLine(pdfA3.ToString());

