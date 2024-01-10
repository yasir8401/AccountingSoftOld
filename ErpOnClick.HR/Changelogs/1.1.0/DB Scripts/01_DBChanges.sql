--First Verion of File--
--Dated: 16 Aug 2021 --
--Author: Yasir Nisar--

--------------------------------------------------------
/****** Object: Adding Constraint on [AUTH].[USERS] table Script ******/

ALTER TABLE [AUTH].[USERS]  WITH NOCHECK ADD  CONSTRAINT [FK_USERS_EMPID] FOREIGN KEY([EMP_ID])
REFERENCES [HR].[EMP] ([EMP_ID])
GO
ALTER TABLE [AUTH].[USERS] CHECK CONSTRAINT [FK_USERS_EMPID]
GO

