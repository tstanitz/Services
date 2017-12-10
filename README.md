# Services

## Version 1

Compares the difference when the Controller returns a JSON from object and the client Deserializes the JSON to object and when the GRPC server returns the GRPC object and the client uses the received object. 

**Rest API server(*api/v1/content*) steps:**

1. Receives content as JSON
2. Deserialize to C# object
3. Add server information to object
4. Returns a JSON from object

**Rest client steps:**

1. Receives content JSON from server
2. Deserialize to C# object
3. Display action name and ids

**GRPC server(GetContent_v1) steps:**

1. Receives content as JSON
2. Deserialize to C# object
3. Create GRPC object
4. Returns GRPC object

**GRPC client steps:**

1. Receives GRPC object
2. Display action name and ids