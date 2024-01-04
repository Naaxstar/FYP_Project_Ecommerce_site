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
2. Easy deployment: Simple to launch and manage with Docker.<br>
3. Portable: Runs consistently across different platforms.<br>
4. Ideal for development, testing, and small-scale production environments.

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

Refer to the official SQL Server documentation: [https://learn.microsoft.com/en-us/sql/sql-server/?view=sql-server-ver16]

## 2. Security

### HTTPS (SSL/TLS)
Self-signed ssl certificates <br>
<img width="1071" alt="Screenshot 2023-06-12 at 12 52 27 PM" src="https://github.com/Naaxstar/FYP_Project_Ecommerce_site/assets/117069737/1357cd68-f523-4ecc-9954-4f5b6b4ab227">

Certification authentication <br>
<img width="1404" alt="Screenshot 2023-06-11 at 2 36 46 PM" src="https://github.com/Naaxstar/FYP_Project_Ecommerce_site/assets/117069737/85e58444-5452-4ea7-bf02-570edff50a95">

