pushd Repository\StreamFile.Repository
dotnet ef migrations add stream-file-test -v --context AppDbContext
dotnet ef database update -v --context AppDbContext
popd