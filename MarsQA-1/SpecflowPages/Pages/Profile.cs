using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages {
    public class Profile {
        private static IWebElement addNewButton => grid.FindElement(By.CssSelector("thead tr th div.ui.teal.button"));
        private static IWebElement addButton => tabContainer.FindElement(By.CssSelector("div.fields .six.wide.field input[type=\"button\"][value=\"Add\"]"));
        private static IWebElement editIcon => rowOfInterest.FindElement(By.CssSelector("td.right.aligned span i.outline.write.icon"));
        private static IWebElement deleteIcon => rowOfInterest.FindElement(By.CssSelector("td.right.aligned span i.remove.icon"));
        private static IWebElement tabContainer => Driver.driver.FindElement(By.CssSelector("div[data-tab=\"first\"]"));

        //Languages Grid
        private const string addLanguageTextSelector = "div.fields .five.wide.field input[type=\"text\"][placeholder=\"Add Language\"]";
        private const string languageLevelDropDownSelector = "div.fields .five.wide.field select.ui.dropdown";

        private static IWebElement grid => tabContainer.FindElement(By.CssSelector("table"));
        private static ReadOnlyCollection<IWebElement> rows => grid.FindElements(By.CssSelector("tbody tr"));
        private static IWebElement rowOfInterest => rows.Any(x=>x.Text.Contains(textToBeSearched)) ? rows.First(x => x.Text.Contains(textToBeSearched)) : rows[0];
        private static IWebElement addLanguageText => update ? rowOfInterest.FindElement(By.CssSelector("td " + addLanguageTextSelector)) :
                                                               tabContainer.FindElement(By.CssSelector(addLanguageTextSelector));
        private static IWebElement languageLevelDropDown => update ? rowOfInterest.FindElement(By.CssSelector("td " + languageLevelDropDownSelector)) :
                                                               tabContainer.FindElement(By.CssSelector(languageLevelDropDownSelector));
        private static IWebElement updateButton => rowOfInterest.FindElement(By.CssSelector("td .fields span input[type=\"button\"][value=\"Update\"]"));
        private static bool update = false;
        private static ReadOnlyCollection<IWebElement> allTabs => Driver.driver.FindElements(By.CssSelector("form.ui.form a"));
        private static string textToBeSearched;

        public static void GoToTab(string tabName) {
            if (allTabs.Any(x => x.Text.Contains(tabName))) {
                allTabs.First(x => x.Text.Contains(tabName)).Click();
                return;
            }
            throw new NoSuchElementException("Tab:" + tabName + " not found in the DOM");
        }

        public static void ClickAddNew() {
            Assert.True(addNewButton.Enabled, "Add new Button is not enabled");
            addNewButton.Click();
        }
        public static void ClickAdd() {
            Assert.True(addButton.Enabled, "Add Button is not enabled");
            addButton.Click();
        }
        public static void ClickEdit() {
            Assert.True(editIcon.Enabled, "Edit Button is not enabled");
            editIcon.Click();
            System.Threading.Thread.Sleep(5000);
        }
        public static void ClickDelete() {
            Assert.True(deleteIcon.Enabled, "Delete Button is not enabled");
            deleteIcon.Click();
            System.Threading.Thread.Sleep(5000);
        }
        public static void ClickUpdate() {
            update = true;
            Assert.True(updateButton.Enabled, "Update Button is not enabled");
            updateButton.Click();
            System.Threading.Thread.Sleep(5000);
        }
        public static void EnterLanguage(string language) {

            Assert.True(addLanguageText.Enabled, "Update Button is not enabled");
            textToBeSearched = language;
            addLanguageText.Clear();
            addLanguageText.SendKeys(language);
          
        }
        public static void SelectProficiencyLevel(string proficiency) {

            Assert.True(languageLevelDropDown.Enabled, "Update Button is not enabled");
            languageLevelDropDown.Click();
            SelectElement e = new SelectElement(languageLevelDropDown);
            e.SelectByText(proficiency);
        }
        public static void IsPageLoaded() {
            System.Threading.Thread.Sleep(5000);
            Assert.That(Driver.driver.Title.Contains("Profile"), Is.True, "Profile Page is not loaded");
            Assert.NotNull(grid, "Profile Page is not loaded as the grid didn't show up yet");

        }

        public static void ValidateGridValues(params string[] values) {
            foreach(string value in values) {
                Assert.True(rowOfInterest.Text.Contains(value), "Value:" + value + " not found in the grid.");
            }
        }

        public static void NoRowExists() {
            Assert.True(rows.Any(x=>!x.Text.Contains(textToBeSearched)), "Row was not deleted successfully!!");
        }

    }
}
