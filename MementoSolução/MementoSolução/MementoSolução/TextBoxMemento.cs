using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoSolução
{
    public class TextBoxMemento : MementoInterface
    {
        public TextBox textBox { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public string text { get; set; }
        public string fontFamily { get; set; }

        public int fontSize { get; set; }

        public string textAlign { get; set; }

        public string fontWeight { get; set; }
        public TextBoxMemento(TextBox textBox, int x, int y, string text, string fontFamily,
        int fontSize, string textAlign, string fontWeight)
        { 
            this.textBox = textBox;
            this.x = x;
            this.y = y;
            this.text = text;
            this.fontFamily = fontFamily;
            this.fontSize = fontSize;
            this.textAlign = textAlign;
            this. fontWeight = fontWeight;
        }
        public void restaurar()
        {
            this.textBox.x = this.x;

            this.textBox.y = this.y;

            this.textBox.text = this.text;

            this.textBox.fontFamily = this.fontFamily;

            this.textBox.fontSize = this.fontSize;

            this.textBox.textAlign = this.textAlign;

            this.textBox.fontWeight = this.fontWeight;
        }
    }
}
