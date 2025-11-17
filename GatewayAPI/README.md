

# Microsoft.NET Core (Moving from Only One Windows platform to Multiple platforms such as MacOS,Linux for development and execution)

  ## Difference between .NET Framework and .NET Core

  | Feature                        | .NET Framework                                  | .NET Core / .NET (Modern)                      |
  |--------------------------------|-------------------------------------------------|------------------------------------------------|
  | Platform Support               | Windows only                                    | Cross-platform (Windows, macOS, Linux)         |
  | Open Source                    | No                                              | Yes                                            |
  | Application Types              | Desktop, Web, Windows Services                  | Web, Cloud, Console, Microservices, IoT, etc.  |
  | Deployment Model               | System-wide, requires installation              | Side-by-side, self-contained, or framework-dependent |
  | Performance                    | Good, but less optimized for modern workloads   | High performance, optimized for modern workloads|
  | API & Library Availability     | Mature, large set of APIs                       | Growing, but some APIs not available           |
  | Updates                        | Infrequent, mostly security/bug fixes           | Frequent, with new features and improvements   |
  | Support for Containers         | Limited                                         | Full support (Docker, Kubernetes, etc.)        |
  | Modern Language Features       | Limited support for latest C# features          | Full support for latest C# features            |
  | Cloud Support                  | Limited                                         | Designed for cloud and microservices           |
  | Microsoft Support              | Mainstream support ended for older versions     | Actively supported and developed               | 

  ## Why To Use 

  - **Open Source**:-Before Open Source microsoft provide Close Source which is only view and execute no modification in code,
    But when open source came into picture its free to use and has a large community of developers who contribute to its development and support.
       
       - **Cost-Effective**:- Being open source and cross-platform, it can reduce development and deployment costs compared to proprietary solutions.
       - **Language Support**:- Supports multiple programming languages, including C#, F#, and Visual Basic, providing flexibility for developers. 
       - **Fast Development**:- With a rich set of libraries and tools, developers can build applications quickly and efficiently.
       - **Performance**:- Known for its high performance and scalability, making it suitable for building high-performance applications.
       - **Microservices Architecture**:- Well-suited for building microservices-based applications, allowing for modular (controller over files due to folder structure Controller,Respository,BL,DAL) and scalable development.
       - **Containerization**:- Works well with containerization technologies like Docker, making it easier to deploy and manage applications in various environments.
  
  - **Cross-Platform**:- Can run on Windows, macOS, and Linux, making it versatile for different development environments.
  
       - **Versatile**:- Supports a wide range of application types, including web, mobile, desktop, gaming, and IoT applications.
       - **Integration with Microsoft Ecosystem**:- Seamlessly integrates with other Microsoft products and services, such as Azure, Visual Studio, and SQL Server.
       - **Modern Development Practices**:- Supports modern development practices, including DevOps, continuous integration/continuous deployment (CI/CD), and agile methodologies.
  
  - **Cloud Applications**:- So due to open source and cross platform microsoft designed with cloud applications in mind, making it suitable for modern application development.
  - **Community and Support**:- Has a large and active community, along with extensive documentation and support from Microsoft.
  - **Regular Updates**:- Microsoft actively maintains and updates .NET Core, ensuring it stays current with the latest technologies and security standards.  
  
***
***

# Web API (Apllication Programing Interface Over Web)

  ## What is Web API?

  ![WebAPI](images/Web_API.png)
  
  - Set of function and protocols that allows different software applications clients (Web, Mobile, IOS, macOS, IoT,etc) to communicate and interact with each other over Internet.   
  - Web API that follows REST Architecture style and pattern as 
     - Standard of calling/trigger URLs throught http protocal/http verbs (GET, POST, PUT, DELETE) 
     - Message passing requests and getting responses in proper message format (Text, XML, JSON(Latest widely used)).  

     Then Web API is called RESTful Web API.

  ***
  
  ## Why Use Web API?
  
  - **Interoperability**: Due to Cross-Platform, APIs access and comunicate with different device,software and application .  
  - **Modularity**: Helps developers can break down complex systems into smaller, manageable components. Each component can be developed, tested, and maintained independently, leading to more efficient development processes.  
  - **Reusability**: APIs allow developers to reuse existing functionality without having to reinvent the wheel. This saves time and effort, as developers can leverage pre-built services and libraries.  
  - **Scalability**: APIs facilitate the scaling of applications by allowing different components to be updated or replaced without affecting the entire system. This makes it easier to adapt to changing requirements or technologies.  
  - **Security**: APIs can provide controlled access to resources and data, allowing developers to implement authentication and authorization mechanisms. This helps protect sensitive information and ensures that only authorized users can access certain functionalities.  
  - **Innovation**: By exposing certain functionalities through APIs, organizations can encourage third-party developers to create new applications or services that enhance their offerings. This fosters innovation and      

  ***

  ## Rules of RESTful Web API

  - **Stateless**: Client provides all information for each request, server dosen't store any client information.
  - **Client-Server Architecture**: Client and server are separate entities that communicate over a network. 
  - **Uniform Interface**: Clinet should need to follow standardized way of interacting with resources using HTTP methods/HTTP verbs (GET, POST, PUT, DELETE).  
  - **Cacheable**: Response from Web API cached/stroe in client to avoid unwanted trigger/calling Web API to avoid load over it.
  - **Layered System**: Web API can be composed of multiple layers, each with specific responsibilities (e.g., authentication, logging, etc.)
  - **Code on Demand (Optional)**: Server can send response with only data as per client request, not extra or unwanted data.
  
***
***

