using Exo03TDD.Bibliotheque;

namespace SearchTests
{

    [TestFixture]
    public class Tests
    {
        private SearchCity searchCity;

        [SetUp]
        public void SetUp()
        {
            searchCity = new SearchCity();
        }

        [Test]
        // Si le texte de la recherche contient moins de 2 caract�res, ***Une exception est lev�e de type NotFoundException***.
        public void When_Search_Less_2_Char_ThrowNotFoundException()
        {
            //Assert
            Assert.Throws<NotFoundException>(() => searchCity.SearchCityByName("a"));
        }

        [Test]
        //    2. Si le texte de recherche est �gal ou sup�rieur � 2 caract�res, il doit renvoyer tous les noms de ville commen�ant par le texte de recherche exact.
        public void When_Search_EqualOrMoreThan2_ReturnCityStartBy()
        {
            //Act 
            var result = searchCity.SearchCityByName("Pa");
            List<string> expected = new List<string>() { "Paris" };
            //Assert
            CollectionAssert.AreEqual(expected, result);
        }
        [Test]
        //3. La fonctionnalit� de recherche doit �tre insensible � la casse
        public void When_Search_CaseInsensitive_ReturnCity()
        {
            //Act 
            var result = searchCity.SearchCityByName("pa");
            List<string> expected = new List<string>() { "Paris" };
            //Assert
            CollectionAssert.AreEqual(expected, result);
        }
        [Test]
        //4. La fonctionnalit� de recherche devrait �galement fonctionner lorsque le texte de recherche n'est qu'une partie d'un nom de ville
        public void When_Search_Is_Contain_In_Any_City_ReturnCityContainSearch()
        {
            var result = searchCity.SearchCityByName("ari");
            List<string> expected = new List<string>() { "Paris" };
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        //Si le texte de recherche est un � * � (ast�risque), il doit renvoyer tous les noms de ville.
        public void When_Search_Is_Asterisk_ReturnAllCity()
        {
            var result = searchCity.SearchCityByName("*");
            CollectionAssert.AreEqual(searchCity.Cities, result);
        }
    }
}