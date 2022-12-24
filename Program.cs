int size = 5;
string[] words = new string[size];
for(int i =0;i<size;i++)
{   
    Console.WriteLine($"Введите {i+1} элемент массива");
    words[i] = Console.ReadLine();
}
