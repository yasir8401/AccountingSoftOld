--First Verion of File--
--Dated: 16 Aug 2021 --
--Author: Yasir Nisar--

--------------------------------------------------------

/****** Object: Updating exisiting user with employee id Script ******/


UPDATE [AUTH].[USERS]
SET EMP_ID = 1
WHERE USER_ID = 1
GO