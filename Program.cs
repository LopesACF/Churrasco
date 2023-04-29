double Cervejas, Criança, AdultoC, AdultoN, CarnePorAdultoEmKG, CarnePorCriançaEmKG, AcompanhamentosA, AcompanhamentosC, Acompanhamentos,
Adultos, RefrigeranteA, RefrigeranteC, Refrigerantes, ÁguaA, ÁguaC, Águas, Carnes;

const double CarnePorAdultoEmG = 400, CarnePorCriançaEmG = 200, AcompanhamentosPorAdulto = 200, AcompanhamentosPorCriança = 200; 
const double CervejaPorAdultoML = 200, RefrigerantePorAdulto = 500, RefrigerantePorCriança = 500, ÁguaPorAdulto = 400, ÁguaPorCriança = 400;

Console.WriteLine("--- Churrasco ---\n");

Console.WriteLine("Quantidade de adultos que bebem? ");
AdultoC = Convert.ToDouble(Console.ReadLine()); 

Console.WriteLine("Quantidade de adultos que não bebem? ");
AdultoN = Convert.ToDouble(Console.ReadLine());

Adultos = AdultoC + AdultoN; 

Console.WriteLine ("Quantidade de crianças? ");
Criança = Convert.ToDouble(Console.ReadLine());

 
Console.Clear();

double Crianças = Criança;

Cervejas = AdultoC * CervejaPorAdultoML /1000;

CarnePorAdultoEmKG = Adultos * CarnePorAdultoEmG /1000;
CarnePorCriançaEmKG = Criança * CarnePorCriançaEmG /1000;

Carnes = CarnePorAdultoEmKG + CarnePorCriançaEmKG;

AcompanhamentosA = Adultos * AcompanhamentosPorAdulto /1000;
AcompanhamentosC = Crianças * AcompanhamentosPorCriança /1000;

Acompanhamentos = AcompanhamentosA + AcompanhamentosC;

RefrigeranteA = Crianças * RefrigerantePorAdulto /1000;
RefrigeranteC = Crianças * RefrigerantePorCriança /1000;

Refrigerantes = RefrigeranteA + RefrigeranteC;

ÁguaA = Crianças * ÁguaPorCriança /1000;
ÁguaC = Adultos * ÁguaPorAdulto /1000;

Águas = ÁguaA + ÁguaC;



Console.WriteLine("---Tabela do Churrasco---\n");

Console.WriteLine($"Quantidade de Crianças        = {Crianças}");
Console.WriteLine($"Quantidade de Adultos         = {Adultos}\n");
Console.WriteLine($"Quantidade de Cerveja         = {Cervejas.ToString("f")} L");
Console.WriteLine($"Quantidade de Carne           = {Carnes.ToString("f")} Kg");
Console.WriteLine($"Quantidade de Acompanhamentos = {Acompanhamentos.ToString("f")} Kg");
Console.WriteLine($"Quantidade de Refrigerante    = {Refrigerantes.ToString("f")} L");
Console.WriteLine($"Quantidade de Água            = {Águas.ToString("f")} L");


