--Replace //loginname// and //password// with secret values from vault
--IMPORTANT create login in Master
--use Master
creat login //loginname// with PASSWORD = '//password//'

--important switch to RecipeDB
create user dev_user from login //loginname//

alter role db_datareader add meber dev_user
alter role db_datawriter add meber dev_user