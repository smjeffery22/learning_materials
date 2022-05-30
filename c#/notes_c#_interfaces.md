# C# Interfaces

- Interfaces allow codes to be flexible and easy to maintain and test

- Interface can be think of as a *contract*
  - When a class implements an interface, it fulfills that contract by carrying over functions from the interface

- Interfaces only contain declarations, not implementation codes
  - Allows to be more flexible

- Members of interfaces do not have access modifiers (public, private, etc.)
  - Public by default
  - Classes and abstracts' default are private

- Program to an *interface* rather than a regular *class* depending on situations
  - Higher level functionality

## Repository Pattern

- Mediates between the domain and data mapping layers using a *collection-like interface* for accessing domain objects
  - Separates application from the data storage technology
  - Do not want the application code to need to know how to make HTTP calls or open a file on the file system

- Repository responsible to expose the data as standard C# objects that the application can use
  - *Service repository* to make HTTP calls to a web service that returns JSON data
  - *CSV repository* to open a file on the file system and parse comma-separated values
  - *SQL repository* to connect a SQLite database using Entity Framework

- *Repository interface* is used to connect the repositories to the application
  - Has methods that can *interact with data*

- *CRUD repository* to fetch and update data objects (to perform read/write operations)
  - Create
  - Read
  - Update
  - Delete

- Different data sources include:
  - Web service => JSON
    - HTTP calls
  - Text file => CSV
    - File I/O
  - SQL database
  - Document database
  - Cloud service
  - Azure functions

**CONTINUE FROM MODULE 3**
  - https://app.pluralsight.com/course-player?clipId=101fe2bd-78b2-46ed-9aea-896e31896377