# .Net Core Web API 

 ## Steps To Create Project  
 
  - Open Visual Studio 2022.
  - Step 2:- Click on "Create a new project".
  - Step 3:- In the "Create a new project" dialog, select "ASP.NET Core Web API" from the list of templates and click "Next".
  - Step 4:- Enter a name for your project, choose a location to save it. 
     1.  If you want to add solution file within project then check "Place solution and project in the same directory" checkbox.
     
     Then click "Next".
  - Step 5:- In the "Additional information" dialog, select the following options:
     1.  Choose the target framework version (e.g., .NET 6.0 (Long Term Support) or .NET 7.0 (Long Term Support)) in a way that it is providing Long Term Support.
     2.  Authentication Type: Select "None" for no authentication.
     3.  If you want secured your Web API request/response protocal then check "Configure for HTTPS" checkbox.
     4.  If your Web API is having a concept of Container then check "Enable Container Support" checkbox and choose the appropriate Container OS operating system (Linux or Windows).
          And also select Container Build Type (Docker or Docker Compose).
     5.  If you want to use in-built Web API Testing Tool (e.g., Internal Testing Tool - Swagger, External Testing Tool - Postman) then check "Enable OpenAPI Support" checkbox.
     6.  If Web API required controller then select "Use controllers" checkbox.
     7.  If you want base level code template/structure like code in Program.cs,etc, then uncheck "Do not use top-level statements" checkbox.
    
    Then click "Create".  
      
 ***

 ## Files and Folders Structure And Its Role

   ![WebAPIFloderStructure](images/ASPNetCoreWebAPI_FolderStructure.png)

 ***

 ## End-to-End Request Lifecycle

   The total ASP.NET Core Web API processing sequence is:
  
   1. Web Server:- Kestrel receives HTTP request

   2.  Middleware:- ExceptionHandler, HTTPS Redirection

   3.  Routing Middleware:- UseRouting() maps endpoint

   4.  Authentication/Authorization:-	UseAuthentication(), UseAuthorization()

   5.	MVC Filter Pipeline:- Authorization → Resource → Action → Exception → Result

   6.	Controller Execution:- Invokes action method and services

   7.  Response Return:- Data flows back through middleware in reverse order

 ***
 ## Explain Program.cs file code - Configure Service and Middleware

   **Configuration and building** of **WebApplication** by **adding servicess** and **handling incoming Request** using **Middleware**
   in **Program.cs Application Entry Point of Execution**:- 

   **Framework**:-
    Microsoft.AspNetCore.App
    Microsoft.NetCore.App

   **Packages**:-
    Swashbuckle.AspNetCore         --For Swagger

   Ocelot                                         --For API Gateway Request Management
   Ocelot.Cache.CacheManager     


   1. **Core Web API Program.cs Flow**
   
        a. **Create WebApplication Builder**
         
              Syntax:
                ```csharp
                        var builder = WebApplication.CreateBuilder(args);
                ```
              Initializes app builder with default settings, Kestrel server, logging, configuration including appsettings.json.

              Provides builder.Services for Dependency Injection (DI) registrations.

        b. **Register Services (Dependency Injection)**
       
              Use builder.Services to register services your app depends on:

              Controllers: builder.Services.AddControllers();

              Database contexts, repositories, custom services

              Authentication, swagger, caching, HTTP clients, etc.

              Examples of DI service lifetimes:
                **AddScoped**: one instance per HTTP request
                **AddSingleton**: one instance for app lifetime
                **AddTransient**: a new instance every injection

        c. **Build the App**
        
              Syntax:
                 ```csharp
                         var app = builder.Build();
                 ```
         
              Compiles all configurations and services into an application instance.

        d. **Setup Middleware Pipeline**
        
              Register middleware components that intercept requests:

              Routing: app.UseRouting();
              Authorization: app.UseAuthorization();
              Controller endpoints: app.MapControllers();
              Logging, exception handling middleware may also be added.

        e. **Run the App**
                
              Syntax:
                  ```csharp
                         app.Run();
                   ```  
          
              Starts the Kestrel web server and begins listening for HTTP requests.

    ***
    
   2. **Ocelot API Gateway Program.cs Flow**
   
        a. **Create Builder and Load Ocelot Config**
         
              Syntax: 
                  ```csharp
                        var builder = WebApplication.CreateBuilder(args);
                        builder.Configuration.AddJsonFile("ocelot.json");
                  ```
          
              Adds Ocelot-specific config file that defines routing, aggregation, authentication, rate limiting.

        b. **Register Ocelot Services**
                
              Syntax:
                  ```csharp
                         builder.Services.AddOcelot();
                  ```
          
              Registers Ocelot middleware and infrastructure for API Gateway features like routing, load balancing.

        c. **Build the App**
         
              Syntax:
                  ```csharp
                         var app = builder.Build();
                  ```
         
              Creates the configured app with Ocelot services.

        d. **Use Ocelot Middleware**
              
              Syntax:
                  ```csharp
                          app.UseOcelot().Wait();
                  ```
         
              Adds Ocelot request handling pipeline to intercept incoming requests and forward to configured downstream services.

              This replaces or extends standard routing.

        e. **Run the App**
              
              Syntax:  
                  ```csharp
                         app.Run();
                  ```
          
              Starts the gateway server.

        3. **Dependency Injection (DI) in Both Contexts  **
        
              Both apps use the built-in ASP.NET Core DI container.

              Register services in builder.Services.

              Controllers or services request dependencies via constructor injection.

              DI improves modularity, testability, and separates concerns.

              **Example DI Registration**:

              Syntax:
                    ```csharp
                           builder.Services.AddScoped<IProductService, ProductService>();
                    ```
              Registered dependencies can then be injected into controllers or other services automatically.

 ***

 ## Main Concepts Of Projects

 1. **Services** :-
   - Services are reusable code block/logic registered in the Dependency Injection (DI) container which have their own indenpendent functionality. 
      Functionality such as authentication,data access,logs management,etc
   - By injecting into controllers, middleware, or other services, developers can do code reusability, maintainability, and separation of concerns within their applications.

     - **Service Lifetimes** :- Services can be registered with different lifetimes, such as Singleton (one instance for the entire application), Scoped (one instance per request), or Transient (a new instance each time it is requested).

     Syntax:-
            ```csharp
                  builder.Services.AddScoped<IProductService, ProductService>();
            ```

 2. **Middleware** :- 
    - Middleware is sequence pipeline of processes that each HTTP incoming request and outcoming response 
    - Process such as authentication, logging, error handling, or modifying the request/response. 
  
       Syntax:-
                
              ```csharp
    
                    var app = builder.Build();     
                    app.UseExceptionHandler("/error");       // 1. Error handling
                    app.UseHsts();                           // 2. Enforce HTTPS
                    app.UseHttpsRedirection();               // 3. Redirect HTTP → HTTPS
                    app.UseResponseCompression();            // 4. Compress responses
                    app.UseStaticFiles();                    // 5. Serve static content
                    app.UseRouting();                        // 6. Match route patterns
                    app.UseCors();                           // 7. Apply CORS rules
                    app.UseAuthentication();                 // 8. Verify user credentials
                    app.UseAuthorization();                  // 9. Enforce access permissions
                    app.UseSession();                        // 10. Maintain user sessions
                    app.UseOutputCache();                    // 11. Cache processed outputs
                    app.UseRateLimiter();                    // 12. Apply rate limiting
                    app.MapControllers();                    // 13. Endpoint execution (Controller/Action)
                    app.Run();
    
             ```
   3. **Filters** :- 
      - Filters pre/post logic in the request processing pipeline, such as before an action method is called or after a response is generated.
      - Independent Logic like logging, caching, validation, or error handling.
      
        **Types of Filters as Per Priority**:-
         - **Authorization Filters** :- Proority of ExtionExecute before any other filter to determine if the user is authorized to access the resource.
         - **Resource Filters** :- Execute after authorization but before model binding. Used for caching or modifying the request.
         - **Action Filters** :- Execute before and after an action method. Used for logging, validation, etc.
         - **Exception Filters** :- Handle unhandled exceptions thrown during action execution.
         - **Result Filters** :- Execute before and after the action result is executed. Used for modifying the response.
         
        Syntax:-
               ```csharp
                    [Authorize]
                    public class ProductsController : ControllerBase
                    {
                        // Action methods
                    }
               ```
  
  4. **Controller** :- 
      
     Each Controller, 
       - **ControllerBase class** :- Controller is derived class of ControllerBase class which internal handles the incoming HTTP requests and outgoing HTTP responses. It provides various methods and properties to work with HTTP requests and responses, such as accessing request headers, query parameters, and request body data. It also provides methods for returning different types of responses, such as JSON, XML, or plain text.   
       - **APIController Attribute** :- This attribute is used to indicate that a class is a Web API controller. It provides additional functionality and behavior specific to Web API controllers, such as attribute routing, automatic model validation and response formatting.
         
  
