# Inventory Management System

## Before Running 
1. Make sure to run `db_ims.sql` file for database.
2. Then create a `appsettings.json` file inside the `Utilities` folder to store database credentials to connect it to system.
3. Add the following code in the `appsettings.json` file:
```json
,
  "DatabaseSettings": {
    "uid": "DATABASE.UID",
    "pwd": "DATABASE.PASSWORD",
    "server": "DATABASE.SERVER",
    "database": "db_ims"
  }
```
4. Replace the values of the variables to your own.
## Features
1.

## Recently Done
1. Created instructions before running in `readme.md` file.
2. Able to Update Employee Information
3. Able to Move Employee to Archive
4. Able to get only active employee in main employee table.


5. Get Recent Remarks to Restore
6. Added Remarks to Archived Employees Table
7. Change form name to restore employee
8. Refresh archived employees table after 

## Plans
1. Create Dashboard or `Home` section
2. Fix `SearchBar.cs` user control to adapt with tablelayoutpanel.
3. Replace 15 in `LIMIT {0}, 15` with `{1}` or `maximum` in `GenericTable.cs`, add `int maximum` in functions.
4. 

## Colors
* rgb(107, 105, 115) or #6b6973 `lightgrey`
* rgb(44, 42, 55) or #2c2a37 `darkblue` 
* rgb(107, 105, 115) 

## Later
* Go tracking
* Misc Categories
* RDLC Reports
* Loading Function
* Help or Tutorial Function

## Cant
* Create subform when double clicking a logs cell that showcases logs content when content is longer.
