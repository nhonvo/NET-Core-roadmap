## step to reproduce the optimistic concurrency
0. restore the library(dotnet restore)
1. update the SQL connection in DbContext [AppDbContext](DemoConcurrency/AppDbContext.cs)
2. apply the migration to create database
3. create 1 Customer object with Wallet = 0
4. query that customer & modify the Wallet but NOT call save change immidiate(put the break-point before save change)
5. using SQL update value on Wallet column
6. Save change & concurrency exception with throw