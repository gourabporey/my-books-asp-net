## Books Management Web API

---

### Dev setup

#### Microsoft SQL Server Setup for Mac

**STEP-1**: Start a colima instance for x86 architecture

```sh
colima start default --arch x86_64 --cpu 4 --memory 4 --disk 20 --vm-type=vz
```

**STEP-2** : Pull the microsoft sql server image

```sh
docker pull mcr.microsoft.com/mssql/server:2022-latest
```

**STEP-3**: Run the docker container in background

```sh
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=NrnC50%u" \
   -p 1433:1433 --name sql1 --hostname sql1 \
   -d \
   mcr.microsoft.com/mssql/server:2022-latest
```

**STEP-4**: Update the Connection String

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnectionString": "Server=localhost,1433;Database=master;User Id=sa;Password=NrnC50%u;Encrypt=True;TrustServerCertificate=True;"
  }
}
```

**STEP-5**: Update the database with migration

```sh
dotnet ef database update
```
