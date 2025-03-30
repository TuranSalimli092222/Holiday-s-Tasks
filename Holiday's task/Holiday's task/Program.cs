#region task1
/*
Console.WriteLine("iki eded daxil edin:");
int num1 =int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int sum = num1 + num2;  
Console.WriteLine($"cemi:{sum}");*/
#endregion
#region task2
/*Console.WriteLine("kvadratin tapmaq istediyiniz ededi daxil edin:");
int num = int.Parse(Console.ReadLine());
int pow = num*num;
Console.WriteLine($"{num} kvadrati - {pow}");
*/
#endregion
#region task3
/*Console.WriteLine("adinizi daxil edin:");
string name = Console.ReadLine();
Console.WriteLine("yasinizi daxil edin:");
int age= int.Parse(Console.ReadLine());
Console.WriteLine($"Salam menim adim {name} ve menim {age} yasim var.");*/
#endregion
#region task4
/*int num = 10;
int num1 = 20;
int ChangeNum;
ChangeNum = num;
Console.Write(num);
num = num1;
Console.WriteLine($" deyisib {num} oldu");
Console.Write(num1);
num1 = ChangeNum;
Console.WriteLine($" deyisib {num1} oldu");*/
#endregion
#region task5
/*int num1 = 10;
int num2 = 20;
int num3 = 30;
int sum = num1 + num2 + num3;
Console.WriteLine(sum);
int EdediOrta = sum / 3;
Console.WriteLine(EdediOrta);*/
#endregion
#region task6
/*Console.WriteLine("eded daxil edin:");
int num = int.Parse(Console.ReadLine()); //1234
int qaliq;
int sum = 0;
for (int i = 0; i < 5; i++)
{
    qaliq = num % 10;
    num = num / 10;
    sum += qaliq;
}
Console.WriteLine(sum);*/
#endregion
#region task7
/*Console.WriteLine("eded daxil edin:");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine($"{num} cut ededdir.");
}
else if (num % 2 == 1)
    Console.WriteLine($"{num} tek ededdir");
else
{
    Console.WriteLine($"{num} ne tek ne cut ededdir");
}*/
#endregion
#region task8
/*Console.WriteLine("eded daxil edin:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("eded daxil edin:");
int num2 = int.Parse(Console.ReadLine());
if (num1 > num2)
    Console.WriteLine($"{num1} -> {num2}-den buyukdur");
else if (num1 < num2)
    Console.WriteLine($"{num2} -> {num1}-den buyukdur");
else
    Console.WriteLine($"{num1} -> {num2}-e beraberdir.");*/
#endregion
#region task9
/*Console.WriteLine("eded daxil edin:");
int num = int.Parse(Console.ReadLine());
if (num == 0)
    Console.WriteLine($"{num} ne menfidir ne musbet.");
else if (num > 0)
    Console.WriteLine($"{num} musbet ededdir.");
else
    Console.WriteLine($"{num} menfi ededdir.");*/
