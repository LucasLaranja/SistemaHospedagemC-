using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHospedagemHotel.Models;
public class Suite
{
    public string TipoSuite { get; set; }
    public int Capacidade {get; set; }
    public Decimal ValorDiaria {get; set; }
    public Suite()
    {
    }

    public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
    {
        TipoSuite = tipoSuite;
        Capacidade = capacidade;
        ValorDiaria = valorDiaria;
    }


}
