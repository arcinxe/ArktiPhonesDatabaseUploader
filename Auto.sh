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
    mariadb)
        echo "MariaDB"
         sed -i 's/\/\/\s*\.UseM/.UseM/' DeviceContext.cs
        ;;
    sqlite)
        echo "SQLite"
        sed -i 's/\/\/\s*\.UseSqli/.UseSqli/' DeviceContext.cs
        ;;
    esac
}

function wipeDatabase(){
    rm Migrations -r
    dotnet ef migrations add initial
    echo y | dotnet ef database drop
    dotnet ef database update
    sleep 10
}


start=`date`
echo "Script started"
echo $start

databases=("mssql" "oracle" "mariadb" "sqlite")
# selectDbContext $1
#shift
while test ${#} -gt 0
do
    for i in "${databases[@]}"; do
#echo $1
#echo $2
#echo $i
        selectDbContext $i
        wipeDatabase
        dotnet run $1 $i 1
        wipeDatabase
        dotnet run $1 $i 2
        wipeDatabase
        dotnet run $1 $i 3
        wipeDatabase
        dotnet run $1 $i 4
        wipeDatabase
        dotnet run $1 $i 5
    done
    shift
done
sleep 4
# end=`date`
# runtime=$((end-start))
#echo $runtime
# stop=`date`
echo "Script started at"
echo $start
echo "and finished at"
date
