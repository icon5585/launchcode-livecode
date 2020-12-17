using System;

/**
 * LC 101 - Unit 2 
 * Class 2.21
 * Chapter 22 - Introduction to web APIs & Rest
 * Hank DeDona
 * 12/17/20
 */
namespace Class_2._21
{
    class Lecture
    {
        static void Main(string[] args)
        {
            // 22.1 Web APIs
            // 22.1.1 MVC Without the V

            // Web APIs are MVC applications without the views, so basically just
            // Models & Controllers.

            // A web API interacts with, or is consumed by, a client application, such as a
            // web app, mobile app, or desktop app.

            // This process involves transferring data representations and instructions like creating,
            // reading, updating and deleting (CRUD).

            // 22.1.2 Responsibilities of a Web API
            // 22.1.2.1 Data Delivery

            // MVC: GET /events -> HTML with data
            // Web API: GET /events -> just data

            // So instead of delivering an entire page that can be rendered by a web browser, we
            // just return the data (as JSON or otherwise) to be consumed by a client (web app, mobile app, etc)

            // 22.1.2.3 Transference of Data
            //
            // 1) A request for data comes from a client application to the API.
            // 2) A controller file in the API catches the request.
            // 3) The controller determines if the request is valid.
            // 4) The controller transfers data from the database to an object, via the ORM.
            // 5) The controller transforms the object into a package the client application can work with.
            // 6) The controller responds to the client with the packaged data.

            // 22.1.3.2 Universal Representation
            // It is important to make sure your web APIs return data in a platform and language
            // agnostic fashion as you may not be aware of what your consumers clients are
            // written in.

            // The most common language for data representation in web APIs is JSON

            // 21.1.4 HTTP as The Language of Web APIs

            // Overview of HTTP
            // 1) Is a stateless request/ response protocol.
            // 2) Requests and responses may include HTTP bodies. HEAD requests don't
            // 3) Responses always contain a three digit HTTP status code.
            // 4) Requests and responses always include HTTP headers.

            // HTML response
            /* 
              <!DOCTYPE html>
                <html>
                   <head>
                      <title>My Web Page</title>
                      content
                   </head>
                   <body>
                      content
                   </body>
                </html>
             */

            // JSON response
            /*
              {
                   "title": "An Astronaut's Guide to Life on Earth",
                   "author": "Chris Hadfield",
                   "ISBN": 9780316253017,
                   "year_published": 2013,
                   "subject": ["Hadfield, Chris", "Astronauts", "Biography"],
                   "available": true
              }
             */

            // 22.1.4.2 Status Codes

            // 2XX	200, 201, 204	        request was successful
            // 3XX	301, 302	            request was redirected
            // 4XX	400, 401, 403, 404, 405 client error
            // 5XX	500, 502, 504	        server error

            // 22.1.5 API Design
            // Long story, short. As long as the server and client adhere to the
            // agreed upon contract, all should be well :)

            // 22.2 What is REST?
            // REpresentational State Transfer

            // A design paradigm for web services (APIs) built on top of HTTP
            // Adopting the REST specification into the design of an API provides
            // consistency during development and consumption.

            // 22.2.1 What is state?
            // Before creating: Empty state
            // After creating: Initial state
            // After updating: New state
            // After deleting: Empty state

            // 22.2.2 What is representation?
            // Representation refers to a depiction of state that is usable in a given context
            // How is this representation presented to your clients? Via HTTP responses
            // using mostly JSON.

            // 22.2.3 Transferring a Representation of State¶
            // It is up to the API to define the contract, or expose:

            // The types of state, or resources, the client can interact with
            // which(CRUD) interactions are supported for each resource.

            // 22.2.4 Resources
            // Entity: a single resource that is uniquely identifiable in a collection.
            // Collection: entities of the same resource type treated as a whole.

            // 22.3 REST: Practical Fundamentals
            // 22.3.1 Shapes example

            // If we had a POCO like such to represent a coding event:
            /*
                public class CodingEvent {
                    public int Id { get; set; }
                    public string Title { get; set; }
                    public string Description { get; set; }
                    public DateTime Date { get; set; }
                }
            */


            // And we created a REST API to retrieve a single coding event, the JSON
            // "schema" would look like this:

            /*
              CodingEvent {
                   Id: integer
                   Title: string
                   Description: string
                   Date: string (ISO 8601 date format)
               }
             */

            // An example response would look like this:
            /*
               {
                   "Id": 1,
                   "Title": "Halloween Hackathon!",
                   "Description": "A gathering of nerdy ghouls to work on GitHub Hacktoberfest contributions",
                   "Date": "2020-10-31"
               }
            */

            // 22.3.2 Endpoints
            // Paths are used to identify the resource being interacted with.

            // Resources & Paths
            // CodingEvent - /events
            // Tag - /tags

            // e.g. A GET request to /events, should return all of the events in a nice JSON
            // collection while a GET to /tags would return all of the tags.

            // 22.3.2.2 CRUD Operations & HTTP Methods

            // HTTP -> CRUD
            // POST -> Create
            // GET -> Read
            // PUT -> Update
            // DELETE -> Delete

            // If we wanted, for instance, to get a single event based on ID, we could
            // use the following path...

            // The generic path is /events/{codingEventId} and a specific event would look like /events/1234
            // This would return a single event based on ID 1234

            // 22.3.4.2 Headers
            // Common request/response headers used in REST services

            // Content-Type - The attached body has the following media type. e.g. application/json
            // Accept - The client expects the requested resource representation in the given media type. e.g. application/json
            // Location - The created resource representation can be found at the given URL value. e.g. /resources/{id}

            // There are a ton of resources and videos on API design and development that I would implore you to
            // seek out. This is only a high level overview of web APIs and REST.
        }
    }
}
