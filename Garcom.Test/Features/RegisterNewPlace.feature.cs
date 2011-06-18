// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.6.1.0
//      SpecFlow Generator Version:1.6.0.0
//      Runtime Version:4.0.30319.225
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace Garcom.Test.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.6.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Register New Place")]
    public partial class RegisterNewPlaceFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RegisterNewPlace.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Register New Place", "As a hungry person\r\nI want to have a list of places available \r\nSo that I can hav" +
                    "e lunch", GenerationTargetLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Registering a new place using the add new place page")]
        public virtual void RegisteringANewPlaceUsingTheAddNewPlacePage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Registering a new place using the add new place page", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given("I am at the register new place page");
#line 8
 testRunner.When("I fill in \"name\" with \"Usina dos Pasteis\"");
#line 9
 testRunner.And("I click on \"submit\"");
#line 10
 testRunner.Then("I should see a link to \"Usina dos Pasteis\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Registering a new place through the all places page")]
        public virtual void RegisteringANewPlaceThroughTheAllPlacesPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Registering a new place through the all places page", ((string[])(null)));
#line 12
this.ScenarioSetup(scenarioInfo);
#line 13
 testRunner.Given("I am at the all places page");
#line 14
 testRunner.When("I fill in \"name\" with \"Usina dos Pasteis\"");
#line 15
 testRunner.And("I click on \"create_place_with_ajax\"");
#line 16
 testRunner.Then("I should see a link to \"Usina dos Pasteis\"");
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
