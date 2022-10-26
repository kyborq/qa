using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Triangle.Test
{
    [TestClass]
    public class TriangleTest
    {
        const string inputPath = "../../../input.txt";
        const string outputPath = "../../../output.txt";

        [TestMethod]
        public static void Main()
        {
            File.WriteAllText(outputPath, string.Empty);
            using StreamWriter outputFile = new StreamWriter(outputPath, true);

            using (var inputFile = new StreamReader(inputPath))
            {
                int testIndex = 1;
                string argsLine;

                while ((argsLine = inputFile.ReadLine()) != null)
                {
                    string[] testArgs = Regex.Replace(argsLine, @"\s+", " ").Split();
                    string expectedResult = inputFile.ReadLine();

                    var strWriter = new StringWriter();
                    Console.SetOut(strWriter);
                    Console.SetError(strWriter);

                    Program.Main(testArgs);

                    string result = strWriter.ToString();

                    if (result == expectedResult)
                    {
                        outputFile.WriteLine("Test " + testIndex + ": success");
                    }
                    else
                    {
                        outputFile.WriteLine("Test " + testIndex + ": error");
                    }

                    Assert.AreEqual(result, expectedResult);

                    testIndex++;
                }
            }
        }
    }
}
