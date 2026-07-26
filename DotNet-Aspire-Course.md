# Niku University

# .NET Aspire Complete Course 🚀
### with Docker, Kubernetes & Azure

A complete, hands-on course for learning **.NET Aspire** — Microsoft's cloud-native application stack — and deploying real-world distributed applications using **Docker**, **Kubernetes**, and **Azure**.

## 📌 About This Course

.NET Aspire simplifies building observable, production-ready, distributed applications. This course takes you from the fundamentals of Aspire's app model all the way to containerizing, orchestrating, and deploying a full microservices solution to the cloud.

## 🎯 What You'll Learn

- Building cloud-native apps with the .NET Aspire app model
- Service discovery, orchestration, and telemetry in Aspire
- Working with Aspire integrations (databases, caching, messaging)
- Containerizing .NET apps with Docker
- Orchestrating containers with Kubernetes (K8s)
- Deploying and managing workloads on Azure (AKS, Container Apps, ACR)
- CI/CD pipelines for cloud-native .NET applications
- Observability: logging, metrics, and distributed tracing

## ✅ Prerequisites

| Requirement | Notes |
|---|---|
| C# fundamentals | Classes, OOP, async/await |
| Basic ASP.NET Core knowledge | Web API or MVC experience helpful |
| Command line basics | Familiarity with terminal/PowerShell |
| Azure account | Free tier is sufficient for most modules |
| Docker Desktop installed | Required from Module 3 onward |

## 🛠️ Tools & Technologies Used

| Tool | Purpose |
|---|---|
| .NET 8 / .NET 9 SDK | Core development framework |
| .NET Aspire Workload | Cloud-native app model & orchestration |
| Visual Studio / VS Code | IDE |
| Docker Desktop | Containerization |
| kubectl | Kubernetes CLI |
| Minikube / Kind | Local Kubernetes cluster |
| Azure CLI | Azure resource management |
| Azure Kubernetes Service (AKS) | Managed Kubernetes in the cloud |
| Azure Container Registry (ACR) | Container image storage |
| Azure Container Apps | Serverless container hosting |
| GitHub Actions | CI/CD pipeline |

## 📚 Course Curriculum

| Module | Title | Topics Covered | Duration |
|---|---|---|---|
| 1 | Introduction to .NET Aspire | What is Aspire, cloud-native concepts, Aspire vs traditional ASP.NET Core | 1 hr |
| 2 | Setting Up Your Environment | Installing SDKs, Aspire workload, project templates | 1 hr |
| 3 | The Aspire App Model | AppHost project, ServiceDefaults, resource references | 2 hrs |
| 4 | Service Discovery & Orchestration | Connecting multiple services, environment variables, endpoints | 2 hrs |
| 5 | Aspire Integrations | PostgreSQL, Redis, RabbitMQ, MongoDB integrations | 2.5 hrs |
| 6 | Observability with Aspire | OpenTelemetry, structured logging, metrics, distributed tracing | 2 hrs |
| 7 | The Aspire Dashboard | Monitoring resources, logs, traces, and health checks locally | 1 hr |
| 8 | Docker Fundamentals | Images, containers, Dockerfile basics, Docker Compose | 2 hrs |
| 9 | Containerizing .NET Aspire Apps | Multi-stage builds, optimizing .NET container images | 2 hrs |
| 10 | Docker Networking & Volumes | Container communication, persistent storage | 1.5 hrs |
| 11 | Introduction to Kubernetes | Pods, Deployments, Services, ConfigMaps, Secrets | 2.5 hrs |
| 12 | Running Aspire Apps on Kubernetes | Aspire manifest generation, `kubectl apply`, Helm basics | 3 hrs |
| 13 | Kubernetes Networking & Ingress | Ingress controllers, load balancing, service types | 2 hrs |
| 14 | Scaling & Health Checks in K8s | HPA (Horizontal Pod Autoscaler), liveness/readiness probes | 2 hrs |
| 15 | Introduction to Azure for .NET Devs | Azure fundamentals, resource groups, Azure CLI | 1.5 hrs |
| 16 | Azure Container Registry (ACR) | Pushing and managing container images | 1 hr |
| 17 | Deploying to Azure Container Apps | Simplified container hosting, revisions, scaling rules | 2.5 hrs |
| 18 | Deploying to Azure Kubernetes Service (AKS) | Cluster setup, deploying Aspire workloads to AKS | 3 hrs |
| 19 | Secrets & Configuration Management | Azure Key Vault, K8s Secrets, environment-specific config | 1.5 hrs |
| 20 | CI/CD with GitHub Actions | Automated build, test, containerize, and deploy pipeline | 2.5 hrs |
| 21 | Monitoring in Production | Azure Monitor, Application Insights, log analytics | 2 hrs |
| 22 | Final Project | End-to-end microservices app: Aspire → Docker → AKS → Azure | 4 hrs |

**Total Estimated Duration:** ~40 hours

## 🧩 Final Project Overview

Build and deploy a multi-service e-commerce style application including:

| Component | Description |
|---|---|
| API Service | ASP.NET Core Web API with Aspire integration |
| Worker Service | Background processing with message queue |
| Database | PostgreSQL via Aspire integration |
| Caching | Redis for session/data caching |
| Frontend | Blazor or React client |
| Deployment | Containerized with Docker, deployed to AKS |
| Observability | Full tracing/logging via Aspire Dashboard + Azure Monitor |

## 📂 Repository Structure

```
dotnet-aspire-complete-course/
├── modules/
│   ├── 01-introduction/
│   ├── 02-environment-setup/
│   ├── 03-app-model/
│   ├── ...
│   └── 22-final-project/
├── docker/
│   └── Dockerfile examples per module
├── k8s/
│   └── manifests (Deployments, Services, Ingress)
├── azure/
│   └── ARM/Bicep templates, deployment scripts
├── .github/
│   └── workflows/ (CI/CD pipelines)
└── README.md
```

## 🚀 Getting Started

```bash
# Clone the repository
git clone https://github.com/your-username/dotnet-aspire-complete-course.git

# Install the .NET Aspire workload
dotnet workload install aspire

# Navigate to a module and run the AppHost project
cd modules/03-app-model/AppHost
dotnet run
```

## 📈 Progress Tracker

| Module | Status |
|---|---|
| 1–7: .NET Aspire Fundamentals | ⬜ Not Started |
| 8–10: Docker | ⬜ Not Started |
| 11–14: Kubernetes | ⬜ Not Started |
| 15–21: Azure Deployment & CI/CD | ⬜ Not Started |
| 22: Final Project | ⬜ Not Started |

## 🤝 Contributing

Suggestions, corrections, and additional module ideas are welcome — feel free to open an issue or PR.

## 📄 License

This project is open source and available under the [MIT License](LICENSE).
