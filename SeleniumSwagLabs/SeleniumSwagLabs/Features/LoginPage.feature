Feature: LoginPage


Scenario Outline: Verifying SwagLabs login functionality on chrome
	Given Chrome is launched and SwagLabs application is launched
	When  user enters  "<username>" and "<password>"
	And  user clicks on login-button
	Then It shows home page

	Examples:
	    | username                | password     |
	    | standard_user           | secret_sauce |
	    | performance_glitch_user | secret_sauce |
	    | problem_user            | secret_sauce |

Scenario: Verifying SwagLabs login functionality by entering empty username and password
 Given Chrome is launched and SwagLabs application is launched
When  user enters Username "" and Password ""
And  user clicks on login-button
Then Message stating 'Edit sadface:Username is  required' is displayed on the screen.

Scenario: Verifying SwagLabs login functionality by entering empty password
 Given Chrome is launched and SwagLabs application is launched
When  user enters Username "standard_user" and Password ""
And  user clicks on login-button
Then Message stating 'Edit sadface:Password is  required' is displayed on the Screen.

Scenario: Verifying SwagLabs login functionality by entering empty username
 Given Chrome is launched and SwagLabs application is launched
When  user enters Username "" and Password "secret_sauce"
And  user clicks on login-button
Then Message stating 'Edit sadface:Username is  required'  is Displayed on the screen.

Scenario Outline: Verifying SwagLabs login functionality by entering invalid details
 Given Chrome is launched and SwagLabs application is launched
When  user enters invalid "<username>" and "<password>"
And  user clicks on login-button
Then Message stating 'Edit sadface:Username and Password do not match any user in the service' is displayed.

 Examples:
	    | username                  | password      |
	    | standard_user             | sauce_secret  |
	    | user_standard             | secret_sauce  |
	    | Vishwa                    | secret_sauce  |
	    | Admin                     | secret_sauce  |
	    | 12345                     | secret_sauce  |
	    | #$%&*                     | secret_sauce  |
	    | Admin123                  | secret_sauce  |
	    | Admin%$&                  | secret_sauce  |
	    | Admin>/*                  | secret_sauce  |
	    | STANDARD_USER             | secret_sauce  |
	    | sTaNdArD_uSeR             | secret_sauce  |
	    | standard.user             | secret_sauce  |
	    | standard_userproblem_user | secret_sauce  |
	    | secret_sauce              | standard_user |
	    | standarduser_             | secret_sauce  |
	    | _standarduser             | secret_sauce  |

Scenario:To validate  that 'Username' field is available on login page.
 Given Chrome is launched and SwagLabs application is launched
 Then Username Field is visible.

 Scenario:To validate  that 'Password' field is available on login page.
 Given Chrome is launched and SwagLabs application is launched
 Then Password Field is visible.

Scenario:To Validate Swag Labs logo is present in login page
 Given Chrome is launched and SwagLabs application is launched
Then Swag Lab Logo is present

Scenario:To Validate Login-logo is present in login page
 Given Chrome is launched and SwagLabs application is launched
Then Swag Login-Logo is present

Scenario: Verifying SwagLabs Login functionality on chrome
	Given Chrome is launched and SwagLabs application is launched
	When  user Enters valid Username "locked_out_user" and Password "sauce_secret"
	And  user clicks on login-button
	Then  It shows message stating "Epic sadface: Sorry, this user has been locked out" is displayed.