// ExploreIf();

void ExploreIf()
{
  int a = 5;
  int b = 5;

  if (a + b > 10)
  {
    Console.WriteLine("The answer is greater than 10.");
  }
  else
  {
    Console.WriteLine("The answer is not greater than 10.");
  }

  int c = 4;

  if ((a + b + c > 10) && (a == b))
  {
    Console.WriteLine("The answer is greater than 10.");
    Console.WriteLine("And the first number is equal to the second");
  }
  else
  {
    Console.WriteLine("The answer is not greater than 10.");
    Console.WriteLine("And the first number is not equal to the second");
  }
}

// ExploreLoops();

void ExploreLoops()
{
  int counter = 0;

  while (counter < 10)
  {
    Console.WriteLine($"Hello World! The counter is {counter}.");
    counter++;
  }

  Console.WriteLine("-------------------------------------------");

  int counter2 = 0;
  do
  {
    Console.WriteLine($"Hello World! The counter2 is {counter2}");
    counter2++;
  } while (counter2 < 10);

  Console.WriteLine("-------------------------------------------");

  for (int index = 0; index < 10; index++)
  {
    Console.WriteLine($"Hello World! The index is {index}");
  }

  Console.WriteLine("-------------------------------------------");

  for (int row = 1; row < 11; row++)
  {
    for (char column = 'a'; column < 'k'; column++)
    {
      Console.WriteLine($"The cell is ({row}, {column})");
    }
  }
}

ChallengeAnswer();

void ChallengeAnswer()
{
  int sum = 0;

  for (int i = 1; i <= 20; i++)
  {
    if (i % 3 == 0)
    {
      sum += i;
    }
  }

  Console.WriteLine(sum);
}