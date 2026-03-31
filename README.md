---
sidebar_position: 2
---
**Tech Culture**, and **Tooling** as focus areas to drive this change.  The Carbon Aware SDK at its core sits firmly in the **Tooling** pillar, and also supports the other pillars, providing **Knowledge** through emissions data to inform change, and being core enabler for the **Tech Culture** for building carbon aware software.

Carbon Aware SDK

Carbon-aware software optimizes when and where it runs based on the carbon intensity of electricity—doing more when energy is clean, and less when it is carbon-intensive.

The Carbon Aware SDK is a toolkit that enables developers to measure, understand, and reduce the carbon emissions of their software systems.

🌍 Why Carbon Awareness Matters

Electricity is generated from a mix of sources:

High-emission (e.g., fossil fuels)
Low-emission (e.g., wind, solar)

By aligning compute workloads with cleaner energy availability, organizations can significantly reduce emissions.

With the Carbon Aware SDK, you can:
Train AI/ML models when emissions are lowest
Deploy workloads in regions with cleaner energy
Schedule jobs during low-carbon time windows
Simulate and evaluate emissions reduction strategies
🚀 What Is the Carbon Aware SDK?

At its core, the SDK provides:

Web API – for centralized, scalable deployments
Command Line Interface (CLI) – for local, scripting, and legacy workflows

Both interfaces provide identical functionality, enabling you to:

Retrieve carbon intensity data
Integrate emissions insights into your applications
Automate greener decision-making
🧠 How It Works

The SDK integrates with external carbon data providers and abstracts their differences.

This allows your application to:

Query carbon intensity by time and location
Optimize execution for lower emissions
Track and report sustainability metrics
⚙️ Key Features
🌐 Flexible Integration
Works with multiple carbon data providers
Decouples your application from provider-specific APIs
📊 Standardized Data
Normalizes emissions data to gCO₂/kWh
Handles unit conversions automatically
🔐 Centralized Management
Manage API keys and secrets securely
Update providers without changing application code
📈 Auditability & Compliance
Track when and why decisions were made
Support regulatory and sustainability reporting
🔄 Aggregated Data Sources (Roadmap)
Combine multiple providers for better regional accuracy
Integrate internal data (e.g., private data centers)
☁️ Deployment Options
Web API
Ideal for enterprise environments
Centralized control and governance
Deployable as a container
CLI
Lightweight and easy to integrate
Useful for:
DevOps pipelines
Legacy systems
Local experimentation
🤖 Real-World Impact

Organizations such as UBS and Vestas are already using the SDK to reduce emissions.

Example:

Shifting ML workloads in time → up to 15% reduction
Shifting location → up to 50%+ reduction
🔍 Why Not Use Data Providers Directly?

While tools like WattTime or ElectricityMaps provide carbon data, the SDK adds:

Abstraction layer (no vendor lock-in)
Data aggregation across providers
Centralized governance and auditing
Standardized outputs
Easier integration into applications
🏗️ Role in Green Software

The SDK is part of the Green Software Foundation’s vision and supports three pillars:

Knowledge – provides emissions data
Tooling – enables carbon-aware development
Tech Culture – encourages sustainable engineering practices
📌 Limitations
Energy mix data (e.g., % solar, wind) is not currently available
Data quality depends on underlying providers
🤝 Contributing

We welcome contributions from the community!

To get started:

Review the contribution guidelines
Explore open issues
Submit improvements or new features
🌐 Project Background

The Carbon Aware SDK is part of the Green Software Foundation (GSF) and its Open Source Working Group.

It aims to create:

A standardized API for carbon awareness
A flexible, provider-agnostic architecture
A foundation for future sustainable software tooling
👥 Maintainers & Contributors

This project is a global collaborative effort.

Core contributors include:

Vaughan Knight (Microsoft) – Project Lead
Sophie Trinder – Green Software Foundation
Szymon Duchniewicz (Avanade)
Dan Benitah (Avanade)
Bill DeRusha (Microsoft)
Yasumasa Suenaga (NTT Data)
Damien Roux (NTT Data)

…and many more contributors across the community.

🎯 Summary

The Carbon Aware SDK enables developers to:

Build sustainable, carbon-aware applications
Reduce emissions through data-driven decisions
Integrate sustainability into modern software engineering
