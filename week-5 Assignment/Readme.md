# Microservices Assignment - JWT & Kafka

This repository contains two assignments demonstrating microservice concepts in .NET. Each assignment highlights important topics like JWT Authentication and Kafka-based real-time messaging.

---

##  Assignment 1: JWT Authentication in ASP.NET Core Web API

### What is JWT?

**JSON Web Token (JWT)** is a compact and secure way of transmitting information between parties as a JSON object. It is widely used for authentication and authorization in web applications.

### How JWT Works:

1. A client sends credentials (username and password) to the API.
2. The API verifies credentials and returns a JWT token signed with a secret key.
3. The client includes the JWT in the Authorization header for future requests.
4. The API validates the JWT and grants/denies access based on claims.

### Implementation in ASP.NET Core:

* Configured JWT Authentication in `Program.cs` using `AddAuthentication()` and `AddJwtBearer()`.
* Added a login endpoint in `AuthController` that generates JWT tokens.
* Secured API endpoints with `[Authorize]` to restrict access to authenticated users.
* Used Swagger to test token generation and authorization.

### Key Features:

* Secret key-based signing for security.
* Token expiry to enforce session timeout.
* Claims support for role-based authorization.

---

## Assignment 2: Kafka-based Chat Application in .NET

### What is Apache Kafka?

Apache Kafka is a distributed streaming platform that acts as a message broker for real-time data pipelines. It uses a publish-subscribe model for high-throughput, fault-tolerant messaging.

###  Kafka Concepts:

* **Producers**: Send messages to Kafka topics.
* **Consumers**: Read messages from Kafka topics.
* **Topics**: Logical channels for organizing messages.
* **Partitions**: Sub-divisions of topics for parallel processing.
* **Brokers**: Kafka servers that store and serve messages.
* **Zookeeper**: Coordinates Kafka brokers in versions <3.x.

### Implementation in .NET:

* Created two separate console applications:

  * **Producer App**: Sends chat messages to a Kafka topic.
  * **Consumer App**: Listens to the Kafka topic and displays messages.
* Integrated Kafka using the `Confluent.Kafka` NuGet package.
* Kafka server and Zookeeper were set up locally for testing.

###  Demo Workflow:

1. Start Kafka and Zookeeper.
2. Run the Consumer App to listen to `chat-topic`.
3. Run the Producer App and type chat messages.
4. Observe real-time message streaming in the Consumer console.

---

##  Technologies Used

* ASP.NET Core 8 Web API
* JWT Authentication (Microsoft.AspNetCore.Authentication.JwtBearer)
* Apache Kafka 2.8.1 for Windows
* `Confluent.Kafka` library for .NET integration
* Swagger for API testing
* Postman for JWT verification

---

##  Summary

This project demonstrates:

* Securing APIs using JWT authentication and authorization.
* Building a Kafka-based real-time messaging system in .NET.

These are essential microservice patterns for building modern, scalable applications.
