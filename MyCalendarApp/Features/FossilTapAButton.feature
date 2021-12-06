Feature: FossilTapAButton
	As a user
	I want to be able to familiarize myself with an application
	In order to understand whether it app interesting to me or not

Scenario: It's possible to tap a Find fossil button to navigate to the map
	When I tap a "Find fossil" button
	Then I navigate to the map, to find a fossil

Scenario: It's possible to tap a Map button to navigate to the map
	When I tap "Map" button
	Then I navigate to the map

Scenario: It's possible to tap a Hub button to navigate to the hap page
	When I tap the "Hub" button
	Then I navigate to the hub page

Scenario: It's possible to tap a Help button to navigate to the help page
	When I tap in "Help" button
	Then I navigate to the help page, where it is written how to use this application

Scenario: It's possible to tap a More button to navigate to the content page
	When Tap the "More" button
	Then Navigate to the content page