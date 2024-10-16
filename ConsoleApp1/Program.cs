
// 1. შექმენით კონსოლური აპლიკაცია რომელიც ხმოვანებს დაითვლის
// * მომხმარებელს შეაყვანინეთ input 
// * მიღებულ input ში დაითვალეთ ხმოვნები
// * დაბეჭდეთ სულ რამდენი ხმოვანი იყო


using System.Diagnostics.Metrics;

Console.WriteLine("Enter a word: ");
string input = Console.ReadLine();

char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'Y', 'a', 'e', 'i', 'o', 'u', 'y' , 'ა', 'ე', 'ი', 'ო' , 'უ'};
int count = 0;



foreach (char c in input)
{
    bool isVowel = false; 


    foreach (char vowel in vowels)
    {
        if (c == vowel)
        {
            isVowel = true; 
            break;
        }
    }

   
    if (isVowel)
    {
        count++;
    }
}


Console.WriteLine("Number of vowels: " + count);




