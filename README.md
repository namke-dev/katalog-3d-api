# katalog-3d-api

dotnet ef migrations add InitialCreate --context KatalogContext
dotnet ef database update --context DataContext

# Sync schema when update model

dotnet ef migrations add FixTableRelationship --context KatalogContext
dotnet ef database update --context KatalogContext
