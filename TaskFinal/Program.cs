﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] ThreeAndLess(string[] inputArr)
{
  int j = 0;                                       //временная переменная размера выходного массива
  string[] newArr = new string[inputArr.Length];   //выходной массив длинны как начальный
  for (int i = 0; i < inputArr.Length; i++)        //цикл по входному массиву
  {
    if (inputArr[i].Length <= 3)                   //Если длинна строки в массиве 3 и меньше знаков то 
    {
      newArr[j] = inputArr[i];                     //добавляем в newArr по индексу j
      j++;                                         // И увеличиваем J

    }
  }
  Array.Resize(ref newArr, j);                    // обрезаем массив до j элементов
  return newArr;
}




//Предзаполненный массив, можно выбрать другой
string[] arr = { "Hello", "2", "world", ":-)" };                          
// string[] arr= {"1234", "1567", "-2", "computer science"};
// string[] arr = { "Russia", "Denmark", "Kazan" };

System.Console.WriteLine(string.Join(", ", ThreeAndLess(arr))); //выводим в консоль массив полученный из метода
