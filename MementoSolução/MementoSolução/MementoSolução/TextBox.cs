using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MementoSolução
{
    public class TextBox : OriginadorInterface
    {
        public int x { get; set; }
        public int y { get; set; }
        public string text { get; set; }
        public string fontFamily { get; set; }

        public int fontSize { get; set; }

        public string textAlign { get; set; }

        public string fontWeight { get; set; }

        public TextBox(int x, int y, string text, string fontFamily,
        int fontSize, string textAlign, string fontWeight)
        {
            this.x = x;
            this.y = y;
            this.text = text;
            this.fontFamily = fontFamily;
            this.fontSize = fontSize;
            this.textAlign = textAlign;
            this.fontWeight = fontWeight;
        }
        public void imprimir()
        {
           
         Console.WriteLine($"Configuração caixa de texto: Pos x: {this.x}, y: {this.y} - Texto: {this.text} /n" +
                $" - Font Family: {this.fontFamily} - Font Size: {this.fontSize} /n" +
                $" - Font Weight: {this.fontWeight} - Text Align: { this.textAlign} ");

        }

        public MementoInterface salvar()
        {
            return new TextBoxMemento(this, this.x, this.y, this.text, this.fontFamily,
            this.fontSize, this.textAlign, this.fontWeight); 
        }

    
    }
}
