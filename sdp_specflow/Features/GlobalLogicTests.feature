@OpenMainPage
Feature: GlobalLogicTests

Scenario: Check GobalLogic main page title
Then Main page has correct title

Scenario Outline: Check Projekty tab in navigation
When I click on <tabId> tab
Then Url contains <keyword> keyword
And Title contains <title> phrase
Examples: 
| tabId           | keyword  | title    |
| menu-item-41613 | work     | Projekty |
| menu-item-41614 | insights | insight  |

Scenario: Check searchbox in insight tab
When I click on menu-item-41614 tab
And I type odkurzacz in searchbox
Then Number of results: 1
