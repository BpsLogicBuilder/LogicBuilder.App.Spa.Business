# LogicBuilder.App.Spa.Business

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