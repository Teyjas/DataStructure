using CustomDataStructure;

// String used to test the word frequency count of the para
string testString;
testString = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";

StringOperation wordOperation = new(testString);

Console.WriteLine($"Frequency of 'Paranoid': {wordOperation.GetVal("paranoid").Count}");

Console.WriteLine(wordOperation.GetAvoidedString());

Console.ReadKey();