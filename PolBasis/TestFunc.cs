﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;
using PolBasis;

namespace PolBasis
{
    class TestFunc
    {
        [TestFixture]
        public class TestCalculation
        {
            [Test]
            [TestCase("11101010011111111110000000100100000010010011000010000110001101110101010100101101001010101001001010110001000101001100110110010011001111010001001010110011110010101011000010000", "01110001001101101101110010111001111110011111100011011011010101110111101001110001001000010000101010001011001011011100000000001011000010010001101001100100100110111011001110000", "10011011010010010011110010011101111100001100100001011101011000000010111101011100000010111001100000111010001110010000110110011000001101000000100011010111010100010000001100000")]
            [TestCase("01111110111001010001111001000101111000111101101010111010000011001011011110100010001000110111110011111010110011100001110101001110011111101000000001101100101101111000001110000100110110100111111010110100101111101010011001110111011101110011001110001111100001110001011000110100111011111011001011010000001110011101101100010000110010001101110000011001000000110001010111000010101111001000010110111000000101101101010110010100010000110010011101100111001010111101000101001010001111111100000110001011110000111111101000011", "10100010101101010110100100010000101101000010100001011001101111000011100100100101000010010000000101110101101010101111100000010110111000011111100010111100100010101011011011110010001101110001101101111011111110110001011101001101011011100011111101001110010111000100011000000100100000000100111010100111101111110101010111000110110010000111110010010001111110100100101101001110001000000000110001110011110101111010011101101001111000000001011010010010100100010010011111001110100100100110101011001100011001100111100100101", "11011100010100000111011101010101010101111111001011100011101100001000111010000111001010100111110110001111011001001110010101011000100111110111100011010000001111010011010101110110111011010110010111001111010001011011000100111010000110010000110011000001110110110101000000110000011011111111110001110111100001101000111011010110000000001010000010001000111110010101111010001100100111001000100111001011110000010111001011111101101000110011000111110101101110101111011010000100101011011010101101000111101001011000001100110")]
            [TestCase("01101010001010011001010001100001101101001011101100001011000000101101111001000100001101001101001111110101011011100001000110001100101010101111011101110101010100001111011100000100011", "00001101010010000111010011101111011010100001110001001100100110000101010100001100000011010110011001101100111011110110000011100010111100110010110001111101111111011101001001010110010", "01100111011000011110000010001110110111101010011101000111100110101000101101001000001110011011010110011001100000010111000101101110010110011101101100001000101011010010010101010010001")]

            public void AddTest(string pol1, string pol2, string expectedResult)
            {
                int[] a = new int[1];
                int[] b = new int[1];
                a = Field.String_To_Byte(pol1);
                b = Field.String_To_Byte(pol2);

                var actualResult = Field.Byte_To_String(Field.Add(a, b));
                Assert.AreEqual(expectedResult, actualResult);
            }


        }
    }
}
