using LeetCodeLibrary;
using System.CommandLine;


namespace AddTwoNumbers
{

    public class Program
    {
        public static int Main(String[] args)
        {
            var firstMethodOption = new Option<string>(
                name: "--firstArgument",
                description: "The file to read and display on the console."
                )
            { IsRequired = true };
            var secondMethodOption = new Option<string>(
                name: "--secondArgument",
                description: "The file to read and display on the console."
                )
            { IsRequired = true };
            var rootComand = new RootCommand();
            rootComand.AddGlobalOption(firstMethodOption);
            var commandDivide = new Command("divide");
            commandDivide.AddOption(secondMethodOption);
            var commandAddTwoNumbers = new Command("addTwoNumbers");
            commandAddTwoNumbers.AddOption(secondMethodOption);
            var commandCanJump = new Command("canJump");
            var commandLengthOfLongestSubstring = new Command("lengthOfLongestSubstring");
            var commandRotate = new Command("rotate");
            commandRotate.AddOption(secondMethodOption);
            var commandIsValidBST = new Command("isValidBST");
            rootComand.AddCommand(commandDivide);
            rootComand.AddCommand(commandAddTwoNumbers);
            rootComand.AddCommand(commandCanJump);
            rootComand.AddCommand(commandLengthOfLongestSubstring);
            rootComand.AddCommand(commandRotate);
            rootComand.AddCommand(commandIsValidBST);
            var leetCode = new LeetCode();
            commandDivide.SetHandler((dividend, devisor) =>
            {
                var answer = leetCode.Divide(-2147483648, 1);
                Console.WriteLine(answer);
            }, firstMethodOption, secondMethodOption);
            commandAddTwoNumbers.SetHandler((l1, l2) =>
            {
                var res = leetCode.AddTwoNumbers(l1.Split(','), l2.Split(','));
                Console.WriteLine(res);
            }, firstMethodOption, secondMethodOption);
            commandCanJump.SetHandler(nums =>
            {
                var array = nums.Split(',').Select(int.Parse).ToArray();
                var answer = leetCode.CanJump(array);
                Console.WriteLine(answer);
            }, firstMethodOption);
            commandLengthOfLongestSubstring.SetHandler(s =>
            {
                var answer = leetCode.LengthOfLongestSubstring(s);
                Console.WriteLine(answer);
            }, firstMethodOption);
            commandRotate.SetHandler((nums, k) =>
            {
                var array = nums.Split(',').Select(int.Parse).ToArray();
                bool resultParse = int.TryParse(k, out var t);
                if (resultParse) leetCode.Rotate(array, t);

                foreach (var v in array) Console.WriteLine(v);
            }, firstMethodOption, secondMethodOption);
            commandIsValidBST.SetHandler(nums =>
            {
                var array = nums.Split(',').Select(int.Parse).ToArray();
                var answer = leetCode.IsValidBST(array);
                Console.WriteLine(answer);
            }, firstMethodOption);
            return rootComand.Invoke(args);
        }


    }

}