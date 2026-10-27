// int age = 20;

// if (age >= 21) {
//     Console.WriteLine("Доступ разрешён");
// }

// Console.WriteLine("Программа продолжает работу");


// int age = 20;

// if (age >= 21) {
//     Console.WriteLine("Доступ разрешён");
// }

// Console.WriteLine("Программа продолжает работу");


// int age = 65;

// if (age >= 60) {
//     Console.WriteLine("Пенсионер");
// } else if (age < 13) {
//     Console.WriteLine("Ребёнок");
// } else if (age < 18) {
//     Console.WriteLine("Подросток");
// } else {
//     Console.WriteLine("Взрослый");
// }


// int age = 12;
// double height = 1.4;
// bool hasAdultEscort = true;

// if (age >= 14 && (height >= 1.5 || hasAdultEscort)) {
//     Console.WriteLine("Можно кататься");
// } else {
//     Console.WriteLine("Пока нельзя");
// }


// Console.Write("Введите целое число: ");
// int n = int.Parse(Console.ReadLine()!);

// if (n % 2 == 0) {
//     Console.WriteLine("Чётное");
// } else {
//     Console.WriteLine("Нечётное");
// }


// Console.Write("Введите оценку (2-5): ");
// int mark = int.Parse(Console.ReadLine()!);

// switch (mark) {
//     case 5:
//         Console.WriteLine("Отлично");
//         break;
//     case 4:
//         Console.WriteLine("Хорошо");
//         break;
//     case 3:
//         Console.WriteLine("Удовлетворительно");
//         break;
//     case 2:
//         Console.WriteLine("Неудовлетворительно");
//         break;
//     default:
//         Console.WriteLine("Неверная оценка");
//         break;
// }


// Console.Write("Введите первое число: ");
// double a = double.Parse(Console.ReadLine()!);
// Console.Write("Введите второе число: ");
// double b = double.Parse(Console.ReadLine()!);
// Console.Write("Введите третье число: ");
// double c = double.Parse(Console.ReadLine()!);

// double max = a;
// if (b > max) max = b;
// if (c > max) max = c;

// Console.WriteLine($"Наибольшее число: {max}");


// Console.Write("Введите год: ");
// int year = int.Parse(Console.ReadLine()!);

// if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) {
//     Console.WriteLine("Високосный год");
// } else {
//     Console.WriteLine("Невисокосный год");
// }


// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();

// if (string.IsNullOrEmpty(surname)) {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }

Console.Write("Введите свою фамилию: ");
string surname = Console.ReadLine()!.Trim();
if (string.IsNullOrEmpty(surname)) {
Console.WriteLine("Фамилия не введена. Завершение работы.");
return;
}
Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
var assigned = Enumerable.Range(1, 10)
.OrderBy(_ => rnd.Next())
.Take(2)
.OrderBy(x => x)
.ToList();
Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// erkin
// 4 var
Console.Write("Введите целое число: ");
int n = int.Parse(Console.ReadLine()!);

bool isEven = (n % 2 == 0);
bool isPositive = (n > 0);

if (isEven && isPositive) {
    Console.WriteLine("Чётное положительное");
} else if (isEven && !isPositive) {
    Console.WriteLine("Чётное не положительное");
} else if (!isEven && isPositive) {
    Console.WriteLine("Нечётное положительное");
} else {
    Console.WriteLine("Нечётное не положительное");
}
//10 var

Console.Write("Введите возраст пассажира: ");
int age = int.Parse(Console.ReadLine()!);

Console.Write("Введите тип места (плацкарт / купе / св): ");
string seatType = Console.ReadLine()!.Trim().ToLower();

double basePrice = seatType switch {
    "плацкарт" => 1000,
    "купе" => 2000,
    "св" => 3000,
    _ => -1
};

if (basePrice < 0) {
    Console.WriteLine("Неверный тип места");
    return;
}

double discount = 0;
if (age < 10) {
    discount = 0.50;
} else if (age >= 18 && age <= 25) {
    discount = 0.30;
} else if (age >= 60) {
    discount = 0.40;
}

double finalPrice = basePrice * (1.0 - discount);
Console.WriteLine($"Итоговая стоимость: {finalPrice} руб.");


// Titov
// 7 var
Console.Write("Сторона a: ");
double a = double.Parse(Console.ReadLine()!);
Console.Write("Сторона b: ");
double b = double.Parse(Console.ReadLine()!);
Console.Write("Сторона c: ");
double c = double.Parse(Console.ReadLine()!);

if (a + b > c && a + c > b && b + c > a) {
    if (a == b && b == c) {
        Console.WriteLine("Равносторонний");
    } else if (a == b || a == c || b == c) {
        Console.WriteLine("Равнобедренный");
    } else {
        Console.WriteLine("Разносторонний");
    }
} else {
    Console.WriteLine("Треугольник не существует");
}

// 8 var
Console.Write("Введите год: ");
int y = int.Parse(Console.ReadLine()!);

if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
{
    Console.WriteLine("Год високосный, в феврале 29 дней");
}
else
{
    Console.WriteLine("Год не високосный, в феврале 28 дней");
}



