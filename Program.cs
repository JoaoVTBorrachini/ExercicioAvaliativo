using FluxoTiposExceptions.Classes;
Pessoa[] usuarios = new Pessoa[]
{
    new Gerente{
        Name = "Claudio"
        , Born = new(year:1990, month: 9, day: 10)
        , Salary = 5000
        , Cargo = "Gerente"
        , LojaResponsavel = "Loja de Fraiburgo-SC"
    },
    new Supervisor{
        Name = "Cleiton"
        , Born = new(year:1994, month: 6, day: 12)
        , Salary = 2500
        , Cargo = "Supervisor"
        , TeamResponseID = "Time escritório"
    },
    new Operario{
        Name = "Candida"
        , Born = new(year:2002, month: 5, day: 27)
        , Salary = 1800
        , Cargo = "Operario" 
        , HoraExtra = 40
    },
};

foreach (var item in usuarios)
{
    string message = string.Empty;
    if (item != null)
    {

        message = $"Nome: {item.Name} |";
        message += $" Cargo: {item.Cargo} |";
        message += $" Data Nasc: {item.Born.ToShortDateString()} |";

        if (item is Operario)
        {
            Operario operario = item as Operario;
            message += $" Hora extra(h): {operario.HoraExtra}";
        }

        if (item is Supervisor)
        {
            Supervisor supervisor = item as Supervisor;
            message += $" Time responsavel: {supervisor.TeamResponseID}";
        }

        if (item is Gerente) 
        {
            Gerente gerente = item as Gerente;
            message += $" Loja responsavel: {gerente.LojaResponsavel}";
        }
    }
    Console.WriteLine(message);
}
