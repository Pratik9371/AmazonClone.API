"# AmazonClone.API" 
dotnet ef migrations add UserProductCartTableAdded --context ApplicationDbContext -o Data/Migrations --project ..\AmazonClone.DbContexts
dotnet ef database update UserProductCartTableAdded  --context ApplicationDbContext

dotnet ef migrations add TotalColumnAddedInCart --context ApplicationDbContext -o Data/Migrations --project ..\AmazonClone.DbContexts
dotnet ef database update TotalColumnAddedInCart --context ApplicationDbContext

dotnet ef migrations add TotalColumnRemovedInCart --context ApplicationDbContext -o Data/Migrations --project ..\AmazonClone.DbContexts
dotnet ef database update TotalColumnRemovedInCart --context ApplicationDbContext

dotnet ef migrations add ProductDetailsTableAdded --context ApplicationDbContext -o Data/Migrations --project ..\AmazonClone.DbContexts
dotnet ef database update ProductDetailsTableAdded --context ApplicationDbContext

dotnet ef migrations add AddressAddedInUserTable --context ApplicationDbContext -o Data/Migrations --project ..\AmazonClone.DbContexts
dotnet ef database update AddressAddedInUserTable --context ApplicationDbContext

dotnet ef migrations add OrdersTableAdded --context ApplicationDbContext -o Data/Migrations --project ..\AmazonClone.DbContexts
dotnet ef database update OrdersTableAdded --context ApplicationDbContext

dotnet ef migrations add RemovedPriceFromOrderDetails --context ApplicationDbContext -o Data/Migrations --project ..\AmazonClone.DbContexts
dotnet ef database update RemovedPriceFromOrderDetails --context ApplicationDbContext

dotnet ef migrations add DroppedOrdersTable --context ApplicationDbContext -o Data/Migrations --project ..\AmazonClone.DbContexts
dotnet ef database update DroppedOrdersTable --context ApplicationDbContext

dotnet ef migrations add AddedOrdersTable --context ApplicationDbContext -o Data/Migrations --project ..\AmazonClone.DbContexts
dotnet ef database update AddedOrdersTable --context ApplicationDbContext

dotnet ef migrations add AddFKToOrders --context ApplicationDbContext -o Data/Migrations --project ..\AmazonClone.DbContexts
dotnet ef database update AddFKToOrders --context ApplicationDbContext

dotnet ef migrations add RemovedProductRefInOrderDetails --context ApplicationDbContext -o Data/Migrations --project ..\AmazonClone.DbContexts
dotnet ef database update RemovedProductRefInOrderDetails --context ApplicationDbContext











