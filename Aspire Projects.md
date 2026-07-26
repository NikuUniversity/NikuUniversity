# Niku University

# Awesome .NET Aspire Projects

A curated, honest list of real open-source projects, tools, and samples built around **.NET Aspire** — Microsoft's cloud-ready stack for building observable, production-ready distributed applications.

> **Note on scope:** .NET Aspire reached GA in May 2024, so the open-source ecosystem around it is still young. This list favors quality and legitimacy over quantity — every entry below is a real, actively referenced repository. It is **not** padded to hit a round number with low-star or abandoned repos.

## Table of Contents

- [Core Framework](#core-framework)
- [Reference Apps & Samples](#reference-apps--samples)
- [Microservices & Architecture Showcases](#microservices--architecture-showcases)
- [Community Toolkits & Extensions](#community-toolkits--extensions)
- [Tooling](#tooling)
- [Learning Resources](#learning-resources)
- [Contributing](#contributing)
- [License](#license)

## Core Framework

| Project | Repository | Description |
|---|---|---|
| .NET Aspire | [dotnet/aspire](https://github.com/dotnet/aspire) | Official Microsoft repo — the Aspire app host, dashboard, service discovery, integrations, and CLI/project templates. |

## Reference Apps & Samples

| Project | Repository | Description |
|---|---|---|
| Aspire Samples | [microsoft/aspire-samples](https://github.com/microsoft/aspire-samples) | Official multi-language sample apps (C#, JS/TS, Python, Go) covering AI, databases, containers, and observability scenarios. |
| eShop | [dotnet/eShop](https://github.com/dotnet/eShop) | Microsoft's flagship reference e-commerce microservices application, built on Aspire. |
| Practical .NET Aspire | [thangchung/practical-dotnet-aspire](https://github.com/thangchung/practical-dotnet-aspire) | Coffeeshop-domain sample demonstrating DDD and clean architecture with Aspire. |
| eShopSupport | [dotnet/eShopSupport](https://github.com/dotnet/eShopSupport) | Official reference app using AI for a customer support ticketing system, built on Aspire. |
| eShopOnAzure | [Azure-Samples/eShopOnAzure](https://github.com/Azure-Samples/eShopOnAzure) | Variant of `dotnet/eShop` wired up to run on Azure services. |
| eShopLite | [Azure-Samples/eShopLite](https://github.com/Azure-Samples/eShopLite) | Lightweight eCommerce reference apps showcasing semantic search, MCP, and reasoning models. |
| eShop App Workshop | [dotnet-presentations/eshop-app-workshop](https://github.com/dotnet-presentations/eshop-app-workshop) | Teaches ASP.NET Core & Aspire by building the eShop catalog and order-placement features. |
| Azure Samples ("*-aspire" repos) | [Azure-Samples](https://github.com/Azure-Samples) | Multiple official Azure + Aspire integration samples — search "aspire" within the org. |

## Microservices & Architecture Showcases

| Project | Repository | Description |
|---|---|---|
| BookWorm | [foxminchan/BookWorm](https://github.com/foxminchan/BookWorm) | Practical implementation of .NET Aspire using a full microservices architecture. |
| CoolShop | [foxminchan/CoolShop](https://github.com/foxminchan/CoolShop) | Cloud-native e-commerce app combining Dapr and Aspire across independent services (catalog, cart, orders, inventory, etc.). |
| DaprWithAspire | [SiddyHub/DaprWithAspire](https://github.com/SiddyHub/DaprWithAspire) | Dapr-ized eShop sample using the .NET 8 Aspire template for service discovery, telemetry, and resilience. |
| aspire-dapr | [rineshpk/aspire-dapr](https://github.com/rineshpk/aspire-dapr) | Minimal microservices sample pairing .NET Aspire with Dapr sidecars and Podman. |
| aspir8-from-scratch | [devkimchi/aspir8-from-scratch](https://github.com/devkimchi/aspir8-from-scratch) | Walkthrough repo for deploying Aspire-flavored apps to Kubernetes via Aspirate. |

## Community Toolkits & Extensions

| Project | Repository | Description |
|---|---|---|
| Aspire Community Toolkit | [CommunityToolkit/Aspire](https://github.com/CommunityToolkit/Aspire) | Community-maintained extra hosting integrations for databases, services, and more. |

## Tooling

| Project | Repository | Description |
|---|---|---|
| Aspire Plugin for Rider | [JetBrains/aspire-plugin](https://github.com/JetBrains/aspire-plugin) | Official JetBrains Rider IDE plugin for .NET Aspire. |
| AspireRunner | [SaifAqqad/AspireRunner](https://github.com/SaifAqqad/AspireRunner) | Standalone runner for the Aspire dashboard, outside of `dotnet run`. |
| Aspirate | [prom3theu5/aspirational-manifests](https://prom3theu5.github.io/aspirational-manifests/getting-started.html) | Generates Kubernetes deployment YAML from an Aspire AppHost project. |

## Learning Resources

| Project | Repository | Description |
|---|---|---|
| .NET Aspire Workshop | [dotnet-presentations/dotnet-aspire-workshop](https://github.com/dotnet-presentations/dotnet-aspire-workshop) | Official "Let's Learn .NET" hands-on Aspire workshop, with slides and starter project. |
| Let's Learn .NET Aspire | [jorgearteiro/letslearn-dotnet-aspire](https://github.com/jorgearteiro/letslearn-dotnet-aspire) | Community-run workshop material, broken into 6 modules. |

## Notes on "Ratings"

GitHub star counts are the closest proxy for community trust here, but note:

- The official `dotnet/aspire` and `dotnet/eShop` repos have by far the most traction.
- Most community projects in this space currently sit in the tens-to-low-hundreds of stars — the ecosystem is still maturing.
- Dapr + Aspire microservices demos (BookWorm, CoolShop, DaprWithAspire, aspire-dapr) are individually maintained and vary in activity level — check the "last commit" date before relying on one as a production starting point.
- Beyond this list, GitHub's [`dotnet-aspire`](https://github.com/topics/dotnet-aspire) and [`aspire`](https://github.com/topics/aspire) topic pages have dozens more repositories, but most are individual learning experiments rather than production-quality, actively maintained projects.

## Contributing

Found a legitimate, actively maintained .NET Aspire project that belongs here? Open a pull request adding it to the relevant table above, following the existing format: `| Project Name | [org/repo](link) | One-line description |`

## License

This list is provided as-is for informational purposes, compiled from publicly available GitHub data as of July 2026.
