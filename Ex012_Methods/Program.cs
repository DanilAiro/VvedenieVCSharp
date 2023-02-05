// Вид 1

void Method1()
{
  Console.WriteLine("Автор Борисов Данила");
}
//Method1();

// Вид 2

void Method2(string msg)
{
  Console.WriteLine(msg);
}
//Method2("Текст сообщения");

void Method21(string msg, int count)
{
  int i = 0;
  while (i < count)
  {
    Console.WriteLine(msg);
    i++;
  }
  
}
//Method21(msg: "Текст сообщения",count: 4);

// Вид 3

int Method3()
{
  return DateTime.Now.Year;
}

//int year = Method3();
//Console.WriteLine(year);

// Вид 4

string Method4(int count, string text)
{
  int i = 0;
  string result = String.Empty;
  while (i < count) 
  { 
    result += text;
    i++;
  }
  return result;
}
//string res = Method4(10, "asdf ");
//Console.WriteLine(res);

string Method41(int count, string text)
{
  string result = String.Empty;
  for (int i = 0; i < count; i++)
  {
    result += text;
  }
  return result;
}
//string res = Method41(10, "asdf ");
//Console.WriteLine(res);

/*for (int i = 2; i <= 10; i++)
{
  for (int j = 2; j <= 10; j++)
  {
    Console.WriteLine($"{i} x {j} = {i * j}");
  }
  Console.WriteLine();
}*/

// Дан текст. В тексте нужно все пробелы заменить чёрточками, маленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
         + "ежели бы вас послали вместо нашего милого Винценгероде, "
         + "вы бы взяли приступом согласие прусского короля. "
         + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty";
//             012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
  string result = String.Empty;

  int length = text.Length;
  for (int i = 0; i < length; i++) 
  {
    if (text[i] == oldValue) result += $"{newValue}";
    else result+= $"{text[i]}";
  }
  return result;
}

//string newText = Replace(text, ' ', '_');
//Console.WriteLine(newText);
//Console.WriteLine();
//newText = Replace(newText, 'к', 'К');
//Console.WriteLine(newText);
//Console.WriteLine();
//newText = Replace(newText, 'С', 'с');
//Console.WriteLine(newText);

// Сортировка массива

int[] numbers = new int[] {6, 8, 3, 2, 1, 4, 5, 7};

PrintArray(numbers);
SelectionSort(numbers);
PrintArray(numbers);



void SelectionSort(int[] numbers)
{
  for (int i = 0; i < numbers.Length - 1;i++) 
  {
    int minPosition = i;
    for (int j = i + 1; j < numbers.Length; j++) 
    { 
      if (numbers[j] < numbers[minPosition]) minPosition = j;
    }
    int temporary = numbers[i];
    numbers[i] = numbers[minPosition];
    numbers[minPosition] = temporary;
  }
}

void PrintArray(int[] array)
{
  int count = array.Length;
  for (int i = 0; i < count;i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}