***
***

# Monolathic vs Microservices Architecture

  ## Monolithic Architecture

  ![MonolithicArchitecture](images/Monolithic_Architecture.png)
  
  In Monolithic Architecture, the entire application is built as a single, cohesive unit. All components and functionalities are tightly integrated and run within a single process. This means that any changes or updates to one part of the application may require redeploying the entire application.
  
  - **Advantages**:
     - Simplicity: Easier to develop, test, and deploy as a single unit.
     - Performance: Direct communication between components can lead to better performance.
     - Easier Debugging: Debugging is straightforward since all code is in one place.
  
  - **Disadvantages**:
     - Scalability: Difficult to scale individual components independently.
     - Maintenance: As the application grows, it can become complex and harder to maintain.
     - Deployment: Any change requires redeploying the entire application, leading to potential downtime.
 
   ***

  ## Microservices Architecture

  ![MicroservicesArchitecture](images/MicroServices_Architecture.png)

  In Microservices Architecture, the application is divided into smaller, independent services that communicate with each other through APIs. Each service is responsible for a specific functionality and can be developed, deployed, and scaled independently. This allows for greater flexibility and agility in development and deployment.
  
  - **Advantages**:
     - Scalability: Individual services can be scaled independently based on demand.
     - Flexibility: Different services can use different technologies and programming languages.
     - Resilience: Failure in one service does not necessarily impact the entire application.
     - Faster Development: Teams can work on different services simultaneously, speeding up development.
  
  - **Disadvantages**:
     - Complexity: Managing multiple services can be complex and requires robust orchestration.
     - Communication Overhead: Services need to communicate over the network, which can introduce latency.
     - Data Consistency: Ensuring data consistency across services can be challenging.
     
  ***
  
  ## When to Use Which?

  - **Monolithic Architecture** is suitable for:  
     - Small to medium-sized applications with limited complexity.
     - Applications with a stable feature set that do not require frequent updates.
     - Teams with limited resources or experience in managing distributed systems.
     
  - **Microservices Architecture** is suitable for: 
     - Large-scale applications with complex functionalities that require frequent updates.
     - Applications that need to scale specific components based on demand.
     - Teams with experience

***
***

