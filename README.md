## Project Title

Bookswagon Website Automation using BrowserStack


## Description

* The project is to automate Bookswagon.com which is e-commerce website for buying books
* This project will run on Browser stack website
* BrowserStack— a cloud-based cross-browser testing tool—lets you test your website across multiple browsers running on real devices Alternatively,
  BrowserStack Automate enables instant Selenium testing on desktop browsers, real Android and iOS devices.

## Prerequisites

* Visual Studio 2019  
* Chrome Browser  
* Firefox Browser
* Internet Connection
* Browser stac account

## Technology Used

* C#

## Frameworks

* .Net Framework  
* Nunit  
* Selenium  
* Data Driven  

## Design Pattern

* Page Object Model

## Packages

* DotNetSeleniumExtras.PageObjects- For Page object Model  
* ExtentReports- To generate Test Reports   
* NUnit- To define test cases, assertion  
* NUnit3Adapter- Running test cases in Visual Studio  
* Selenium.WebDriver- .Net Binding for selenium webdriver API  
* Selenium.WebDriver.ChromeDriver- Driver for Google Chrome  
* Selenium.Firefox.WebDriver-Driver for Firefox browser
* DNSClient- In this project it is uesd to get Host name
* Log4Net-Logging Test steps to log file
* ExcelDataReader.DataSet-Extension for reading microsoft excel files
* Newtonsoft.Json-To access data from json file
* Microsoft.Office.Interop.Excel- Assembly necessary for to do Microsoft office interop

## Test scenario covered

  #First- Positive scenario of buying book
  
* Login to Bookswagon application  
* Navigates to Home page  
* Search any book  
* Select the book 
* Place the order
* Add shipping address 
* Review the placed order
* Navigates to homepage  
* Log out from application  

## Running the tests

* Navigate to tool bar and Click on Test  
* Click on run all Test
* Open Browser stack webiste to check for running test and its result

## Author

* Siddhesh Thakur
