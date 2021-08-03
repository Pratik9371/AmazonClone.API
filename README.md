"# AmazonClone.API" 
dotnet ef migrations add AmazonClone-InitialCommit --context ApplicationDbContext -o Data/Migrations --project ..\AmazonClone.DbContexts
dotnet ef database update AmazonClone-InitialCommit --context ApplicationDbContext

dotnet ef migrations add AddedUserTable --context ApplicationDbContext -o Data/Migrations --project ..\AmazonClone.DbContexts
dotnet ef database update AddedUserTable  --context ApplicationDbContext

dotnet ef migrations add RenamedUserTabletousersTable --context ApplicationDbContext -o Data/Migrations --project ..\AmazonClone.DbContexts
dotnet ef database update RenamedUserTabletousersTable --context ApplicationDbContext

dotnet ef migrations add AddedProductsTable --context ApplicationDbContext -o Data/Migrations --project ..\AmazonClone.DbContexts
dotnet ef database update AddedProductsTable --context ApplicationDbContext

dotnet ef migrations add ChangedTypeOfPrice --context ApplicationDbContext -o Data/Migrations --project ..\AmazonClone.DbContexts
dotnet ef database update ChangedTypeOfPrice --context ApplicationDbContext