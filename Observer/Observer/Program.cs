using ObserverSolucao.Observers;
using ObserverSolucao.Subjects;


   Newsletter newsletter = new Newsletter();

   Funcionario funcionario1 = new Funcionario("func01", "func01@teste.com");
   newsletter.registerObserver(funcionario1);

   Funcionario funcionario2 = new Funcionario("func02", "func02@teste.com");
   newsletter.registerObserver(funcionario2);

   Cliente cliente = new Cliente("cli01", "cli01@teste.com");
   newsletter.registerObserver(cliente);

   Parceiro parceiro = new Parceiro("parc", "parc@teste.com");
   newsletter.registerObserver(parceiro);

   Fornecedor fornecedor = new Fornecedor("forn", "forn@teste.com");
   newsletter.registerObserver(fornecedor);

   Console.WriteLine("--------------TESTE 1 MENSAGEM---------");
   newsletter.addMenssage("Primeira mensagem");

   newsletter.removeObserver(funcionario2);
   Console.WriteLine("--------------TESTE 2 MENSAGEM---------");
   newsletter.addMenssage("Segunda mensagem");

   newsletter.registerObserver(funcionario2);
   Console.WriteLine("--------------TESTE 3 MENSAGEM---------");
   newsletter.addMenssage("Terceira mensagem");
