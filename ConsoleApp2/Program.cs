// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Console.WriteLine("二、");

//int[] array = { 1, 4, 3, 6, 9, 11, 8, 36};
//int e = 23;
//int index = 2;

//List<int> listA = array.ToList();
//listA.Insert(index, e);

//foreach (int i in listA.ToArray())
//{
//    Console.Write(i + " ");
//}


//Console.WriteLine("\n");
//Console.WriteLine("三、");

//int[] array2 = new int[10];

//for (int i = 0; i < 10; i++)
//{
//    string tmp = Console.ReadLine() ?? "";
//    if (string.IsNullOrEmpty(tmp) || !tmp.All(char.IsDigit))
//    {
//        Console.WriteLine("only number!");
//        i--;
//    }
//    else
//    {
//        int number = Convert.ToInt32(tmp);
//        bool re = false;
//        for (var k = 0; k < array2.Length; k++)
//        {
//            if(array2[k] == number) {
//                re = true;
//                break;
//            }
//        }
//        if (!re)
//        {
//            array2[i] = number;
//        }
//        else
//        {
//            Console.WriteLine("repeat!");
//            i--;
//        }
//    }
//}

//Array.Reverse(array2);

//foreach (int i in array2)
//{
//    Console.Write(i + " ");
//}

string t = "qwer";
Console.WriteLine(t.Substring(2));