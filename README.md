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
cd ProjectName
```
Compile and run the project.

```bash
dotnet run
```

## Usage
You can use an API client (e.g., Postman) to test the API.

To retrieve all staff members with a GET request:
```bash
GET https://localhost:5001/api/staff
```

To retrieve a specific staff member by ID with a GET request:
```bash
GET https://localhost:5001/api/staff/{id}
```


To add a new staff member with a POST request:
```bash
POST https://localhost:5001/api/staff
Content-Type: application/json

{
  "firstName": Ela
  "lastName": "Kascioglu",
  "email": "elaksc@example.com",
  "phone": "5554443333",
  "dateOfBirth": "1999-01-01",
  "addressLine1": "Deneme",
  "city": "Istanbul",
  "country": "Turkey",
  "province": "string"
}
```

To update a staff member with a PUT request:
```bash

PUT https://localhost:5001/api/staff/{id}
Content-Type: application/json
{
  "firstName": Ela
  "lastName": "Kascioglu",
  "email": "elaksc@example.com",
  "phone": "5554443333",
  "dateOfBirth": "1999-01-01",
  "addressLine1": "Deneme",
  "city": "Istanbul",
  "country": "Turkey",
  "province": "string"
}
```

To delete a staff member with a DELETE request:
```bash
DELETE https://localhost:5001/api/staff/{id}
```


## Contributing
If you have any issues, errors, or suggestions, please open an issue or contribute by submitting a pull request.

- Fork this project and create a local copy.
- Create a separate branch for new features or fixes.
- Make your changes and test your code.
- Commit your changes and push to your branch.
- Propose your changes to the main project by opening a pull request.
















