using ADS.Algorithms.Sorting;
using ADS.AlgorithmsTests.Data;
using ADS.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ADS.AlgorithmsTests
{
    [TestClass]
    public class QuickSortTest
    {
        [TestMethod]
        public void Should_sort_int_list_using_quicksort()
        {
            // arrange
            int[] list = TestData.UnsortedIntegers;
            int[] expected = TestData.SortedIntegers;

            // act
            var actual = list.QuickSort();

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Should_sort_string_list_using_quicksort()
        {
            // arrange
            string[] list = TestData.UnsortedStrings;
            string[] expected = TestData.SortedStrings;

            // act
            var actual = list.QuickSort();

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void Should_sort_card_list_using_quicksort()
        {
            // arrange
            Card[] list = TestData.UnsortedCards;
            Card[] expected = TestData.SortedCards;

            // act
            var actual = list.QuickSort();

            // assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
