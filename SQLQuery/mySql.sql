create table Member (
	userId int identity(1,1) primary key,
	id nvarchar(20) not null,
	pwd nvarchar(20) not null,
	userName nvarchar(20) not null,
	birthMon int not null,
	birthDay int not null,
	phoneNum nvarchar(20) not null,
	alarm int not null
);

create table Write (
	writeId int identity(1,1) primary key,
	title nvarchar(256) not null,
	body nvarchar(256) not null,
	createDay date not null,
	updateDay date,
	userId int not null,
	foreign key(userId) references Member(userId)
);

create table Comment (
	commentId int identity(1,1) primary key,
	writeId int not null,
	userId int not null,
	body nvarchar(256) not null,
	parentCommentId int,
	foreign key(writeId) references Write(writeId),
	foreign key(userId) references Member(userId),
	foreign key(commentId) references Comment(commentId)
);

select * from Member;
select * from Write;
select * from Comment;

drop table Member;
drop table Write;
drop table Comment;

insert into Member(id, pwd, userName, birthMon, birthDay, phoneNum, alarm) values('admin', 'admin', 'admin', 10, 2, '+821066055379', 1);