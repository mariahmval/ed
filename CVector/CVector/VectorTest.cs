using NUnit.Framework;
using System;
namespace CVector
{
    [TestFixture]
    public class VectorTest
    {
        [Test]
        public void BinarySearch()
        {
            Assert.AreEqual(-1, Vector.BinarySearch(new int[] {45}, 20));
            Assert.AreEqual(0, Vector.BinarySearch(new int[] {15}, 15));
            Assert.AreEqual(0, Vector.BinarySearch(new int[] {10,15}, 10));
            Assert.AreEqual(1, Vector.BinarySearch(new int[] {10,15}, 15));
            Assert.AreEqual(2, Vector.BinarySearch(new int[] {1,1,1,1,1}, 1));
            Assert.AreEqual(-1, Vector.BinarySearch(new int[] {3,7,12,20,70,85}, 2));
            Assert.AreEqual(0, Vector.BinarySearch(new int[] {3,7,12,20,70,85}, 3));
            Assert.AreEqual(3, Vector.BinarySearch(new int[] {3,7,12,20,70,85}, 20));
            Assert.AreEqual(5, Vector.BinarySearch(new int[] {3,7,12,20,70,85}, 85));
            Assert.AreEqual(-1, Vector.BinarySearch(new int[] {3,7,12,20,70,85}, 86));
        }

        [Test]
        public void BinarySearchEmpty()
        {
            Assert.AreEqual(-1, Vector.BinarySearch(new int[] { }, 20));
        }

    }
}
