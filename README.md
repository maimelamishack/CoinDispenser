# CoinDispenser
Getting Started

CoinDispenser is a service for a coin dispenser machine that will calculate the minimum number of coins needed to make change for a given amount.

Installation

- Install Visual Studio 2019 or latest
- SQL Server
- Enable IIS (Turn Windows Features on and Off)
- Clone the project from https://github.com/maimelamishack/CoinDispenser.git Using Visual Studio
- Build the Solution
- Right click the project(CoinDispenser) > Publish > Choose Folder > Location(C:\CoinDispenserAPIDeployed)
- Right click the project(CoinDispenser) > Publish > Choose Folder > Location(C:\CoinDispenserAppUI)

Hosting Rest Service:
- Go to IIS > Sites
- Right click > Add website.(Enter the properties)
    [
	SiteName: Give Any name, 
	ApplicationPool: DefaultAppPool,
	Physical Path: Paste -> C:\CoinDispenserAPIDeployed,
	Host: localhost
	Port: 5001 (5001 Mandatory application settings configured to use 5001)
	]
- Ensure Start Website immediately checkbox is checked and click ok.
- Service is running.

Running Front End Application:
- Go to Folder C:\CoinDispenserAppUI
- Double click file: CoinDispenserAppUI (file type: Application)

Enjoy...
