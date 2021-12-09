
string input = Console.ReadLine();
input = input.ToLower();
Dictionary<char, char> means = new Dictionary<char, char>(input.Length);
for (int i = 0; i < input.Length; i++)
{
    for(int j = input.Length - 1; j >= 0; j--)
    {
        if (means.ContainsKey(input[i]))
        {
            break;
        }
        if (input[j] == input[i] && j != i)
        {
            means.Add(input[j], ')');
            break;
        }
        else if (input[j] == input[i] && j == i)
        {
            means.Add(input[j], '(');
            break;
        }
    }
}
foreach(char c in input)
{
    input = input.Replace(c, means[c]);
}

Console.WriteLine(input);