#endregion
#region task10
/*Console.Write("eded daxil edin:");
int num = int.Parse(Console.ReadLine());
if (num % 3 == 0 && num % 5 == 0)
{
    Console.WriteLine($"{num} hem 3 e hemde 5 e bolunur.");
}
else if (num % 3 == 0 && num % 5 != 0)
{
    Console.WriteLine($"{num} eded 3 e bolunur 5 e ise yox");
}
else if (num % 3 != 0 && num % 5 == 0)
{
    Console.WriteLine($"{num} eded 5 e bolunur 3 e ise yox");
}
else
{
    Console.WriteLine("eded ne 3 e nede 5 e bolunmur.");
}*/
#endregion
#region task11
/*Console.Write("eded daxil edin:");
int num = int.Parse(Console.ReadLine());
if (num % 3 == 0 && num % 2 == 0)
{
    Console.WriteLine($"{num} hem 3 e hemde 2 e bolunur.");
}
else if (num % 3 == 0 && num % 2 != 0)
{
    Console.WriteLine($"{num} eded 3 e bolunur 2 e ise yox");
}
else if (num % 3 != 0 && num % 2 == 0)
{
    Console.WriteLine($"{num} eded 2 e bolunur 3 e ise yox");
}
else
{
    Console.WriteLine("eded ne 3 e nede 2 e bolunmur.");
}*/
#endregion
#region task12
/*Console.WriteLine("ayin nomresini daxil edin:");
int month = int.Parse(Console.ReadLine());
switch (month)
{
    case 1:
        Console.WriteLine($"{month}-ci ay Yanvardir");
        break;
    case 2:
        Console.WriteLine($"{month}-ci ay Fevraldir");
        break;
    case 3:
        Console.WriteLine($"{month}-ci ay Martdir");
        break;
    case 4:
        Console.WriteLine($"{month}-ci ay Apreldir");
        break;
    case 5:
        Console.WriteLine($"{month}-ci ay Maydir");
        break;
    case 6:
        Console.WriteLine($"{month}-ci ay Iyundur");
        break;
    case 7:
        Console.WriteLine($"{month}-ci ay Iyuldur");
        break;
    case 8:
        Console.WriteLine($"{month}-ci ay Avgustdur");
        break;
    case 9:
        Console.WriteLine($"{month}-ci ay Sentyabrdir");
        break;
    case 10:
        Console.WriteLine($"{month}-ci ay Oktyabrdir");
        break;
    case 11:
        Console.WriteLine($"{month}-ci ay Noyabrdir");
        break;
    case 12:
        Console.WriteLine($"{month}-ci ay Dekabrdir");
        break;
    default:
        Console.WriteLine("Sadece 12 ay vardir");
        break;
}*/
#endregion
#region task13
/*Console.WriteLine("Imtahan neticenizi qeyd edin:");
int result = int.Parse(Console.ReadLine());
switch (result)
{
    case int n when (result >= 91 && result <= 100):
    Console.WriteLine("Tebrikler A-aldiniz");
        break;
    case int n when (result >= 81 && result <= 90):
        Console.WriteLine("Tebrikler B-aldiniz");
        break;
    case int n when (result >= 71 && result <= 80):
        Console.WriteLine("Tebrikler C-aldiniz");
        break;
    case int n when (result >= 61 && result <= 70):
        Console.WriteLine("Tebrikler D-aldiniz");
        break;
    case int n when (result >= 51 && result <= 60):
        Console.WriteLine("Tebrikler E-aldiniz");
        break;
    case int n when (result >= 0 && result <= 51):
        Console.WriteLine("Tebrikler Xosbext oldunuz)");
        break;
    default:
        Console.WriteLine("menfi bal ala bilmersiniz...");
        break;
}*/
#endregion
#region task14
using System.ComponentModel.Design;
using System.Numerics;
using System.Security.AccessControl;
/*
Console.WriteLine("eded daxil edin:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("eded daxil edin:");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("icra etmek istediyiniz emeliyyati qeyd edin(+ ; - ; * ; / ):");
string emeliyyat = Console.ReadLine();
 switch (emeliyyat)
{
    case "+" :
        Console.WriteLine(num1 + num2);
        break;
    case "-":
        Console.WriteLine(num1 - num2);
        break;
    case "*":
        Console.WriteLine(num1 * num2);
        break;  
    case "/":
        Console.WriteLine(num1 / num2);
        break;
        default:
        Console.WriteLine("bele bir emeliyyat yoxdu");
        break;
}*/
#endregion
#region task15
/*Console.WriteLine("istediyiniz meblegi qeyd edin:");
double amount = double.Parse(Console.ReadLine());
double DiscountedPrice;
if (amount >= 100)
{
    DiscountedPrice = amount * 0.9;
    Console.WriteLine($"100 AZN ve uzeri alisverisiniz ucun endirmle {amount} AZN Yox! {DiscountedPrice} AZN dir");
}
else if (amount >= 50 && amount <= 99)
{
    DiscountedPrice = amount * 0.95;
    Console.WriteLine($"50-99 AZN arasi alisverisiniz ucun endirmle {amount} AZN Yox! {DiscountedPrice} AZN dir");
}
else
    Console.WriteLine(" 50 AZN den asagi als=isveris etdiyiniz ucun tessufki endirim yoxdur");*/
