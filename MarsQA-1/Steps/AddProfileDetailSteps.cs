using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace MarsQA_1.Steps {
    [Binding]
    public sealed class AddProfileDetailSteps {
        [Given(@"I login to the MARS Application")]
        public void GivenILoginToTheMARSApplication() {
            SignIn.SigninStep();
        }

        

        [Given(@"Ensure the profile page loads")]
        public void GivenEnsureTheProfilePageLoads() {
            Profile.IsPageLoaded();
        }

        [When(@"I Click on the Tab (.*)")]
        public void WhenIClickOnTheTab(string p0) {
            Profile.GoToTab(p0);
        }

        [When(@"Click on Add New Button")]
        public void WhenClickOnAddNewButton() {
            Profile.ClickAddNew();
        }

       

        [When(@"I Enter (.*) and Select (.*) and Click on Add Button")]
        public void WhenIEnterAndSelectAndClickOnAddButton(string language, string level) {
            Profile.EnterLanguage(language);
            Profile.SelectProficiencyLevel(level);
            Profile.ClickAdd();
        }

        [Then(@"New Row is added in the grid and I can Validate values")]
        public void ThenNewRowIsAddedInTheGridAndICanValidateValues(Table table) {
            
            dynamic values = table.CreateInstance<Languages>();
            Profile.ValidateGridValues(values.Language, values.Proficiency);
        }

        [When(@"I click on Edit Icon")]
        public void WhenIClickOnEditIcon() {
            Profile.ClickEdit();
        }

        [When(@"Update below fields and Click Update")]
        public void WhenUpdateBelowFieldsAndClickUpdate(Table table) {
            dynamic values = table.CreateInstance<Languages>();
            
            Profile.EnterLanguage(values.Language);
            Profile.ClickUpdate();
        }

        [Then(@"Existing row updates with values")]
        public void ThenExistingRowUpdatesWithValues(Table table) {
            dynamic values = table.CreateInstance<Languages>();
            Profile.ValidateGridValues(values.Language, values.Proficiency);
        }

        [When(@"I click on Delete Icon")]
        public void WhenIClickOnDeleteIcon() {
            Profile.ClickDelete();
        }

        [Then(@"Row is deleted")]
        public void ThenRowIsDeleted() {
            Profile.NoRowExists();
        }


    }
}
