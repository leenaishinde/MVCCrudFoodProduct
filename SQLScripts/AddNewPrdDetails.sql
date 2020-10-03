USE [MvcCRUDDB]
GO
/****** Object:  StoredProcedure [dbo].[GetEmployees]    Script Date: 10/2/2020 4:38:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[AddNewPrdDetails]  
(  
	@Product_Name  varchar(100),
	@Category_Name varchar(100),
	@Product_Description varchar(200),
	@Additional_Info varchar(200),
	@Price int
)  
as  
begin  
   Insert into Prd_Master values(@Product_Name,@Category_Name,@Product_Description,@Additional_Info,@Price)  
End 