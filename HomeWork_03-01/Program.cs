using HomeWork_03_01;

//Square square = new Square();
//square.squarePrint();

//Palindrome palindrome = new Palindrome();
//Console.WriteLine(palindrome.methodPalindrome());

Filter filter = new Filter();

int[] array_1 = { 1, 2, 6, -1, 88, 7, 6 };
Console.WriteLine("Оригинальный массив:");
filter.PrintArray(array_1);

int[] array_2 = { 6, 88, 7 };
Console.WriteLine("Массив для фильтра:");
filter.PrintArray(array_2);

int[] array_3 = filter.ArrayFiltering(array_1, array_2);
Console.WriteLine("Отфильтрованный массив:");
filter.PrintArray(array_3);