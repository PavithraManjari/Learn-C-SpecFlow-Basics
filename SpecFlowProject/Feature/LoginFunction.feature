Feature: Login

	Login into EA Demo Application

@tag1
Scenario: Perform Login in EA Application Site
#Steps
	Given I launch the Application
	And I click the login link
	And I enter the following details
		| UserName | Password |
		| Pavithra    | Test@123 |
	And I click the login button
	Then I should see the Employee details link