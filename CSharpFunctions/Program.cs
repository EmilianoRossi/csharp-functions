//ESERCIZIO 1 STAMPA ARRAY SECONDO IL FORMATO [n , n , n , n]

void StampaArrayInteri(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {

        if (i < array.Length-1)
        {

            Console.Write(array[i] + " , ");

        }

        else
        {

            Console.Write(array[i]);

        }

    }

    Console.WriteLine("]");
}


//ESERCIZIO 2 STAMPA IL QUADRATO DI UN NUMERO PASSATO COME PARAMETRO



int Quadrato(int numero)
{

    int quadrato = (int)Math.Pow(numero, 2);
    return quadrato;

}







//RICHIAMO LE FUNZIONI

//richiamo funzione stampa array
int[] arrayDiNumeri = { 2, 6, 7, 5, 3, 9 };
StampaArrayInteri(arrayDiNumeri);

//richiamo funzione quadrato di un numero
Console.WriteLine("Inserisci un numero da elevare al quadrato");
int mioNumero = int.Parse(Console.ReadLine());
int quadratoNumero = Quadrato(mioNumero);
Console.WriteLine(quadratoNumero);