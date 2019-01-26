-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[InsertNewOrder]
	-- Add the parameters for the stored procedure here
	@bill_id int,
	@product_id int,
	@serialNumber int,
	@goodsDescription text,
	@Qtl decimal(18, 2),
	@Pkg decimal(18, 2),
	@weight decimal(18, 2),
	@ratePerQtl decimal(18, 2),
	@amount decimal(18, 2)
AS
BEGIN
INSERT INTO tbl_orders(bill_id, product_id, serialNumber, goodsDescription, Qtl, Pkg, weight, ratePerQtl, amount)

Values (@bill_id, @product_id, @serialNumber, @goodsDescription, @Qtl, @Pkg, @weight, @ratePerQtl, @amount)
END
