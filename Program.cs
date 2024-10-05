int idade;

Console.Write("Qual a sua idade: ");
idade = Convert.ToInt32(Console.ReadLine()!);
bool podeSerDoador = (idade >= 18) && (idade <= 67);
if (podeSerDoador)
{ 
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine("Você pode ser doador de sangue.");
}
else
{
     Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Você não pode ser doador de sangue.");

}
