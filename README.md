# CS-Craigslist-Scraper
A tool that navigates craigslist and pulls data from listings.

# To Do:
* add mode to save output to file.
* add proxy use. craigslist blocks ip's if it sense unrealistic unrealistic traffic patterns (i.e. visiting 100 listings at a time from 1 ip)
* fix the terrible ui. I only added the bare bones of what was needed to test the proof of concept.
* Add auto mode. The user currently has to click start to pull all cities, then to pull all listing directories, then pull all listings, then pull all number pages(craigslist stores contact information on a separate page), then extract all numbers. Ideally this would be one button click to do them all. 
* refactor code into reusable modules, theres alot of duplicate code because of debugging and making small changes within each phase of the scraping. Alot of this can be consolidated into a few methods.

# Recently added:
* changed from webbrowser to webclient to inprove the performance.
* Added multi-threading and asyncronous processing to ensure a responsive ui.

feel free to send a pull request if anyone wants to contribute. 
