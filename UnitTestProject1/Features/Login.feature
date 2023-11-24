Feature: Login

Scenario: Login Page
	Given I navigate to login page
		And I enter the "<Username>" and "<Password>"
	When I click login
	Then I should see user logged in to application

Examples:
		 | Username | Password |
		 | Demo     | Demo     |



