//ESERCIZIO 1 STAMPA ARRAY SECONDO IL FORMATO [n , n , n , n]

void StampaArrayInteri(int[] array)
{

    Console.Write("Array stampato:  ");
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
    Console.Write("Il quadrato di " + numero + " è: ");
    int quadrato = (int)Math.Pow(numero, 2);
    return quadrato;

}


//ESERCIZIO 3 ARRAY AL QUADRATO
//per evitare modifiche all'array globale ridichiaro nella funzione un nuovo array che farò tornare con return

int[] ElevaArrayAlQuadrato(int[] array)
{
    Console.Write("Array elevato al quadrato: ");
    Console.Write("[");
    int[] arrayNuovo = (int[])array.Clone();

    for(int i = 0; i < arrayNuovo.Length; i++)
    {
        if (i < arrayNuovo.Length-1)
        {
        
            arrayNuovo[i] = (int)Math.Pow(arrayNuovo[i], 2);
            Console.Write(arrayNuovo[i] + " , ");

        }
        else
        {

            arrayNuovo[i] = (int)Math.Pow(arrayNuovo[i], 2);
            Console.Write(arrayNuovo[i]);

        }

    }

    Console.WriteLine("]");
    return arrayNuovo;

}


//ESERCIZIO 4 stampa somma numeri array


int SommaElementiArray(int[] array)
{
 
    int sommaArray = 0;
    for (int i = 0; i < array.Length; i++)
    {

        sommaArray = sommaArray + (int)array[i];

    }
    return sommaArray;

}


//RICHIAMO LE FUNZIONI

int[] arrayDiNumeri = { 2, 6, 7, 5, 3, 9 };
//richiamo funzione stampa array
StampaArrayInteri(arrayDiNumeri);
Console.WriteLine(Environment.NewLine);

//richiamo funzione quadrato di un numero
Console.WriteLine("Inserisci un numero da elevare al quadrato");
int mioNumero = int.Parse(Console.ReadLine());
int quadratoNumero = Quadrato(mioNumero);
Console.WriteLine(quadratoNumero);
Console.WriteLine(Environment.NewLine);

//Richiamo Funzione array al quadrato
int[] arrayAlQuadrato= ElevaArrayAlQuadrato(arrayDiNumeri);
Console.WriteLine(Environment.NewLine);

//richiamo di nuovo l'array per verificare cambiamenti
StampaArrayInteri(arrayDiNumeri);
Console.WriteLine(Environment.NewLine);

//richiamo somma array

int somma = 0;
somma = SommaElementiArray(arrayDiNumeri);
Console.WriteLine("La somma degli elementi dell'array è: " + somma);
Console.WriteLine(Environment.NewLine);

//somma elementi array al quadrato e richiamo la funzione somma passando come valore l'array al quadrato
int sommaArrayAlQuadrato = SommaElementiArray(arrayAlQuadrato);
Console.WriteLine("La somma dell'array al quadrato è: " + sommaArrayAlQuadrato);




