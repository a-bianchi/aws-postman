<p align="center">
	<a href="https://github.com/Linusar/aws-postman"  target="_blank">
	<img  align="center"  alt="pineapple"  src="https://raw.githubusercontent.com/Linusar/aws-postman/public/imag/pineapple2.png"  />
	</a>
</p>
<h1 align="center">Welcome to dotnet api Aws Ses 👋</h1>
<p>
  <img alt="Version" src="https://img.shields.io/badge/version-0.1.0-blue.svg?cacheSeconds=2592000" />
</p>

> Dotnet Core 3 api AWS-POSTMAN

## Packages

### Core

- AWSSDK.Core
- AWSSDK.SimpleEmail
- AWSSDK.Extensions.NETCore.Setup
- Swashbuckle.AspNetCore
- Microsoft.AspNetCore.Mvc.NewtonsoftJson
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools

## Started

Clone the repo and make it yours:

```bash
git clone --depth 1 https://github.com/Linusar/aws-postman
cd aws-postman
rm -rf .git
```

## Install

```sh
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.AspNetCore.Mvc.NewtonsoftJson
dotnet add package Swashbuckle.AspNetCore
dotnet add package AWSSDK.Core
dotnet add packageAWSSDK.SimpleEmail
```

## ConnectionStrings appsettings.json

```sh
"ConnectionStrings":
{

"DefaultConnection": "Server=IPSQLSERVER;Database=NAMEDB;User Id=USERDB;password=PASSWORDDB;Trusted_Connection=False;MultipleActiveResultSets=true;"

}
```

## Migration

```sh
dotnet ef database update
```

## Aws Credentials

**Linux o macOS**

```sh
$ ls  ~/.aws
```

**Windows**

```sh
C:\>dir"%UserProfile%\.aws"
```

Create file
**`~/.aws/credentials`**

```
[default]
aws_access_key_id=AKIAIOSFODNN7EXAMPLE
aws_secret_access_key=wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY
```

## Usage

```sh
dotnet run
```

## Build

```sh
dotnet build
```

## Run unit tests

```sh

```

## Author

👤 **Alejo Bianchi <alejobianchi@gmail.com>**

- Twitter: [@Alejo40740246](https://twitter.com/Alejo40740246)
- Github: [@Linusar](https://github.com/Linusar)
