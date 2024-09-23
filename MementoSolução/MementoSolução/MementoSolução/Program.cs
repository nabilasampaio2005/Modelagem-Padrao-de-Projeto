using MementoSolução;

Historico historico = new Historico();

TextBox textBox = new TextBox(x: 2, y: 10, text: "Texto versão 01",
    fontFamily: "monospace", fontSize: 15, textAlign: "center", fontWeight: "bold");

historico.criarCheckPoint(textBox);

textBox.text = "Texto versão 02";

historico.criarCheckPoint(textBox);

textBox.x = 100;
textBox.y = 200;

Console.WriteLine("Ultima atualização");
historico.imprimir();
historico.desfazer();

Console.WriteLine("Versão anterior");
historico.imprimir();
historico.desfazer();

Console.WriteLine("Primeira versão");
historico.imprimir();
