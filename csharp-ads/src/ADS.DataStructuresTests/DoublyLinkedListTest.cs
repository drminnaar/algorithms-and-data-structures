using System.Collections.Generic;
using ADS.Data;
using ADS.DataStructures.DoublyLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ADS.DataStructuresTests
{
    [TestClass]
    public class DoublyLinkedListTest
    {
        [TestMethod]
        public void Should_create_doubly_linked_list_having_multiple_nodes_using_add_front()
        {
            // arrange
            var card2 = Card.Hearts(2);
            var card4 = Card.Hearts(4);
            var card6 = Card.Hearts(6);

            var list = new DoublyLinkedList<Card>();

            // act
            list.AddFront(card2);
            list.AddFront(card4);
            list.AddFront(card6);

            // assert
            Assert.AreEqual(expected: 3, actual: list.Count);
            Assert.AreEqual(expected: card6, actual: list.Head.Value);
            Assert.AreEqual(expected: card2, actual: list.Tail.Value);
        }

        [TestMethod]
        public void Should_create_doubly_linked_list_having_multiple_nodes_using_add_end()
        {
            // arrange
            var card2 = Card.Hearts(2);
            var card4 = Card.Hearts(4);
            var card6 = Card.Hearts(6);

            var list = new DoublyLinkedList<Card>();

            // act
            list.AddEnd(card2);
            list.AddEnd(card4);
            list.AddEnd(card6);

            // assert
            Assert.AreEqual(expected: 3, actual: list.Count);
            Assert.AreEqual(expected: card2, actual: list.Head.Value);
            Assert.AreEqual(expected: card6, actual: list.Tail.Value);
        }

        [TestMethod]
        public void Should_remove_node_from_font_of_doubly_linked_list_having_multiple_nodes()
        {
            // arrange
            var card4 = Card.Hearts(4);
            var card6 = Card.Hearts(6);

            var list = new DoublyLinkedList<Card>();

            // act
            list.AddFront(card4);
            list.AddFront(card6);
            var removedNode = list.RemoveFront();

            // assert
            Assert.AreEqual(expected: 1, actual: list.Count);
            Assert.AreEqual(expected: card4, actual: list.Head.Value);
            Assert.AreEqual(expected: card6, actual: removedNode.Value);
            Assert.AreEqual(expected: null, actual: removedNode.Next);
            Assert.AreEqual(expected: card4, actual: list.Tail.Value);
        }

        [TestMethod]
        public void Should_remove_node_from_end_of_doubly_linked_list_having_multiple_nodes()
        {
            // arrange
            var card4 = Card.Hearts(4);
            var card6 = Card.Hearts(6);

            var list = new DoublyLinkedList<Card>();

            // act
            list.AddFront(card4);
            list.AddFront(card6);
            var removedNode = list.RemoveEnd();

            // assert
            Assert.AreEqual(expected: 1, actual: list.Count);
            Assert.AreEqual(expected: card6, actual: list.Head.Value);
            Assert.AreEqual(expected: card4, actual: removedNode.Value);
            Assert.AreEqual(expected: null, actual: removedNode.Next);
            Assert.AreEqual(expected: card6, actual: list.Tail.Value);
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

            var list = new DoublyLinkedList<Card>();

            // act
            list.AddFront(card2);
            list.AddFront(card4);
            list.AddFront(card6);

            // assert
            CollectionAssert.AreEqual(expected: expectedList, actual: list.ToList());
        }
    }
}
