using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GON.Extensions;


namespace UnitTests
{
    [TestClass]
    public class BitExtensionsTest
    {
        [TestMethod]
        public void SetBit_WithZero_ReturnsNewValue()
        {
            //Arrange
            byte data = 0x00;
            byte expected1 = 0b00000001;
            byte expected2 = 0b00000010;
            byte expected3 = 0b00000100;
            byte expected4 = 0b00001000;
            byte expected5 = 0b00010000;
            byte expected6 = 0b00100000;
            byte expected7 = 0b01000000;
            byte expected8 = 0b10000000;

            //Act
            var res1 = data.SetBit(0);
            var res2 = data.SetBit(1);
            var res3 = data.SetBit(2);
            var res4 = data.SetBit(3);
            var res5 = data.SetBit(4);
            var res6 = data.SetBit(5);
            var res7 = data.SetBit(6);
            var res8 = data.SetBit(7);

            //Assert
            Assert.AreEqual(expected1, res1);
            Assert.AreEqual(expected2, res2);
            Assert.AreEqual(expected3, res3);
            Assert.AreEqual(expected4, res4);
            Assert.AreEqual(expected5, res5);
            Assert.AreEqual(expected6, res6);
            Assert.AreEqual(expected7, res7);
            Assert.AreEqual(expected8, res8);
        }

        [TestMethod]
        public void SetBit_WithFF_ReturnsOldValue()
        {
            //Arrange
            byte data = 0xFF;
            byte expected = 0xFF;

            //Act
            var res1 = data.SetBit(0);
            var res2 = data.SetBit(1);
            var res3 = data.SetBit(2);
            var res4 = data.SetBit(3);
            var res5 = data.SetBit(4);
            var res6 = data.SetBit(5);
            var res7 = data.SetBit(6);
            var res8 = data.SetBit(7);

            //Assert
            Assert.AreEqual(expected, res1);
            Assert.AreEqual(expected, res2);
            Assert.AreEqual(expected, res3);
            Assert.AreEqual(expected, res4);
            Assert.AreEqual(expected, res5);
            Assert.AreEqual(expected, res6);
            Assert.AreEqual(expected, res7);
            Assert.AreEqual(expected, res8);
        }

        [TestMethod]
        public void ClearBit_WithZero_ReturnsOldValue()
        {
            //Arrange
            byte data = 0x00;
            byte expected = 0x00;

            //Act
            var res1 = data.ClearBit(0);
            var res2 = data.ClearBit(1);
            var res3 = data.ClearBit(2);
            var res4 = data.ClearBit(3);
            var res5 = data.ClearBit(4);
            var res6 = data.ClearBit(5);
            var res7 = data.ClearBit(6);
            var res8 = data.ClearBit(7);

            //Assert
            Assert.AreEqual(expected, res1);
            Assert.AreEqual(expected, res2);
            Assert.AreEqual(expected, res3);
            Assert.AreEqual(expected, res4);
            Assert.AreEqual(expected, res5);
            Assert.AreEqual(expected, res6);
            Assert.AreEqual(expected, res7);
            Assert.AreEqual(expected, res8);
        }

        [TestMethod]
        public void ClearBit_WithFF_ReturnsNewValue()
        {
            //Arrange
            byte data = 0xFF;
            byte expected1 = 0b11111110;
            byte expected2 = 0b11111101;
            byte expected3 = 0b11111011;
            byte expected4 = 0b11110111;
            byte expected5 = 0b11101111;
            byte expected6 = 0b11011111;
            byte expected7 = 0b10111111;
            byte expected8 = 0b01111111;

            //Act
            var res1 = data.ClearBit(0);
            var res2 = data.ClearBit(1);
            var res3 = data.ClearBit(2);
            var res4 = data.ClearBit(3);
            var res5 = data.ClearBit(4);
            var res6 = data.ClearBit(5);
            var res7 = data.ClearBit(6);
            var res8 = data.ClearBit(7);

            //Assert
            Assert.AreEqual(expected1, res1);
            Assert.AreEqual(expected2, res2);
            Assert.AreEqual(expected3, res3);
            Assert.AreEqual(expected4, res4);
            Assert.AreEqual(expected5, res5);
            Assert.AreEqual(expected6, res6);
            Assert.AreEqual(expected7, res7);
            Assert.AreEqual(expected8, res8);
        }

