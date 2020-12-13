using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps {
    [Binding]
    public sealed class AddProfileDetailSteps {
        [Given(@"I login to the website with (.*) and (.*)")]
        public void GivenILoginToTheWebsiteWithAnd(string p0, string p1) {
            ScenarioContext.Current.Pending();
        }

        [Given(@"Ensure the profile page loads")]
        public void GivenEnsureTheProfilePageLoads() {
            ScenarioContext.Current.Pending();
        }

        [When(@"I Click on the Tab (.*)")]
        public void WhenIClickOnTheTab(string p0) {
            ScenarioContext.Current.Pending();
        }

        [When(@"Click on Add New Button")]
        public void WhenClickOnAddNewButton() {
            ScenarioContext.Current.Pending();
        }

        [Then(@"A New Row Editable Row is added on the Grid")]
        public void ThenANewRowEditableRowIsAddedOnTheGrid() {
            ScenarioContext.Current.Pending();
        }

        [When(@"I Enter (.*) and Select (.*) and Click on Add Button")]
        public void WhenIEnterAndSelectAndClickOnAddButton(string p0, string p1) {
            ScenarioContext.Current.Pending();
        }

        [Then(@"New Row is added in the grid and I can Validate values")]
        public void ThenNewRowIsAddedInTheGridAndICanValidateValues(Table table) {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on Edit Icon")]
        public void WhenIClickOnEditIcon() {
            ScenarioContext.Current.Pending();
        }

        [When(@"Update below fields and Click Update")]
        public void WhenUpdateBelowFieldsAndClickUpdate(Table table) {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Existing row updates with values")]
        public void ThenExistingRowUpdatesWithValues(Table table) {
            ScenarioContext.Current.Pending();
        }

        [When(@"I click on Delete Icon")]
        public void WhenIClickOnDeleteIcon() {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Row is deleted")]
        public void ThenRowIsDeleted() {
            ScenarioContext.Current.Pending();
        }


    }
}
