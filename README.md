"# AmazonClone.API" 
dotnet ef migrations add UserProductCartTableAdded --context ApplicationDbContext -o Data/Migrations --project ..\AmazonClone.DbContexts
dotnet ef database update UserProductCartTableAdded  --context ApplicationDbContext










