int size = 5;
int newsize = 0;
string[] words = new string[size];
for(int i =0;i<size;i++)
{   
    Console.WriteLine($"Введите {i+1} элемент массива");
    words[i] = Console.ReadLine();
}
for(int i = 0;i<size;i++)
{
    if(words[i].Length<=3)
    {
        newsize++;
    }
}
string[] newWords = new string[newsize];
int t=0;
for(int i = 0;i<size;i++)
{
    if(words[i].Length<=3)
    {
        newWords[t]=words[i];
        t++;
    }
}
Console.Write("Новый массив = [");
for(int i=0;i<newsize;i++)
    {
        Console.Write(newWords[i] +", ");
    }
Console.WriteLine("]");