using bytebank.Contas;
using bytebank.Titular;

Cliente cliente = new Cliente("Wellysson Nascimento Rocha", "123456789", "Desenvolvedor");

ContaCorrente cc1 = new ContaCorrente(15, "1010-x", 0, cliente);
ContaCorrente cc2 = new ContaCorrente(15, "1010-x", 0, cliente);
ContaCorrente cc3 = new ContaCorrente(15, "1010-x", 0, cliente);

Console.WriteLine($"Olá {cc1.titular.nome}! 👋🏾");
Console.WriteLine($"Seu saldo é {cc1.saldo}");

Console.WriteLine("Dados de ADMINISTRADOR:");
Console.WriteLine($"Total de contas criadas ➡️ {ContaCorrente.totalDeContasCriadas}");