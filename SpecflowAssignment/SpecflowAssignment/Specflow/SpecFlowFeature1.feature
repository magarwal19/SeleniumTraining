Feature: Assignment for SpecFlow
	To perform various tests on the application

@assignment
Scenario: Open business partner page
	Given I have navigated to the idempiere login page
	And I have logged in with valid credentials
	When I press select businees partner from favorites
	Then The business partner page should be displayed
	And The application should be closed after run

Scenario: Close business partner page
	Given I have navigated to the business partner page
	When I click on the close button
	Then The business partner page should be closed
	And The application should be closed after run

Scenario: Reset textboxes on a business partner
	Given I have navigated to the business partner page
	When I enter the values in the fields
	And click on reset button
	Then The fields values filled should be removed
	And The application should be closed after run

Scenario: Search a business partner
	Given I have navigated to the business partner page
	When I enter the values in the fields
	And click on ok button
	Then The business partner page should be open
	And The application should be closed after run

Scenario: Create new business partner
	Given I have navigated to create business partner page
	When I enter the required values in Business partner form
	And Click on Save button
	Then A new business partner should be created
	And The application should be closed after run