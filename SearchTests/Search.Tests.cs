using Exo03TDD.Bibliotheque;

namespace SearchTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        // Si le texte de la recherche contient moins de 2 caractères, ***Une exception est levée de type NotFoundException***.
        public void When_Search_Less_2_Char_ThrowNotFoundException()
        {
            //Arrange
            SearchCity searchCity = new SearchCity();

            //Act 
            //searchCity.SearchCityByName("a");

            Assert.Throws<NotFoundException>(() => searchCity.SearchCityByName("a"));

        }
    }
}