// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear ();
Console.WriteLine ("Введите пятизначное число: ");
int[] array1 = new int[5];
array1[0]=int.Parse(Console.ReadLine()!);
array1[1]=int.Parse(Console.ReadLine()!);
array1[2]=int.Parse(Console.ReadLine()!);
array1[3]=int.Parse(Console.ReadLine()!);
array1[4]=int.Parse(Console.ReadLine()!);

for (int i = 0; i < array1.Length; i++){
            Console.Write(array1[i]);
            if (i < array1.Length - 1) {
                Console.Write("");
            }
        }


Console.WriteLine(" Ваше число ");

int[] array2 = array1;
for (int i = 0; i < array2.Length/2; i++)
            {
                Console.Write(array2[i]);
                int temp = array2[i];
                array2[i] = array2[array2.Length - i - 1];
                array2[array2.Length - i - 1] = temp;
               
            }



Console.WriteLine(" Это палиндром");

Console.WriteLine("Нет, это не палиндром");