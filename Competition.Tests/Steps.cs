using System;
using Competition.Lib;
using TechTalk.SpecFlow;

namespace Competition.Tests
{
    [Binding]
    public class Steps
    {
        [Given(@"Jow Blow n'est pas inscrit")]
        public void GivenJowBlowNEstPasInscrit()
        {
            
        }
        
        [When(@"Jow Blow s'inscrit")]
        public void WhenJowBlowSInscrit()
        {
            var database = Database.Load();
            database.Save(new Personne()
            {
                Prenom = "Joe", 
                Nom = "Blow",
                NumeDeTerrain = 103
            });
        }

        [Then(@"Il doit fournir son ""(.*)""")]
        public void ThenIlDoitFournirSon(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
