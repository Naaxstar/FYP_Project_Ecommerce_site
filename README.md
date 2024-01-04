# Ecommerce shopping site with OAuth2

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 8.0.1.

## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The app will automatically reload if you change any of the source files.

## Code scaffolding

Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory. Use the `--prod` flag for a production build.

## Running unit tests

Run `ng test` to execute the unit tests via [Karma](https://karma-runner.github.io).

## Running end-to-end tests

Run `ng e2e` to execute the end-to-end tests via [Protractor](http://www.protractortest.org/).

## Further help

To get more help on the Angular CLI use `ng help` or go check out the [Angular CLI README](https://github.com/angular/angular-cli/blob/master/README.md).


# Technology & securities implementation 


## 1. Databases

### Azure data studio
ADS is used for ease of data management and monitoring, nontheless you may use data handler of your choice.<br>

<img width="1267" alt="Screenshot 2023-06-12 at 1 27 39 PM" src="https://github.com/Naaxstar/FYP_Project_Ecommerce_site/assets/117069737/db9b79c2-d0e4-45ba-850f-535daf270bb7">

### Docker container
This repository provides a ready-to-use Docker container for Microsoft SQL Server 2019, making it easy to deploy and manage your database in various environments. <br>

<img width="1264" alt="Screenshot 2023-06-12 at 2 02 07 PM" src="https://github.com/Naaxstar/FYP_Project_Ecommerce_site/assets/117069737/1d6f3f4b-f3bf-4b4d-87ca-1d98ac33200f">

### Bold Rosalind: Containerized Microsoft SQL Server 2019

 This repository provides a ready-to-use Docker container for Microsoft SQL Server 2019, making it easy to deploy and manage your database in various environments.

### Key Features:

1. Pre-configured SQL Server 2019: Optimized for performance and reliability.<br>
1. Easy deployment: Simple to launch and manage with Docker.<br>
1. Portable: Runs consistently across different platforms.<br>
1. Ideal for development, testing, and small-scale production environments.

### Getting Started:

1. Pull the container:
Bash:<br>
`docker pull mcr.microsoft.com/mssql/server:2019-latest372bcc394119`

2. Run the container:
Bash:<br>
`docker run -d -p 1433:1433 --name bold_rosalind mcr.microsoft.com/mssql/server:2019-latest372bcc394119`

### Connecting to the Database:

Use your preferred SQL client or tool to connect to the database server at localhost:1433.<br>
Use the default credentials for SQL Server (if not modified):<br>
Username: `sa`<br>
Password: `[Initial password found in container logs]`

### Need Help?

Refer to the official [SQL Server documentation](https://learn.microsoft.com/en-us/sql/sql-server/?view=sql-server-ver16/)

## 2. Security

### HTTPS (SSL/TLS)
HTTPS (Secure Hypertext Transfer Protocol) is used to protect website traffic and keep sensitive information secure. It's essential for:

+ **Encryption**: Data sent between the website and browser is scrambled, preventing eavesdropping and interception.
+ **Authentication**: Ensures that users are connecting to the genuine website, not a fake one.
+ **Integrity**: Protects data from being tampered with during transmission.

> Self-signed ssl certificates <br>
<img width="1071" alt="Screenshot 2023-06-12 at 12 52 27 PM" src="https://github.com/Naaxstar/FYP_Project_Ecommerce_site/assets/117069737/1357cd68-f523-4ecc-9954-4f5b6b4ab227">

> Certification authentication <br>
<img width="1404" alt="Screenshot 2023-06-11 at 2 36 46 PM" src="https://github.com/Naaxstar/FYP_Project_Ecommerce_site/assets/117069737/85e58444-5452-4ea7-bf02-570edff50a95">

### OAuth 2 process flow
OAuth 2.0 is a widely used authorization framework that allows users to grant apps access to their data on other websites or services without sharing their passwords. It's crucial for:

- Secure third-party access: Apps can access user data on external services without storing sensitive passwords.
- User control: Users choose what data to share and can revoke access at any time.
- Standardization: Ensures interoperability between different apps and services.

Common use cases for OAuth 2.0:

- Social logins: Signing in to apps using Facebook, Google, or other social accounts.
- API access: Authorizing apps to access data from APIs like Twitter, GitHub, or Google Drive.
- Single Sign-On (SSO): Logging in to multiple apps with one set of credentials.
  
> Process 1: User redirect to Login panel server after click login <br>
<img width="544" alt="Screenshot 2024-01-04 at 5 12 25 PM" src="https://github.com/Naaxstar/FYP_Project_Ecommerce_site/assets/117069737/4879441b-26d6-463c-9d69-330d92aa8059">

> Process 2: The client requests access for data belonging to the resource owner <br>
<img width="929" alt="1 Console for making new authorization" src="https://github.com/Naaxstar/FYP_Project_Ecommerce_site/assets/117069737/1a893618-4e5e-4d19-8452-aac394de845e">

> Process 3: The resource owner replies by sending the authentication grant. The reply contains, grant type, the preferable authentication server to be used, and which server holds the resources and requesting for logins <br>
<img width="929" alt="2  The replies from resources owner" src="https://github.com/Naaxstar/FYP_Project_Ecommerce_site/assets/117069737/192a860b-4e85-4d0b-83e9-73faab1c6615">

> Process 4: User input their credentials <br>
<img width="1258" alt="0 1  Login page" src="https://github.com/Naaxstar/FYP_Project_Ecommerce_site/assets/117069737/e6910e0c-83a6-4cdd-8959-5558c9669a70">

> Process 5: The client forwards the authentication grant to the authentication server, asking for the access token
<img width="1095" alt="3  The client forwards the authentication grant to the authentication server" src="https://github.com/Naaxstar/FYP_Project_Ecommerce_site/assets/117069737/2cc513c3-1185-45e9-83dc-1b3f8687601c">

> Process 6: The authentication server validates the received grant and then sends back an access token, which represents the resource owner and states that the authorization has been approved
<img width="1095" alt="4" src="https://github.com/Naaxstar/FYP_Project_Ecommerce_site/assets/117069737/2e43e994-0640-41b1-921e-c755e1868b65">

> Process 7: The client asks the permission to access the protected resources from the server that contains the data by providing the access token.
Lastly, the resource server receives the token and validates it, returning the requested data invokes the ‘UserInfoEndpoint’, indicating that the resource server had received the token and gave the client the protected information
<img width="1095" alt="5" src="https://github.com/Naaxstar/FYP_Project_Ecommerce_site/assets/117069737/d30005ab-2fdb-4fa0-88ea-237b9f9e42ed">

> Process 8: User successfully login to their account
<img width="1254" alt="Screenshot 2023-06-14 at 4 54 53 PM" src="https://github.com/Naaxstar/FYP_Project_Ecommerce_site/assets/117069737/17615d47-7599-4dde-a9d5-153a645a1bf2">

### User input sanitisation 
User input sanitization is a critical security practice that involves validating and cleaning any data entered by users before it's processed by an application. It's essential to:

- Prevent attacks: Malicious input can lead to injection attacks like SQL injection, cross-site scripting (XSS), and others. Sanitization helps block these attacks.
- Protect data integrity: Ensures data remains accurate and consistent by removing or correcting invalid characters or formatting.
- Maintain functionality: Prevents unexpected errors or crashes caused by malformed input.
  
<img width="940" alt="Screenshot 2023-06-12 at 2 24 08 AM" src="https://github.com/Naaxstar/FYP_Project_Ecommerce_site/assets/117069737/8748450d-732d-4fc6-8834-9281d1ea6bd1">


