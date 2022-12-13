# NatWest
A .netCoreApiController application. Developed on dotnet framework 6.  
This scrapper is fetching the vacancies from the NatWest Dummy Website I developed, which is uploaded at https://github.com/musmankkr/ExampleWebsite  

#How to Run    
1- download and the Example Website File, make sure you have the dotnet core 3 sdk.   
2- download this Scrapper, make sure the url path at appsettings is same to your local path on which the website is running.
![alt text](https://github.com/musmankkr/NatWestScrapper/blob/master/Capture.JPG?raw=true)     
![alt text](https://github.com/musmankkr/NatWestScrapper/blob/master/Capture2.JPG?raw=true)        
3- When running the scrapper Swagger UI will open, you can execute the /api/NatWestApi, to scrape the vacancies from the NatWest Dummy website.
![alt text](https://github.com/musmankkr/NatWestScrapper/blob/master/Capture3.JPG?raw=true)          
4- Make sure the both applications are running on different ports. You can change the port of any one of the application from the launchSettings.json located inside the property folder of both the applications.
