using System.Text;
using SistemaHospedagemHotel.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Lucas", "Laranja");
Pessoa p2 = new Pessoa(nome: "Caroline", "Laranja");

hospedes.Add(p1);
hospedes.Add(p2);

List<Pessoa> hospedesB = new List<Pessoa>();
Pessoa hosp = new Pessoa(nome: "Benjamin", "Laranja");
hospedesB.Add(hosp);

// Cria a suíte
Suite suiteA = new Suite(tipoSuite: "Junior", capacidade: 2, valorDiaria: 50);
Suite suiteB = new Suite(tipoSuite: "Master", capacidade: 5, valorDiaria: 200);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suiteA);
reserva.CadastrarHospedes(hospedes);
//-----------------------------------------------------------//
Reserva reservaB = new Reserva(diasReservados: 3);
reservaB.CadastrarSuite(suiteB);
reservaB.CadastrarHospedes(hospedesB);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}, Tipo de suite : {suiteA.TipoSuite}");
Console.WriteLine($"Hóspedes: {reservaB.ObterQuantidadeHospedes()}, Tipo de suite : {suiteB.TipoSuite}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
Console.WriteLine($"Valor diária: {reservaB.CalcularValorDiaria()}");