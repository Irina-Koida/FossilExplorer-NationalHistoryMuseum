Feature: MapButtonExplorer
	As a user
	I want to find the area on the map
	In order to get geological information about fossil

	@MapButton
Scenario: Сheck possibility of opening geological map after tap on the map button
	When I tap "Map" button
	Then I navigate to the map

	@MapButton
Scenario: Сheck possibility to finding fossil geological information after tap on the location
	When I tap "Map" button
	Then I navigate to city "London" in the map
	When I tap "Find fossils" button
	Then I can see "Geology" information in the page

	@MapButton
Scenario: Сheck possibility to finding fossil information after intut location in Search field
	When I tap "Map" button
	Then I input "Manchester" in the map
	When I tap "Find fossils" button
	Then I can see "Geology" information in the page

	@MapButton
Scenario: Сheck display the landscape after pressing the geolocation button
	When I tap "Map" button
	Then I input "Manchester" in the map
	When I tap geolocation button
	Then I can see map in different colors according to the features of the terrain

	@MapButton
Scenario: Сheck possibility to finding superfisial fossil information after tap on the menu
	When I tap "Map" button
	When I navigate to city "Edinburg" in the map
	Then I can see all location detail "Waterloo Place, Edinburg"
	When I tap "Find fossils" button
	Then I can see menu with default activation the "All rocks" item
	When I tap "Superfisial" item
	Then I can see geological info about the "Fossils from rocks formed on land in past 0.1 million years" 



