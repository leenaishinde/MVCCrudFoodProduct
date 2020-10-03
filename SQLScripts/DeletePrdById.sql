USE [MvcCRUDDB]
GO
/****** Object:  StoredProcedure [dbo].[DeletePrdById]    Script Date: 10/2/2020 4:38:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create procedure [dbo].[DeletePrdById]  
(  
   @Id int  
)  
as   
begin  
   Delete from Prd_Master where Id=@Id  
End 