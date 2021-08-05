"# AmazonClone.API" 
dotnet ef migrations add UserProductCartTableAdded --context ApplicationDbContext -o Data/Migrations --project ..\AmazonClone.DbContexts
dotnet ef database update UserProductCartTableAdded  --context ApplicationDbContext

dotnet ef migrations add TotalColumnAddedInCart --context ApplicationDbContext -o Data/Migrations --project ..\AmazonClone.DbContexts
dotnet ef database update TotalColumnAddedInCart --context ApplicationDbContext

dotnet ef migrations add TotalColumnRemovedInCart --context ApplicationDbContext -o Data/Migrations --project ..\AmazonClone.DbContexts
dotnet ef database update TotalColumnRemovedInCart --context ApplicationDbContext










