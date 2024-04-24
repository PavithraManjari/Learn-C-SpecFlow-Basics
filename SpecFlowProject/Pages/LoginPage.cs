using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.Pages
{
	public class LoginPage
	{
		public IWebDriver Driver { get; }
		public LoginPage(IWebDriver Driver)
		{
			this.Driver = Driver;
		}
		public IWebElement Username => Driver.FindElement(By.XPath("//input[@id='UserName']"));		
		public IWebElement Password => Driver.FindElement(By.XPath("//input[@id='Password']"));		
		public IWebElement Submit => Driver.FindElement(By.XPath("//input[@type='submit']"));
		public IWebElement EmployeeList => Driver.FindElement(By.LinkText("Employee List"));
		public IWebElement LoginLink => Driver.FindElement(By.XPath("//a[@id='loginLink']"));
		
		public void ClickLoginLink() => LoginLink.Click();
		public void EnterCredentials(string username,string password)
		{
			Username.SendKeys(username);
			Password.SendKeys(password);
		}
		public void ClickLoginButton() => Submit.Click();
		public bool EmployeeListIsDisplayed() => EmployeeList.Displayed;
	}
}
