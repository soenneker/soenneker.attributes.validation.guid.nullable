[![](https://img.shields.io/nuget/v/soenneker.attributes.validation.guid.nullable.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.attributes.validation.guid.nullable/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.attributes.validation.guid.nullable/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.attributes.validation.guid.nullable/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.attributes.validation.guid.nullable.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.attributes.validation.guid.nullable/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.attributes.validation.guid.nullable/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.attributes.validation.guid.nullable/actions/workflows/codeql.yml)

# Soenneker.Attributes.Validation.Guid.Nullable

A validation attribute that ensures a nullable string is a valid, nullable GUID. If this value is not null, checks to make sure the GUID can be parsed. If the value is null, this passes.

## Install

```bash
dotnet add package Soenneker.Attributes.Validation.Guid.Nullable
```

## Quick start

```csharp
using Soenneker.Attributes.Validation.Guid.Nullable;

public sealed class Request
{
    [NullableGuidValidation]
    public string? Value { get; init; }
}
```

A validation attribute that ensures a nullable string is a valid, nullable GUID. If this value is not null, checks to make sure the GUID can be parsed. If the value is null, this passes.

## What you get

- `NullableGuidValidationAttribute` — A validation attribute that ensures a nullable string is a valid, nullable GUID. If this value is not null, checks to make sure the GUID can be parsed. If the value is null, this passes.
