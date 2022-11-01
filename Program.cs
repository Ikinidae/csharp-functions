//Snack 1
//Dare la possibilità di inserire due parole. Verificare tramite una funzione che le due parole abbiano la stessa lunghezza.
//Se hanno la stessa lunghezza, stamparle entrambe, altrimenti stampare la più lunga delle due. (stampare fuori dalla funzione)

//string firstWord = Console.ReadLine();
//string secondWord = Console.ReadLine();

//string stampWord (string word1, string word2)
//{
//	if (word1.Length == word2.Length)
//	{
//        return word1 + ", " + word2;
//	}
//	else if (word1.Length >= word2.Length)
//	{
//		return word1;
//	}
//	else
//	{
//        return word2;
//    }
//}

//Console.WriteLine(stampWord(firstWord, secondWord));



//Snack 2
//Scrivere una funzione per verificare se un numero è pari o dispari. Quindi chiedere un numero all’utente e comunicargli se è pari o dispari.

//int input = Convert.ToInt32(Console.ReadLine());

//string evenOdd (int input)
//{
//    if (input % 2 == 0)
//    {
//        return "pari";
//    }
//    else
//    {
//        return "dispari";
//    }
//}

//Console.WriteLine(evenOdd(input));




//void StampaArray(int[] array): che preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]“. 

using System;

void StampaArray(int[] array)
{
    Console.WriteLine("il tuo array è: [");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
        if (i != array.Length - 1)
            Console.Write(", ");
    };
    Console.WriteLine("]");
}




//int Quadrato(int numero): che vi restituisca il quadrato del numero passato come parametro.
int Quadrato(int numero)
{
    return numero * numero;
}



//int[] ElevaArrayAlQuadrato(int[] array): che preso un array di numeri interi, restituisca un nuovo array con tutti gli elementi elevati quadrato.
//Attenzione: è importante restituire un nuovo array, e non modificare l’array come parametro della funzione! Vi ricordate perchè? Pensateci (vedi slide)

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i] * array[i];
    }
    return newArray;
}



//int SommaElementiArray(int[] array): che preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.

int SommaElementiArray(int[] array)
{
	int sum = 0;
	for (int i = 0; i < array.Length; i++)
	{
		sum += array[i];
	}
	return sum;
}


Console.WriteLine("Quanti numeri vuoi inserire?");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
for (int i = 0; i < N; i++)
{
    Console.WriteLine("Inserisci il numero " + (i + 1));
    array[i] = Convert.ToInt32(Console.ReadLine());
}

int[] ints = { 2, 6, 7, 5, 3, 9 };
StampaArray(array);
int[] arrayQuadrato = ElevaArrayAlQuadrato(array);
StampaArray(arrayQuadrato);
StampaArray(array);
Console.WriteLine(SommaElementiArray(array));
Console.WriteLine(SommaElementiArray(arrayQuadrato));