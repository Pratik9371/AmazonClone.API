dotnet ef migrations add AmazonClone-InitialCommit --context ApplicationDbContext -o Data/Migrations --project ..\AmazonClone.DbContexts
dotnet ef database update AmazonClone-InitialCommit --context ApplicationDbContext

dotnet ef migrations add AddedUserTable --context ApplicationDbContext -o Data/Migrations --project ..\AmazonClone.DbContexts
dotnet ef database update AddedUserTable  --context ApplicationDbContext