# 🧠 REST API Basics

## ✅ What is a REST API?

REST (Representational State Transfer) is an architectural style for designing web services.  
It allows systems to communicate over HTTP using standardized, stateless operations.

---

## 🔑 3 Key Principles of REST

1. **Statelessness**  
   - Each request contains all the information needed — the server does **not** store any session data.
   
2. **Resource-Based URIs**  
   - Everything is treated as a resource and identified by a URI (e.g., `/users/123`).

3. **Use of Standard HTTP Methods**  
   - `GET` → retrieve data  
   - `POST` → create new resource  
   - `PUT` → update resource  
   - `DELETE` → remove resource

---

## 🗂️ Notes App API Example

GET     /notes           → list all notes
GET     /notes/123       → fetch note #123
POST    /notes           → create a new note
PUT     /notes/123       → update entire note
PATCH   /notes/123       → update part of note
DELETE  /notes/123       → delete note


---

## 💬 Sample JSON

### ➕ POST `/notes`
```json
{
  "title": "My Note",
  "content": "This is a note created via REST API"
}

--
## Flow Diagram

Client → HTTP Request → API Server → DB → Response



| Code | Meaning               | When to Use                        |
| ---- | --------------------- | ---------------------------------- |
| 200  | OK                    | Request succeeded (GET/PUT/DELETE) |
| 201  | Created               | After successful POST              |
| 204  | No Content            | Success but no data returned       |
| 400  | Bad Request           | Invalid input from client          |
| 401  | Unauthorized          | Missing or bad auth token          |
| 403  | Forbidden             | You’re not allowed                 |
| 404  | Not Found             | Resource doesn’t exist             |
| 500  | Internal Server Error | Server crashed, bad code           |


## 🧠 Key Concepts in REST

### 🔹 Statelessness
- Every request is independent.
- No session or user state is stored on the server.
- All necessary data must be in each request.

### 🔹 Idempotency
- Making the same request multiple times results in the same effect.
- GET, PUT, DELETE = idempotent  
- POST = not idempotent

### 🔹 Caching
- Improves performance by storing previous responses.
- Controlled via headers like:
  - `Cache-Control`
  - `ETag`
  - `Last-Modified`

### 🔹 Versioning
- Keep backward compatibility by versioning APIs.
- Example: `/api/v1/notes`  
- Alternatives: version in URL, headers, or query param.

### 🔹 Pagination
- Limit large responses using pages.
- Example:  
  `GET /notes?page=2&limit=20`




  # 🧪 REST vs SOAP – Full Comparison

---

## 📖 Overview

| Feature                | REST                                      | SOAP                                         |
|------------------------|-------------------------------------------|-----------------------------------------------|
| **Full Form**          | Representational State Transfer           | Simple Object Access Protocol                 |
| **Type**               | Architectural style (uses HTTP)           | Strict protocol (uses XML + WSDL)             |
| **Format**             | JSON, XML, or plain text                  | **XML only**                                  |
| **Transport**          | HTTP only                                 | HTTP, SMTP, TCP, etc.                         |
| **Performance**        | ✅ Lightweight, faster                    | ❌ Heavy (XML parsing, strict structure)      |
| **Flexibility**        | ✅ Flexible, less strict                  | ❌ Rigid, strict schema                        |
| **Standardization**    | Loose (no formal spec)                    | Strict (uses WSDL for service contracts)       |
| **Security**           | OAuth2, HTTPS, tokens (manually handled)  | WS-Security (built-in security features)       |
| **Error Handling**     | HTTP status codes                         | Uses structured **SOAP Fault** messages       |
| **Testing Tools**      | Postman, curl, browser                    | Special tools (SoapUI, WSDL clients)           |
| **Best Used For**      | Web APIs, mobile apps, microservices      | Enterprise apps, banking, legacy systems       |

---

## 💡 Real-World Analogy

| Concept           | REST                                  | SOAP                                  |
|-------------------|----------------------------------------|----------------------------------------|
| Document Style    | A postcard (light, quick, simple)      | A notarized legal document (heavy, strict) |

---

## 📦 Sample Example

### 🔹 REST

```http
GET /users/123
Accept: application/json

---Json----

{
  "id": 123,
  "name": "Akshay"
}

-----SOAP---

<soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/"
                  xmlns:web="http://webservice.example.com/">
   <soapenv:Header/>
   <soapenv:Body>
      <web:GetUser>
         <web:UserId>123</web:UserId>
      </web:GetUser>
   </soapenv:Body>
</soapenv:Envelope>


| Use REST when:                            | Use SOAP when:                                  |
| ----------------------------------------- | ----------------------------------------------- |
| Speed, simplicity, and format flexibility | Strong contracts, built-in security, legacy B2B |
| Building web/mobile apps                  | Working with banking, enterprise, or telecom    |



# 🚀 Advanced REST API Concepts

---

## 🔐 Authentication vs Authorization

| Term              | Meaning                                      |
|-------------------|----------------------------------------------|
| **Authentication**| Verifying identity (e.g., login)             |
| **Authorization** | Verifying access rights (e.g., is admin?)    |

---

## 🔑 Common Authentication Methods

| Method          | Use Case                        |
|------------------|---------------------------------|
| **Basic Auth**    | Dev/testing only               |
| **API Key**       | Internal/low-security systems  |
| **OAuth2**        | 3rd-party login (e.g., Google) |
| **JWT (JSON Web Token)** | Modern stateless auth   |

### 📌 JWT in a Nutshell

- After login, server sends a JWT token
- Client includes this token in every request header:

```http
Authorization: Bearer <token>
 
* Server verifies token for each request (stateless)
* Payload can include user ID, role, expiry, etc.