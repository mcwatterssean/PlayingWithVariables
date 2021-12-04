
int age;
string firstname;
bool under26;
char lastName;
double days;
decimal myMoney;

age = 25;
firstname = "Sean";
lastName = 'M';
days = 1000d;
under26 = true;
myMoney = 1000000M;

if (under26== true)
{
    Console.WriteLine($"Hello, my name is {firstname} {lastName}. and I am {age} years old. I am currently {days} days away from my goal of {myMoney} dollars.");
}
if (under26 == false)
{
    Console.WriteLine($"Please correct number of days left");
        }