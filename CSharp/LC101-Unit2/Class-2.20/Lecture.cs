/**
 * LC 101 - Unit 2 
 * Class 2.20
 * Chapter 21 - Authentication
 * Hank DeDona
 * 12/15/20
 */
namespace Class_2._20
{
    class Lecture
    {
        static void Main(string[] args)
        {
            // 21.1 Introduction to Authentication
            // Authentication is the process of determining a user’s identity. In other words,
            // are they who they say they are?

            // This is often confused with authorization, which is different. Authorization is
            // the process of determining if a user is allowed to carry out a specific action.

            // 21.1.1.2 Flow for Simple Authentication
            // Is the user asking for a restricted page?
            // If so, do we know who thay are (are they already authenticated)?
            // If not, redirect to login page and request authentication

            // 21.1.2.1 Sessions and Cookies
            // We use user state (via cookies or HTML 5 local storage) to determine session
            // state (or better put, who is currently authenticated).

            // More reading on cookies:
            // https://developer.mozilla.org/en-US/docs/Web/HTTP/Cookies

            // Cookies and sessions work together to enable simple authentication in the following way:

            // 1) When a user is authenticated—that is, they provide a valid username / password pair—a session containing their user
            // ID is created on the server. The session has a unique session ID, such as 81LfWG9.
            // 2) In order to associate the user with their session, the server creates a session cookie and returns the
            // cookie to the browser within an HTTP response.The session cookie contains the session ID, and looks something
            // like this: session_id: 81LfWG9.
            // 3) For each subsequent request to the server, the browser passes the session cookie along with the request.
            // 4) When the server receives a request for a restricted resource, it checks for a session cookie.It then looks for a
            // session with the given session ID.If such a session exists, then the server knows who the user is since their user ID
            // is stored in the session.If the session does NOT exist, then the server does not know the user and they must authenticate themselves.

            // Cookies (and therefore sessions) are used to determine if a user has access to restricted information.

            // 21.1.3 A Note On Authentication In ASP.NET
            // We will be using the Identity library as part of ASP.NET
            // More reading: https://docs.microsoft.com/en-us/aspnet/identity/overview/getting-started/introduction-to-aspnet-identity

            // Some things to note when using this library:
            // 1) Identity handles many aspects of the authentication process for you. This may hide steps that are important to
            // understand as you learn about authentication.
            // 2) Some of the inner workings of Identity are beyond the scope of this course.Do not fear when troubleshooting!
            // 3) Identity has lots of different configuration options and can handle complex authentication setups.

            // 21.2 Hashing Passwords
            // First and foremost, do NOT store clear-text passwords in a database! Ever!

            // 21.2.1 Two-Way Encryption
            // Allows for encrypting and decrypting the message via a shared key

            // 21.2.2 One-Way Encryption
            // Also known as hashing, encodes a message that *should* not be able to be decoded.

            // Good hashes have the following properties
            // 1) Deterministic: Encode the same message with the same hash should produce the same result
            // 2) Hard to reverse: You should not be able to decode a hashed value (i.e. it's one-way)
            // 3) Hash values are ALMOST unique: This basically says that two different messages shouldn't
            // produce the same hash. If they do, this is known as a collision and the offending hash algorithm
            // shouldn't be used for passwords.
            // 4) Similar messages have VERY different hashes: If you change a single letter in a message, the
            // entire hash should be VERY different, even though only one character changed.

            // 21.2.3 Password Verification with Hashes

            // Using secure hashing algorithms, we can store the HASH of the password rather than the password itself.
            // This allows us to take in a users password, calculate the hash and store the hash in the database.

            // Note: You should SALT your passwords before hashing them to prevent hackers

            // 21.3 Getting started with Identity
            // We will be using 3 NuGet packages with our Coding Events project, make sure to use 3.1.x versions!!

            // 1) Microsoft.AspNetCore.Identity.UI
            // 2) Microsoft.AspNetCore.Identity.EntityFrameworkCore
            // 3) Microsoft.EntityFrameworkCore.SqlServer

            // 21.3.1 Before You Start

            // 21.3.2 Scaffolding Identity in an Existing Project

            // 21.3.2.1 Adding Identity Through the Visual Studio UI
            // Right click on the project -> Add -> New Scaffolded Item (or New Scaffolding...)

            // 21.3.2.2 Adding Identity through the Command Line
            // NOTE: WE MUST SPECIFY THE VERSION SINCE IT WILL DEFAULT TO v5.x AND WE ARE USING .NET CORE 3.1!!!

            // dotnet tool install -g dotnet-aspnet-codegenerator --version 3.1.4
            // dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 3.1.4

            // To create the identity scaffolding using the EventDbContext we already have in our coding events project, we run the following:
            // dotnet aspnet-codegenerator identity --dbContext EventDbContext --files "Account.Register;Account.Login;Account.Logout;Account.RegisterConfirmation"

            // 21.3.2.3 DbContext

            // A new class IdentityHostingStartup.cs was created for us
            // Also a new directory Areas/Identity was created to handle our authentication/identity needs

            // In order to store the identity information in the database, we need to do a few things
            // 1) Delete the new EventDbContext in the Areas/Identity/Data directory that .NET created for us
            // 2) Update our existing EventDbContext to now extend IdentityDbContext<IdentityUser>
            // 2a) Add base.OnModelCreating(modelBuilder); to the OnModelCreating() method
            // 3) Update the location of the connection string in IdentityHostingStartup to DefaultConnection
            // 3a) Update the options.UseSqlServer to optoins.UseMySql

            // 21.3.2.4 Views
            // The _LoginPartial.cshtml contains a view that has links to the following:
            // Registration forms
            // Login forms
            // Sign out actions
            // etc.

            // The core conditional in this page is this: @if (SignInManager.IsSignedIn(IdentityUser))

            // This introduces two new classes called UserManager and SignInManager
            // UserManager - Deals with the user information in the database, such as usernames
            // SignInManager - Deals with users signing in and to determine if they are signed in

            // This partial view can be used anywhere with the <partial> tag, the easiest way to
            // implement it into our Coding Events project is to add it to our _Layout.cshtml
            // which is shared by all of our views automatically.

            // 21.3.2.5 Final Steps
            // In order to utilize the "scaffolding" we've laid out, we need to add a new
            // EntityFrameworkCore migration and update using the following commands:

            // dotnet ef migrations add AddIdentity
            // dotnet ef database update

            // After these commands are run (again), we will have a bunch of new identity tables
            // in our MySQL database including the following:

            // AspNetRoleClaims, AspNetRoles, AspNetUserClaims, AspNetUserLogins, AspNetUserRoles, AspNetUsers, ASpNetUserTokens

            // To test that we have everything successful, start your coding events proejct register a new account and
            // then query the AspNetUsers table to see the new account.

            // You should see something like this in your AspNetUsers table:
            // Username: hank@aol.com, EmailConfirmed: 1, PasswordHash: A12DSRFQASDFADSGFaedwsrf1243184 SecurityStamp...

            // 21.4 Registrations and Logins
            // These actions introduce the Task<?> class, which is the way .NET core does asynchronous
            // tasks, e.g. registering a user in the database.

            // Areas/Identity/Pages/Account the Register.cshtml.cs handles user registration
            // UserManager allows us to register the user in the database

            // Areas/Identity/Pages/Account the Login.cshtml.cs handles user logins
            // SignInManager allows us to authenticate (login) as user asynchronously through the PasswordSIgnInAsync() method,
            // this begins the session

            // Areas/Identity/Pages/Account the Logout.cshtml.cs handles user logouts
            // SignInManager allows us to logout the user asynchronously through the SignOutAsync() method, this ends the session

            // 21.5 Configuring Identity

            // 21.5.1 Startup.cs

            // 21.5.1.1 ConfigureServices()
            // We can configure the IdentityOptions to require passwords be 10 characters in length (along with other things) here.

            // 21.5.1.2 Configure()
            // We need to configure app.UseAuthentication(); in order to tell .NET core's middleware to require user authentication
            // and protect our web applications pages.

            // 21.6 Identity and Authorization
            // Authorization allows us to restrict access to pages to only logged in users. 

            // ASP.NET has two simple attributes that will allow us to restrict access to pages to only logged in users.
            // [Authorize] - Limits access to content to onlyh logged in users, can be used on method or whole controller
            // [AllowAnonymous] - Allows any viewer to access content, note that this is the default.

            // For our coding events project, we will add the [Authorize] attribute to the whole controller, but allow
            // all users to view the events (the get on index) via the [AllowAnonymous] attribute.

            // When you run your project, you should be able to go to "All Events" and see the events, however,
            // when you click on "Add Event" it will prompt you to login :)
        }
    }
}
