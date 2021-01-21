<div align="center">

![Zeats](https://zeatsbalancaautomatica.blob.core.windows.net/icons/nuget.png)

</div>

# zeats-legacy-unit-of-work

Simple interface of UnitOfWork

[![Build Status](https://dev.azure.com/zeats/Legacy/_apis/build/status/zeats-legacy-unit-of-work?branchName=master)](https://dev.azure.com/zeats/Legacy/_build/latest?definitionId=36&branchName=master)
[![NuGet](https://img.shields.io/nuget/v/Zeats.Legacy.UnitOfWork.svg)](https://www.nuget.org/packages/Zeats.Legacy.UnitOfWork)

## Installation

```PM>
Install-Package Zeats.Legacy.UnitOfWork
```

### IUnitOfWork
IUnitOfWork interface
```c#
public interface IUnitOfWork : IDisposable
{
    void Commit();
}
```
---
