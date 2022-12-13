# NatWest Scrapper
A .netCoreApiController application. Developed on dotnet framework 6.  
This scrapper is fetching the vacancies from the NatWest Dummy Website I developed, which is uploaded at https://github.com/musmankkr/ExampleWebsite  

#How to Run    
1- download and run the Example Website, make sure you have the dotnet core 3 sdk.   


2- download this Scrapper, and make sure the url path at appsettings is the same to your local path on which the website is running. You will require .net framework 6 sdk to run this scrapper.
![alt text](https://github.com/musmankkr/NatWestScrapper/blob/master/Capture.JPG?raw=true)     
![alt text](https://github.com/musmankkr/NatWestScrapper/blob/master/Capture2.JPG?raw=true)        


3- When running the scrapper Swagger UI will open, and you can execute the /api/NatWestApi, to scrape the vacancies from the NatWest Dummy website.  


![alt text](https://github.com/musmankkr/NatWestScrapper/blob/master/Capture3.JPG?raw=true)     


4- Make sure both applications are running on different ports. You can change the port of any one of the applications from the launchSettings.json located inside the property folder.
