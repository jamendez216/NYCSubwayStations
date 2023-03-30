# NYCSubwayStations
## Description
The app would be built using RESTful API principles, which would allow it to be easily consumed by a wide range of clients, including web and mobile applications. The API would expose endpoints for calculating distances between subway stations and for registering favorite stations.
## Distance calcualtion
The distance calculation endpoint would accept two parameters, the start and end subway station IDs, and would return the distance in miles between the two stations. The endpoint would utilize a database of subway station locations and calculate the distance using a geospatial algorithm, such as the Haversine formula.
## Favorite station
The favorite station registration endpoint would allow users to register their favorite subway stations by submitting the station ID and a user ID as parameters. The endpoint would store this information in a database and allow users to retrieve their favorite stations at a later time.
## Security
The API would be secured using JWT, to ensure that only authorized users can access the endpoints. The API would also be scalable and highly available, with load balancing and caching mechanisms in place to handle high volumes of traffic.
## Summary
Overall, the app would provide a useful service to NYC subway commuters by allowing them to quickly calculate the distance between subway stations and register their favorite stations for easy access.
