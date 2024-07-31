# Customer_Data_API
## Used Technologies: 
### The language of the available to code in this project: C# 12.0
### Target framework: [.NET 8.0](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
### IDE : [Visual Studio 2022 Preview](https://visualstudio.microsoft.com/vs/preview/)
* In this web API mainly focus on Edit Customer Details, Retrive All Customers Data, calculate the distance of given coordinates, search customers, group customers by Zipcode according to the three-tier architecture.
* By using Identity framework initally create the Admin Role and Customer Role. Then after user creation use that for authentication, role, and permission management.
## Credentials:
#### Admin Role - Email: admin1234@gmail.com | Password: Admin@1234

#### Customer Role - Email: customer1234@gmail.com | Password: Customer@1234
## Customer Data Frontend:
### Used Technologies: React Js, Boostrap, CSS, HTML5
## Instructions:
* Once you log into the system you can see the Login Page.
* If you are not registered, you can register to the system by using the register page.
* If you registered as an Admin you can visit the Admin Page and see the details about the customers.
* If you registered as a customer you can not access the Admin Page.
* You can generate the JWT token using your login credentials
```json
{
  "email": "admin1234@gmail.com",
  "password": "Admin@1234"
}
```
* After generating the token you can also access the other APIs.
* You can edit the customer name, email, and phone number using Customer ID. Here is the sample request body.
```json
{
    "_id": "5aa252be5d1e07697b16d463",
    "Name": "Cain Changed",
    "Email": "caingoodman@99sportan.com",
    "Phone": "+1 (993) 518-3773"
}
```
* You can get the distance calculated in kilometers using Customer ID, longitude, and latitude.
```json
{
    "CustomerId": "5aa252be5d1e07697b16d463",
    "Latitude": "37.7749",
    "Longitude": "34.0522"
}
```
* You can search the customers by using search text.
* You can list all Customers of the system by their "zip code".