        [TestMethod]
        public void ToggleBit_WithZero_ReturnsNewValue()
        {
            //Arrange
            byte data = 0x00;
            byte expected1 = 0b00000001;
            byte expected2 = 0b00000010;
            byte expected3 = 0b00000100;
            byte expected4 = 0b00001000;
            byte expected5 = 0b00010000;
            byte expected6 = 0b00100000;
            byte expected7 = 0b01000000;
            byte expected8 = 0b10000000;

            //Act
            var res1 = data.ToggleBit(0);
            var res2 = data.ToggleBit(1);
            var res3 = data.ToggleBit(2);
            var res4 = data.ToggleBit(3);
            var res5 = data.ToggleBit(4);
            var res6 = data.ToggleBit(5);
            var res7 = data.ToggleBit(6);
            var res8 = data.ToggleBit(7);

            //Assert
            Assert.AreEqual(expected1, res1);
            Assert.AreEqual(expected2, res2);
            Assert.AreEqual(expected3, res3);
            Assert.AreEqual(expected4, res4);
            Assert.AreEqual(expected5, res5);
            Assert.AreEqual(expected6, res6);
            Assert.AreEqual(expected7, res7);
            Assert.AreEqual(expected8, res8);
        }

        [TestMethod]
        public void ToggleBit_WithFF_ReturnsNewValue()
        {
            //Arrange
            byte data = 0xFF;
            byte expected1 = 0b11111110;
            byte expected2 = 0b11111101;
            byte expected3 = 0b11111011;
            byte expected4 = 0b11110111;
            byte expected5 = 0b11101111;
            byte expected6 = 0b11011111;
            byte expected7 = 0b10111111;
            byte expected8 = 0b01111111;

            //Act
            var res1 = data.ToggleBit(0);
            var res2 = data.ToggleBit(1);
            var res3 = data.ToggleBit(2);
            var res4 = data.ToggleBit(3);
            var res5 = data.ToggleBit(4);
            var res6 = data.ToggleBit(5);
            var res7 = data.ToggleBit(6);
            var res8 = data.ToggleBit(7);

            //Assert
            Assert.AreEqual(expected1, res1);
            Assert.AreEqual(expected2, res2);
            Assert.AreEqual(expected3, res3);
            Assert.AreEqual(expected4, res4);
            Assert.AreEqual(expected5, res5);
            Assert.AreEqual(expected6, res6);
            Assert.AreEqual(expected7, res7);
            Assert.AreEqual(expected8, res8);
        }

        [TestMethod]
        public void IsBitSet_WithZero_ReturnsFalse()
        {
            //Arrange
            byte data1 = 0b11111110;
            byte data2 = 0b11111101;
            byte data3 = 0b11111011;
            byte data4 = 0b11110111;
            byte data5 = 0b11101111;
            byte data6 = 0b11011111;
            byte data7 = 0b10111111;
            byte data8 = 0b01111111;

            //Act
            var res1 = data1.IsBitSet(0);
            var res2 = data2.IsBitSet(1);
            var res3 = data3.IsBitSet(2);
            var res4 = data4.IsBitSet(3);
            var res5 = data5.IsBitSet(4);
            var res6 = data6.IsBitSet(5);
            var res7 = data7.IsBitSet(6);
            var res8 = data8.IsBitSet(7);

            //Assert
            Assert.IsFalse(res1);
            Assert.IsFalse(res2);
            Assert.IsFalse(res3);
            Assert.IsFalse(res4);
            Assert.IsFalse(res5);
            Assert.IsFalse(res6);
            Assert.IsFalse(res7);
            Assert.IsFalse(res8);
        }

        [TestMethod]
        public void IsBitSet_WithNonZero_ReturnsTrue()
        {
            //Arrange
            byte data1 = 0b00000001;
            byte data2 = 0b00000010;
            byte data3 = 0b00000100;
            byte data4 = 0b00001000;
            byte data5 = 0b00010000;
            byte data6 = 0b00100000;
            byte data7 = 0b01000000;
            byte data8 = 0b10000000;

            //Act
            var res1 = data1.IsBitSet(0);
            var res2 = data2.IsBitSet(1);
            var res3 = data3.IsBitSet(2);
            var res4 = data4.IsBitSet(3);
            var res5 = data5.IsBitSet(4);
            var res6 = data6.IsBitSet(5);
            var res7 = data7.IsBitSet(6);
            var res8 = data8.IsBitSet(7);

            //Assert
            Assert.IsTrue(res1);
            Assert.IsTrue(res2);
            Assert.IsTrue(res3);
            Assert.IsTrue(res4);
            Assert.IsTrue(res5);
            Assert.IsTrue(res6);
            Assert.IsTrue(res7);
            Assert.IsTrue(res8);
        }

