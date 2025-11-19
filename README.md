# TollSphereAdmin — Project Template

Arohan Infocare — TollSphere Admin template (MIT)

**Overview**

TollSphereAdmin is a starter template implementing Clean Architecture for .NET with a Blazor front-end and modern infrastructure patterns:
- Blazor (server or WASM + hosted) + MudBlazor components
- MediatR, Entity Framework Core
- SignalR for realtime/notifications
- Docker + docker-compose for local dev
- Template config for scaffolding new projects

## Features
- Clean Architecture project layout (Application / Domain / Infrastructure / Web/UI)
- Docker compose sample for local stacks
- Sample environment file (`sample.env`) for secrets & config placeholders
- Example tests structure
- Code scanning and CI-ready configuration (recommended)

## Prerequisites
- .NET 10 SDK (or the SDK pinned in the repo)
- Docker & Docker Compose (for running the sample stack)
- Git

## Quickstart (local, non-docker)
1. Clone the repository:
   ```bash
   git clone https://github.com/Arohan-Infocare-TollSphere/TollSphereAdmin.git
   cd TollSphereAdmin