#endregion
#region task16
/*while (true)
{
    Console.WriteLine("istifadeci adinizi daxil edin:");
    string UserName = Console.ReadLine();
    Console.WriteLine("Sifrenizi daxil edin:");
    int Password = int.Parse(Console.ReadLine());
    if (UserName == "admin" && Password == 2222)
    {
        Console.WriteLine("Tebrikler accounta ugurla daxil oldunuz");
        break;
    }
    else if (UserName == "admin")
        Console.WriteLine("password yanlisdir,zehmet olmasa yeniden ceht edin...");
    else if (Password == 2222)
        Console.WriteLine("UserName yanlisdir,zehmet olmasa yeniden ceht edin...");
    else
    {
        Console.WriteLine("melumatlar yanlisdir zehmet olmasa yeniden ceht edin...");
    }
}*/
#endregion
#region task17
/*Console.WriteLine("valyutani secin:");
string currency = Console.ReadLine(); 
switch(currency)
{
    case "AZN":
        Console.WriteLine("cevirmet istediyiniz meblegi yazin:");
        decimal AznAmount = decimal.Parse(Console.ReadLine());
        decimal UsdAmount;
        UsdAmount = AznAmount / 1.70M;
        Console.WriteLine($"{AznAmount} AZN {UsdAmount} dollara beraberdir");
        break;
    case "USD":
        Console.WriteLine("cevirmet istediyiniz meblegi yazin:");
        decimal USDAmount = decimal.Parse(Console.ReadLine());
        decimal AZNAmount;
        AZNAmount = USDAmount * 1.70M;
        Console.WriteLine($"{USDAmount} dollar {AZNAmount} AZN-e beraberdir");
        break;
        default:
        Console.WriteLine("bele bir valyuta yoxdur...");
        break;
}*/
#endregion
#region task18
/*Console.WriteLine("Boyunuzun uzunluqunu daxil edin:");
double HeightLength = double.Parse(Console.ReadLine());
Console.WriteLine("Cekinizi daxil edin:");
double Weight = double.Parse(Console.ReadLine());   
double BMI = Weight / (HeightLength * HeightLength);
if (BMI > 0 && BMI < 18.5)
    Console.WriteLine($"BMI test neticesin {BMI} \n Ceki azliginiz var.");
else if (BMI >= 18.5 && BMI <= 24.9)
    Console.WriteLine($"BMI test neticesin {BMI} \n Normal cekidesiniz.");
else if (BMI > 25 && BMI <= 29.9)

    Console.WriteLine($"BMI test neticesin {BMI} \n artiq cekiniz var.");
else
    Console.WriteLine($"BMI test neticesin {BMI} \n Pylenme var.");*/
#endregion
#region task19
/*    Console.WriteLine("SalimliBank-a Xos gelmisiniz!");
    decimal balance = 500;
while (true)
{
    Console.WriteLine("istediyiniz emelliyati secin:");
    Console.WriteLine("\n 1.Balansi yoxla \n 2.Balansi artir \n 3.pul cixart");
    int MainMenu = int.Parse(Console.ReadLine());
    switch (MainMenu)
    {
        case 1:
            Console.WriteLine(balance);
            break;
        case 2:
            Console.WriteLine("ne qeder artirmaq isteyirsiniz");
            decimal AddAmount = decimal.Parse(Console.ReadLine());
            if (AddAmount > 0)
            {
                balance += AddAmount;
                Console.WriteLine($"balansiniza {AddAmount} AZN pul artirildi, cari balans {balance}");
            }
            else
                Console.WriteLine("menfi AZN artirmaq olmaz!!");
            break;
        case 3:
            Console.WriteLine("cixarmaq istediyiniz meblegi yazin");
            decimal WithDraw = decimal.Parse(Console.ReadLine());
            if (WithDraw > 0 && WithDraw < balance)
            {
                balance -= WithDraw;
                Console.WriteLine($"balansiniza {WithDraw} AZN pul cixarildi, cari balans {balance}");
            }
            else if (WithDraw < 0 )
                Console.WriteLine("menfi AZN cixarmaq olmaz");
            else
            Console.WriteLine("balansinizda kifayet qeder vesait yoxdu");
            break;
        default:
            Console.WriteLine("bele bir emeliyyat yoxdur.");
            break;
    }
}*/
#endregion
#region task20
/*int[] numbers = {9,72,69,85,99};
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}*/
#endregion
#region task21
/*int[] numbers = { 9, 72, 69, 85, 99 };
int sum = 0;
for (int i = 0; i < numbers.Length; i++)
{
 sum += numbers[i];
}
    Console.WriteLine(sum);*/