        [TestMethod]
        public void ChangeBit_WithZero_ReturnsNewValue()
        {
            //Arrange
            byte data = 0x00;
            byte expected1 = 0b00000001;
            byte expected2 = 0b00000010;
            byte expected3 = 0b00000100;
            byte expected4 = 0b00001000;
            byte expected5 = 0b00010000;
            byte expected6 = 0b00100000;
            byte expected7 = 0b01000000;
            byte expected8 = 0b10000000;

            //Act
            var res1 = data.ChangeBit(0, true);
            var res2 = data.ChangeBit(1, true);
            var res3 = data.ChangeBit(2, true);
            var res4 = data.ChangeBit(3, true);
            var res5 = data.ChangeBit(4, true);
            var res6 = data.ChangeBit(5, true);
            var res7 = data.ChangeBit(6, true);
            var res8 = data.ChangeBit(7, true);

            //Assert
            Assert.AreEqual(expected1, res1);
            Assert.AreEqual(expected2, res2);
            Assert.AreEqual(expected3, res3);
            Assert.AreEqual(expected4, res4);
            Assert.AreEqual(expected5, res5);
            Assert.AreEqual(expected6, res6);
            Assert.AreEqual(expected7, res7);
            Assert.AreEqual(expected8, res8);
        }

        [TestMethod]
        public void ChangeBit_WithFF_ReturnsNewValue()
        {
            //Arrange
            byte data = 0xFF;
            byte expected1 = 0b11111110;
            byte expected2 = 0b11111101;
            byte expected3 = 0b11111011;
            byte expected4 = 0b11110111;
            byte expected5 = 0b11101111;
            byte expected6 = 0b11011111;
            byte expected7 = 0b10111111;
            byte expected8 = 0b01111111;

            //Act
            var res1 = data.ChangeBit(0, false);
            var res2 = data.ChangeBit(1, false);
            var res3 = data.ChangeBit(2, false);
            var res4 = data.ChangeBit(3, false);
            var res5 = data.ChangeBit(4, false);
            var res6 = data.ChangeBit(5, false);
            var res7 = data.ChangeBit(6, false);
            var res8 = data.ChangeBit(7, false);

            //Assert
            Assert.AreEqual(expected1, res1);
            Assert.AreEqual(expected2, res2);
            Assert.AreEqual(expected3, res3);
            Assert.AreEqual(expected4, res4);
            Assert.AreEqual(expected5, res5);
            Assert.AreEqual(expected6, res6);
            Assert.AreEqual(expected7, res7);
            Assert.AreEqual(expected8, res8);
        }

        [TestMethod]
        public void ChangeBit_WithZero_ReturnsOldValue()
        {
            //Arrange
            byte data = 0x00;
            byte expected = 0x00;

            //Act
            var res1 = data.ChangeBit(0, false);
            var res2 = data.ChangeBit(1, false);
            var res3 = data.ChangeBit(2, false);
            var res4 = data.ChangeBit(3, false);
            var res5 = data.ChangeBit(4, false);
            var res6 = data.ChangeBit(5, false);
            var res7 = data.ChangeBit(6, false);
            var res8 = data.ChangeBit(7, false);

            //Assert
            Assert.AreEqual(expected, res1);
            Assert.AreEqual(expected, res2);
            Assert.AreEqual(expected, res3);
            Assert.AreEqual(expected, res4);
            Assert.AreEqual(expected, res5);
            Assert.AreEqual(expected, res6);
            Assert.AreEqual(expected, res7);
            Assert.AreEqual(expected, res8);
        }

        [TestMethod]
        public void ChangeBit_WithFF_ReturnsOldValue()
        {
            //Arrange
            byte data = 0xFF;
            byte expected = 0xFF;

            //Act
            var res1 = data.ChangeBit(0, true);
            var res2 = data.ChangeBit(1, true);
            var res3 = data.ChangeBit(2, true);
            var res4 = data.ChangeBit(3, true);
            var res5 = data.ChangeBit(4, true);
            var res6 = data.ChangeBit(5, true);
            var res7 = data.ChangeBit(6, true);
            var res8 = data.ChangeBit(7, true);

            //Assert
            Assert.AreEqual(expected, res1);
            Assert.AreEqual(expected, res2);
            Assert.AreEqual(expected, res3);
            Assert.AreEqual(expected, res4);
            Assert.AreEqual(expected, res5);
            Assert.AreEqual(expected, res6);
            Assert.AreEqual(expected, res7);
            Assert.AreEqual(expected, res8);
        }
    }
}