# API Gateway

  ## What?
  It acts as a single centralized entry point that manages and routes client requests to multiple backend services or APIs.

  ## Why?
  - Clients interact with a single endpoint
  - Centralized authentication and authorization, protecting backend services.
  - Features such as rate limiting and load balancing protect services from overload.
  - Caching, and protocol translation
  - Centralized logging and analytics

  ## Explain Ocelot.json structure

  **Ocelot** is a lightweight API Gateway framework for .NET Core, widely used to route and manage requests to microservices. Its configuration is primarily driven by a JSON file, often named ocelot.json.

   Main Sections of ocelot.json
   
  1. **Routes (or ReRoutes in older versions)**
 
     An array of route definitions.

     Each route defines how an upstream request (from clients) is forwarded to a downstream service (your microservice).

       Key properties inside each route:

        - UpstreamPathTemplate: The route path clients call (e.g., /api/users/{id}).

        - UpstreamHttpMethod: Allowed HTTP methods (GET, POST, etc.) for this route.

        - DownstreamPathTemplate: The path on the backend service to forward to.

        - DownstreamScheme: The protocol to use when forwarding (usually http or https).

        - DownstreamHostAndPorts: Array specifying one or multiple backend hosts and ports.

     **AuthenticationOptions** (optional): Defines security such as JWT bearer tokens.

     **RateLimitOptions** (optional): Parameters to control request throttling.

     **FileCacheOptions** (optional): Cache settings for responses.

     **LoadBalancerOptions** (optional): Load balancing strategy among multiple backend hosts.

   2. **Aggregates**
    
      Defines routes that combine multiple Routes' responses into one aggregated response.

      Useful for reducing multiple downstream calls into a single upstream response.

   3. **GlobalConfiguration**
   
      Settings applied globally to all routes.

      Syntax:

        BaseUrl: The external address of the gateway.

        Other settings for administration, request identification, etc.

      **How It Works in Practice**
    
        When a client requests an endpoint matching an UpstreamPathTemplate, Ocelot:

        Matches the request method to UpstreamHttpMethod.

        Routes the request to the appropriate DownstreamHostAndPorts and DownstreamPathTemplate.

        Applies middleware features like authentication, caching, rate limiting, or load balancing based on the route configuration.

        Syntax:

                ```json
                        {
                          "Routes": [
                            {
                              "UpstreamPathTemplate": "/api/users/{id}",
                              "UpstreamHttpMethod": ["GET"],
                              "DownstreamPathTemplate": "/api/users/{id}",
                              "DownstreamScheme": "http",
                              "DownstreamHostAndPorts": [
                                { "Host": "localhost", "Port": 7001 }
                              ],
                              "AuthenticationOptions": {
                                "AuthenticationProviderKey": "Bearer",
                                "AllowedScopes": []
                              },
                              "RateLimitOptions": {
                                "EnableRateLimiting": true,
                                "Period": "1m",
                                "Limit": 100
                              }
                            }
                          ],
                          "GlobalConfiguration": {
                            "BaseUrl": "http://localhost:7000"
                          }
                        }
                ```

        **Summary**

        Routes map external API paths to internal microservices.

        Each route can have customized HTTP methods, security, caching, and load balancing.

        GlobalConfiguration defines overall gateway behavior.

        Aggregates combine multiple service responses into one.
   
   
 ***  
 ***
 
 # Authentication Techniques in Web API

  ## JWT(JSON Web Token) Authentication
  - **JWT** is a compact, URL-safe means of representing claims to be transferred between two parties. It is commonly used for authentication and authorization in web applications.
  - In JWT authentication, when a user logs in, the server generates a JWT containing user information and signs it with a secret key. The client then includes this token in the Authorization header of subsequent requests. The server verifies the token's signature and extracts user information to authenticate and authorize access to protected resources.
  
   **Advantages**:     
   - Security: Signed tokens ensure data integrity and authenticity.
   - Flexibility: Can include custom claims for additional user information.
   - Standardized: Widely adopted and supported by many libraries and frameworks.
   - Ease of Use: Simple to implement and use in various applications.

  Example of JWT Structure:
  
   A JWT consists of three parts separated by dots (.), which are:
   - Header: Contains metadata about the token, such as the signing algorithm.
   - Payload: Contains the claims or user information.
   - Signature: Used to verify the token's integrity and authenticity.
   
   Example JWT:
        ```
            eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c
        ```   
  Implementation Code Snippet:
  
   Syntax:

        ```csharp
            // Generating JWT Token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("your_secret key");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Id.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);
        ```

   ***
   ***

   # Interview

   ## Key Differences
        
   ### **Abstract Class vs Interface**
  
   **Aspect              	                Abstract Class	                                                                Interface**
   Instantiation	                    Cannot be instantiated	                                                Cannot be instantiated
   Method Implementation	Can have both abstract and concrete methods	        Only abstract methods (except default methods in latest C#)
    Fields & Constructors       	Can have fields and constructors	                                No fields or constructors
    Access Modifiers                	Can have varying access modifiers	                            Members are public by default
    Inheritance	                        Supports single inheritance (extends)	                        Supports multiple inheritance (implements)
    Use Case	                            When classes share common behavior	                    To specify a contract across unrelated types
    Abstraction Level	            Partial abstraction	                                                        Full abstraction

   ### ** Object vs var vs dynamic**

   - ** Object**: 
      1. The base type for all data types in C#. 
      2. It requires explicit casting to convert to a specific type. 
      3. It is statically typed, meaning the type is determined at compile time.

   - ** var**: 
      1. Implicitly typed local variable.
      2. The type is inferred by the compiler based on the assigned value.
      3. It is statically typed, meaning the type is determined at compile time.
   
   - ** dynamic**: 
      1. A type that bypasses compile-time type checking.
      2. The type is determined at runtime, allowing for more flexibility.
      3. It can lead to runtime errors if the expected members or methods are not present.

   ## **SOLID Principles**

   - **Single Responsibility Principle (SRP)**: A class should have only one reason to change, meaning it should have only one job or responsibility.
       
        Eg: 
          
          ```csharp
                public class Invoice
                {
                    public void CalculateTotal() { /* ... */ }
                }
                public class InvoiceRepository
                {
                    public void SaveToDatabase(Invoice invoice) { /* ... */ }
                }
          ```
       Explaination: The Invoice class now only handles invoice calculations, while the InvoiceRepository class handles database operations.

  - **Open/Closed Principle (OCP)**: Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification.
        
       Eg:
 
         ```csharp
                abstract class PaymentMethod {
                        public abstract void Pay();
                 }
                 
                 class CreditCardPayment : PaymentMethod {
                        public override void Pay() { /* credit card pay logic */ }
                  }
         ```
       
       Explaination: You can add new payment methods by extending PaymentMethod without modifying existing code.

  - **Liskov Substitution Principle (LSP)**: Derived classes should be substitutable for their base classes without altering the correctness of the program.
        
       Eg:
 
         ```csharp
                class Bird {
                        public virtual void Fly() { /* flying logic */ }
                 }
                 
                 class Penguin : Bird {
                        public override void Fly() {
                            throw new NotSupportedException("Penguins can't fly");
                        }
                  }
         ```
       
       Explaination: Penguin violates LSP because it cannot substitute Bird without changing expected behavior. 
   
  - **Interface Segregation Principle (ISP)**: Clients should not be forced to depend on interfaces they do not use. 
       
       Eg:
 
         ```csharp
                interface IPrinter {
                        void Print();
                 }
                 
                 interface IScanner {
                        void Scan();
                  }
         ```
       
       Explaination: Instead of a single interface with both Print and Scan methods, we have separate interfaces for each functionality. 
   
   - **Dependency Inversion Principle (DIP)**: High-level modules should not depend on low-level modules. Both should depend on abstractions. Abstractions should not depend on details. Details should depend on abstractions.
        
       Eg:
 
         ```csharp
                interface IMessageSender {
                        void SendMessage(string message);
                 }
                 
                 class EmailSender : IMessageSender {
                        public void SendMessage(string message) { /* email sending logic */ }
                  }
         ```
       
       Explaination: The high-level module (e.g., NotificationService) depends on the IMessageSender abstraction rather than a concrete implementation like EmailSender.
   
   *** 
    
   ## **HTTP Response**

   - **Response**:
   
     200 - OK: The request has succeeded.
     201 - Created: The request has been fulfilled and resulted in a new resource being created.
     202 - Accepted: The request has been accepted for processing, but the processing has not been completed.
     204 - No Content: The server successfully processed the request, but is not returning any content.
      
     400 - Bad Request: The server cannot or will not process the request due to a client error.
     401 - Unauthorized: The request requires user authentication.
     403 - Forbidden: The server understood the request, but refuses to authorize it.
     404 - Not Found: The requested resource could not be found.
     406 - Not Acceptable: The requested resource is capable of generating only content not acceptable according to the Accept headers sent in the request.
    
     500 - Internal Server Error: An unexpected condition was encountered on the server.
     501 - Not Implemented: The server does not support the functionality required to fulfill the request.
     502 - Bad Gateway: The server received an invalid response from the upstream server.
     503 - Service Unavailable: The server is currently unable to handle the request due to temporary overload or maintenance.

***
***
   
   # DevOps

   ## CI (Continous Integration Phase(Build & Test)) / CD (Continous Delivery Phase(Release & Deploy))

   - CD Types
        - When CD is called continuos delivery means when projects are mainly based on sensitive data for example transaction based application such as banking.
        - When CD is called continuos deployment means when projects are mainly non-sensitive data for example non transaction based application such as netflix.

  
  - Deployment Statergy Types
        - Blue Green Deployment  - Maintaining Blue(Current on-going version) & Green(New version)
        - Canary/Progressive Deployment - Increasing chunck of user traffic to new deployment from old version in increasing user trafic.
        - Rolling Deployment - Maintaining multiple instance of project environment based on load balance and user traffic review replaces each instance with new deployment (This implementation when good DevOps available)

  - Mainly tools available for implementing process of CI/CD such as Githhub Actions, Jenkins, Gitlab based on organization.More popular tools are  Githhub Actions, Jenkins and Azure Pipelines.
       - Githhub Action (Released Year 2019)
       - Jenkins (Released Year 2011)

   ### GitHub Actions CI/CD vs Azure CI/CD

   1. **GitHub Actions CI/CD** :-
   
        - This is mainly used when Repo is in GithHub Version control.
        - Action stages such as pull, push, commit and release definde in .YAML script

  2.

   ***

   ## Docker

   ### Docker vs VM
    
   Local system made of 3 layers such as H/w Layer, OS Kernel Layer and Application Layer

   **Advantage**:-

   1. So, Docker only creates it own virtual Application layer  against Application Layer of Local OS machine and uses other 2 layers of local machine as it is.
       Incase of running Linux container  on windows/macOS docker deskyop app provides Linux lightweight OS Kernel  enironment which is  provided by WSL2 with Hyper-V  but not fully enable Linux environment.
       That why **Advantage of Docker is Lightweight & Faster then VM**.

       As VM(Virtaul Machines) create 2 virtual layers fully enable  OS Kernel Layer and Application Layer against OS Kernel Layer and Application Layer of Local OS machine and uses Hardware Laye of local machine as it is.
       More overhead then Docker due 2 its 2 own virtial layer taking more memory space.

   **Dis-advantage**:-

   1. So, Docker uses it lightweight OS kernel not fully enable OS kernel so sometimes need to face OS compatibility issue while running different OS dockerimage for
       E.g  Linux dockerimage on windows so need to switch docker to Linux container  before creating docker linux container in local windows OS machine.

       As VM(Virtaul Machines) create fully functional OS kernel so OS compatibility issue doesn't exist.
    
   ### Docker AND Docker Cmmands

   -  Dockerfiles created by developers or users. Its human written text(what software and configurations it should include) file contains to build DockerImage.
   
   -  Docker Engine runtime environment that read Dockerfiles text(what software and configurations it should include) and builds a DockerImage from it also runs containers from those images and also
      shows list of containers and images on local machine.
    
        URL To Install Docker Engine Application: https://docs.docker.com/desktop/install/windows-install/ 
     
   -  DockerHub is cloud-based registry service that allows you to store and share DockerImages with others. It provides a centralized repository where required developers can publish, discover, and download DockerImages for various applications and services.
    
        Images can be public (accessible to anyone) or private (restricted access). 
    
        Online URL To Access Self Created Images or Global Shared DockerImages:  https://hub.docker.com/ 
     
        (**Note**:- But doesn't help in creating container from downloaded DockerImages, that's why Docker Engine is need in machine to create Container from DockerImage) 

   -  Check Docker is install or not 
        
      Syntax:
    
            ```terminal
                    docker --version    or   docker -v
            ```                  
   
   -  To avoid inconsistency of application and dependencies across different environments (Development, Testing, Staging, Production,etc) by sharing images known as docker images(exe file to extract to form container on another machine). 
     
   -  Docker uses Linux kernel to form lightweight,linux commands in **Linux container on Windows machines** using WSL2(Windows Subsystem for Linux), so Docker is lightweight and fast. 
          
        
        Syntax:
    
              ```terminal
                    wsl --install                   //Install WSL required components for linux environment 
                     
                    wsl -version   or   wsl  -v     //Check WSL version    

              ```

   - Docker uses Hyper-V to form **Windows container on Windows machines**.
     

   ### DockerImage and DockerContainer  

   Examples of Common Docker Commands require Docker Engine installed and running:    

   1. Create Container from sample ubuntu dockerimage locally in machine/globally from dockerhub global/public images, then download and run interactively.
        Syntax:
         
    
        - **Pull DockerImage from DockerHub in Local Machine**:
    
              ```terminal
                    docker pull <image_name>     or  docker pull <image_id_>
              ``` 
        
            Pull DockerImage based on tag of image:
              ```terminal
                    docker pull <image_name>:<tag>          // Pull dockerimage based on image_name with tag 
              ```

    
        - **Run Container using DockerImage**:
    
              ```terminal
                    docker run -it <image_name>     or  docker run -it <image_id_>          // -it stands for interactive terminal
              ```

           By default all containers are in attached mode.

            - To make it detached mode use -d flag
              ```terminal
                    docker run -d <image_name>                                              // -d stands for detached mode
              ```

            -  To make it detached mode with environment variable.
              ```terminal
                    docker run -d -e "ENV_VAR_NAME=value" <image_name>                      // -d stands for detached mode, -e stands for environment variable
              ```

            - To create custom name container in detached mode
              ```terminal
                    docker run -d --name mycontainer <image_name>                          // -d stands for detached mode, --name stands for custom name of container
              ```


        - **Keep Container running till Terminal is not exit/closed**:
    
              ```terminal
                    docker run -it --rm ubuntu          // --rm stands for remove container after exit
              ```
        - **Run Container with custom name**:
    
              ```terminal
                    docker run -it --name myubuntu ubuntu          // --name assign custom name to container
              ```
                

   2. List all containers
        Syntax:
         Only Running Containers:
    
              ```terminal
                    docker ps                                     // ps- for container, images- for dockerimages  
              ```         All Containers (Running and Stopped):                  ```terminal                    docker ps -a     docker images -a             // ps- for container, images- for dockerimages and  -a stands for all container/images based on cmd              ```    
   

   3. Delete a specific 
   
        Syntax:
        
        - Container :
    
              ```terminal
                    docker rm <container_id>          // rm- Remove container, container_id can be find by docker ps -a command
              ```
             
             Forcefull delete
       
              ```terminal
                    docker rm -f <container_id>       // rm-remove, -f - forceful delete, container_id can be find by docker ps -a command
              ```   
                
        - DockerImage : DockerImage cannot be deleted until and unless its all containers are deleted which are created from that DockerImage.
    
              ```terminal
                    docker rmi <image_id>             // rmi - Remove image, image_id can be find by docker images command
              ```
              
             Forcefull delete
       
              ```terminal
                    docker rmi -f <image_id>          // rmi- remove image, -f - forceful delete, image_id can be find by docker images command
              ```
        
   4. See OS type of DockerImage e.g Linux amd64/linux  or Windows  adm64/windows  
   
        Syntax:
    
              ```terminal
                    docker image inspect <image_id>          // image_id can be find by docker images command
              ```
         


   - **DockerImage** is made up of Layers from Base Laye,Layer1,Layer2,...Container to form final DockerImage.

     - Base Layer is lightweight OS layer such as Ubuntu,Alpine,Linux etc. 
     - Base Layer and sub-sequennt layers are read-only layers.
     - Container Layer is topmost read-write layer where application and its dependencies are installed.


  5. Binding/Mapping port of container
    
     Syntax:
        
        ```terminal
              docker run -d -p <host_port>:<container_port> <image_name>          // -d stands for detached mode, -p stands for port binding, host-port is port of local machine, container_port is port of container
        ```

       If need to change host port of running container then
         -  First stop the container 
         -  Remove the container
         -  Again create container with with change host port number
 
  6.  Docker Troubleshooting Commands
   - To see logs of container
    
        Syntax:
    
              ```terminal
                    docker logs <container_id>          // container_id can be find by docker ps -a command
              ```
     
   - To see real-time stats of container such as CPU,Memory,Network I/O etc.
    
        Syntax:
    
              ```terminal
                    docker stats <container_id>          // container_id can be find by docker ps -a command
              ```
     
   - To run extra bash/shell commands inside running container by accessing container's terminal bash or shell commands such as e.g. ls - for listing files,env - view environment variables,ping - check network connectivity,etc.
    
        Syntax:
    
              ```terminal
                    docker exec -it <container_id> /bin/bash		  // -it stands for interactive terminal, container_id can be find by docker ps -a command
              ```
       If bash terminal is not present in container then use sh shell
              ```terminal
                    docker exec -it <container_id> /bin/sh		  // -it stands for interactive terminal, container_id can be find by docker ps -a command
              ```

 
        
 ### Docker Network(Virtual Environment)

   - When No Port Binding Is Binding to Container, then Docker creates its own virtual network environment to communicate between containers directly and local machine.

   #### Docker Command Line :

   1. To see list of all docker networks
        Syntax:
    
              ```terminal
                    docker network ls          
              ```
   
   2. To create custom docker network
        Syntax:
    
              ```terminal
                    docker network create <network_name>          
              ```
  
   3. To remove custom docker network
        Syntax:
    
              ```terminal
                    docker network rm <network_name>          
              ```

   Note:-  To use multiple commands on creating docker container such as port binding,environment variable,custom name,detached mode etc use all commands together in single docker run command.
        
   Syntax:
    
              ```terminal
                    docker run -d -p <host_port>:<container_port> -e "ENV_VAR_NAME=value" --name mycontainer <image_name>          
              ```

   0R   Use \ at end of each line to continue command in next line for better readability.

   - List  wsl 
           Syntax:
                   ```terminal
                        wsl -l -v          // -l for list, -v for version
                   ``` 
   - To Install and enable WSL2 Ubuntu Linux on Windows by enabling "Turn Windows features on or off"  by checking option as  "Windows Subsystem for Linux" & "Hyper-V"  
                  ```terminal
                        wsl --install
                  ``` 
   - After installing WSL2 Ubuntu Linux on Windows, then enable WSL Integration from settings in docker-desktop application enable Ubuntu option and apply & restart docker-desktop application.
  
   - In docker desktop application terminal run below command after anove setup as
                 ```terminal
                        wsl -l -v                                                 // -l for list, -v for version         
                        wsl --set-default <wsl_name_>          // set default wsl_name  Ubuntu from list to enable actual linux environment
                 ```   
     Same can be run in windows powershell terminal also.
   
     Split create container command with multiple setup commands by \ at end of each command instead of 1 line command both works similar but for better undersatand and readable.
              
              ```terminal
                    docker run -d \
                    -p <host_port>:<container_port> \
                    -e "ENV_VAR_NAME=value" \
                    --name mycontainer \
                    <image_name>          
              ```

   e.g 
             ```terminal
                    docker run -d \
                    > -p 27017:27017 \
                    > -e MONGO_INITDB_ROOT_USERNAME=admin \
                    > -e MONGO_INITDB_ROOT_PASSWORD=qwerty \
                    > --name localcn_mongo \
                    > --network mongo_docker_nw \
                    > mongo
             ```

             ```terminal
                    docker run -d  \
                    > -p8081:8081 \
                    > --name <container_customname_mongoexpress> \
                    > --network <network_id> \
                    > -e ME_CONFIG_MONGODB_ADMINUSERNAME=admin \
                    > -e ME_CONFIG_MONGODB_ADMINPASSWORD=qwerty \
                    > -e ME_CONFIG_MONGODB_URL="mongodb://admin:qwerty@<container_customname_mongo>:27017" \
                    > mongo-express
             ```   
   
   #### Docker Compose Tool Command Line:

   Is is a tool to easily manage commands to create containers if its is multiple like in above example we create mongo and mongo-express container through docker command line.
   Which is little bit complex and need to edit it take time and little difficult to modify and maintain if required in future changes.

   So we create .yaml file(Yet Another Markup Language) which stored this docker commands in structure and more understandable way.Can be change if required in future.

   In such as way a below

       ```yaml
             version:"3.8"

                services:
                  localcn_mongo:                                                                                                                                             //customer name of container for mongo db app
                        image:mongo                                                                                                                                          //dockerimage
                        ports:
                            - 27017:27017                                                                                                                                     //binding machine_port:host_port
                        environment:
                            MONGO_INITDB_ROOT_USERNAME: admin                                                                                    //db root/default username 
                            MONGO_INITDB_ROOT_PASSWORD: qwerty                                                                                   //db root/default password
    
    
                  localcn_mongoexp:                                                                                                                                      //customer name of container for mongo express db UI app
                        image:mongo-express                                                                                                                            //dockerimage
                        ports:
                            - 8081:8081                                                                                                                                         //binding machine_port:host_port
                        environment:       
                            ME_CONFIG_MONGODB_ADMINUSERNAME: admin                                                                      //db UI root/default username 
                            ME_CONFIG_MONGODB_ADMINPASSWORD: qwerty                                                                     //db UI  root/default password
                            ME_CONFIG_MONGODB_URL: mongodb://admin:qwerty@localcn_mongo:27017/                   //mapping mongodb in mongo express UI for graphical access to db
      ```


   This file is then execute by Docker Compose tool.

   Docker Compose commands:-

   - Create container defined in .yaml. (up - is to create container)
        Syntax:
   
            ```terminal
                    docker compose -f <file.yaml> up -d                                        // -f for file, up- action to create container
            ```
   - Delete container defined in .yaml. (up - is to create container)
        Syntax:
   
           ```terminal
                     docker compose -f <file.yaml> down                                     // -f for file, down- action to delete container
           ```

   - If you are building image using dockerfile and using that dockerfile in docker-compose to club that image in single network

        1. First built docker-compose yaml file 
            Syntax:
   
            ```terminal
                    docker compose -f <file.yaml> build                                        // -f for file , build -to first build and create local image of local app before pulling
            ```
        2. Then create single container using same docker-compose.yaml file using up action
            Syntax:
   
            ```terminal
                    docker compose -f <file.yaml> up -d                                        // -f for file , up -to pull  local and docker hub image and club all image require for application form single container
            ```
   No need to add command to create multiple container in same network which is done while creating container through terminal.

   .YAML file automatically create containers under same network which is mention in file.

   #### Docker Network Type (Bridge,host,null):

   1. Bridge :- When any network is created its default DRIVER type is bridge and when we include multiple containers in the same network then multiple container with same network
       communicate through bridge.

   2. Host :- When no docker network is created then when container is created it uses host network which exist by default

   ### Dockerization (Forming DockerImage of Local App)

   Means converting application from DockerImage and then into Docker Container is call dockerizing the application using steps/commands written in Dockerfile.

   **Imp Dockerfile instruction**

   - **FROM** :-  Required base image for e.g. For .Net application required by default .net sdk install on machine, For NodeJS application required by default Node install on machine.
   - **WORKDIR** :- Means futher below command is execute in mention directory e.g. /src    further below command get execute and result/files generated inside /src folder.
   - **COPY** :- Means copy file from physical project where dockerfile is created to folder path provided by creating the folder as per path.
   - **RUN** :-   Means after copy of all dependencies and files then run commands in sequence such as restore,build,publish. Multiple RUN cmds in dockerfile.
   - **CMD** :-  Only single CMD command in dockerfile, which indicate how to dockerimage gets executes by this command.
   - **EXPOSE** :- Port assign to DockerImage
   - **ENV** :-  Environment variable which are required by application which is wrapped as DockerImage.

   E.g:- Dockerfile instruction to build NodeJS app

   ```dockerfile

            FROM node

            ENV MONGO_DB_USERNAME=admin \
                    MONGO_DB_PASSWORD=qwerty 

            RUN mkdir -p testapp                                                                      //-p stands for parent directory

            WORKDIR testapp

            COPY . .

            RUN rm -rf node_modules                                                           //statement is optional if you ignore through .dockerignore file _

            RUN npm install            

            CMD ["node", "/testapp/server.js"]


   ```

   - Docker cmd to build  above dockerfile to create dockerimage
        Syntax:-
            ```terminal
                    docker build -t <image_name>:<tag> .                                     // -t is TAG assign to dockerimage name testapp with tag is version 
            ```
               

   ### Uploading Above Created DockerImage Onto DockerHub (Sharing and global access of DockerImage to form DockerContainer)

   - First need login access to DockerHub site https://hub.docker.com

   - After login in My Profile --> Repository --> Create New Repository

   Then using created Repository to push all dockerimages into respository commands
  
   - Then logout of docker-desktop throught terminal.
         
        Syntax:-
            ```terminal
                        docker logout
            ```
   - Again login of docker-desktop throught terminal.
         
        Syntax:-
            ```terminal
                        docker login
            ```

  - Before pushing desktop-docker image in docker-hub repo assign tag to desktop-docker  image with docker-hub repo name
  
       Syntax:-
            ```terminal
                        docker tag <image_name>:<tag> <repo_name>:<repo_tag>
            ```
  
  - Then push above created image with assign rep_name with repo_tag from docker desktop to docker hub.
   
       Syntax:-
            ```terminal
                        docker push  <repo_name>:<repo_tag>
            ```

  - Successfully push into docker hub which is seen in Genral or Tag  then no need of local application 
     we can pull image and create container work inside container bash.

       Syntax:-
            ```terminal
                        docker pull <repo_name>:<repo_tag>
            ```

   ### Docker Volumes

   - Persistence of data even after restart or delete of container. 
   - Data can be retrieved by docker throught vulumes created.
   - Sharing of volume among containers
   
  **Commands**

  1. Bind Mount:- To data folder in container is map to physical folder on local disk as volume which preserves data when docker container is stop,restart,delete.
   
  
        Syntax:-             
             ```terminal
                    docker run -v <host_local_disk_path> : <container_data_folder>              // -v stands on local disk 
             ```

  2. List volumes
  
        Syntax:-             
             ```terminal
                    docker volume ls   
             ```

  3. Create named volume throught CLI command

        Syntax:-             
             ```terminal
                    docker volume create <volume_name>
             ```

      Volume created path:-
     - Windows :-     C:\ProgramData\docker\volumes
     - macOS/LinuxOS :-         /var/lib/docker/volumes

  4. Remove named volume thought CLI command using volume_name

        Syntax:-             
             ```terminal
                    docker volume rm <volume_name>
             ```

  5. Named Volume:- Map container data folder with named volume based on volume_name

        Syntax:-             
             ```terminal
                    docker run -v  <named_volume> : <container_data_folder> 
             ```
  
  6.  To create Anonymous Volumes
   
        Syntax:-             
             ```terminal
                    docker run -v  <mount_path>                                       // mount_path - is a container_data_folder
             ```

       - To delete anonymous volumes(unknown volumes)
       
         Syntax:-             
             ```terminal
                    docker volume prune                                       // prune - means delete unknown volumes
             ```