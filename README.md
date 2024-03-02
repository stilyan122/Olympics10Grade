# Olympics10Grade
# Repository about ICT Olympics in 10th grade

# Aims

### Students today face difficulties in learning the material in many subjects, including chemistry. Very often the reason is rooted in poor structuring 
### and the lack of logical connections with previously acquired knowledge. Our goal was to create a "ElementFactory" app to help visualize and understand information about chemical elements, while demonstrating that chemistry is a science based on well-defined patterns encoded in the periodic table of elements. It interacts with all other sciences, and the challenges before it are enormous.
### We mainly aim to spark interest and present complex matter as an achievable challenge for anyone, regardless of current knowledge level. Through the use 
### of the application, we aim to facilitate not only students, but also the work of chemistry teachers by providing an intuitive and easy-to-use user interface.
### In a world of technology, the periodic table, the chemist's best friend, is used in a static version, without much choice of functionality other than its main 
### one - to provide information about chemical elements. In our project, we illustrate the system, in which a large set of representations are embedded, which support its 
### more comprehensive understanding and use.
### The project is aimed at anyone who wants to recall what they have learned in chemistry, but especially at students from grades 7 to 12.

# Main stages in the implementation of the project

### - acquiring and shaping the idea (brainstorming)
### - creating a suitable logo for the project
### - choosing a suitable development environment
### - building a template for the project with an MVC pattern of work
### - construction of a structure of entity classes and a database (code first approach to work)
### - creating and filling (seeding) the database through configurations (with methods or with JSON)
### - creation of the following functionalities:
  • Basic (Periodic system with its pop-up menus and various sorting implemented with JavaScript logic)
  • Quiz system
  • Flash cards
  • CRUD operations to them
### - setting up Authentication (authentication) – creating our own user
### - setting up Authorization (authorization) – creating own roles
### - adding functionalities according to the role
### - adding ranking functionality according to points of different users
### - creating styles for the pages (HTML & CSS)
### - publication of the project

# Level of complexity of the project

### Our application includes both simple concepts (from simple classes to Regex) and complex techniques 
### for writing quality and readable code (from design patterns to service layer specification). It is formulated on the basis of 
### quality program code, the principles of successful code (SOLID) are observed:
### - Single Responsibility
### - Open / Close
### - Liskov Substitution
### - Interface Segregation
### - Dependency Inversion

### It is divided into separate parts, with a clear division between: the services department, the data department and the web application department, in which the front-end is managed.
### A complex structure is implemented in the database, where different table structures are distinguished, with different relationships in them. 
### There are also three types of connection: one-to-one, many-to-many and one-to-many. Complex connections between individual "actions" (actions) and functions in JavaScript are also implemented. Authentication and authorization make the project work more complex, ensure its better implementation on the Internet and make it much more stable and properly functioning.

![image](https://github.com/stilyan122/Olympics10Grade/assets/117260079/ae595bb6-2708-495d-a04c-6b5cd19faeb1)

# Logical and functional description of the solution

### The application includes the different representations of the periodic table, as well as many other ways to prepare for the so "scary" chemistry class, a few of
### which are: our quiz system and the various flash cards. Each of the features in the project is unique in itself and different from the others.

### Authentication and authorization are also included. There is a role division, distinguishing 3 main roles: administrator, teacher and student. 
### Each of the roles comes with its own rights and different authorization. Admin can remove, approve and directly grant roles to users as per his wish. 
### The program does not limit its users in terms of customization, as everyone can create and choose their own way of preparation.

# Architecture

### The project consists of 3 main sub-projects.

![image](https://github.com/stilyan122/Olympics10Grade/assets/117260079/bc7e701f-76cd-4c5e-8a5a-e673d227f76f)

### - ElementFactory – keeping front-end resources, pages and models for displaying the project
### - ElementFactory.Core – a subproject related to the middle layer between the upper and lower layers, ensuring their communication, through interfaces and implementation
### - ElementFactory.Data – a layer related to the architecture and data content – ​​the database – of the project

# Implementation

### • The project is implemented with ASP.NET Core MVC (Model-View-Controller) technology, on version .NET 6.
### • Business logic is written in C# and JavaScript.
### • Front-end is achieved with Razor and with a combination of HTML & CSS.
### • Database architecture achieved with Entity Framework Core.
### • The IDE for the project is Visual Studio 2022. The ASP.NET Core MVC technology was chosen because it easily achieves 
### the "separation of concerns" pattern - responsibilities are distributed between View, Model and Controller.
### • The C# language was chosen because of its stable ecosystem, its widespread public use, its strong typing, and its integration with Microsoft technologies.
### • Razor syntax is used in the Views because of its easy integration into C# code.
### • Used HTML & CSS & JavaScript for front-end because of their stability, cross-browser performance and ecosystem in general.
### • Entity Framework Core is used to work with the database because it allows object relational mapping, integration with LINQ and a Code First approach.

# Conclusion

### The "Element Factory" project has been implemented, achieving basic programming directions and techniques for clean and correct code. The application
### realizes the set tasks - it provides a suitable field of expression both for teachers who want to take their tests and for students who want to prepare as much
### as possible and gain lasting knowledge.
### The application will be maintained with the code open for constant change. We continue to work on implementing new functionalities with flexible design and appropriate logic.
