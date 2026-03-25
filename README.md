# 🚀 Job Tracker API (.NET 10)

A RESTful Web API built using ASP.NET Core and Entity Framework Core to manage job applications.

---

## 🛠️ Tech Stack

* ASP.NET Core Web API (.NET 10)
* Entity Framework Core (Code First)
* SQL Server
* Repository Pattern
* Swagger (Swashbuckle)

---

## 📌 Features

* Create, update, delete job applications
* Track job status (Applied, Interview, Offer, Rejected)
* Clean architecture using Repository Pattern
* DTO-based request/response handling
* Swagger UI for API testing

---

## 📂 Project Structure

* Controllers → API endpoints
* Repositories → Data access logic
* Models → Database entities
* DTOs → Request/Response models
* Data → DbContext

---

## 🚀 How to Run

1. Clone the repo
2. Update connection string in `appsettings.json`
3. Run migration:

```
dotnet ef database update
```

4. Run project:

```
dotnet run
```

5. Open Swagger:

```
http://localhost:xxxx/swagger
```

---

## 📸 API Preview
<img width="1828" height="560" alt="image" src="https://github.com/user-attachments/assets/c365b53f-e979-4bd2-a926-de98b0fab8d0" />

(Add Swagger screenshot here later)

---

## 💡 Future Enhancements

* JWT Authentication
* Role-based authorization
* Pagination & filtering
* Deployment to Azure

---

## 👩‍💻 Author

Smriti Singh
