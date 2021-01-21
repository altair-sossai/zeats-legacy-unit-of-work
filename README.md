<div align="center">

![Zeats](https://zeatsbalancaautomatica.blob.core.windows.net/icons/nuget.png)

</div>

# zeats-legacy-unit-of-work

Extensions to solve common problems when working with UnitOfWork

[![Build Status](https://dev.azure.com/zeats/Legacy/_apis/build/status/zeats-legacy-unit-of-work?branchName=master)](https://dev.azure.com/zeats/Legacy/_build/latest?definitionId=19&branchName=master)
[![NuGet](https://img.shields.io/nuget/v/Zeats.Legacy.UnitOfWork.svg)](https://www.nuget.org/packages/Zeats.Legacy.UnitOfWork)

## Installation

```PM>
Install-Package Zeats.Legacy.UnitOfWork
```

## Extensions

### IpValidator.IsIpV4(string unit-of-work)
Checks if the content of a string is a valid UnitOfWork V4
```c#
IpValidator.IsIpV4("10.a.30.40") /* return false */
IpValidator.IsIpV4("10.0.0.150") /* return true */
```
---
