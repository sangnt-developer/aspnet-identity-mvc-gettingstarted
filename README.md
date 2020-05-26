# ASP.NET Core Identity MVC - Getting Started

This is a project for getting started with ASP.NET Core Identity that comprise **Register, Login, Logout, Forgot Password,...**.
**Attention:** The project just run on localhost. don't use any server for deployment.

## Requisites

- Visual studio 2019 (16.6 or higher)
- .NET SDK 3.1.
- SQL Server
- Microsoft SQL Server Management Tools (optional)

## Projects

### EmailService (class library)
The project is built to send email when processing "forgot password",... functionalities. We use NetCore.MailKit

### GettingStarted ASPNET IDENTITY (gettingstarted-aspnet-identity)
The project is a main project to build main functionalities as Register, Login, Logout, Forgot Password,...

## How to start ?

**Step 1** : Open "gettingstarted-aspnet-identity.sln" file by Visual Studio 2019 (VS2019).<br/>
**Step 2** : Install .NET SDK 3.1 or higher if any errors are noticed about that.<br/>
**Step 3** : Press "F5" or "Ctrl + F5" on VS2019 to build and run projects. <br/>
**Step 4** : Waiting for automatic running migrations for create Database and SeedData. After that, enjoy with the functionalities on ASP.NET Core Identity. <br/>

## Attention
- We need to modify configuration in appsettings.json:

```json

{
  "ConnectionStrings": {
    "sqlConnection": "server=.; database=SANGNTASPNETIDENTITY; Integrated Security=true"
  },
  ...,
  "EmailConfiguration": {
    "From": "your-email@gmail.com",
    "SmtpServer": "smtp.gmail.com",
    "Port": 465,
    "Username": "your-authen-login-email@gmail.com",
    "Password": "your-authen-login-password"
  },
  ...
}
```
Your email that you provide to section "EmailConfiguration.Username" and "EmailConfiguration.Password" need to **enable "Less secure app access" mode to "ON"** If you're using Gmail or other need to turn on that.

## Author
Sang Nguyen (sangnt-developer@gmail.com)
