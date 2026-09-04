# LogicBuilder.App.Spa.Business

[![CI](https://github.com/BpsLogicBuilder/LogicBuilder.App.Spa.Business/actions/workflows/ci.yml/badge.svg)](https://github.com/BpsLogicBuilder/LogicBuilder.App.Spa.Business/actions/workflows/ci.yml)
[![CodeQL](https://github.com/BpsLogicBuilder/LogicBuilder.App.Spa.Business/actions/workflows/github-code-scanning/codeql/badge.svg)](https://github.com/BpsLogicBuilder/LogicBuilder.App.Spa.Business/actions/workflows/github-code-scanning/codeql)
[![codecov](https://codecov.io/github/BpsLogicBuilder/LogicBuilder.App.Spa.Business/graph/badge.svg?token=IOIUGYRI8W)](https://codecov.io/github/BpsLogicBuilder/LogicBuilder.App.Spa.Business)
[![Quality gate status](https://sonarcloud.io/api/project_badges/measure?project=BpsLogicBuilder_LogicBuilder.App.Spa.Business&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=BpsLogicBuilder_LogicBuilder.App.Spa.Business)
[![NuGet](https://img.shields.io/nuget/v/LogicBuilder.App.Spa.Business.svg)](https://www.nuget.org/packages/LogicBuilder.App.Spa.Business)


`LogicBuilder.App.Spa.Business` defines the shared contracts used to exchange UI workflow state between a single-page application (SPA) and an API that hosts BPS Logic Builder-generated flows.

## Purpose

This library centralizes flow metadata models so both client and server can serialize and deserialize the same payload shapes during workflow execution.

## What it contains

- **Request models** (`Requests`)
  - `RequestBase` with concrete request types such as `DefaultRequest`, `GridRequest`, and `DetailRequest`
  - Command/navigation request payloads such as `CommandButtonRequest` and `NavBarRequest`
  - Transient flow request payloads such as `SelectorFlowRequest`

- **Response models** (`Responses.TransientFlows`)
  - `BaseFlowResponse` and concrete responses including `ErrorFlowResponse` and `SelectorFlowResponse`

- **Flow state and screen metadata** (`ScreenSettings`)
  - `FlowState` and `FlowSettings`
  - Screen/view contracts (`ScreenSettingsBase`, `ScreenSettings<TDialogSetting>`, `ViewType`, `ExceptionView`)
  - Navigation metadata (`NavigationBar`, `NavigationMenuItem`)

- **Flow cache contracts** (`Cache`)
  - `IFlowDataCache`, `FlowDataCache`, and `RequestedFlowStage`

## Serialization behavior

The library includes polymorphic JSON converter support for key base contracts:

- `RequestBase` via `RequestConverter`
- `ScreenSettingsBase` via `ScreenSettingsConverter`

This enables consistent JSON round-tripping of workflow metadata across SPA and API boundaries.