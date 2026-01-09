using MyVocabulary.Web;

namespace MyVocabulary.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestGetFromBase()
        {
            var str = "one";
            var expectedStr = new DataBase((int)1, "one", "один");

            var result = DataBase.GetFromBase(str);
            //var dataBaseFalseString = new DataBase(0, "absent", "absent");

            Assert.Equal(expectedStr.RussianWord, result.RussianWord);
            Assert.Equal(expectedStr.EnglishWord, result.EnglishWord);
            Assert.Equal(expectedStr.Id, result.Id);
        }
    }
}


