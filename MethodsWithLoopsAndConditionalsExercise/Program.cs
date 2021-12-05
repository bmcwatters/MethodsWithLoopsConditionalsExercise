
//to the console all numbers 1000 through -1000
PrintThousand();

static void PrintThousand()
{
    for(int i = 1000; i >= -1000; i--) //keyword, initializer, conditional, decrement, scope
    {
        Console.WriteLine(i);
    }
}


//to the console numbers 3 through 999 by 3
PrintByThrees();

static void PrintByThrees()
{
    for(int i = 3; i < 1000; i+=3)
    {
        Console.WriteLine(i);
    }
}


//accept two integers and check if equal or not
Console.WriteLine(IsEqual(2, 8));

static bool IsEqual(int a, int b)  //bool statement
{
    var check = (a == b) ? true : false;
    return check;
}


//check a number for odd or even
OddEven(35);

static void OddEven(int number)
{
    if (number % 2 == 0)
    {
        Console.WriteLine("Yes, that's is even");
    }
    else
    {
        Console.WriteLine("That's odd!");
    }
}



//check if number is pos or neg
PosNeg(-48);

static void PosNeg(int number)
{
    if (number < 0)
    {
        Console.WriteLine("That number is negative");
    }
    else
    {
        Console.WriteLine("That number is positive!");
    }
}



//User Input of age to determine voting candidancy 

VoterAge(35);

static bool VoterAge(int age)
{   
    if (age >= 18)
    {
        Console.WriteLine("Yes, they are voting age!");
        return true;
    }
    else
    {
        Console.WriteLine("No, they are not of voting age!");
        return false;
    }
}


//check if number is in the range
CheckRange(34);

static bool CheckRange(int num)
{
if (num < 10  -10)
    {
        Console.WriteLine("Number is within range!");
        return true;
    }
else
    {
        Console.WriteLine("Number is out of range!");
        return false;
    }

}







