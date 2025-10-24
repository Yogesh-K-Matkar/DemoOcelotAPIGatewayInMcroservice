

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

   ## SOLID Principles
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
    
 