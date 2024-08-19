using System.Text;
using SistemaHospedagemHotel.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Marcio", "Alves");
Pessoa p2 = new Pessoa(nome: "Ronado", "Borges");

hospedes.Add(p1);
hospedes.Add(p2);

List<Pessoa> hospedesB = new List<Pessoa>();
Pessoa hosp = new Pessoa(nome: "Isabel", "Silva");
hospedesB.Add(hosp);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);
Suite suiteB = new Suite(tipoSuite: "Master", capacidade: 5, valorDiaria: 150);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);
//-----------------------------------------------------------//
Reserva reservaB = new Reserva(diasReservados: 3);
reservaB.CadastrarSuite(suiteB);
reservaB.CadastrarHospedes(hospedesB);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}, Tipo de suite : {suite.TipoSuite}");
Console.WriteLine($"Hóspedes: {reservaB.ObterQuantidadeHospedes()}, Tipo de suite : {suiteB.TipoSuite}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
Console.WriteLine($"Valor diária: {reservaB.CalcularValorDiaria()}");