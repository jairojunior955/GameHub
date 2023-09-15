# GameHub - Desafio Backend LAPES
![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Postgres](https://img.shields.io/badge/postgres-%23316192.svg?style=for-the-badge&logo=postgresql&logoColor=white)
## Table of Contents
- [Installation](#installation)
- [Running](#running)
- [API Endpoints](#api-endpoints)
- [Database](#database)

## ERD 
![diagrama ER](https://github.com/jairojunior955/GameHub/assets/79456331/69c0b6b9-3ecc-41c5-95fc-638401756a69)

## UML Diagram
![diagrama UML](https://github.com/jairojunior955/GameHub/assets/79456331/f8a75eeb-b0a7-4bc9-824b-d6f4661820cc)

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/jairojunior955/GameHub.git
   ```
2. Edit your connection string on appsettings.json
## Running
1. Start the application in the *GameHub.ProductAPI* Folder with the command
```bash
dotnet run
```
2. The Server will be listen on https://localhost:7208
3. Swagger available on https://localhost:7208/swagger/index.html
## API Endpoints
```markdown
GET /api/Categories - Retrieve a list of all categories.

POST /api/Categories - Register a new categories.

GET /api/Categories/products- Retrieve a list of all categories with the products.

GET /api/Categories/{id} - Retrieve the categorie searched by id

PUT /api/Categories/{id} - Update the categorie by id
 
DELETE /api/Categories/{id} - Delete a categorie by id.

GET /api/Products - Retrieve a list of all products.

POST /api/Products - Register a new product.

GET /api/Products/{id}- Retrieve product searched by id.

PUT /api/Products/{id} - Update the product by id
 
DELETE /api/Products/{id} - Delete a product by id.
```
## Database
The project utilizes [PostgresSQL](https://www.postgresql.org/) as the database.
