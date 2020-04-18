using DocumentFormat.OpenXml.Bibliography;
using System;
using Xunit;

namespace Palindromes.Tests
{
    public class test_palindrome_backwards
    {
        [Fact]
        public void check_if_stars_is_palindrome()
        {
            //Arrange
            var palindrome = "Stars";
            var expectedResult = false;
            var translator = new MirrorTest();

            //Act
            var actualResult = translator.Mirror(palindrome);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void check_if_O_a_kak_Uwakov_lil_vo_kawu_kakao_is_palindrome()
        {
            //Arrange
            var palindrome = "O, a kak Uwakov lil vo kawu kakao!";
            var expectedResult = true;
            var translator = new MirrorTest();

            //Act
            var actualResult = translator.Mirror(palindrome);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void check_if_Some_men_interpret_nine_memos_is_palindrome()
        {
            //Arrange
            var palindrome = "Some men interpret nine memos";
            var expectedResult = true;
            var translator = new MirrorTest();

            //Act
            var actualResult = translator.Mirror(palindrome);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