#endregion
#region task22
/*int[] numbers = { 10,20,30,40,50,95};
double sum = 0;
double EdediOrta =0;
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}
    EdediOrta = sum/numbers.Length;
Console.WriteLine(EdediOrta);*/
#endregion
#region task23
/*int[] numbers = { 96, 72, 69, 85, 99, 13, 115, 1, 56, 988 };
int MinElement= numbers[0];
int MaxElement = numbers[0];
int MinIndex = 0;
int MaxIndex = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < MinElement)
    {
        MinElement = numbers[i];
        MinIndex = i;
        
    }
    if (numbers[i] > MaxElement)
    {

        MaxElement = numbers[i];
        MaxIndex = i;
        
    }
}
    Console.WriteLine($"massivin en kicik elementi {MinElement}-dir ve indexsi {MinIndex}");
    Console.WriteLine($"massivin en boyuk elementi {MaxElement}-dir ve indexsi {MaxIndex}");
*/
#endregion
#region task24
/*int[] numbers = { 96, 72, 69, 85, 99, 13, 115, 1, 56, 988 };
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 ==0)  
        Console.WriteLine(numbers[i]);
}*/
#endregion
#region task25
/*int[] numbers = { 96, 72, 69, 85, 99, 13, 115, 1, 56, 988 };
int[] numbers1 = new int[numbers.Length];
for (int i = 0; i < numbers.Length; i++)
{
    numbers1[i] = numbers[numbers.Length - 1 - i];
    Console.WriteLine(numbers1[i]);
}*/
#endregion
#region task26
/*int[] arr = { 1, 2, 4, 8, 9 };
bool found = false;
Console.WriteLine("axtardiginiz ededi yazin");
int a = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == a)
    {
        Console.WriteLine(arr[i]);
        found = true;
        break;
    }
}
if (!found)
    Console.WriteLine("tapilmadi");*/
#endregion
#region task27
/*int[] numbers = { 96, 72, 69, 85, 99, 13, 115, 1, 56, 988, 72, 96, 13 };
int[] counts = new int[1000];

foreach (int num in numbers)
{
    counts[num]++;

}

Console.Write("Tekrarlanan elementler: ");
for (int i = 0; i < counts.Length; i++)
{
    if (counts[i] > 1)
    {
        Console.Write(i + " ");
    }

}
Console.WriteLine();*/
#endregion
#region task28
/*int[] numbers = { 0,1, 2, 3, 4, 5, 6, 7, 8, 9 };
int max = 0;
int max2 = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max2 = max;
        max = numbers[i];
    }
    if (numbers[i] > max2 && max != numbers[i])
    {
        max2 = numbers[i];
    }
}
    Console.WriteLine($"{max} , {max2}");
*/
#endregion
#region task29
/*Console.WriteLine("eded daxil edin:");
int num = int.Parse(Console.ReadLine());
int qaliq;
int sum = 0;
for (int i = 0; i < 5; i++)
{
    qaliq = num % 10;
    num = num / 10;
    sum += qaliq;
}
Console.WriteLine(sum);*/
#endregion
#region task30
/*Console.WriteLine("eded daxil edin:");
int num = int.Parse(Console.ReadLine());
int qaliq = 0;
int count = 0;
while (num > 0)
{
    qaliq = num % 10;
    num = num / 10;
    count++;
}
Console.WriteLine(count);*/
#endregion
#region task31
/*Console.WriteLine("eded daxil edin:");
int num = int.Parse(Console.ReadLine());
if (num < 2)
    Console.WriteLine("ne sadesen nedeki murekkeb");
bool sadedir = true;
for (int bolen = 2; bolen * bolen <= num; bolen++)
{
    if (num % bolen == 0)
    {
        sadedir = false;
        break;
    }
}
if (sadedir)
    Console.WriteLine("sade ededdir");
else
    Console.WriteLine("murekkebdir");*/
#endregion
#region task32
/*Console.WriteLine("eded daxil edin");
int num = int.Parse(Console.ReadLine());
int reverse = 0;

while (num > 0)
{
    reverse = num % 10;
    num = num / 10;
    Console.Write(reverse);
}*/

#endregion
#region task33
/*Console.WriteLine("tapmaq istediyiniz heddi yazin:");
int fibonacci = int.Parse(Console.ReadLine());
int fib = 0;
int next = 1;
for (int i = 0; i < fibonacci; i++)
{
Console.WriteLine(fib);

    next = fib + next;
    fib = next - fib;


}*/
#endregion