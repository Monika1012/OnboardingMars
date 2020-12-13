using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.Steps {
    [Binding]
    public sealed class AddProfileDetailSteps {
        [Given(@"I login to the website with (.*) and (.*)")]
        public void GivenILoginToTheWebsiteWithAnd(string username, string password) {
            ScenarioContext.Current.Pending();
        }

        [Given(@"Ensure the profile page loads")]
        public void GivenEnsureTheProfilePageLoads() {
            ScenarioContext.Current.Pending();
        }

        [When(@"I enter following details in the form and click save button")]
        public void WhenIEnterFollowingDetailsInTheFormAndClickSaveButton(Table table) {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Details Saved message appears")]
        public void ThenDetailsSavedMessageAppears() {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The new created profiles shows up in the grid with profile name (.*)")]
        public void ThenTheNewCreatedProfilesShowsUpInTheGridWithProfileName(string p0) {
            ScenarioContext.Current.Pending();
        }
        //New Stuff
        [When(@"I Click on New Profile button")]
        public void WhenIClickOnNewProfileButton() {
            ScenarioContext.Current.Pending();
        }

        [Then(@"New Profile form opens up")]
        public void ThenNewProfileFormOpensUp() {
            ScenarioContext.Current.Pending();
        }

        [When(@"I Select the profile (.*)")]
        public void WhenISelectTheProfile(string p0) {
            ScenarioContext.Current.Pending();
        }

        [When(@"I edit following details in the form and click save button")]
        public void WhenIEditFollowingDetailsInTheFormAndClickSaveButton(Table table) {
            ScenarioContext.Current.Pending();
        }

        [When(@"Click Delete button")]
        public void WhenClickDeleteButton() {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Profile deleted message appears")]
        public void ThenProfileDeletedMessageAppears() {
            ScenarioContext.Current.Pending();
        }

        [Then(@"The (.*) profile does not appear on the grid\.")]
        public void ThenTheProfileDoesNotAppearOnTheGrid_(string p0) {
            ScenarioContext.Current.Pending();
        }

        [When(@"Click view button")]
        public void WhenClickViewButton() {
            ScenarioContext.Current.Pending();
        }

        [Then(@"Selected profile opens up on the page")]
        public void ThenSelectedProfileOpensUpOnThePage() {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I am able to validate all critical profile details successfully")]
        public void ThenIAmAbleToValidateAllCriticalProfileDetailsSuccessfully(Table table) {
            ScenarioContext.Current.Pending();
        }

    }
}
