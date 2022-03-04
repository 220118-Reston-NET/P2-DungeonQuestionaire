CREATE TABLE public.User (
PlayerID int generated always as Identity primary key not null,
PlayerName text not null,
SpriteImgUrl text,
Hp integer,
EnemyCurrentlyFighting integer references Enemy (EnemyID),
UserEmail text unique,
UserPassword text,
UserVictories integer
);

CREATE TABLE public.Enemy (
EnemyID integer primary key not null,
EnemyName text,
EnemySpriteImgUrl text,
EnemyStartingHP integer,
EnemyAttack integer
);

CREATE TABLE Question (
QuestionID int generated always as Identity primary key not null,
Answer1 text,
Answer2 text,
Answer3 text,
Answer4 text,
Category text,
CorrectAnswer text,
DamageValue integer
);

CREATE TABLE Enemy_Question (
EnemyID integer references Enemy (EnemyID) ,
QuestionID integer references Question (QuestionID) 
);

drop TABLE Player;
drop TABLE Enemy;
drop table Question;
drop table Enemy_Question;
