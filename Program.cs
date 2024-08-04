//
// This Code is written with some help from (Microsoft Copilet & POE Assistance)
//

Console.Write("Enter your first input : ");
string firstInput = Console.ReadLine();

Console.Write("Enter your second input : ");
string secondInput = Console.ReadLine();

bool samePattern = checkSamePattern(firstInput, secondInput);

Console.WriteLine($"Original strings: {firstInput},{secondInput}");
Console.WriteLine($"Check the same character pattern: {samePattern}");

Console.ReadKey();

static bool checkSamePattern(string str1,string str2)
{
    if (str1.Length != str2.Length)
        return false;

    Dictionary<char, char> map1 = new Dictionary<char, char>();
    Dictionary<char, char> map2 = new Dictionary<char, char>();

    for (int i = 0; i < str1.Length; i++)
    {
        char c1 = str1[i];
        char c2 = str2[i];

        
        if (!map1.ContainsKey(c1))
        {
            if (map2.ContainsKey(c2))
                return false; 

            map1[c1] = c2;
            map2[c2] = c1;
        }
        
        else if (map1[c1] != c2 || map2[c2] != c1)
        {
            return false; 
        }
    }

    return true; 
}
