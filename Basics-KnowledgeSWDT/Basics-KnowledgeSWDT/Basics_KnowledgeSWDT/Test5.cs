using System.Collections.Generic;
using NUnit.Framework;


namespace UnitLab1
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        private static readonly object[] _sourceLists =
        {
            new object[] {new List<object> { 1, 2, "a", "b" }, new List<object> { 1, 2} },   //case 1
            new object[] {new List<object> {1, 2, "sasdf", "csd", 3, "fd"}, new List<object> { 1, 2, 3} } //case 2
        };

        [TestCaseSource("_sourceLists")]
        public void Test1(List<object> input, List<object> output)
        {
            List<object> result = Task1.filterList(input);
            Assert.AreEqual(output, result);
        }

        [TestCase("stress", 't')]
        [TestCase("sTreSS", 'T')]
        public void Test2(string input, char output)
        {
            char result = Task2.first_non_repeating_letter(input);
            Assert.AreEqual(output, result);
        }

        [TestCase(16, 7)]
        [TestCase(493193, 2)]
        public void Test3(int input, int output)
        {
            int result = Task3.digital_root(input);
            Assert.AreEqual(output, result);
        }

        [TestCase(new int[] { 1, 3, 6, 2, 2, 0, 4, 5 }, 5, 4)]
        [TestCase(new int[] { 1, 3, 6, 2, 2, 4, }, 5, 3)]
        public void Test4(int[] input, int target, int output)
        {
            int result = Task4.pair_sum(input, target);
            Assert.AreEqual(output, result);
        }

        [TestCase("Fred:Corwill;Wilfred:Corwill;Barney:TornBull;" +
            "Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;" +
            "Alfred:Corwill", "(CORWILL, ALFRED)(CORWILL, FRED)" +
            "(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)" +
            "(TORNBULL, BETTY)(TORNBULL, BJON)")]
        //[TestCase(new int[] { 1, 3, 6, 2, 2, 4, }, 5, 3)]
        public void Test5(string input, string output)
        {
            string result = Task5.surname_order(input);
            Assert.AreEqual(output, result);
        }

    }
}