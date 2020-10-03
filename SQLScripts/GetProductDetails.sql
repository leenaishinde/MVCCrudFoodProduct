USE [MvcCRUDDB]
GO
/****** Object:  StoredProcedure [dbo].[GetEmployees]    Script Date: 10/2/2020 4:38:23 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[GetProductDetails]  
as  
begin  
   select * from Prd_Master  
End 