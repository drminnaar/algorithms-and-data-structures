using System.Collections.Generic;
using ADS.Data;
using ADS.DataStructures.SinglyLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ADS.DataStructuresTests
{
    [TestClass]
    public class SinglyLinkedListTest
    {
        [TestMethod]
        public void Should_create_singly_linked_list_having_multiple_nodes()
        {
            // arrange
            var card2 = Card.Hearts(2);
            var card4 = Card.Hearts(4);
            var card6 = Card.Hearts(6);

            var list = new SinglyLinkedList<Card>();

            // act
            list.AddFront(card2);
            list.AddFront(card4);
            list.AddFront(card6);

            // assert
            Assert.AreEqual(expected: 3, actual: list.Count);
            Assert.AreEqual(expected: card6, actual: list.Head.Value);
        }

        [TestMethod]
        public void Should_remove_node_from_singly_linked_list_having_multiple_nodes()
        {
            // arrange
            var card2 = Card.Hearts(2);
            var card4 = Card.Hearts(4);
            var card6 = Card.Hearts(6);

            var list = new SinglyLinkedList<Card>();

            // act
            list.AddFront(card2);
            list.AddFront(card4);
            list.AddFront(card6);
            var removedNode = list.RemoveFront();

            // assert
            Assert.AreEqual(expected: 2, actual: list.Count);
            Assert.AreEqual(expected: card4, actual: list.Head.Value);
            Assert.AreEqual(expected: card6, actual: removedNode.Value);
            Assert.AreEqual(expected: null, actual: removedNode.Next);
        }

        [TestMethod]
        public void Should_get_list_of_node_values_from_singly_linked_list()
        {
            // arrange
            var card2 = Card.Hearts(2);
            var card4 = Card.Hearts(4);
            var card6 = Card.Hearts(6);

            var expectedList = new List<Card>
            {
                card6,
                card4,
                card2
            };

            var list = new SinglyLinkedList<Card>();

            // act
            list.AddFront(card2);
            list.AddFront(card4);
            list.AddFront(card6);

            // assert
            CollectionAssert.AreEqual(expected: expectedList, actual: list.ToList());
        }
    }
}
