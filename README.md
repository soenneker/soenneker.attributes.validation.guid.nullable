[![](https://img.shields.io/nuget/v/soenneker.attributes.validation.guid.nullable.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.attributes.validation.guid.nullable/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.attributes.validation.guid.nullable/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.attributes.validation.guid.nullable/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.attributes.validation.guid.nullable.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.attributes.validation.guid.nullable/)

# Soenneker.Attributes.Validation.Guid.Nullable

A DataAnnotations validator for an optional string that, when supplied, must contain a non-empty GUID.

## Installation

```bash
dotnet add package Soenneker.Attributes.Validation.Guid.Nullable
```

## Usage

```csharp
using Soenneker.Attributes.Validation.Guid.Nullable;

public sealed class SearchRequest
{
    [NullableGuidValidation]
    public string? OwnerId { get; init; }
}
```

The attribute participates in normal DataAnnotations and ASP.NET Core model validation.

## Validation rules

| Value | Result |
| --- | --- |
| `null` | Valid |
| A parseable, non-empty GUID string | Valid |
| Malformed or blank string | Invalid |
| `00000000-0000-0000-0000-000000000000` | Invalid |
| A non-string value | Invalid |

This validator treats only `null` as absent; an empty string is not a valid GUID. Use `Soenneker.Attributes.Validation.Guid` when the value is required.
