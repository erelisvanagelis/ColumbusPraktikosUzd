// See https://aka.ms/new-console-template for more information
using ColumbusPraktikosUzd;
using ColumbusPraktikosUzd.Utility;

var actions = 
    "********************************************************* \n" +
    "Actions (enter number): \n" +
    "\t 1. Reverse string; \n" +
    "\t 2. Min Max of array; \n" +
    "\t 3. Reocurring of array ; \n" +
    "\t 4. Reocurring of array (indexed) ; \n" +
    "\t 5. Vowel and Consosnant count; \n" +
    "********************************************************* \n";

int[] randomised;

while (true)
{
    string? text = "";
    Console.WriteLine(actions);
    var number = Console.ReadLine();
    Console.Clear();

    switch (number)
    {
        case "1":
            Console.WriteLine("Enter a string:");
            text = Console.ReadLine();

            var reversed = Algorithms.ReverseString(text ??= "");
            Console.WriteLine(reversed);

            break;

        case "2":
            randomised = Algorithms.RandomisedArray(100, 0, 1000);
            Console.WriteLine(randomised.ToPrintable());

            (int min, int max) = Algorithms.FindMinMax(randomised);
            Console.WriteLine($"Min: {min}, Max: {max}");

            break;

        case "3":
            randomised = Algorithms.RandomisedArray(100, 0, 50);
            Console .WriteLine(randomised.ToPrintable());

            var counters = Algorithms.CountOccurencesShort(randomised); 
            var reocurring = Algorithms.GetReoccuring(counters);
            Console.WriteLine(randomised);

            foreach(var item in reocurring)
            {
                Console.WriteLine(item.ToString());
            }

            break;

        case "4":
            randomised = Algorithms.RandomisedArray(100, 0, 50);
            Console.WriteLine(randomised.ToPrintable());

            counters = Algorithms.CountOccurences(randomised);
            reocurring = Algorithms.GetReoccuring(counters);
            
            Console.WriteLine(randomised);

            foreach (var item in reocurring)
            {
                NumberCounter test = (NumberCounter)item;
                Console.WriteLine(test.ToString());
            }

            break;

        case "5":
            Console.WriteLine("Enter a string:");
            text = Console.ReadLine();

            (int vowels, int consonants) = Algorithms.VowelConsonantCounter(Language.Lithuanian, text ??= "");
            Console.WriteLine($"Vowel count: {vowels}, Consonant count: {consonants}");

            break;

        default:
            Console.WriteLine("No sutch action");
            break;
    }
}


