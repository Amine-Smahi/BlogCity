## BlogCity
BlogCity a platform where words matter. It enables people to make an impression on others. To teach them something or connect emotionally. Where the quality of the idea matters

## What is .NET Core
.NET Core is a cross-platform, high-performance, open-source framework for building modern, cloud-based, Internet-connected applications.

## Features
The goal is to create a secure multiuser platform for dynamic content. the user can
* Create an account
* Login to own account
* Update hes credentials
* Add/edit/delete posts
* Create a profile page
* Watch other users posts
* Share posts on social media
* Social media authentication
* Like(love) posts
* Search for posts
* Download personnal data
* Two factor authentication

### Todo
* Image upload instead of image url
* Add comment system
* Add markdown 

## How to run the project
The steps are very easy you only have to
* Check if .NET Core sdk version 2.2 preview1 installed on your system, you can download it from [Here](https://www.microsoft.com/net/download/dotnet-core/2.2) then check if the instalation has gone correctly by typing
      
      user$ dotnet --version
      user$ 2.2.100-preview1
* Restore the dependencies by typing the commande
  
      user$ dotnet restore
* Apply migrations

      user$ dotnet ef database update
* Update Facebook app details

      user$ dotnet user-secrets set Authentication:Facebook:AppId <app-id>
      user$ dotnet user-secrets set Authentication:Facebook:AppSecret <app-secret>

* Finnaly go and run the app by typing

      user$ dotnet run
* Support me by making a <img style="margin-bottom: -20px;" src="https://user-images.githubusercontent.com/24621701/44811262-193e6e00-abcc-11e8-8e61-e52d8c78d5c9.png" /> for the repo and thank you :D , If you want to contribute to the project and make it better, your help is very welcome. 

## Screenshot

![blogcity](https://user-images.githubusercontent.com/24621701/45369008-cf4a8480-b5dc-11e8-89cc-5d78b2e3ec5e.png)
If you want to see more screenshots checkout [Screenshots](https://github.com/Amine-Smahi/BlogCity/blob/master/Screenshot.md)

## Team
proudly made by [Amine Smahi](https://github.com/Amine-Smahi) and support from [Jetlight Studio](http://jetlightstudio.tech/)

## License
The project is under GNU GENERAL PUBLIC LICENSE 

                GNU GENERAL PUBLIC LICENSE
                 Version 3, 29 June 2007

     Copyright (C) 2007 Free Software Foundation, Inc. <http://fsf.org/>
     Everyone is permitted to copy and distribute verbatim copies
    of this license document, but changing it is not allowed.

