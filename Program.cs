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

int input = Convert.ToInt32(Console.ReadLine());

string evenOdd (int input)
{
    if (input % 2 == 0)
    {
        return "pari";
    }
    else
    {
        return "dispari";
    }
}

Console.WriteLine(evenOdd(input));