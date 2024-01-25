using Exo03TDD.Bibliotheque;

namespace SearchTests
{
    //   Par exemple, pour le texte de recherche "Va", la fonction doit renvoyer Valence et Vancouver 
    //3. La fonctionnalité de recherche doit être insensible à la casse
    //4. La fonctionnalité de recherche devrait également fonctionner lorsque le texte de recherche n'est qu'une partie d'un nom de ville
    //   Par exemple "ape" devrait renvoyer la ville "Budapest"
    //5. Si le texte de recherche est un « * » (astérisque), il doit renvoyer tous les noms de ville.
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



        [Test]
        //    2. Si le texte de recherche est égal ou supérieur à 2 caractères, il doit renvoyer tous les noms de ville commençant par le texte de recherche exact.
        public void When_Search_EqualOrMoreThan2_ReturnCityStartBy()
        {
            SearchCity searchCity = new SearchCity();
            //Act 
            var result = searchCity.SearchCityByName("Pa");
            List<string> expected = new List<string>() {"Paris"};
            CollectionAssert.AreEqual(expected, result);
        }
    }
}