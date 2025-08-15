using   Note_Calculator.Domain;
using   System;

namespace Note_Calculator.CLi;
internal class ClientMsg
{
    public void WelcomeMsg()
    {
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("| Bienvenue sur le Calculateur de Note !                    |");
        Console.WriteLine("| Entrez vos notes séparées par des virgules (ex: 12,14,8): |");
        Console.WriteLine("-------------------------------------------------------------");
        Console.WriteLine("\nTapez \'Exit\' afin de quitter l'application: ");
        Console.WriteLine("-------------------------------------------");
    }

    public void ExitMsg()
    {
        Console.WriteLine();
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine("| Merci d'avoir utilisé le Calculatoeur de Note              |");
        Console.WriteLine("| Bonne Journée !                                            |");
        Console.WriteLine("--------------------------------------------------------------");
    }
    public void Exception_Invalid_Input()
    {
        Console.WriteLine("➤Entrée invalide : seuls les chiffres, virgules et espaces sont autorisés. Réessayer...");
    }
}