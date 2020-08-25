Feature: ContactToBlogFeature
	In this test we have test have tests cases which checking

@mytag
Scenario: As User I enter to blog and I’m contacting by contact form.
	Given I enter to "home" page
	And I click on ”Contact” in menu
	When I fill contact form
	Then I expect to see message as „Message Sent (go back)”