[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-24ddc0f5d75046c5622901739e7c5dd533143b0c8e959d652212380cedb1ea36.svg)](https://classroom.github.com/a/iGZu94G3)
# aw2

Asagida verilen modeli kullanarak GetAll, GetById , Put , Post , Delete methodlarini icen bir controller implement ediniz. 

EF ile generic repository ve UnitOfWork kullanabilirsiniz.

Put  ve Post apilerin de model validation hazirlayiniz.  Fluent validation kullaniniz. 

Extra olarak 2 tane alana gore (Query parameter) filtreleme yapan Filter apisi ekleyiniz (GET) ve WHERE sarti ile database den filtreleme yapiniz. 

Generic Repository uzerinde Where sartini implement ediniz. 

SOLID e uymaya ozen gosteriniz . 

Proje icerisinde sadece odev ile ilgili kisimlara yer veriniz. Kullanilmayan controller ve methodlari gondermeyiniz. Yorum satiri gondermeyininiz.

Model icin initial migration dosyasini ekleyiniz. 

Readme file uzerinde nasil calisacagina dair gerekli aciklamalara yer veriniz. 

Email alanini unique olmalidir. 

```
  public class Staff  
    { 
        public int Id { get; set; } 
        public string CreatedBy { get; set; } 
        public DateTime CreatedAt { get; set; } 
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public string Email { get; set; } 
        public string Phone { get; set; } 
        public DateTime DateOfBirth { get; set; } 
        public string AddressLine1 { get; set; } 
        public string City { get; set; } 
        public string Country { get; set; } 
        public string Province { get; set; } 
        [NotMapped] 
        public string FullName 
        { 
            get { return FirstName + " " + LastName; } 
        } 
    }
```

--------
--------
--------
--------

# SimpraApi-W2

This project contains an API for managing Staff data.

### Installation

Clone this repository to your local machine or download and extract the zip file.

```bash
git clone https://github.com/P259-Simpra-NET-Bootcamp/aw2-elaksc.git
```
Navigate to the project folder.

```bash
cd aw2-elaksc
```
Compile and run the project.

```bash
dotnet run
```

## Usage
You can use an API client (e.g., Postman) to test the API.

- To retrieve all staff members with a GET request:
```bash
GET https://localhost:7113/api/staff
```

- To retrieve a specific staff member by ID with a GET request:
```bash
GET https://localhost:7113/api/staff/{id}
```


- To add a new staff member with a POST request:
```
POST https://localhost:7113/api/staff
Content-Type: application/json

Successful Response (201 Created):
```
```bash
{
  "id": 1,
  "createdBy": "string",
  "createdAt": "2023-05-12",
  "firstName": "Ela",
  "lastName": "Kascioglu",
  "email": "elakasci@gmail.com",
  "phone": "5551234567",
  "dateOfBirth": "1990-01-01",
  "addressLine1": "Bagdat St",
  "city": "Istanbul",
  "country": "Turkey",
  "province": "string",
  "fullName": "Ela Kascioglu"
}

```
- To update a staff member with a PUT request:
```
PUT https://localhost:7113/api/staff/{id}
Content-Type: application/json
Example Json Payload:
```
```bash
{
  "id": 15,
  "createdBy": "string",
  "createdAt": "2023-05-12",
  "firstName": "Ela",
  "lastName": "Kascioglu",
  "email": "elakasci@gmail.com",
  "phone": "5551234567",
  "dateOfBirth": "1990-01-01",
  "addressLine1": "Bagdat St",
  "city": "Istanbul",
  "country": "Turkey",
  "province": "string"
}
```

- To delete a staff member with a DELETE request:
```bash
DELETE https://localhost:7113/api/staff/{id}
```


- To filter staff members based on specific criteria, you can use the following endpoint:
```bash
GET https://localhost:7113/api/staff/filter?firstName={firstName}&city={city}

`firstName`: Filter staff members by their first name.
`city` : Filter staff members by their city.
```
#### Example

To filter staff members by first name and city, make a GET request to the filter endpoint with the desired parameters:
```bash
GET https://localhost:7113/api/staff/filter?firstName=Ela&city=Istanbul
```

##### Successful Response (200 OK)

The API will respond with a list of staff members that match the provided filter criteria:

```bash
[
  {
    "id": 1,
    "createdBy": "string",
    "createdAt": "2023-05-12",
    "firstName": "Ela",
    "lastName": "Kascioglu",
    "email": "elakasci@gmail.com",
    "phone": "5551234567",
    "dateOfBirth": "1990-01-01",
    "addressLine1": "Bagdat St",
    "city": "Istanbul",
    "country": "Turkey",
    "province": "string",
    "fullName": "Ela Kascioglu"
  },
  ...
]

```

If no matching staff members are found, an empty array will be returned.
Note: The filter endpoint supports filtering by both firstName and city, but you can modify the code to include additional filter criteria as needed.





## Contributing
If you have any issues, errors, or suggestions, please open an issue or contribute by submitting a pull request.

- Fork this project and create a local copy.
- Create a separate branch for new features or fixes.
- Make your changes and test your code.
- Commit your changes and push to your branch.
- Propose your changes to the main project by opening a pull request.
















