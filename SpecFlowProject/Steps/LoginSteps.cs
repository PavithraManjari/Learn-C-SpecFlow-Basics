using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using SpecFlowProject.Pages;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject.Steps
{
	[Binding]
	public class LoginSteps
	{
		LoginPage loginl1 = null;
		[Given(@"I launch the Application")]
		public void GivenILaunchTheApplication()
		{
			IWebDriver Driver = new ChromeDriver();
			Driver.Navigate().GoToUrl("http://eaapp.somee.com/");
			loginl1 = new(Driver);
		}

		[Given(@"I click the login link")]
		public void GivenIClickTheLoginLink()
		{
			loginl1.ClickLoginLink();
		}

		[Given(@"I enter the following details")]
		public void GivenIEnterTheFollowingDetails(Table table)
		{
			dynamic data = table.CreateDynamicInstance();
			loginl1.EnterCredentials((string)data.UserName, (string)data.Password);
		}

		[Given(@"I click the login button")]
		public void GivenIClickTheLoginButton()
		{
			loginl1.ClickLoginButton();
		}

		[Then(@"I should see the Employee details link")]
		public void ThenIShouldSeeTheEmployeeDetailsLink()
		{
			loginl1.EmployeeListIsDisplayed();
		}
	}
}
