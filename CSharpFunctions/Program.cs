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

    Console.Write("]");
}

//RICHIAMO LE FUNZIONI

int[] arrayDiNumeri = { 2, 6, 7, 5, 3, 9 };
StampaArrayInteri(arrayDiNumeri);