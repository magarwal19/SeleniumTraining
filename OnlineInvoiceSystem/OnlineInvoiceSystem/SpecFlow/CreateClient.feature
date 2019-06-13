Feature: CreateClient
	In order to test the create client feautre

@mytag
Scenario: Create new client
	Given I have navigated to the URL
	And I have logged in to the system
	When I click on the new client button
	Then I should be able to enter the values
