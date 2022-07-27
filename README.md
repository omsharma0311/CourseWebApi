# CourseWebApi
Web API with GET,PUT,POST,DELETE Operatios.Swagger and DTO are also Implemenation

API Contracts
*************************************
READ ALL COURSE
TYPE GET
REQUEST URL https://localhost:<PORTNO>/api/courses/GetAll

RESPONSE BODY
                [
                   {
                        "courseID":int,
                        "courseName":"string",
                        "courseCode":"string",
                        "courseRating":double
                    },
                    {
                        "courseID":int,
                        "courseName":"string",
                        "courseCode":"string",
                        "courseRating":double
                    }
                ]
RESPONSES 200


******************************************

READ COURSE BY ID
TYPE GET
REQUEST URL https://localhost:<PORTNO>/api/courses/{id}
            https://localhost:<PORTNO>/api/courses/1
REQUEST BODY
               {
                   "courseId":int
               }
RESPONSE BODY
               {
                   "courseID":int,
                   "courseName":"string",
                   "courseCode":"string",
                   "courseRating":double
               }
RESPONSES 200

******************************************
CREATE COURSE
TYPE POST
REQUEST URL https://localhost:<PORTNO>/api/courses
REQUEST BODY
               {
                   "courseName":"string",
                   "courseCode":"string",
                   "courseRating":double
               }
RESPONSE BODY
               {
                   "courseID":int,
                   "courseName":"string",
                   "courseCode":"string",
                   "courseRating":double
               }
RESPONSES 200


****************************************
EDIT COURSE
TYPE PUT
REQUEST URL https://localhost:<PORTNO>/api/courses/{id}
            https://localhost:<PORTNO>/api/courses/3
RESPONSE BODY
               {
                   "courseName":"string",
                   "courseCode":"string",
                   "courseRating":double
               }
RESPONSES 200

****************************************
DELETE COURSE
TYPE DELETE
REQUEST URL https://localhost:<PORTNO>/api/courses/{id}
            https://localhost:<PORTNO>/api/courses/3
RESPONSE BODY
RESPONSES 200
