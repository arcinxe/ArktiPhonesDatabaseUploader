#!/bin/bash

function commentAll() {
    sed -i 's/^\s*\.UseO/ \/\/.UseO/; s/^\s*\.UseM/ \/\/.UseM/; s/^\s*\.UseSqlS/ \/\/.UseSqlS/; s/^\s*\.UseSqli/ \/\/.UseSqli/; ' DeviceContext.cs
}

function selectDbContext() {
    commentAll
    echo -ne "Selected "
    case $1 in
    oracle)
        echo "Oracle"
        sed -i 's/\/\/\s*\.UseO/.UseO/' DeviceContext.cs
        ;;
    mssql)
        echo "MS SQL Server"
        sed -i 's/\/\/\s*\.UseSqlS/.UseSqlS/' DeviceContext.cs
        ;;
    mysql)
        echo "MySql"
        sed -i 's/\/\/\s*\.UseM/.UseM/' DeviceContext.cs
        ;;
    sqlite)
        echo "SQLite"
        sed -i 's/\/\/\s*\.UseSqli/.UseSqli/' DeviceContext.cs
        ;;
    esac
}

databases=("mssql" "mysql" "sqlite") # "oracle"
# selectDbContext $1
for i in "${databases[@]}"; do
    selectDbContext $i
    rm Migrations -r
    dotnet ef migrations add initial
    echo y | dotnet ef database drop
    dotnet ef database update
    dotnet run $1 $i
done