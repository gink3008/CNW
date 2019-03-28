use CNW
go
create proc get_UserAD(@username char(10), @password char(10))
as
begin
	select from 
end

-- cau lenh check sql login
ALTER procedure users_login (
                              @username varchar(50),
                              @password varchar(50),
                              @ret int output
                             )
as
begin
       set @ret=0
       select @ret=1 
       from [User] 
       where username=isnull(@username,null) and [password]=@password
end

-- khi co dung email
create procedure users_login (
                              @username varchar(50),
                              @password varchar(50),
                              @emailid varchar(50),
                              @ret int output
                             )
as
  begin
       set @ret=0
       select @ret=1 
       from users 
       where (username=isnull(@username,null) or emailid=isnull(@emailid,null) 
             and [password]=@password
  end

  -- lay danh sach sanpham
  alter proc laydanhsach
  as
  begin
	select * from SanPham where Display = 1
  end