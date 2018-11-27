CREATE PROCEDURE projectsTeam()
BEGIN
	select Distinct(name)
    from projectLog
    order by name;
END