# Three-Layer-Web-App

### STEP 1 : Create ASP.Net web application

open visual studio –> File menu –>New –>Website

### STEP 2 : Design the default.aspx page  to regisrate

### STEP 3 : Create New Database in SQL 

Create a database in sql server named “SmartUserData”, and create a table “UserMsk” in newly created sql database.

- Create UserMsk Table

```text
ID (PK, int, not null)
Username (nvarchar(50), null)
UserType (nvarchar(50), null)
Address (nvarchar(50), null)
ProducedEnergy (nvarchar(50), null)
ConsumedEnergy (nvarchar(50), null)
 ```

- Create Procedure

```sql
USE [SmartUserData]
GO
/****** Object:  StoredProcedure [dbo].[USERMSK_SELECT]    Script Date: 7.08.2022 16:13:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[USERMSK_SELECT]
	@Username AS NVARCHAR(256),
    @Usertype AS NVARCHAR(256),
    @Address AS NVARCHAR(256),
    @ProducedEnergy AS NVARCHAR(256),
	@ConsumedEnergy AS NVARCHAR(256)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM UserMsk

END

```

### STEP 4 :  Create new class Library for Data Access Layer

### STEP 5 : Connection with DataSet using Different connection method

### STEP 6 : write code in Data Access Layer

### STEP 7 : Create Business Logic Layer (BLL)
![image](https://github.com/ynccsyd/Three-Layer-Web-App/assets/109158340/cff9eeae-7ea3-4af0-b9a6-f5551a36c2a0)


[if you need more information]( https://meeraacademy.com/3-tier-architecture-example-in-asp-net-c/ )
