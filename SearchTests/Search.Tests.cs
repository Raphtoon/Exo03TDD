using Exo03TDD.Bibliotheque;

namespace SearchTests
{
    //   Par exemple, pour le texte de recherche "Va", la fonction doit renvoyer Valence et Vancouver 
    //3. La fonctionnalit� de recherche doit �tre insensible � la casse
    //4. La fonctionnalit� de recherche devrait �galement fonctionner lorsque le texte de recherche n'est qu'une partie d'un nom de ville
    //   Par exemple "ape" devrait renvoyer la ville "Budapest"
    //5. Si le texte de recherche est un � * � (ast�risque), il doit renvoyer tous les noms de ville.
    [TestFixture]
    public class Tests
    {
        [Test]
        // Si le texte de la recherche contient moins de 2 caract�res, ***Une exception est lev�e de type NotFoundException***.
        public void When_Search_Less_2_Char_ThrowNotFoundException()
        {
            //Arrange
            SearchCity searchCity = new SearchCity();

            //Act 
            //searchCity.SearchCityByName("a");

            Assert.Throws<NotFoundException>(() => searchCity.SearchCityByName("a"));
        }



        [Test]
        //    2. Si le texte de recherche est �gal ou sup�rieur � 2 caract�res, il doit renvoyer tous les noms de ville commen�ant par le texte de recherche exact.
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