My intention was 
- to create a TopProducts branch off the master
- commit my work to this branch
- create a Pull Request for code review prior to being able to merge to the master branch


This file lists aspects that were out of scope for the following reasons
- Unable to implement
- Not implemented because of time constraints
- Out of scope given requirements

1) Unable to implement
- EF Core with InMemory provider
  - Unable to map and seed the link table required to map the M:M relationship between Products and Simulators
  - Hard coded initial 30 data items in ProductRepository
    - Will return min 10 for fsx, fsxe and p3dv? simulators
    - Returns a smaller number of msfs, afs2 and xp11 simulators

2) Not implemented because of time constraints
- Connecting to json file
  - Used the hard coded ProductRepository so that I could provide Angular data
  - IProductRepository method includes skip and take parameters as a basis for possible pagination

    List<Product> GetTopProductsForSimulator(
    string simulator, string sortField, string sortOrder, int skipItems, int takeItems);

- MediatR for CQRS and query handler in the Application project
  - Thinner API controllers that delegate to the MediatR handlers
    - Inject IProductRepository into the query handler and not the API Controller
    - Return a Result object wrapper from handlers to API controller 
      to communicate return Http Status Code
- Ordering by selected field and sort order (Asc/ Desc)
  - Initial sort details in appsettings.Development.json
  - Dynamically create IQueryable expression tree for passed sort field and order parameters
    - https://github.com/StephenJSmith/JobAdder    (recruitment programming assignmnet)
      - an example of Generic repository and specification pattern that could be implemented
  - Clicking on Angular table header column to select sort field 
    - initial sort order will be ascending
    - subsequent click on same headler column will toggle to descending
    - visual indicator to show currently sorted column and if Asc/ Desc.
  - NO Angular style framework installed
    - minimal styling and formatting
    - Styling framework table components have sort field controls for showing and specifying column sort
  - Send sort field and sort order Angular service parameters as query parameters

3) Out of scope given requirements
- http only
- Identity - Authentication
- Validation
- Common error and exception handling
  - Server Side and Client Side
- Logging
- Unit testing - both C# and Angular
- Angular stand alone components
- Hard coded API endpoints url into Angular service
- Drop down list of selectable Simulators in place of typing it in on Angular form
- Swagger endpoint definitions


To start the application
1. Server runs on port localhost:5000
   >cd API
   >dotnet run

2. Angular client runs on port localhost:4200
   >cd client
   >npm start

3. Go to browser tab 
   >localhost:4200
