// Задача № 1
// int Twonumber(int number){
//     return number /10 % 10;
// }
// Random rnd = new Random();
// int n = rnd.Next(100, 1000);
// System.Console.WriteLine($"Вторая цифра числа {n} - {Twonumber(n)}");

//Задача № 2
// int Threenumber(int number){
//     if (number < 100){
//         System.Console.WriteLine("Третьей цифры нет");
//         return 0;
//     }
//     int result = 0;
//     while (number > 999){
//         number /= 10;
//         result = number % 10;
//     }
//     return result;
// }
// System.Console.WriteLine(Threenumber(43421221));

//Задача № 3

bool Weekend(int number){
    if(number > 7 || number < 1){
        return false;
    }
    if (number > 5){
        return true;
    }
    else{
        return false;
    }
}
System.Console.WriteLine(Weekend(5));



