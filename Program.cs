
string[] readArr(){
 // Получаем массив от пользователя
    System.Console.WriteLine("Введите размер массива: ");
    string? arrLen = Console.ReadLine();
    int count = 0;
     while (!int.TryParse(arrLen, out int num) || num <= 0)
     {
      System.Console.WriteLine("Размер должен быть числом больше 0, введите размер массива: ");
      arrLen = Console.ReadLine();
     }
    string[] arr = new string[Convert.ToInt32(arrLen)];
    while(count < arr.Length)
    {
     System.Console.WriteLine("Введите элемент массива");
     string? elem = Console.ReadLine();
     if(elem == "") {
        System.Console.WriteLine("Элемент не должен быть пустым");
        continue;
     }
     arr[count] = elem;
     count += 1;
    }
    return arr;
}

string[] createNewArr(string[] arr){
 // Создаем новый рандомный массив из старого массива
 Random rand = new Random();
 string[] newArr = [];
 int i = 0;
 foreach (var t in arr)
 {
   if (Convert.ToBoolean(rand.Next(3))){   
      int start = rand.Next(t.Length);      // Вносим элемент в новый массив или нет
      Array.Resize(ref newArr, i + 1);
      newArr[i] = t.Substring(start, Math.Min(3, t.Length - start));
      i ++;
  }
 }
 return newArr;
}

void printArr(string[] newArr){
 // выводим массив на печать
 if(newArr.Length != 0) {
  System.Console.Write("[");
  for(int i = 0; i < newArr.Length - 1; i++)
  {
   System.Console.Write(newArr[i] + ",");
  }
  System.Console.Write(newArr[newArr.Length - 1] + "]");
 }
 else
 {
  System.Console.Write("[]");   
 }
}

printArr(createNewArr(readArr()));

