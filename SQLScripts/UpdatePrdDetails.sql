USE [MvcCRUDDB]
GO

/****** Object:  StoredProcedure [dbo].[UpdatePrdDetails]    Script Date: 10/4/2020 1:37:15 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create procedure [dbo].[UpdatePrdDetails]  
(  
    @Id int,  
	@Product_Name  varchar(100),
	@Category_Name varchar(100),
	@Product_Description varchar(200),
	@Additional_Info varchar(200),
	@Price int
)  
as  
begin  
   Update Prd_Master   
   set Product_Name=@Product_Name,  
   Category_Name=@Category_Name,  
   Product_Description=@Product_Description,
   Additional_Info = @Additional_Info,
   Price = @Price
   where Id=@Id  
End 
GO


